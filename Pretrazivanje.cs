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
    public partial class Pretrazivanje : Form
    {

       
        public Pretrazivanje()
        {
            
            InitializeComponent();
        }

        private void Izadji(object sender, EventArgs e)
        {
            this.Hide();
            Ulaz otvori = new Ulaz();
            otvori.Show();

        }

        

        private void Pretrazivanje_sifra(object sender, EventArgs e)
        {
            var con = PozivBaze.konekcija();

            con.Open();
            string izvadi = "select * from  Servis where sifra = '"+srch.Text+"' ; ";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();
            if (citac.Read())
            {
                textBox1.Text = (citac["Marka"].ToString());
                textBox2.Text = (citac["Model"].ToString());
                textBox3.Text = (citac["Komponenta"].ToString());
                textBox4.Text = (citac["Rok"].ToString());
                textBox5.Text = (citac["Cijena"].ToString());
                textBox6.Text = (citac["Potrebno_vrijeme"].ToString());


            }
            else
            {
                

                MessageBox.Show(" Nije pronađen niti jedan potreban servis s tom šifrom");
            }
            con.Close();

        }

        private void Obrisi_sve(object sender, EventArgs e)
        {
            var con = PozivBaze.konekcija();
            con.Open();
            string brisi = "delete from  Servis where sifra = '" + srch.Text + "' ; ";
            SqlCommand brisi_cmd = new SqlCommand(brisi, con);
            SqlDataReader brisac;
            brisac = brisi_cmd.ExecuteReader();
            con.Close();


            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
        }

        private void Izmjeni(object sender, EventArgs e)
        {
            var con = PozivBaze.konekcija();
            con.Open();
            SqlDataReader izmjenjivac;
            string izmjeni = "UPDATE  Servis set Marka = '"+this.textBox1.Text+"'  where sifra = '" + srch.Text + "' ; ";
            SqlCommand izmjeni_cmd = new SqlCommand(izmjeni, con);
           
            izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();



             izmjeni = "UPDATE  Servis set Model = '" + this.textBox2.Text + "'  where sifra = '" + srch.Text + "' ; ";
             izmjeni_cmd = new SqlCommand(izmjeni, con);
            izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();


            izmjeni = "UPDATE  Servis set Komponenta = '" + this.textBox3.Text + "'  where sifra = '" + srch.Text + "' ; ";
            izmjeni_cmd = new SqlCommand(izmjeni, con);
             izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();



            izmjeni = "UPDATE  Servis set Rok = '" + this.textBox4.Text + "'  where sifra = '" + srch.Text + "' ; ";
            izmjeni_cmd = new SqlCommand(izmjeni, con);
             izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();




            izmjeni = "UPDATE  Servis set Cijena = '" + this.textBox5.Text + "'  where sifra = '" + srch.Text + "' ; ";
            izmjeni_cmd = new SqlCommand(izmjeni, con);
             izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();




            izmjeni = "UPDATE  Servis set Potrebno_vrijeme = '" + this.textBox6.Text + "'  where sifra = '" + srch.Text + "' ; ";
            izmjeni_cmd = new SqlCommand(izmjeni, con);
             izmjenjivac = izmjeni_cmd.ExecuteReader();
            izmjenjivac.Close();

            con.Close();
            MessageBox.Show(" Izmjenjeno");

        }

        private void ispis(object sender, EventArgs e)
        {
          new  formaispisa().Show();

        }
    }
}
