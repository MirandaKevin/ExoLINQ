using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoLINQ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>
            {
                new Article("PS5", 5, 500),
                new Article("XBOX", 10, 300),
                new Article("NINTENDO", 1, 250),
                
            };

            Console.Write("Quel console voulez vous afficher ? (Nitendo, PS5, XBOX) ");
            var name = Console.ReadLine();

            var article = listArticle.FirstOrDefault(a => a.Nom == name);

            if (article != null)
            {
                Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix}, Quantité: {article.Qte}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Article non trouvé");
            }
        }
    }
}
