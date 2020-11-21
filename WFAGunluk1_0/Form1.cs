using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAGunluk1_0
{
    public partial class Form1 : Form
    {
        string constr = (@"server = .; database = GunluklerAdoDb; uid=sa; pwd =23323847lol;");
        BindingList<Yazi> gunlukBasligi = new BindingList<Yazi>();
        BindingList<Yazi> gunlukIcerigi = new BindingList<Yazi>();

        public Form1()
        {
            VeritabaniYoksaOlustur();
            InitializeComponent();
            GunlukleriListele();
        }

        private SqlConnection BaglantiOlustur()
        {
            var con = new SqlConnection(constr);
            con.Open();
            return con;
        }
        private void VeritabaniYoksaOlustur()
        {
            using (var con = new SqlConnection(@"server=.; database=master; uid=sa ;  password=23323847lol;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"IF DB_ID('GunluklerAdoDb') IS NULL CREATE DATABASE GunluklerAdoDb;", con);
                cmd.ExecuteNonQuery();
            }

            using (var con = BaglantiOlustur())
            {
                SqlCommand cmd = new SqlCommand(@"IF OBJECT_ID(N'dbo.Gunlukler') IS NULL 
                CREATE TABLE Gunlukler
                (
                  Id INT PRIMARY KEY IDENTITY,
                  Baslik NVARCHAR(50) NOT NULL,
                  Icerik NVARCHAR(MAX) NOT NULL

                );", con);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text.Trim();
            string icerik = rtxtNotAlani.Text;

            if (baslik == "" || icerik == "")
            {
                MessageBox.Show("Lütfen Baslik Veya İcerik Alanının Boş olmadığından Emin Olun");
                return;
            }

            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand(@"INSERT INTO Gunlukler(Baslik,Icerik) VALUES(@p1,@p2);", con);
                cmd.Parameters.AddWithValue("@p1", baslik);
                cmd.Parameters.AddWithValue("@p2", icerik);
                cmd.ExecuteNonQuery();
            }

            GunlukleriListele();
        }

        private void GunlukleriListele()
        {
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand(@"SELECT Id,Baslik,Icerik FROM Gunlukler", con);
                var dr = cmd.ExecuteReader();
                gunlukBasligi.Clear();
                gunlukIcerigi.Clear();
                while (dr.Read())
                {
                    gunlukBasligi.Add(new Yazi
                    {
                        Baslik = (string)dr["Baslik"],
                    });
                    lstYazilarim.Items.Add((string)dr["Baslik"]);
                    txtBaslik.Text = (string)dr["Baslik"];
                }
            }
        }

        private void lstYazilarim_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtNotAlani.Clear();
            int secili_index = lstYazilarim.SelectedIndex;
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand(@"SELECT Baslik,Icerik FROM Gunlukler WHERE Id = @p1", con);
                cmd.Parameters.AddWithValue("@p1", secili_index + 1);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtxtNotAlani.Text = (string)dr["Icerik"];
                    txtBaslik.Text = (string)dr["Baslik"];
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndeks = lstYazilarim.SelectedIndex;
            if (seciliIndeks < 0)
                return;
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand(@"DELETE FROM Gunlukler WHERE Id = @p1", con);
                cmd.Parameters.AddWithValue("@p1", seciliIndeks + 1);
                cmd.ExecuteNonQuery();
            }

            lstYazilarim.Items.RemoveAt(seciliIndeks);
            txtBaslik.Text = "←Tıklayarak Bir Günlük Oluşturun Ya Da Bir Günlük Seçin";

        }
    }
}
