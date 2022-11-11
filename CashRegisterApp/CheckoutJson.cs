using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterApp
{
    internal class CheckoutJson
    {
        public string DateTime { get; set; }
        public List<ArticleJson> Articles { get; set; } = new List<ArticleJson>();
        public Double Total { get; set; }
        public int Discount { get; set; }
        public string Moyen { get; set; }
    }

    internal class ArticleJson
    {
        public string Label { get; set; }
        public Double Prix { get; set; }
    }
}
