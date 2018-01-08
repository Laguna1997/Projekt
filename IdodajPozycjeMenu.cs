using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja_16_12_2017_Najnowsza
{
    interface IDodajPozycjeMenu
    {
       void dodajglowne(string nazwa,double cena);
       void dodajzupe(string nazwa, double cena);
       void dodajdeser(string nazwa, double cena);
    }
}
