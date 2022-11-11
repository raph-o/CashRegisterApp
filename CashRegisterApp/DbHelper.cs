using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CashRegisterApp
{
    public class DbHelper
    {
        public string DataSource { get; private set; }
        private SQLiteConnection conn;

        public DbHelper(string dataSource)
        {
            DataSource = dataSource;
        }

        private SQLiteConnection Connect()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source={DataSource};Version=3;");
            try
            {
                conn.Open();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;
        }

        /// <summary>
        ///  Permet d'ajouter un article dans la base de données
        /// </summary>
        /// <param name="article">Object Article</param>
        /// <returns>1 si l'article a bien été créé</returns>
        public int AddArticle(Article article)
        {
            int inserted = 0;
            try
            {
                conn = Connect();
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Articles(label, photo, prix) VALUES('{article.Label}', '{article.Photo}', '{article.Prix}')", conn);
                inserted = cmd.ExecuteNonQuery();

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            conn.Close();
            return inserted;
        }

        /// <summary>
        /// Permet de supprimer un article de la base de données
        /// </summary>
        /// <param name="article">Object Article</param>
        /// <returns>1 si l'article a bien été supprimé</returns>
        public int RemoveArticle(Article article)
        {
            int deleted = 0;
            try
            {
                conn = Connect();
                SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM Articles WHERE label = '{article.Label}' AND prix = '{article.Prix}'", conn);
                deleted = cmd.ExecuteNonQuery();

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            conn.Close();
            return deleted;
        }

        /// <summary>
        /// Permet d'obtenir un article présent dans la base de données
        /// </summary>
        /// <param name="label">Le label de l'article</param>
        /// <returns>Un Article</returns>
        public Article GetArticle(string label)
        {
            Article article = new Article();
            try
            {
                conn = Connect();
                SQLiteCommand command = new SQLiteCommand($"SELECT label, photo, prix FROM Articles WHERE label = '{label}'", conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        article.Label = reader.GetString(0);
                        article.Photo = reader.GetString(1);
                        article.Prix =  reader.GetString(2);
                    }
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            conn.Close();
            return article;
        }

        /// <summary>
        /// Permet de récupérer les articles présents dans la base de données
        /// </summary>
        /// <returns>Une liste d'Article</returns>
        public List<Article> GetArticles()
        {
            List<Article> articles = new List<Article>();
            try
            {
                conn = Connect();
                SQLiteCommand command = new SQLiteCommand($"SELECT label, photo, prix FROM Articles", conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article article = new Article();
                        article.Label = reader.GetString(0);
                        article.Photo = reader.GetString(1);
                        article.Prix = reader.GetString(2);
                        articles.Add(article);
                    }
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            conn.Close();
            return articles;
        }
    }
}
