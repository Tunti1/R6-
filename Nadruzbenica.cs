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
    public partial class Narudzbenica : Form
    {
        
        public Narudzbenica()
        {
            InitializeComponent();
            popuni_combo();
            popuni_combo_za_sifru();
        }

       

        private void Izlaz(object sender, EventArgs e)
        {
            this.Hide();
            Servis otvori = new Servis();
            otvori.Show();
        }

        private void Stvori_novog(object sender, EventArgs e)
        {
            this.Hide();
            Kooperant otvori = new Kooperant();
            otvori.Show();
        }

        void popuni_combo()
        {
            var con = PozivBaze.konekcija();
            con.Open();
            string izvadi = "select * from  Kooperant;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();

            
            while (citac.Read())
            {

                string Snaziv = citac.GetString(1);

                KomboKop.Items.Add(Snaziv);
            }
            con.Close();
        }
        void popuni_combo_za_sifru()
        {
            var con = PozivBaze.konekcija();
            con.Open();
            string izvadi = "select * from  Servis;";
            SqlCommand izvadi_cmd1 = new SqlCommand(izvadi, con);
            SqlDataReader citac1;
            citac1 = izvadi_cmd1.ExecuteReader();


            while (citac1.Read())
            {

                string Sifra = citac1.GetString(0);

                Sifra_1.Items.Add(Sifra);
            }
            con.Close();
        }


        private void Spremi_narudzbenicu(object sender, EventArgs e)
        {
            var con = PozivBaze.konekcija();
            con.Open();
            string zadatak = "INSERT INTO Narudzbenica (Broj, Djelovi,Kooperant)  VALUES( '" + this.Sifra_1.Text + "' ,'" + this.Djelovi.Text + "','" + this.KomboKop.Text.ToString() + "'); ";
            SqlCommand cmdnar = new SqlCommand(zadatak, con);

            cmdnar.ExecuteNonQuery();

            Sifra_1.Text = "";
            Djelovi.Text = "";
            KomboKop.Text = "";

            con.Close();

            MessageBox.Show("Narudzbenica spremljena !");
        }

        private void Narudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_ProjektaDataSet.Servis' table. You can move, or remove it, as needed.
            this.servisTableAdapter.Fill(this.baza_ProjektaDataSet.Servis);

        }
    }
        
        
        
            

    
                




        
    
}
