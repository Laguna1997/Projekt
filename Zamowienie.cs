using System;
using System.Collections.Generic;


namespace Restauracja_16_12_2017_Najnowsza
{
    class Zamowienie : Menu, IZamowienie
    {
        private double total;//zmienna na caly koszt zamowienia
        private double reszta;// reszta do wydania przy platnosci gotowka
        private double podatek;//podatek od calkowitej kwoty
        private const int napiwek = 5;//napiwek doliczany automatycznie dla kelnerow
        private double suma;//koszt zamowionych dan bez podatku i napiwku
        private bool karta_stalego_klienta;//zmienna przechowujaca informacje czy klient ma karte stalego klienta
        private int wiecej;
        private int rodzajplatnosci;
        private double kwota;
        List<string> zamowienie = new List<string>(); // Robie liste, na ktora bede dodawal nazwy produktow
        List<double> cena = new List<double>(); // lista na ktora bede dodawal ceny produktow w kolejnosci zgodnej z lista zamowienie
        private int liczba; // zmienna ktora zapamietuje numer wybranego posilku
        private double [] wartosc = new double[100];
        private int w = 0;
        public Zamowienie(bool karta_stalego_klienta)//konstruktor zamowienia, pobiera tylko info o karcie
        {
            this.karta_stalego_klienta = karta_stalego_klienta;
        }
        public Zamowienie()//pusty konstruktor
        {

        }
        public void Dodaj()//funkcja ktora ma za zadanie dodac posilek na liste i zrealizowac zamowienie klienta
        {
            do
            {

                Console.WriteLine("Podaj numer wybranego dania glownego: (Jezeli nie chcesz nic wybrac wcisnij 9)");
                try
                {
                    liczba = Convert.ToInt32(Console.ReadLine());//pobieram numer posilku
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                          
                switch (liczba)//uzalezniam dalsze kroki od wczesniejszego wyboru
                {
                    case 0:
                        Console.WriteLine("Wybrales schabowego ;)");
                        zamowienie.Add(NazwaGlownego[0]);//wrzucam na liste wybrana nazwe posilku
                        cena.Add(CenaGlownego[0]);//wrzucam na liste cene wybranego posilku
                        break;
                    case 1:
                        Console.WriteLine("Wybrales pierogi");
                        zamowienie.Add(NazwaGlownego[1]);
                        cena.Add(CenaGlownego[1]);
                        break;
                    case 2:
                        Console.WriteLine("Wybrales nalesniki");
                        zamowienie.Add(NazwaGlownego[2]);
                        cena.Add(CenaGlownego[2]);
                        break;
                    case 3:
                        Console.WriteLine("Wybrales spaghetti");
                        zamowienie.Add(NazwaGlownego[3]);
                        cena.Add(CenaGlownego[3]);
                        break;
                    case 4:
                        Console.WriteLine("Wybrales lasagne");
                        zamowienie.Add(NazwaGlownego[4]);
                        cena.Add(CenaGlownego[4]);
                        break;
                    default:
                        Console.WriteLine("Nie wybrales zadnego drugiego dania");
                        break;
                }
                Console.WriteLine("Czy chcesz dodac jeszcze jakies drugie danie ? Jezeli tak 1, nie 0");// czy klient chce dodac wiecej
                try
                {
                    wiecej = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            while (wiecej != 0);
          
            Console.WriteLine("Teraz czas wybrac zupe !!!");
            do
            {   
            Console.WriteLine("Jaki numer zupy wybierasz ?");
                try
                {
                    liczba = Convert.ToInt32(Console.ReadLine());//wczytuje numer zupy
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            
                       
                switch (liczba)//uzalezniam od numeru zupy dalsze kroki,dzialanie jak przy daniu glownym
                {
                    case 0:
                        Console.WriteLine("Wybrales zupe rosol");
                        zamowienie.Add(NazwaZupy[0]);
                        cena.Add(CenaZupy[0]);
                        break;
                    case 1:
                        Console.WriteLine("Wybrales zupe pieczarkowa");
                        zamowienie.Add(NazwaZupy[1]);
                        cena.Add(CenaZupy[1]);
                        break;
                    case 2:
                        Console.WriteLine("Wybrales zupe pomidorowa");
                        zamowienie.Add(NazwaZupy[2]);
                        cena.Add(CenaZupy[2]);
                        break;
                    default:
                        Console.WriteLine("Nie wybrales zadnej zupy");
                        break;
                }

                Console.WriteLine("Czy chcesz dodac jeszcze jakas zupe ? Jezeli tak 1, nie 0");
                try
                {
                    wiecej = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            } while (wiecej != 0);
            //jezeli zamowienie jest juz ukonczone to wyswietlam co wybral uzytkownik i ceny poszczegolnych produktow
            Console.WriteLine("A moze jeszcze cos na deser ? /n ");
            do
            {
                Console.WriteLine("Jaki numer deseru wybierasz  ?");
                try
                {
                    liczba = Convert.ToInt32(Console.ReadLine());//wczytuje numer deseru                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }          

                switch (liczba)//uzalezniam od numeru deseru dalsze kroki,dzialanie jak przy daniu glownym
                {
                    case 0:
                        Console.WriteLine("Wybrales Lody ;)");
                        zamowienie.Add(Desery[0]);
                        cena.Add(Cenadesery[0]);
                        break;
                    case 1:
                        Console.WriteLine("Wybrales wloskie Mascarpone");
                        zamowienie.Add(Desery[1]);
                        cena.Add(Cenadesery[1]);
                        break;
                    case 2:
                        Console.WriteLine("Wybrales przepyszna szarlotke");
                        zamowienie.Add(Desery[2]);
                        cena.Add(Cenadesery[2]);
                        break;
                    case 3:
                        Console.WriteLine("Wybrales pyszny makowiec");
                        zamowienie.Add(Desery[3]);
                        cena.Add(Cenadesery[3]);
                        break;
                    default:
                        Console.WriteLine("Nie wybrales zadnego deseru");
                        break;
                }

                Console.WriteLine("Czy chcesz dodac jeszcze jakis deser do zamowienia? Jezeli tak 1, nie 0");
                try
                {
                    wiecej = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            } while (wiecej != 0);
            if (zamowienie.Count == 0)//jezeli nie ma nic na liscie
                {
                Console.WriteLine("Nie wybrales zadnego posilku\n");
                Console.WriteLine("DO ZOBACZENIA PONOWNIE");
                Console.ReadKey();
                Environment.Exit(1);
              
                }
                Console.WriteLine("TWOJE ZAMOWIENIE ZOSTALO DODANE !!!! WYBRALES:\n");
                foreach (string  element in zamowienie)//wypisanie nazw wybranych posilkow
                {
                    Console.WriteLine(element);
                }
                zamowienie.Clear();//czyszczenie listy
                Console.WriteLine("CENA POSZCZEGOLNYCH POSILKOW W KOLEJNOSCI\n");
                if (cena.Count == 0)
                {
                    Console.WriteLine("Nic nie kupujesz nic nie placisz :)\n");
                }
                foreach (var element in cena)//wypisanie cen wybranych posilkow
                {
                    Console.WriteLine(element);
                    wartosc[w] = element;
                    w++;
                }
                cena.Clear();//czyszczenie listy
            

        }
        public void Rachunek()
        {              
            for(int i=0;i<wartosc.Length;i++)//licze ile kosztuje zamowienie
            {
                suma += wartosc[i];
            }
            podatek = Math.Round(suma * 0.08,2);//8% podatku od wartosci zamowienia
            total = suma + podatek + napiwek;//kwota do zaplacenia uwzgledniajaca podatek i napiwek
            total = Math.Round(total, 2);
            if(karta_stalego_klienta==true)//jezeli klient ma karte stalego klienta to dostaje rabat
            {
                total = Math.Round(total - total * 0.05,2);
            }
            Console.WriteLine("Kwota do zaplacenia to: " + total);
            Console.WriteLine("Wysokosc podatku: " + podatek);
            Console.WriteLine("Wysokosc napiwku: " + napiwek);
            Console.WriteLine("\n");
            Console.WriteLine("Platnosc gotowka czy karta ? Gotowka: 1 Karta 0 \n");
            rodzajplatnosci = Convert.ToInt32(Console.ReadLine());
            if(rodzajplatnosci==1)//Jezeli placi karta to moze dostac reszte
            {
                Console.WriteLine("Ile gotowki przekazal klient ? \n");
                kwota = Convert.ToInt32(Console.ReadLine());
                reszta = kwota - total;
                Console.WriteLine("Reszta do wyplacenia klientowi to: " + reszta);
            }
            else//platnosc karta
            {
                Console.WriteLine("Dokonujesz platnosci karta w wysokosci: " + total);
            }
            Console.WriteLine("DZIEKUJEMY ZA DOKONANIE ZAMOWIENIA");
            
        }
    }
}
0