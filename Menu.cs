using System;


namespace Restauracja_16_12_2017_Najnowsza
{
    public class Menu:IWyswietlanie,IDodajPozycjeMenu
    {
        public string[] NazwaGlownego = { "SCHABOWY", "PIEROGI", "NALESNIKI", "SPAGHETTI", "LAZANIA" };//tablica zawierajaca nazwy dan glownych
        public double[] CenaGlownego = { 15.99, 12.99, 13.0, 19.99, 24.5 };//tablica z cenami dan glownych
        public string[] NazwaZupy = {"Rosol", "Pieczarkowa", "Pomidorowa" };//tablica z nazwami zup
        public double[] CenaZupy = {5.99, 8.99, 5.99 };//tablica z cenami zup
        public string[] Desery = { "Lody", "Mascarpone", "Szarlotka", "Makowiec" };//tablica z nazwami deserow
        public double[] Cenadesery = { 10.99, 5.99, 5.99, 3.99 };//tablica z cenami deserow
        public int dzialanie;//w dalszych krokach odpowiedzialny za wybor klienta
        public void wyswietlmenu()//funkcja odpowiedzialna za wyswietlenie sie menu na ekranie
        {
            Console.WriteLine();
            Console.WriteLine("DANIE GLOWNE" + "   " + "CENA DANIA GLOWNEGO");
            for(int i=0;i<NazwaGlownego.Length;i++)
            {
                Console.WriteLine("Numer:" + " "+ i + "     "+ NazwaGlownego[i] + "             " + CenaGlownego[i]);               
            }
            Console.WriteLine();
            Console.WriteLine("ZUPY" + "             " + "CENA ZUPY");
            for (int i = 0; i < NazwaZupy.Length; i++)
            {
                Console.WriteLine("Numer:" + " " + i + "     " + NazwaZupy[i] + "        " + CenaZupy[i]);
            }
            Console.WriteLine();
            Console.WriteLine("DESERY" + "             " + "CENA DESERU");
            for (int i = 0; i < Desery.Length; i++)
            {
                Console.WriteLine("Numer:" + " " + i + "     " + Desery[i] + "        " + Cenadesery[i]);
            }

        }
        public void dodajglowne(string nazwa,double cena)//dodanie dania glownego do menu
        { 
            int rozmiar = NazwaGlownego.Length;
            Array.Resize(ref NazwaGlownego, rozmiar + 1);//zmiana rozmiaru tablicy
            NazwaGlownego[rozmiar] = nazwa;//dodanie nazwy
            Array.Resize(ref CenaGlownego, rozmiar + 1);//zmiana rozmiaru
            CenaGlownego[rozmiar] = cena;//dodanie ceny
        }

        public void dodajzupe(string nazwa, double cena)//dodanie zupy do glownego menu
        {
            int rozmiar = NazwaZupy.Length;
            Array.Resize(ref NazwaZupy, rozmiar + 1);
            NazwaZupy[rozmiar] = nazwa;
            Array.Resize(ref CenaZupy, rozmiar + 1);
            CenaZupy[rozmiar] = cena;
        }

        public void dodajdeser(string nazwa, double cena)//dodanie deseru do glownego menu
        {
            int rozmiar = Desery.Length;
            Array.Resize(ref Desery, rozmiar + 1);
            Cenadesery[rozmiar] = cena;
            Array.Resize(ref Cenadesery, rozmiar + 1);
            Cenadesery[rozmiar] = cena;
        }
        public void Wybor()//funkcja odpowiedzialna za obsluge klienta,wybor jego dan
        {
            Console.WriteLine("Witaj w naszej Restauracji");
            Menu menu = new Menu();//tworze nowy obiekt klasy menu
            Zamowienie zamowienie = new Zamowienie();//tworze nowy obiekt klasy zamowienie
            do
            {

                Console.WriteLine("Jakie działanie chcesz wykonać ? ");
                Console.WriteLine("1. Skompletuj nowe zamowienie");
                Console.WriteLine("2. Drukuj rachunek");
                Console.WriteLine("3. Dodaj nowe danie glowne do listy dan");
                Console.WriteLine("4. Dodaj nowa zupe do listy zup");
                Console.WriteLine("5. Dodaj nowy deser do listy deserow");
                Console.WriteLine("6. WYJSCIE");
                try
                {
                    dzialanie = Convert.ToInt32(Console.ReadLine());//przypisuje zmiennej dzialanie wybor klienta
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

                switch (dzialanie)//uzalezniam od wyboru klienta dalsze kroki, zgodnie z wyborem powyżej
                {
                    case 1://kompletuje nowe zamowienie
                        menu.wyswietlmenu();
                        zamowienie.Dodaj();
                        zamowienie.Rachunek();
                        break;
                    case 2://wyswietlam rachunek
                        zamowienie.Rachunek();
                        break;
                    case 3://dodanie owego dania glownego do menu
                        string nazwadania;
                        double cenadania;
                        Console.WriteLine("Podaj nazwe dania ktore chcesz dodać");
                        nazwadania = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Podaj cene tego dania");
                        cenadania = Double.Parse(Console.ReadLine());
                        menu.dodajglowne(nazwadania, cenadania);
                        break;
                    case 4://dodanie nowej zupy do menu
                        string nazwazupy;
                        double cenazupy;
                        Console.WriteLine("Podaj nazwe zupy ktora chcesz dodać");
                        nazwazupy = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Podaj cene tej zupy");
                        cenazupy = Double.Parse(Console.ReadLine());
                        menu.dodajzupe(nazwazupy, cenazupy);
                        break;
                    case 5://dodanie nowego deseru do menu
                        string nazwadeseru;
                        double cenadeseru;
                        Console.WriteLine("Podaj nazwe deseru ktory chcesz dodac do menu");
                        nazwadeseru = Convert.ToString(Console.ReadLine());
                        cenadeseru = Double.Parse(Console.ReadLine());
                        menu.dodajdeser(nazwadeseru, cenadeseru);
                        break;
                    case 6://Wyjscie z aplikacji
                        Console.WriteLine("WYBRALES WYJSCIE Z APLIKACJI");
                        Console.ReadKey();
                        break;
                    default://Gdy zostanie podana inna liczba niz wymagana
                        Console.WriteLine("WYBRALES WYJSCIE Z APLIKACJI");
                        break;
                }
                Console.WriteLine();
            }
            while (dzialanie != 6);//wykonuj sie dopoki wybor uzytkownika czyli zmienna dzialanie rozna od 6
        }
    }
}
