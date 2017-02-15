using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twixv2
{
    public partial class Form1 : Form
    {
        KlientStrzelnicy uzytkownik = new KlientStrzelnicy();
        public Form1()
        {
            InitializeComponent();
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelRejestracja);
            ukrywaniePanelu(panelDodajUzytkownika);
            ukrywaniePanelu(panelPanelPracownika);
            ukrywaniePanelu(panelUsunUzytkownika);
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
            ukrywaniePanelu(panelLogowanie);
            errorProviderLogowanie.Clear();
        }

        private void buttonOknoGlowneZaloguj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelLogowanie);
        }

        private void buttonOknoGlowneWyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOknoGlowneZarejestruj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelRejestracja);
        }

        private void buttonRejestracjaWroc_Click(object sender, EventArgs e)
        {
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
                buttonRejestracjaZarejestruj.Enabled = true;
            }
        }

        private void buttonRejestracjaZarejestruj_Click(object sender, EventArgs e)
        {
            TwixEntities twixEncjaRejestracja = new TwixEntities();
            var nowyUzytkownik = new Twix_Klienci();
            nowyUzytkownik.IMIE = textBoxRejestracjaImie.Text;
            nowyUzytkownik.NAZWISKO = textBoxRejestracjaNazwisko.Text;
            nowyUzytkownik.NR_DOWODU = textBoxRejestracjaNrDowodu.Text;
            nowyUzytkownik.PESEL = textBoxRejestracjaPesel.Text;
            nowyUzytkownik.LOGIN = textBoxRejestracjaLogin.Text;
            nowyUzytkownik.HASLO = textBoxRejestracjaHaslo.Text;
            twixEncjaRejestracja.Twix_Klienci.Add(nowyUzytkownik);
            twixEncjaRejestracja.SaveChanges();
        }

        private void buttonLogowanieZaloguj_Click(object sender, EventArgs e)
        {
            bool logowanie;
            logowanie = uzytkownik.pobranieDanych(textBoxLogowanieLogin.Text, textBoxLogowanieHaslo.Text);
            if(logowanie == true)
            {
                pokazywaniePanelu(panelPanelPracownika);
            }
            else
            {  
                MessageBox.Show("Login i/lub hasło niepoprawne!" + Environment.NewLine + "Spróbuj ponownie" , "Logowanie" );
            }
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelDodajUzytkownika);
        }

        private void textBoxDodajPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' )
            {
                MessageBox.Show("Wprowadź tylko cyfry");
                e.KeyChar = (char)0;
            }
        }

        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
            try
            {
                TwixEntities twixEncjaDodajUzytkownika = new TwixEntities();
                var nowyUzytkownik = new Twix_Klienci();
                nowyUzytkownik.IMIE = textBoxDodajImie.Text;
                nowyUzytkownik.NAZWISKO = textBoxDodajNazwisko.Text;
                nowyUzytkownik.NR_DOWODU = textBoxDodajNrDowodu.Text;
                nowyUzytkownik.PESEL = textBoxDodajPesel.Text;
                nowyUzytkownik.LOGIN = textBoxDodajLogin.Text;
                nowyUzytkownik.HASLO = textBoxDodajHaslo.Text;               
                twixEncjaDodajUzytkownika.Twix_Klienci.Add(nowyUzytkownik);
                twixEncjaDodajUzytkownika.SaveChanges();
                MessageBox.Show("+++DODANO+++");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (e.KeyChar < '0' || e.KeyChar > '9' )
            {
                MessageBox.Show("Wprowadź tylko cyfry");
                e.KeyChar = (char)0;
            }
        }

        private void textBoxDodajLogin_Leave(object sender, EventArgs e)
        {
            TwixEntities twixEncjaDodajUzytkownika = new TwixEntities();
            if (twixEncjaDodajUzytkownika.Twix_Klienci.Any(o => o.LOGIN == textBoxDodajLogin.Text))
            {
                MessageBox.Show("Login istnieje!");
            }
        }

        private void textBoxRejestracjaLogin_Leave(object sender, EventArgs e)
        {
            TwixEntities twixEncjaRejestracja = new TwixEntities();
            if (twixEncjaRejestracja.Twix_Klienci.Any(o => o.LOGIN == textBoxRejestracjaLogin.Text))
            {
                MessageBox.Show("Login zajęty :(");
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
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelPanelPracownika);
        }

        private void buttonUsunUzytkownikaCofnij_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelUsunUzytkownika);
        }

        private void buttonPanelPracownikaUsunUzytkownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelUsunUzytkownika);
        }
    }
    }

