using System;
using System.Collections;
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
            if (uzytkownik.rejetracja(textBoxRejestracjaImie.Text, textBoxRejestracjaNazwisko.Text, textBoxRejestracjaNrDowodu.Text, textBoxRejestracjaPesel.Text, textBoxRejestracjaLogin.Text, textBoxRejestracjaHaslo.Text))
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
            if(uzytkownik.pobranieDanych(textBoxLogowanieLogin.Text, textBoxLogowanieHaslo.Text) == true)
            {
                MessageBox.Show("Logowanie zakończone", "Logowanie");
            }
            else
            {  
                MessageBox.Show("Nieudane logowanie" + Environment.NewLine + "Spróbuj ponownie" , "Logowanie" );
            }
        }

        private void buttonZaktualizujDaneWyszukaj_Click(object sender, EventArgs e)
        {
            string imie = textBoxZaktualizujDaneWyszukajImie.Text;
            string pesel = textBoxZaktualizujDaneWyszukajPesel.Text;
            if(uzytkownik.wyszukajUzytkownika(imie, pesel) == true)
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
                if(Convert.ToBoolean(lista[7]) == true)
                {
                    checkBoxZaktualizujDaneCzyAdministrator.ThreeState = true;
                }
                else
                {
                    checkBoxZaktualizujDaneCzyAdministrator.ThreeState = false;
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
            if (uzytkownikZmiana.zmianaDanych(textBoxZaktualizujDaneWyszukajImie.Text, textBoxZaktualizujDaneWyszukajPesel.Text, textBoxZaktualizujDaneImie.Text, textBoxZaktualizujDaneNazwisko.Text, textBoxZaktualizujDaneNrDowodu.Text, textBoxZaktualizujDanePesel.Text, textBoxZaktualizujDaneLogin.Text, textBoxZaktualizujDaneHaslo.Text) == true)
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
                textBoxZaktualizujDaneWyszukajImie.Text = "";
                textBoxZaktualizujDaneWyszukajPesel.Text = "";
            }
            else
            {
                MessageBox.Show("Nie udało się zaktualizować danych użytkownika", "Błąd");
            }
        }
    }
}
