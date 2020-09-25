using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoLINQ_4
{
    public class Article
    {

        public string Nom { get; set; }
        public int Prix { get; set; }

        public Article(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
        }
    }
}
