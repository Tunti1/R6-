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

namespace Projekt
{
    public partial class Servis : Form
    {

        public string sifra;
        public string marka;
        public string model;
        public string komponenta;
        public string rok;
        public int cijena;
        public int vrijeme;

        List<Servis> servisi = new List<Servis>();


       
        public Servis()
        {
            var con = PozivBaze.konekcija();
            InitializeComponent();
        }

        
        private void Izadji(object sender, EventArgs e)
        {
            this.Hide();
            Ulaz otvori = new Ulaz();
            otvori.Show();
        }

        private void Otvori_Narudzbenicu(object sender, EventArgs e)
        {
            this.Hide();
            Narudzbenica otvori = new Narudzbenica();
            otvori.Show();
        }

         void SpremiUredjaj(object sender, EventArgs e)
        {

            var con = PozivBaze.konekcija();

            con.Open();

            

             
            string zadatak = "INSERT INTO Servis(Sifra,Marka,Model,Komponenta,Rok,Cijena,Potrebno_vrijeme)  VALUES('"+this.Sifratxt.Text+"' , ' "+this.MarkaTxt.Text+"' , '"+this.ModelTxT.Text+"', '"+this.KomponentaTxt.Text+ "' ,'"+this.RokKraj.Text+"' , "+this.CijenaTxtic.Text+" , "+this.Vrijeme.Text+" );";
            SqlCommand cmd = new SqlCommand (zadatak, con);
            
            cmd.ExecuteNonQuery();
            
            con.Close();

            this.Sifratxt.Text = " ";
            this.MarkaTxt.Text = " ";
            this.ModelTxT.Text = " ";
            this.KomponentaTxt.Text = " ";
            this.CijenaTxtic.Text = " ";
            this.Vrijeme.Text = " ";

            MessageBox.Show("Servis spremljen!");

        }

        

       
    }
}
