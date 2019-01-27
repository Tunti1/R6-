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
    public partial class formaispisa : Form
    {
        static string ConnectionString = "Data Source=DESKTOP-71KF32U;Initial Catalog=Baza;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(ConnectionString);
        List<Servis> servisi = new List<Servis>();
        public formaispisa()
        {
            InitializeComponent();
            ispisi();
           
        }

        private void ispisi()
        {
            
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Servis", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Servis prijenos = new Servis();
                prijenos.sifra = (string)reader["Sifra"];
                prijenos.marka = (string)reader["Marka"];
                prijenos.model = (string)reader["Model"];
                prijenos.komponenta = (string)reader["Komponenta"];
                prijenos.rok = (string)reader["Rok"];
                prijenos.cijena = (int)reader["Cijena"];
                prijenos.vrijeme = (int)reader["Potrebno_vrijeme"];
                servisi.Add(prijenos);




            }
            for (int k = 0; k < servisi.Count; k++)
            {
                for (int i = 0; i < servisi.Count; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (servisi[j - 1].vrijeme > servisi[j].vrijeme)
                        {
                            Servis temp = servisi[j - 1];
                            servisi[j - 1] = servisi[j];
                            servisi[j] = temp;
                        }
                    }
                }
            }


            foreach (var s in servisi)
                {
                    string[] red = { s.sifra.ToString(), s.marka, s.model, s.cijena.ToString(), s.vrijeme.ToString(), s.rok.ToString() };
                 var prenosioc = new ListViewItem(red);
                    lista.Items.Add(prenosioc);
                }
            con.Close();
        }

        
    }
}
