using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                // ranga = klient.ID_RANGI;
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
                if(czyAdm == true)
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

        public bool usunUzytkownika (string pes)
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

        public bool wyloguj ()
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
            catch (Exception ex)
            {
                return false;
            }
        }
    
    }
}
