using System.IO;

namespace CashRegisterApp
{
    public class Article
    {
        public string Label { get; set; }
        public string Photo { get; set; }
        public string Prix { get; set; }

        public Article() {}

        public Article(string label, string photo, string prix)
        {
            Label = label;
            Photo = photo;
            Prix = prix;
        }
    }
}
