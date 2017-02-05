using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twixv2
{
    class KlientStrzelnicy
    {
        private int id;
        public string imie;
        private string nazwisko;
        private string pesel;
        private string nrDowodu;
        private string login;
        private string haslo;
        //int ranga;
        byte[] czyAdmin;
        Boolean czyAdminBool = false;

        public bool pobranieDanych(string log, string has)
        {
            try
            {
                TwixEntities encjaTwix = new TwixEntities();
                var klient = encjaTwix.Twix_Klienci.FirstOrDefault(a => a.LOGIN == log && a.HASLO == has);
                imie = klient.IMIE;
                nazwisko = klient.NAZWISKO;
                pesel = klient.PESEL;
                nrDowodu = klient.NR_DOWODU;
                login = klient.LOGIN;
                haslo = klient.HASLO;
                /*czyAdmin = klient.czyADMIN;
                if(czyAdmin[0]==1)
                {
                    czyAdminBool = true;
                }*/
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
