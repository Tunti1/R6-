using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Ulaz : Form
    {
        public Ulaz()
        {
            InitializeComponent();
        }

        private void Otvori_unos(object sender, EventArgs e)
        {
            this.Hide();
            Servis otvori = new Servis();
            otvori.ShowDialog();
        }

        private void Otvori_pretrazivanje(object sender, EventArgs e)
        {
            this.Hide();
            Pretrazivanje otvori = new Pretrazivanje();
            otvori.Show();
        }

        private void IZLAZ(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Planiraj(object sender, EventArgs e)
        {
            this.Hide();
            Planiranje otvori = new Planiranje();
            otvori.Show();
        }
    }
}
