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
        twixDataSet.Twix_KlienciRow user;
        public Okno()
        {
            InitializeComponent();
            panelLogowanie.Visible = false;
            panelLogowanie.Enabled = false;
            panelLogowanie.SendToBack();
            panelRejestracja.Visible = false;
            panelRejestracja.Enabled = false;
            panelRejestracja.SendToBack();
        }

        private void buttonLogowanieWroc_Click(object sender, EventArgs e)
        {
            panelLogowanie.Enabled = false;
            panelLogowanie.Visible = false;
            panelLogowanie.SendToBack();
            epLogowanieLogin.Clear();
        }

        private void buttonOknoZaloguj_Click(object sender, EventArgs e)
        {
            panelLogowanie.BringToFront();
            panelLogowanie.Enabled = true;
            panelLogowanie.Visible = true;
        }

        private void buttonOknoWyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxLogowanieLogin_Leave(object sender, EventArgs e)
        {
            setError(this.textBoxLogowanieLogin, "Nieporpawny login");
        }

        private void textBoxLogowanieHaslo_Leave(object sender, EventArgs e)
        {
            setError(this.textBoxLogowanieHaslo, "Nieporpawne hasło");
        }

        private void setError(TextBox componentToValidate, string message)
        {
            if (string.IsNullOrEmpty(componentToValidate.Text))
            {
                epLogowanieLogin.Icon = Properties.Resources.error;
                epLogowanieLogin.SetError(componentToValidate, message);
            }
            else
            {
                epLogowanieLogin.Clear();
            }
        }

        private void setError(Button logowanie, string message)
        {
            if(user == null)
            {
                epLogowanieLogin.Icon = Properties.Resources.error;
                epLogowanieLogin.SetError(logowanie, message);
            }
            else
            {
                epLogowanieLogin.Clear();
            }
            
        }

        private void buttonLogowanieZaloguj_Click(object sender, EventArgs e)
        {
            string login = textBoxLogowanieLogin.Text;
            string haslo = textBoxLogowanieHaslo.Text;


            IDataReader dr = this.twixDataSet1.CreateDataReader();
            this.twixDataSet1.Twix_Klienci.Load(dr,LoadOption.OverwriteChanges);
            int aaa = this.twixDataSet1.Twix_Klienci.Count;
           
            //user = this.twixDataSet1.Twix_Klienci.Where(user => 
            //user.LOGIN.Equals(login) && user.HASLO.Equals(haslo)).FirstOrDefault();
            setError(buttonLogowanieZaloguj, "Niepoprawny użytkownik");
            string usert = user.IMIE.ToString();
            label1.Text = usert;
        }

        private void buttonRejestracjaWroc_Click(object sender, EventArgs e)
        {
            panelRejestracja.SendToBack();
            panelRejestracja.Visible = false;
            panelRejestracja.Enabled = false;
        }

        private void buttonOknoZarejestruj_Click(object sender, EventArgs e)
        {
            panelLogowanie.SendToBack();
            panelRejestracja.Enabled = true;
            panelRejestracja.Visible = true;
            panelRejestracja.BringToFront();
        }
    }
}
