using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoLINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListAnnee = new List<int>()
            { 2001, 2002,2003, 2004,2005, 2006, 2007, 2008};

            var rqt = from year in ListAnnee
                      where testBissextile(year)
                      select year;

            var sortList = rqt.ToList();
            sortList.ForEach(y =>
            {
                Console.WriteLine(y+" est une année bissextile dans la liste");
                Console.ReadLine();
            });
        }

        public static bool testBissextile(int year)
        {
            var firstDate = new DateTime(year, 1, 1);
            var endDate = new DateTime(year, 12, 31);
            TimeSpan Ts = endDate - firstDate;

            var nbJours = Ts.TotalDays + 1;
            if (nbJours == 366)
                return true;

            return false;
        }
    }
}
