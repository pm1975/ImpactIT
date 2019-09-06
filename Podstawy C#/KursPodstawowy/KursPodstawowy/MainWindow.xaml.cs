using System.Collections.Generic;
using System.Windows;

namespace KursPodstawowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Zmienne i ich typy

        #region Zasiegi zmiennych

        public int zmiennaPubliczna = 1;
        internal int zmiennaInternal = 1;
        private int zmiennaPrivate = 1;

        #endregion

        #endregion

        #region Stale

        const float PI = 3.14f;
        const string naszeA = "aaaaa";

        #endregion
        int liczbaPolubien = 10; // Testowa zmienna
        float r = 10f; // zmienna pomocnicza

        #region Konstruktory klasy
        // Bazowy konstruktor klasy
        public MainWindow()
        {
            InitializeComponent();
            //Instrukcje();
            Kolekcje();
        }
        #endregion

        #region Kolekcje

        int[] naszaTablica = new int[10];
        List<int> naszaList = new List<int>();

        void Kolekcje()
        {
            naszaTablica[0] = 1;
            naszaTablica[1] = 55;
            naszaTablica[2] = 33;
            naszaTablica[3] = 56;
            naszaTablica[4] = 24;
            naszaTablica[5] = 95;
            naszaTablica[6] = 67;
            naszaTablica[7] = 23;
            naszaTablica[8] = 254;
            naszaTablica[9] = 23;

            naszaList.Add(1);
            naszaList.Add(55);
            naszaList.Add(33);

            listView.ItemsSource = naszaList;
        }

        #endregion

        #region Instrukcje

        private void Instrukcje()
        {
            testowyTextBlock.Text = "Start";
            var warunek = false;
            var liczba = 4;
            //testowyTextBlock.Text = (warunek) ? "3" : "0";
            #region instrukcja IF
            if (liczba > 1 && liczba < 100)
            {
                testowyTextBlock.Text = "Prawda 1";
            }
            else if (liczba > 100 && liczba < 200)
                testowyTextBlock.Text = "Prawda 2";
            else
                testowyTextBlock.Text = "Fałsz";
            #endregion

            #region Instrukcja Switch
            switch (liczba)
            {
                case 0:
                    testowyTextBlock.Text = "Nie działa";
                    break;
                case 1:
                    testowyTextBlock.Text = "Działa";
                    break;
                case 2:
                    testowyTextBlock.Text = "MOŻE!!!";
                    break;
                default:
                    testowyTextBlock.Text = "UPS !!!";
                    break;
            }
            #endregion

            #region Instrukcja FOR

            for (int i = 0; i < 10; i++)
            {
                testowyTextBlock.Text = i.ToString();
            }

            #endregion
        }

        #endregion

        #region Metody pomocnicze
        public void PierwszaMetoda()
        {
            var wynik = PI * r * r;


            if (wynik > 30)
            {
                int klamrowaPulapka = 1;
            }
            //var wynik2 = PI + klamrowaPulapka; //BŁAD

            var naszPierwszyVar = liczbaPolubien; // magiczny var-1
        }

        /// <summary>
        /// To jest testowa metoda, która przyjmuje zawsze 'aaaa'
        /// </summary>
        /// <param name="a">Super Parametr 'aaaa'</param>
        public void DrugaMetoda(string a)
        {
            var naszDrugiVar = liczbaPolubien; // magiczny var-2
        }
        #endregion

    }
}
