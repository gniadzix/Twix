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

namespace Twixv2
{
    public partial class FormOknoGlowne : Form
    {
        private SoundPlayer odtwarzacz;
        KlientStrzelnicy uzytkownik = new KlientStrzelnicy();
        public FormOknoGlowne()
        {
            InitializeComponent();
            //odtwarzacz = new SoundPlayer("GTA.wav");
           // odtwarzacz.PlayLooping();
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelRejestracja);
            ukrywaniePanelu(panelDodajUzytkownika);
            ukrywaniePanelu(panelPanelPracownika);
            ukrywaniePanelu(panelUsunUzytkownika);
            ukrywaniePanelu(panelZaktualizujDane);
        }
       
        private void ustawieniapolaPesel(TextBox polePesel, KeyPressEventArgs e)
        {
            polePesel.MaxLength = 11;
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Wprowadź tylko cyfry");
                e.KeyChar = (char)0;
            }
            //tu bedzie weryfikacji pelnoletnosci
        }

        private void ustawieniapolaNrDowodu(TextBox poleNrDowodu, KeyPressEventArgs e)
        {
            poleNrDowodu.MaxLength = 9;
            //tutaj bedzie sprawdzenie poprawnosci nr dowodu
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
            odtwarzacz.Stop();
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
            if (uzytkownik.rejestracja(textBoxRejestracjaImie.Text, textBoxRejestracjaNazwisko.Text, textBoxRejestracjaNrDowodu.Text, textBoxRejestracjaPesel.Text, textBoxRejestracjaLogin.Text, textBoxRejestracjaHaslo.Text))
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
            logowanie = uzytkownik.pobranieDanych(textBoxLogowanieLogin.Text, textBoxLogowanieHaslo.Text);
            if(logowanie == true && uzytkownik.czyAdminBool == true)
            {
                pokazywaniePanelu(panelPanelPracownika);
            }
            else if(logowanie == true && uzytkownik.czyAdminBool == false)
            {
                MessageBox.Show("Jesteś zwykłym userem!" + Environment.NewLine + "Spróbuj ponownie", "Logowanie");
            }
            else
            {
                MessageBox.Show("Login i/lub hasło niepoprawne!" + Environment.NewLine + "Spróbuj ponownie", "Logowanie");
            }
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelDodajUzytkownika);
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
            if(uzytkownik.dodajUzytkownika(textBoxDodajImie.Text, textBoxDodajNazwisko.Text, textBoxDodajNrDowodu.Text, textBoxDodajPesel.Text, textBoxDodajLogin.Text, textBoxDodajHaslo.Text, czyAdm))
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
            Twix twixEncjaDodajUzytkownika = new Twix();
            if (twixEncjaDodajUzytkownika.Twix_Klienci.Any(o => o.LOGIN == textBoxDodajLogin.Text))
            {
                MessageBox.Show("Login istnieje!");
            }
        }


        private void textBoxRejestracjaLogin_Leave(object sender, EventArgs e)
        {
            Twix twixEncjaRejestracja = new Twix();
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
            uzytkownik.wyloguj();
        }

        private void buttonUsunUzytkownikaCofnij_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelUsunUzytkownika);
        }

        private void buttonPanelPracownikaUsunUzytkownika_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelUsunUzytkownika);
        }

        private void buttonPanelPracownikaZmienDaneUzytkownika_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelPanelPracownika);
            pokazywaniePanelu(panelZaktualizujDane);
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
            if (uzytkownikZmiana.zmianaDanych(textBoxZaktualizujDaneWyszukajPesel.Text, textBoxZaktualizujDaneImie.Text, textBoxZaktualizujDaneNazwisko.Text, textBoxZaktualizujDaneNrDowodu.Text, textBoxZaktualizujDanePesel.Text, textBoxZaktualizujDaneLogin.Text, textBoxZaktualizujDaneHaslo.Text, czyAdm) == true)
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
    }
    }

