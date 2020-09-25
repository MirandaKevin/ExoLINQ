using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoLINQ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
                new Article("Tshirt Rouge", 25),
                new Article("Le guide du parfait Codeur", 249),
                new Article("PS5", 500),

                
            };

            var articles = (from article in listArticle
                            where article.Prix > 50
                            select article).ToList();

            Console.WriteLine("Les articles de plus de 50 euros sont : ");
            articles.ForEach(art =>
            {
                
                Console.WriteLine($"Nom : {art.Nom}, Prix : {art.Prix}");
                Console.ReadLine();

            });
        }
    }
}
