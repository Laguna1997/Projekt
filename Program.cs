using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja_16_12_2017_Najnowsza
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu nowe = new Menu();//tworze nowe menu
            nowe.Wybor();
            Console.WriteLine("Dziekujemy za uzycie naszej aplikacji");
            Console.ReadKey();
        }
    }
}
