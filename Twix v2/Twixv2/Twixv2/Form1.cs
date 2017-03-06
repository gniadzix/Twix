using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Security.Cryptography;

namespace Twixv2
{
    public partial class FormOknoGlowne : Form
    {
       // private SoundPlayer odtwarzacz;
        KlientStrzelnicy uzytkownik = new KlientStrzelnicy();
        public FormOknoGlowne()
        {
            Thread tr = new Thread(new ThreadStart(LoadingStart));
            tr.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            tr.Abort();
            //odtwarzacz = new SoundPlayer("GTA.wav");
            //odtwarzacz.PlayLooping();
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelKalkulatorKosztow);
            ukrywaniePanelu(panelUzytkownika);
            ukrywaniePanelu(panelRezerwacjaTerminu);
            ukrywaniePanelu(panelRejestracja);
            ukrywaniePanelu(panelDodajWynik);
            ukrywaniePanelu(panelDodajUzytkownika);
            ukrywaniePanelu(panelPanelPracownika);
            ukrywaniePanelu(panelUsunUzytkownika);
            ukrywaniePanelu(panelZaktualizujDane);
            ukrywaniePanelu(panelDodajWynik);
        }
        public void LoadingStart()
        {
            Application.Run(new Start());
        }

        public void uzupelnianie_comboboxWybierzBron(ComboBox cb)
        {
            ArrayList bron = new ArrayList();
            bron = uzytkownik.slownikBroni();
            cb.TabIndex = 0;
            cb.DataSource = bron;

        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public void autouzupelnianie_textBoxDodajWynikNazwaUzytkownika()
        {  
            textBoxDodajWynikNazwaUzytkownika.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxDodajWynikNazwaUzytkownika.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection uzytkownicy = new AutoCompleteStringCollection();
            ArrayList user = new ArrayList();

            user=uzytkownik.nazwyUzytkownikow();
            int maxid = uzytkownik.maxIdUzytkownika();
            for (int i = 0; i <= maxid; i++)
            {
                uzytkownicy.Add(user[i].ToString());
            }    
            textBoxDodajWynikNazwaUzytkownika.AutoCompleteCustomSource=uzytkownicy;
        }
       
        private void ustawieniapolaPesel(TextBox polePesel, KeyPressEventArgs e)
        {
            polePesel.MaxLength = 11;
            const char Delete = (char)8;
            if (!char.IsNumber(e.KeyChar)  && e.KeyChar != Delete)
            { 
                e.Handled = true;
                MessageBox.Show("PODAJ TYLKO CYFRY");
            }
        }

        private bool sprawdzanieLoginu(TextBox login)
        {
            Baza twixWalidacjaLogin = new Baza();
            if (twixWalidacjaLogin.Twix_Klienci.Any(o => o.LOGIN == login.Text))
            {
                //MessageBox.Show("Login istnieje!");
                //login.Focus();
                return false;
            }
            return true;
        }

        public int czyPelnoletni (TextBox tekst)
        {
            DateTime data = DateTime.Now;
            string dzien;
            string miesiac;
            string rok;
            dzien = data.Day.ToString();
            miesiac = data.Month.ToString();
            rok = data.Year.ToString();
            string pesel = tekst.Text;
            if (pesel == "")
            {
                //MessageBox.Show("Pole pesel nie może być puste");
                //tekst.Focus();
                return -1;
            }
            else
            {
                string rokPesel = pesel.Substring(0, 2);
                string miesiacPesel = pesel.Substring(2, 2);
                string dzienPesel = pesel.Substring(4, 2);
                int intRokPesel = Int32.Parse(rokPesel);
                int intMiesiacPesel = Int32.Parse(miesiacPesel);
                int intDzienPesel = Int32.Parse(dzienPesel);
                if (intMiesiacPesel > 20)
                {
                    intRokPesel += 2000;
                    intMiesiacPesel = intMiesiacPesel - 20;
                }
                else
                {
                    intRokPesel += 1900;
                }
                int rokDzis = Int32.Parse(rok);
                int miesiacDzis = Int32.Parse(miesiac);
                int dzienDzis = Int32.Parse(dzien);
                int wiek = rokDzis - intRokPesel;
                if (wiek < 18)
                {
                    //MessageBox.Show("Gówniarz");
                    //tekst.Focus();
                    return 0;
                }
                else if ((wiek == 18) && (intMiesiacPesel > miesiacDzis))
                {
                    //MessageBox.Show("Gówniarz");
                    //tekst.Focus();
                    return 0;
                }
                else if ((wiek == 18) && (intMiesiacPesel == miesiacDzis) && (intDzienPesel > dzienDzis))
                {
                    //MessageBox.Show("Gówniarz");
                    //tekst.Focus();
                    return 0;
                }
            }
            return 1;
        }

        private int wartoscZnaku(char litera)
        {
            char[] wartosciLiter = new char[36];
            wartosciLiter[0] = '0';
            wartosciLiter[1] = '1';
            wartosciLiter[2] = '2';
            wartosciLiter[3] = '3';
            wartosciLiter[4] = '4';
            wartosciLiter[5] = '5';
            wartosciLiter[6] = '6';
            wartosciLiter[7] = '7';
            wartosciLiter[8] = '8';
            wartosciLiter[9] = '9';
            wartosciLiter[10] = 'A';
            wartosciLiter[11] = 'B';
            wartosciLiter[12] = 'C';
            wartosciLiter[13] = 'D';
            wartosciLiter[14] = 'E';
            wartosciLiter[15] = 'F';
            wartosciLiter[16] = 'G';
            wartosciLiter[17] = 'H';
            wartosciLiter[18] = 'I';
            wartosciLiter[19] = 'J';
            wartosciLiter[20] = 'K';
            wartosciLiter[21] = 'L';
            wartosciLiter[22] = 'M';
            wartosciLiter[23] = 'N';
            wartosciLiter[24] = 'O';
            wartosciLiter[25] = 'P';
            wartosciLiter[26] = 'Q';
            wartosciLiter[27] = 'R';
            wartosciLiter[28] = 'S';
            wartosciLiter[29] = 'T';
            wartosciLiter[30] = 'U';
            wartosciLiter[31] = 'V';
            wartosciLiter[32] = 'W';
            wartosciLiter[33] = 'X';
            wartosciLiter[34] = 'Y';
            wartosciLiter[35] = 'Z';
            for (int i = 0; i < 36; i++)
            {
                if (wartosciLiter[i] == litera)
                {
                    return i;
                }
            }
            return -1;
        }

        private bool sprawdzanieNrDowodu(TextBox poleNrDowodu)
        {
            int sumakontrolna;
            string nrDowodu = poleNrDowodu.Text;
            if ((nrDowodu == "") || (nrDowodu.Count() < 8)) return false;
            char[] litery = new char[9];
            litery = nrDowodu.ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                if (wartoscZnaku(litery[i]) < 10)
                {
                    return false;
                }
            }
            for (int i = 3; i < 9; i++)
            {
                if (wartoscZnaku(litery[i]) < 0 || wartoscZnaku(litery[i]) > 9)
                {
                    return false;
                }
            }
            sumakontrolna = 7 * wartoscZnaku(litery[0]);
            sumakontrolna += 3 * wartoscZnaku(litery[1]);
            sumakontrolna += 1 * wartoscZnaku(litery[2]);
            sumakontrolna += 7 * wartoscZnaku(litery[4]);
            sumakontrolna += 3 * wartoscZnaku(litery[5]);
            sumakontrolna += 1 * wartoscZnaku(litery[6]);
            sumakontrolna += 7 * wartoscZnaku(litery[7]);
            sumakontrolna += 3 * wartoscZnaku(litery[8]);
            sumakontrolna %= 10;
            if (sumakontrolna != wartoscZnaku(litery[3]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ukrywaniePanelu(Panel doUkrycia)
        {
            doUkrycia.Enabled = false;
            doUkrycia.Visible = false;
            doUkrycia.SendToBack();
        }

        private void pokazywaniePanelu(Panel doPokazania)
        {
            doPokazania.BringToFront();
            doPokazania.Enabled = true;
            doPokazania.Visible = true;
        }

        private void ustawBladLogowanie(TextBox przedmiotDoWalidacji, string wiadomosc)
        {
            if (string.IsNullOrEmpty(przedmiotDoWalidacji.Text))
            {
                errorProviderLogowanie.Icon = Properties.Resources.blad;
                errorProviderLogowanie.SetError(przedmiotDoWalidacji, wiadomosc);
            }
            else
            {
                errorProviderLogowanie.Clear();
            }
        }
        
        private void textBoxLogowanieLogin_Leave(object sender, EventArgs e)
        {
            ustawBladLogowanie(this.textBoxLogowanieLogin, "Niepoprawny login");
        }

        private void textBoxLogowanieHaslo_Leave(object sender, EventArgs e)
        {
            ustawBladLogowanie(this.textBoxLogowanieHaslo, "Niepoprawne hasło");
        }

        private void buttonLogowanieWroc_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelOknoGlowne);
            ukrywaniePanelu(panelLogowanie);
            errorProviderLogowanie.Clear();
            
        }

        private void buttonOknoGlowneZaloguj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelOknoGlowne);
            textBoxLogowanieLogin.Focus();
        }

        private void buttonOknoGlowneWyjdz_Click(object sender, EventArgs e)
        {
          //  odtwarzacz.Stop();
            Application.Exit();
        }

        private void buttonOknoGlowneZarejestruj_Click(object sender, EventArgs e)
        {    
            pokazywaniePanelu(panelRejestracja);
            ukrywaniePanelu(panelOknoGlowne);
            textBoxRejestracjaImie.Focus();
        }

        private void buttonRejestracjaWroc_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelOknoGlowne);
            ukrywaniePanelu(panelRejestracja);
        }

        private void textBoxRejestracjaPowtorzHaslo_Leave(object sender, EventArgs e)
        {
            int porownanie = string.Compare(textBoxRejestracjaHaslo.Text, textBoxRejestracjaPowtorzHaslo.Text);
            if (porownanie != 0)
            {
                errorProviderRejestracjaHaslo.Icon = Properties.Resources.blad;
                errorProviderRejestracjaHaslo.SetError(textBoxRejestracjaPowtorzHaslo, "Hasła nie są takie same");
            }
            else
            {
                errorProviderRejestracjaHaslo.Clear();
                if((errorProviderRejestracjaLogin.GetError(textBoxRejestracjaLogin) == "") &&(errorProviderRejestracjaNrDow.GetError(textBoxRejestracjaNrDowodu) == "") && (errorProviderRejestracjaPesel.GetError(textBoxRejestracjaPesel) == "")) buttonRejestracjaZarejestruj.Enabled = true;
            }
        }

        private void buttonRejestracjaZarejestruj_Click(object sender, EventArgs e)
        {
            
            if (uzytkownik.rejestracja(textBoxRejestracjaImie.Text, textBoxRejestracjaNazwisko.Text, textBoxRejestracjaNrDowodu.Text, textBoxRejestracjaPesel.Text, textBoxRejestracjaLogin.Text, GenerateSHA256String(textBoxRejestracjaHaslo.Text)))
            {
                MessageBox.Show("Rejestracja przebiegła pomyślnie", "Rejestracja");
            }
            else
            {
                MessageBox.Show("Rejestracja zakończyła się niepowodzeniem, spróbuj ponownie", "Rejestracja");
            }
        }

        private void buttonLogowanieZaloguj_Click(object sender, EventArgs e)
        {
            bool logowanie;
            logowanie = uzytkownik.pobranieDanych(textBoxLogowanieLogin.Text,GenerateSHA256String(textBoxLogowanieHaslo.Text));
            if(logowanie == true && uzytkownik.czyAdminBool == true)
            {
                pokazywaniePanelu(panelPanelPracownika);
            }
            else if(logowanie == true && uzytkownik.czyAdminBool == false)
            {
                ukrywaniePanelu(panelLogowanie);
                pokazywaniePanelu(panelUzytkownika);
            }
            else
            {
                MessageBox.Show("Login i/lub hasło niepoprawne!" + Environment.NewLine + "Spróbuj ponownie", "Logowanie");
            }
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelDodajUzytkownika);
            textBoxDodajImie.Focus();
        }

        private void textBoxDodajPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ustawieniapolaPesel(textBoxDodajPesel, e);
        }

        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
            int czyAdm = 0;
            if (checkBoxCzyAdmin.Checked == true)
            {
                czyAdm = 1;

            }
            else czyAdm = 0;
            if(uzytkownik.dodajUzytkownika(textBoxDodajImie.Text, textBoxDodajNazwisko.Text, textBoxDodajNrDowodu.Text, textBoxDodajPesel.Text, textBoxDodajLogin.Text, GenerateSHA256String(textBoxDodajHaslo.Text), czyAdm))
            {
                MessageBox.Show("+++DODANO+++");
            }
            else MessageBox.Show("Bład");
        }

        private void textBoxDodajImie_Click(object sender, EventArgs e)
        {
            textBoxDodajImie.Clear();
        }

        private void textBoxDodajNazwisko_Click(object sender, EventArgs e)
        {
            textBoxDodajNazwisko.Clear();
        }

        private void textBoxDodajPesel_Click(object sender, EventArgs e)
        {
            textBoxDodajPesel.Clear();
        }

        private void textBoxDodajNrDowodu_Click(object sender, EventArgs e)
        {
            textBoxDodajNrDowodu.Clear();
        }

        private void buttonWrocDoPaneluPracownika_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelDodajUzytkownika);
            pokazywaniePanelu(panelPanelPracownika);
        }

        private void textBoxDodajLogin_Click(object sender, EventArgs e)
        {
            textBoxDodajLogin.Clear();
        }

        private void textBoxRejestracjaPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ustawieniapolaPesel(textBoxRejestracjaPesel, e);
        }

        private void textBoxDodajLogin_Leave(object sender, EventArgs e)
        {
            sprawdzanieLoginu(textBoxDodajLogin);
        }


        private void textBoxRejestracjaLogin_Leave(object sender, EventArgs e)
        {
            if(sprawdzanieLoginu(textBoxRejestracjaLogin) == false)
            {
                errorProviderRejestracjaLogin.Icon = Properties.Resources.blad;
                errorProviderRejestracjaLogin.SetError(textBoxRejestracjaLogin, "Login istnieje");
                buttonRejestracjaZarejestruj.Enabled = false;
            }
            else
            {
                errorProviderRejestracjaLogin.Clear();
                if ((errorProviderRejestracjaNrDow.GetError(textBoxRejestracjaNrDowodu) == "") && (errorProviderRejestracjaPesel.GetError(textBoxRejestracjaPesel) == "") && (errorProviderRejestracjaHaslo.GetError(textBoxRejestracjaPowtorzHaslo) == "")) buttonRejestracjaZarejestruj.Enabled = true;
            }
        }

        private void textBoxDodajHaslo_Click(object sender, EventArgs e)
        {
            string allowedChars = "";
            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";
            char[] sep = { ',' };
            string[] arr = allowedChars.Split(sep);
            string passwordString = "";
            string temp = "";
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                passwordString += temp;
            }
            textBoxDodajHaslo.Text = passwordString;
        }

        private void buttonPanelPracownikaWyloguj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelOknoGlowne);
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelPanelPracownika);
            uzytkownik.wyloguj();
        }

        private void buttonUsunUzytkownikaCofnij_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelUsunUzytkownika);
        }

        private void buttonPanelPracownikaUsunUzytkownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelUsunUzytkownika);
            textBoxUsunUzytkownikaPodajPesel.Focus();
        }

        private void buttonPanelPracownikaZmienDaneUzytkownika_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelPanelPracownika);
            pokazywaniePanelu(panelZaktualizujDane);
            textBoxZaktualizujDaneWyszukajPesel.Focus();
        }

        private void buttonZaktualizujDaneWroc_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelZaktualizujDane);
            pokazywaniePanelu(panelPanelPracownika);
        }

        private void buttonZaktualizujDaneWyszukaj_Click(object sender, EventArgs e)
        {
            string pesel = textBoxZaktualizujDaneWyszukajPesel.Text;
            if (uzytkownik.wyszukajUzytkownika(pesel) == true)
            {
                ArrayList lista = new ArrayList();
                lista = uzytkownik.daneKlienta();
                textBoxZaktualizujDaneImie.Text = Convert.ToString(lista[1]);
                textBoxZaktualizujDaneNazwisko.Text = Convert.ToString(lista[2]);
                textBoxZaktualizujDaneNrDowodu.Text = Convert.ToString(lista[3]);
                textBoxZaktualizujDanePesel.Text = Convert.ToString(lista[4]);
                textBoxZaktualizujDaneLogin.Text = Convert.ToString(lista[5]);
                textBoxZaktualizujDaneHaslo.Text = Convert.ToString(lista[6]);
                textBoxZaktualizujDaneRanga.Text = Convert.ToString(lista[7]);
                if (Convert.ToBoolean(lista[8]) == true)
                {
                    checkBoxZaktualizujDaneCzyAdministrator.Checked = true;
                }
                else
                {
                    checkBoxZaktualizujDaneCzyAdministrator.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Nie ma takiego użytkownika", "Błąd");
            }
        }

        private void buttonZaktualizujDaneZmienDane_Click(object sender, EventArgs e)
        {
            textBoxZaktualizujDaneHaslo.Enabled = true;
            textBoxZaktualizujDaneImie.Enabled = true;
            textBoxZaktualizujDaneLogin.Enabled = true;
            textBoxZaktualizujDaneNazwisko.Enabled = true;
            textBoxZaktualizujDaneNrDowodu.Enabled = true;
            textBoxZaktualizujDanePesel.Enabled = true;
            checkBoxZaktualizujDaneCzyAdministrator.Enabled = true;
            buttonZaktualizujDaneZatwierdz.Enabled = true;
            buttonZaktualizujDaneZatwierdz.Visible = true;
            textBoxZaktualizujDaneRanga.Enabled = true;
        }

        private void buttonZaktualizujDaneZatwierdz_Click(object sender, EventArgs e)
        {
            KlientStrzelnicy uzytkownikZmiana = new KlientStrzelnicy();
            bool czyAdm = false;
            if (checkBoxZaktualizujDaneCzyAdministrator.Checked)
            {
                czyAdm = true;
            }
            else czyAdm = false;
            if (uzytkownikZmiana.zmianaDanych(textBoxZaktualizujDaneWyszukajPesel.Text, textBoxZaktualizujDaneImie.Text, textBoxZaktualizujDaneNazwisko.Text, textBoxZaktualizujDaneNrDowodu.Text, textBoxZaktualizujDanePesel.Text, textBoxZaktualizujDaneLogin.Text, GenerateSHA256String(textBoxZaktualizujDaneHaslo.Text), czyAdm) == true)
            {
                MessageBox.Show("Poprawnie zaktualizowano dane użytkownika", "Sukces");
                textBoxZaktualizujDaneHaslo.Enabled = false;
                textBoxZaktualizujDaneImie.Enabled = false;
                textBoxZaktualizujDaneLogin.Enabled = false;
                textBoxZaktualizujDaneNazwisko.Enabled = false;
                textBoxZaktualizujDaneNrDowodu.Enabled = false;
                textBoxZaktualizujDanePesel.Enabled = false;
                checkBoxZaktualizujDaneCzyAdministrator.Enabled = false;
                buttonZaktualizujDaneZatwierdz.Enabled = false;
                buttonZaktualizujDaneZatwierdz.Visible = false;
                textBoxZaktualizujDaneRanga.Enabled = false;
                textBoxZaktualizujDaneWyszukajPesel.Text = "";
            }
            else
            {
                MessageBox.Show("Nie udało się zaktualizować danych użytkownika", "Błąd");
            }
        }

        private void buttonUsunUzytkownikaWyszukaj_Click(object sender, EventArgs e)
        {
            string pesel = textBoxUsunUzytkownikaPodajPesel.Text;
            if (uzytkownik.wyszukajUzytkownika(pesel) == true)
            {
                ArrayList lista = new ArrayList();
                lista = uzytkownik.daneKlienta();
                textBoxUsunUzytkownikaImie.Text = Convert.ToString(lista[1]);
                textBoxUsunUzytkownikaNazwisko.Text = Convert.ToString(lista[2]);
                textBoxUsunUzytkownikaNrDowodu.Text = Convert.ToString(lista[3]);
                textBoxUsunUzytkownikaPesel.Text = Convert.ToString(lista[4]);
                textBoxUsunUzytkownikaLogin.Text = Convert.ToString(lista[5]);
            
            }
            else
            {
                MessageBox.Show("Nie ma takiego użytkownika", "Błąd");
            }
        }

        private void buttonUsunUzytkownikaUsunUzytkownika_Click(object sender, EventArgs e)
        {
            if(uzytkownik.usunUzytkownika(textBoxUsunUzytkownikaPesel.Text))
            {
                MessageBox.Show("Poprawnie usunięto użytkownika", "Sukces");
                textBoxUsunUzytkownikaImie.Text = "";
                textBoxUsunUzytkownikaNazwisko.Text = "";
                textBoxUsunUzytkownikaPesel.Text = "";
                textBoxUsunUzytkownikaNrDowodu.Text = "";
                textBoxUsunUzytkownikaLogin.Text = "";
            }
            else
            {
                MessageBox.Show("Nie udało się usunąć użytkownika", "Błąd");
            }
        }

        private void buttonUsunUzytkownikaCofnij_Click_1(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelUsunUzytkownika);
            pokazywaniePanelu(panelPanelPracownika);
        }

        private void textBoxUsunUzytkownikaPodajPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ustawieniapolaPesel(textBoxUsunUzytkownikaPesel, e);
        }

        private void textBoxZaktualizujDaneWyszukajPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ustawieniapolaPesel(textBoxZaktualizujDaneWyszukajPesel, e);
        }

        private void textBoxDodajNrDowodu_Leave(object sender, EventArgs e)
        {
            if(sprawdzanieNrDowodu(textBoxDodajNrDowodu) == false)
                {
                    MessageBox.Show("Nieprawidłowy numer dowodu");
                    textBoxDodajNrDowodu.Focus();
                }
        }

        private void textBoxRejestracjaNrDowodu_Leave(object sender, EventArgs e)
        {
            if (sprawdzanieNrDowodu(textBoxRejestracjaNrDowodu) == false)
            {
                errorProviderRejestracjaNrDow.Icon = Properties.Resources.blad;
                errorProviderRejestracjaNrDow.SetError(textBoxRejestracjaNrDowodu, "Niepoprawny numer dowodu");
                buttonRejestracjaZarejestruj.Enabled = false;
            }
            else
            {
                errorProviderRejestracjaNrDow.Clear();
                if((errorProviderRejestracjaLogin.GetError(textBoxRejestracjaLogin) == "") && (errorProviderRejestracjaPesel.GetError(textBoxRejestracjaPesel) == "") && (errorProviderRejestracjaHaslo.GetError(textBoxRejestracjaPowtorzHaslo) == "")) buttonRejestracjaZarejestruj.Enabled = true;
            }
        }

        private void textBoxZaktualizujDaneNrDowodu_Leave(object sender, EventArgs e)
        {
            if (sprawdzanieNrDowodu(textBoxZaktualizujDaneNrDowodu) == false)
            {
                MessageBox.Show("Nieprawidłowy numer dowodu");
                textBoxZaktualizujDaneNrDowodu.Focus();
            }
        }

        private void textBoxZaktualizujDaneNrDowodu_Click(object sender, EventArgs e)
        {
            textBoxZaktualizujDaneNrDowodu.Clear();
        }

        private void textBoxRejestracjaNrDowodu_Click(object sender, EventArgs e)
        {
            textBoxRejestracjaNrDowodu.Clear();
        }

        private void textBoxRejestracjaPesel_Leave(object sender, EventArgs e)
        {
            int sprawdzenie = czyPelnoletni(textBoxRejestracjaPesel);
            if (sprawdzenie == -1)
            {
                errorProviderRejestracjaPesel.Icon = Properties.Resources.blad;
                errorProviderRejestracjaPesel.SetError(textBoxRejestracjaPesel, "Pole pesel nie może byc puste");
                buttonRejestracjaZarejestruj.Enabled = false;
            }
            else if(sprawdzenie == 0)
            {
                errorProviderRejestracjaPesel.Icon = Properties.Resources.blad;
                errorProviderRejestracjaPesel.SetError(textBoxRejestracjaPesel, "Osoba niepełnoletnia");
                buttonRejestracjaZarejestruj.Enabled = false;
            }
            else
            {
                errorProviderRejestracjaPesel.Clear();
                if((errorProviderRejestracjaLogin.GetError(textBoxRejestracjaLogin) == "") && (errorProviderRejestracjaNrDow.GetError(textBoxRejestracjaNrDowodu) == "") && (errorProviderRejestracjaHaslo.GetError(textBoxRejestracjaPowtorzHaslo) == "")) buttonRejestracjaZarejestruj.Enabled = true;
            }
        }

        private void textBoxZaktualizujDanePesel_Leave(object sender, EventArgs e)
        {
            czyPelnoletni(textBoxZaktualizujDanePesel);
        }

        private void textBoxDodajPesel_Leave(object sender, EventArgs e)
        {
            czyPelnoletni(textBoxDodajPesel);
        }

        private void textBoxZaktualizujDanePesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ustawieniapolaPesel(textBoxZaktualizujDanePesel, e);
        }

        private void textBoxZaktualizujDaneLogin_Leave(object sender, EventArgs e)
        {
            sprawdzanieLoginu(textBoxZaktualizujDaneLogin);
        }

      
       
        private void buttonDodajWynik_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelDodajWynik);
        }

        private void panelRezerwacjaTerminu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonDodajWynikDodaj_Click(object sender, EventArgs e)
        {




            int x = uzytkownik.intoString(textBoxDodajWynikWynik.Text);
            if (x == -1)
            {
                MessageBox.Show("Podaj poprawny wynik", "Błąd", MessageBoxButtons.OK);
                textBoxDodajWynikWynik.Clear();
            }
            else
            {

                if (uzytkownik.dodajWynik(comboBoxDodajWynikWbierzBron.Text, x, textBoxDodajWynikNazwaUzytkownika.Text))
                {
                    MessageBox.Show("Sukces", "Dodano wynik", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Błąd", "Spróbuj jeszcze raz", MessageBoxButtons.OK);
                }

            }
        }

        private void buttonDodajWynikWroc_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelDodajWynik);
            textBoxDodajWynikNazwaUzytkownika.Text="Nazwa użytkownika";  
        }

        private void buttonUzytkownikRezerwacjaTerminu_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelUzytkownika);
            pokazywaniePanelu(panelRezerwacjaTerminu);
        }

        private void buttonRezerwacjaTerminuWroc_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelRezerwacjaTerminu);
            pokazywaniePanelu(panelUzytkownika);
        }

        private void buttonUzytkownikWyloguj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelOknoGlowne);
            ukrywaniePanelu(panelUzytkownika);
            uzytkownik.wyloguj();
        }

        private void buttonDodajWynik_Click_1(object sender, EventArgs e)
        {
            uzupelnianie_comboboxWybierzBron(comboBoxDodajWynikWbierzBron);
            autouzupelnianie_textBoxDodajWynikNazwaUzytkownika();
            comboBoxDodajWynikWbierzBron.SelectedIndex = 0;
            pokazywaniePanelu(panelDodajWynik);
          
        }

        private void comboBoxDodajWynikWbierzBron_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }
   
        private void textBoxDodajWynikNazwaUzytkownika_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDodajWynikNazwaUzytkownika.Clear();
           
        }

        private void buttonOtworzPanelKalkulatorKosztow_Click(object sender, EventArgs e)
        {
            uzupelnianie_comboboxWybierzBron(comboBoxKalkulatorKosztowWybierzBron);
            ukrywaniePanelu(panelUzytkownika);
            pokazywaniePanelu(panelKalkulatorKosztow);
        }

        private void buttonKalkulatorKosztowCofnij_Click(object sender, EventArgs e)
        {
            labelKalkulatorKosztowWynik.Text = "";
            pictureBoxKalkulatorKosztowMoneyGIF.Visible = false;
            textBoxKalkulatorKosztowIloscStrzalow.Text = "Ilość strzałów";
            ukrywaniePanelu(panelKalkulatorKosztow);
            pokazywaniePanelu(panelUzytkownika);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxKalkulatorKosztowIloscStrzalow.Clear();
        }

        private void buttonKalkulatorKosztowOblicz_Click(object sender, EventArgs e)
        {
            string nazwabroni = comboBoxKalkulatorKosztowWybierzBron.Text;
            int iloscstrzalow = Convert.ToInt32(textBoxKalkulatorKosztowIloscStrzalow.Text);
            Baza encjaTwix = new Baza();
            var bron = encjaTwix.Twix_SL_Broni.FirstOrDefault(a => a.NAZWA == nazwabroni);
            int cena = (int)bron.CENA;
            int koszt = cena * iloscstrzalow;
            pictureBoxKalkulatorKosztowMoneyGIF.Visible = true;
            labelKalkulatorKosztowWynik.Text = "PŁACISZ\n" + Convert.ToString(koszt) + " PLN";
        }

        private void buttonDodajWynikWyszukaj_Click(object sender, EventArgs e)
        {
            if (uzytkownik.wyszukajPoLoginie(textBoxDodajWynikNazwaUzytkownika.Text) == 1)
                MessageBox.Show("Wyszukano użytkownika", "Sukces", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Nieporawna nazwa użytkownika", "Błąd", MessageBoxButtons.OK);
                textBoxDodajWynikNazwaUzytkownika.Clear();

            }
       

        }

        private void textBoxDodajWynikWynik_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDodajWynikWynik.Clear();

        }
    }
    }

