using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodaj_wynik
{
    public partial class Dodaj_wynik : Form
    {
        public Dodaj_wynik()
        {
            InitializeComponent();
           
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodano wynik", "Sukces", MessageBoxButtons.OK);
           
        }
        string a = "test";
       
        private void Wybierz_bron_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
