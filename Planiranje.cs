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
    public partial class Planiranje : Form
    {
       List<Servis> servisi = new List<Servis>();
       
        int smjena;
        int zastava = 1;
        int suma=0;
        public Planiranje()
        {
            InitializeComponent();
            popuni_listu();
           

        }

        private void popuni_listu()
        {
            var con = PozivBaze.konekcija();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Servis",con);
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
                for (int k = 0; k < servisi.Count; k++)
                {
                    for (int i = 0; i < servisi.Count; ++i)
                    {
                        for (int j = 1; j <= i; ++j)
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

            }
            con.Close();
        }

        List<Servis> Knapsack_lista(List<Servis> servisi, int smjena)
        {

            int[,] cijena = new int[servisi.Count + 1, smjena + 1];
            bool[,] sacuvaj = new bool[servisi.Count + 1, smjena + 1];

            for (int i = 1; i <= servisi.Count; i++)
            {
                Servis trenutni = servisi[i-1];
                for (int preostalo_vremena_za_rad = 1; preostalo_vremena_za_rad <= smjena; preostalo_vremena_za_rad++)
                {
                    if (preostalo_vremena_za_rad >= trenutni.vrijeme)
                    {
                        int preostalo_vrijeme = preostalo_vremena_za_rad - trenutni.vrijeme;
                        int dobivena_dobit_uredjaja = 0;
                        if (preostalo_vrijeme > 0)
                        {
                            dobivena_dobit_uredjaja = cijena[i - 1, preostalo_vrijeme];
                        }
                        int treunutna_vrijednost = trenutni.cijena + dobivena_dobit_uredjaja;
                        if (treunutna_vrijednost > cijena[i - 1, preostalo_vremena_za_rad])
                        {
                            sacuvaj[i, preostalo_vremena_za_rad] = true;
                            cijena[i, preostalo_vremena_za_rad] = treunutna_vrijednost;
                        }
                        else
                        {
                            sacuvaj[i, preostalo_vremena_za_rad] = false;
                            cijena[i, preostalo_vremena_za_rad] = cijena[i - 1, preostalo_vremena_za_rad];
                        }
                    }
                }
            }

            List<Servis> upakovani = new List<Servis>();

            int pomocni = smjena;
            int servis_lista = servisi.Count;
            while (servis_lista > 0)
            {
                bool pakiranje = sacuvaj[servis_lista, pomocni];
                if (pakiranje)
                {
                    upakovani.Add(servisi[servis_lista - 1]);
                    pomocni = pomocni - servisi[servis_lista - 1].vrijeme;
                }
                servis_lista--;
            }


            return upakovani;
        }


        

        private void izlaz(object sender, EventArgs e)
        {
            this.Hide();
            Ulaz otvori = new Ulaz();
            otvori.Show();
        }

        private void knapsack(object sender, EventArgs e)
        { if (rad.Text == "") { zastava = 0; MessageBox.Show(" Unesite broj sati!"); }
            else zastava = 1;
            if (zastava == 1)
            {
                lista.Items.Clear();
                smjena = Convert.ToInt32(rad.Text);
                List<Servis> konacni = new List<Servis>();
                konacni = Knapsack_lista(servisi, smjena);
                foreach (var s in konacni)
                {

                    string[] red = { s.sifra.ToString(), s.marka, s.model, s.cijena.ToString(), s.vrijeme.ToString(), s.rok.ToString() };
                    var prenosioc = new ListViewItem(red);
                    lista.Items.Add(prenosioc);
                }
            }     
            
            
            
        }

        private void reverse_greedy(object sender, EventArgs e)
        {
            if (rad.Text == "") { zastava = 0; MessageBox.Show(" Unesite broj sati!"); }
            else zastava = 1;
            if (zastava == 1)
            {
                lista.Items.Clear();
                smjena = Convert.ToInt16(rad.Text);

                suma = 0;
                foreach (var s in servisi)
                {

                    suma = suma + s.vrijeme;
                    if (suma > smjena) { break; }
                    else
                    {
                        string[] red = { s.sifra.ToString(), s.marka, s.model, s.cijena.ToString(), s.vrijeme.ToString(), s.rok.ToString() };
                        var prenosioc = new ListViewItem(red);
                        lista.Items.Add(prenosioc);

                    }

                }
            }



        }
    }
}

