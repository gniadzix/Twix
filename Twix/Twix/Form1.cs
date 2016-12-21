using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twix
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
            ukrywaniePanelu(panelLogowanie);
            ukrywaniePanelu(panelRejestracja);
        }

        private void buttonLogowanieWroc_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelLogowanie);
            epLogowanie.Clear();
        }

        private void buttonOknoZaloguj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelLogowanie);
        }

        private void buttonOknoWyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxLogowanieLogin_Leave(object sender, EventArgs e)
        {
            setError(this.textBoxLogowanieLogin, "Niepoprawny login");
        }

        private void textBoxLogowanieHaslo_Leave(object sender, EventArgs e)
        {
            setError(this.textBoxLogowanieHaslo, "Niepoprawne hasło");
        }

        private void setError(TextBox componentToValidate, string message)
        {
            if (string.IsNullOrEmpty(componentToValidate.Text))
            {
                epLogowanie.Icon = Properties.Resources.error;
                epLogowanie.SetError(componentToValidate, message);
            }
            else
            {
                epLogowanie.Clear();
            }
        }

        private void setError(Button logowanie, string message)
        {
            if(user == null)
            {
                epLogowanie.Icon = Properties.Resources.error;
                epLogowanie.SetError(logowanie, message);
            }
            else
            {
                epLogowanie.Clear();
            }
            
        }

        private void buttonRejestracjaWroc_Click(object sender, EventArgs e)
        {
            ukrywaniePanelu(panelRejestracja);
        }

        private void buttonOknoZarejestruj_Click(object sender, EventArgs e)
        {
            pokazywaniePanelu(panelRejestracja);
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

        private void buttonZaktualizujDaneZmien_Click(object sender, EventArgs e)
        {
            textBoxZaktualizujDaneImie.Enabled = true;
            textBoxZaktualizujDaneNazwisko.Enabled = true;
            textBoxZaktualizujDaneNrDowodu.Enabled = true;
            textBoxZaktualizujDanePesel.Enabled = true;
        }
    }
}
