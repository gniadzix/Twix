using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twixv2
{
    class KlientStrzelnicy
    {
        private int id;
        private string imie;
        private string nazwisko;
        private string pesel;
        private string nrDowodu;
        private string login;
        private string haslo;
        private Nullable<int> ranga;
        private int czyAdmin;
        public bool czyAdminBool = false;
        private Nullable<int> suma;
        int[ , ] rangi = new int[17, 2] { {0, 200}, { 201, 400}, {401, 600}, {601, 800}, {801, 1000}, {1001, 1200}, {1201, 1400}, {1401, 1600}, {1601, 1800}, {1801, 2000}, {2001, 2200}, {2201, 2400}, {2401, 2600}, {2601, 2800}, {2801, 3000}, {3001, 3200}, {3201, 100000}};
        public bool pobranieDanych(string log, string has)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.LOGIN == log && a.HASLO == has);
                id = klient.ID;
                imie = klient.IMIE;
                nazwisko = klient.NAZWISKO;
                pesel = klient.PESEL;
                nrDowodu = klient.NR_DOWODU;
                login = klient.LOGIN;
                haslo = klient.HASLO;
                czyAdmin = klient.czyADMIN.GetValueOrDefault();
                sumowanie();
                suma = klient.SUMAPKT;
                nadawanieRangi();
                //ranga = obliczanieRangi();
                ranga = klient.ID_RANGI;
                if (czyAdmin == 1)
                {
                    czyAdminBool = true;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool rejestracja(string im, string naz, string nrDow, string pes, string log, string has)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var nowyUzytkownik = new Twix_Klienci();
                nowyUzytkownik.IMIE = im;
                nowyUzytkownik.NAZWISKO = naz;
                nowyUzytkownik.NR_DOWODU = nrDow;
                nowyUzytkownik.PESEL = pes;
                nowyUzytkownik.LOGIN = log;
                nowyUzytkownik.HASLO = has;
                nowyUzytkownik.czyADMIN = 0;
                encjaTwix.Twix_Klienci.Add(nowyUzytkownik);
                encjaTwix.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool wyszukajUzytkownika(string pes)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.PESEL == pes);
                id = klient.ID;
                imie = klient.IMIE;
                nazwisko = klient.NAZWISKO;
                pesel = klient.PESEL;
                nrDowodu = klient.NR_DOWODU;
                login = klient.LOGIN;
                haslo = klient.HASLO;
                //ranga = klient.ID_RANGI;
                czyAdmin = klient.czyADMIN.GetValueOrDefault();
                if (czyAdmin == 1)
                {
                    czyAdminBool = true;
                }
                else czyAdminBool = false;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool dodajWynik(String bron, int wynik, String login)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.LOGIN == login);
                id = klient.ID;
                var wyniki = new Twix_Wyniki();
                wyniki.ID_KLIENTA = klient.ID;
                wyniki.WYNIK = wynik;
                //wyniki.bron=bron;
                encjaTwix.Twix_Wyniki.Add(wyniki);
                encjaTwix.SaveChanges();


                return true;

            }
            catch
            {
                return false;
            }


        }
        public short wyszukajPoLoginie(string login)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.LOGIN == login);

                string log;
                log = klient.LOGIN;
                return 1;
            }
            catch
            {
                return 0;
            }
          

        }
        public ArrayList daneKlienta()
        {
            ArrayList dane = new ArrayList();
            dane.Add(id);
            dane.Add(imie);
            dane.Add(nazwisko);
            dane.Add(nrDowodu);
            dane.Add(pesel);
            dane.Add(login);
            dane.Add(haslo);
            dane.Add(ranga);
            dane.Add(czyAdminBool);
            return dane;
        }

        public bool zmianaDanych(string pes, string imPoZmianie, string naz, string nrDow, string pesPoZmianie, string log, string has, bool czyAdm)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.PESEL == pes);
                klient.IMIE = imPoZmianie;
                klient.NAZWISKO = naz;
                klient.PESEL = pesPoZmianie;
                klient.NR_DOWODU = nrDow;
                klient.LOGIN = log;
                klient.HASLO = has;
                if (czyAdm == true)
                {
                    klient.czyADMIN = 1;
                }
                else
                {
                    klient.czyADMIN = 0;
                }
                //klient.ID_RANGI = ran;*/
                encjaTwix.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool usunUzytkownika(string pes)
        {
            try
            {
                Twix encjaTwix = new Twix();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.PESEL == pes);
                encjaTwix.Twix_Klienci.Remove(klient);
                encjaTwix.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool wyloguj()
        {
            try
            {
                id = 0;
                imie = null;
                nazwisko = null;
                pesel = null;
                nrDowodu = null;
                login = null;
                haslo = null;
                ranga = null;
                czyAdmin = 0;
                czyAdminBool = false;
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool dodajUzytkownika(string imie, string nazwisko, string nrDowodu, string pesel, string login, string haslo, int czyAdmin)
        {
            try
            {
                Twix twixEncjaDodajUzytkownika = new Twix();
                var nowyUzytkownik = new Twix_Klienci();
                nowyUzytkownik.IMIE = imie;
                nowyUzytkownik.NAZWISKO = nazwisko;
                nowyUzytkownik.NR_DOWODU = nrDowodu;
                nowyUzytkownik.PESEL = pesel;
                nowyUzytkownik.LOGIN = login;
                nowyUzytkownik.HASLO = haslo;
                nowyUzytkownik.czyADMIN = czyAdmin;
                twixEncjaDodajUzytkownika.Twix_Klienci.Add(nowyUzytkownik);
                twixEncjaDodajUzytkownika.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public ArrayList slownikBroni()
        {
            
            Twix encjaTwix = new Twix();
            ArrayList bronie = new ArrayList();
            bronie.Add("Wybierz broń");

            int i = 0;
            for (i = 1; i <= 32; i++)
            {
                var bron = encjaTwix.Twix_SL_Broni.FirstOrDefault(a => a.ID == i);
                bronie.Add(bron.NAZWA);
            }
            return bronie;

        }
        public ArrayList nazwyUzytkownikow()
        {
            Twix encjaTwix = new Twix();
            ArrayList uzytkownicy = new ArrayList();
            int i = 0;

            for (i=0; i < 2; i++)
            {
                var nazwa = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.ID == i);
                uzytkownicy.Add(nazwa.LOGIN);
            }    
           
            return uzytkownicy;
        }
        public void sumowanie()
        {
            try
            {
                Twix encjaTwix = new Twix();
                var wynik = encjaTwix.Twix_Wyniki.Select(a => a.ID_KLIENTA == id);
                var sum = encjaTwix.Twix_Wyniki.Where(a => a.ID_KLIENTA == id).Sum(s => s.WYNIK);
                var aktualizacjaPkt = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.ID == id);
                aktualizacjaPkt.SUMAPKT = sum;
                encjaTwix.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Bład");
            }
        }
        public int obliczanieRangi()
        {
            for (int i = 0; i < 17; i++)
            {
                if ((suma >= rangi[i, 0])&& suma <= rangi[i, 1])
                {
                    return i+1;
                }
            }
            return -1;
        }
        public void nadawanieRangi()
        {
            int rang = obliczanieRangi();
            //int? nullRang = rang;
            try
            {
                Twix encjaTwix = new Twix();
                var aktualizacjaRangi = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.ID == id);
                aktualizacjaRangi.ID_RANGI = rang;
                encjaTwix.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }
    }
}
