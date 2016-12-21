using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace dodajUzytkownika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textboxDodajImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textboxDodajNazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxDodajPesel_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=cfcfq5jupw.database.windows.net,1433;Initial Catalog=twix;Persist Security Info=True;User ID=twixadmin;Password=qazTHRD1250";
            string Query = "insert into dbo.Twix_Klienci(IMIE,NAZWISKO,PESEL,NR_DOWODU) VALUES ('" + textboxDodajImie.ToString()+ "','" + textboxDodajNazwisko.ToString() + "','" + textboxDodajPesel.ToString() + "','" + textboxDodajNrDowodu.ToString() +"');";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                }

        private void textboxDodajID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxDodajID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }

        private void textboxDodajImie_Click(object sender, EventArgs e)
        {
            textboxDodajImie.Clear();
        }

        private void textboxDodajNazwisko_Click(object sender, EventArgs e)
        {
            textboxDodajNazwisko.Clear();
        }

        private void textboxDodajPesel_Click(object sender, EventArgs e)
        {
            textboxDodajPesel.Clear();
        }

        private void textboxDodajNrDowodu_Click(object sender, EventArgs e)
        {
            textboxDodajNrDowodu.Clear();
        }
    }
}
