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
    public partial class Dodaj_wynik : Form
    {
        public Dodaj_wynik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sukces", "Dodano wynik", MessageBoxButtons.OK);

        }
    }
}
