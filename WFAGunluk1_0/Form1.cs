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

        BindingList<Yazi> gunlukler = new BindingList<Yazi>();
        BindingList<Yazi> arananlar = new BindingList<Yazi>();


        public Form1()
        {
            VeritabaniYoksaOlustur();
            InitializeComponent();
            lstYazilarim.DataSource = gunlukler;
            lstArananlar.DataSource = arananlar;
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
                gunlukler.Clear();
                while (dr.Read())
                {
                    gunlukler.Add(new Yazi
                    {
                        Id = (int)dr["Id"],
                        Baslik = (string)dr["Baslik"],
                        Icerik = (string)dr["Icerik"]
                    });
                }
            }
            lstYazilarim.Visible = true;
            lstArananlar.Visible = false;
        }

        private void lstYazilarim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazilarim.SelectedIndex < 0)
            {
                return;
            }
            int secili_index = (int)lstYazilarim.SelectedIndex;
            Yazi gunluk = gunlukler[secili_index];
            txtBaslik.Text = gunluk.Baslik;
            rtxtNotAlani.Text = gunluk.Icerik;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secili_index = (int)lstYazilarim.SelectedIndex;
            Yazi gunluk = gunlukler[secili_index];

            if (secili_index < 0)
                return;
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand(@"DELETE FROM Gunlukler WHERE Id = @p1", con);
                cmd.Parameters.AddWithValue("@p1", gunluk.Id);
                cmd.ExecuteNonQuery();
            }

            GunlukleriListele();
            txtBaslik.Text = "←Tıklayarak Bir Günlük Oluşturun Ya Da Bir Günlük Seçin";

            if (lstYazilarim.Items.Count > 0)
            {
                lstYazilarim.ClearSelected();
                int secilecekIndeks = secili_index >= lstYazilarim.Items.Count ? lstYazilarim.Items.Count - 1 : secili_index;
                lstYazilarim.SelectedIndex = secilecekIndeks;

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananKelime = txtAra.Text;
            using (var con = BaglantiOlustur())
            {
                var cmd = new SqlCommand("SELECT * FROM Gunlukler WHERE Baslik  LIKE '%'+@text+'%' OR Icerik LIKE '%'+@text+'%'", con);
                cmd.Parameters.AddWithValue("@text", arananKelime);
                var dr = cmd.ExecuteReader();
                arananlar.Clear();
                while (dr.Read())
                {
                    arananlar.Add(new Yazi
                    {
                        Id = (int)dr["Id"],
                        Baslik = (string)dr["Baslik"],
                        Icerik = (string)dr["Icerik"]
                    });
                }
                lstYazilarim.Visible = false;
                lstArananlar.Visible = true;
                btnAramaİptal.Visible = true;
            }
            this.Text = "Gunluk 1.0";
        }
        private void Kaydet()
        {
            string duzenlenenBaslik = txtBaslik.Text;
            string duzenlenenIcerik = rtxtNotAlani.Text;

            int seciliIndeks = lstYazilarim.SelectedIndex;

            if (lstArananlar.Visible == true)
            {
                Yazi arananYazi = gunlukler[seciliIndeks];
                using (var con = BaglantiOlustur())
                {
                    var cmd = new SqlCommand("Update Gunlukler SET Baslik = @p1 ,Icerik = @p2 WHERE Id = @p0", con);
                    cmd.Parameters.AddWithValue("@p1", duzenlenenBaslik);
                    cmd.Parameters.AddWithValue("@p2", duzenlenenIcerik);
                    cmd.Parameters.AddWithValue("@p0", arananYazi.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                Yazi seciliYazi = gunlukler[seciliIndeks];
                using (var con = BaglantiOlustur())
                {
                    var cmd = new SqlCommand("Update Gunlukler SET Baslik = @p1 ,Icerik = @p2 WHERE Id = @p0", con);
                    cmd.Parameters.AddWithValue("@p1", duzenlenenBaslik);
                    cmd.Parameters.AddWithValue("@p2", duzenlenenIcerik);
                    cmd.Parameters.AddWithValue("@p0", seciliYazi.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            btnAramaİptal.Visible = false;
            this.Text = "Gunluk 1.0";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.Text = "Gunluk 1.0";

            Kaydet();
            GunlukleriListele();


        }

        private void lstArananlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArananlar.SelectedIndex < 0)
            {
                return;
            }
            int secili_index = (int)lstArananlar.SelectedIndex;
            Yazi aranan = arananlar[secili_index];
            txtBaslik.Text = aranan.Baslik;
            rtxtNotAlani.Text = aranan.Icerik;
        }

        private void btnAramaİptal_Click(object sender, EventArgs e)
        {
            lstArananlar.Visible = false;
            btnAramaİptal.Visible = false;
            lstYazilarim.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int seciliIndeks = lstYazilarim.SelectedIndex;
            Yazi seciliBaslikVeIcerik = gunlukler[seciliIndeks];
            if (lstYazilarim.SelectedItems.Count > 0)
            {
                if (lstArananlar.Visible == true)
                {
                    if (rtxtNotAlani.Text != seciliBaslikVeIcerik.Icerik || txtBaslik.Text != seciliBaslikVeIcerik.Baslik)
                    {
                        DialogResult dr = MessageBox.Show("İçerikte değişiklikler algılandı ve kaydedilmedi kaydedip çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            Kaydet();
                        }
                        else if (dr == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
                else if (rtxtNotAlani.Text != seciliBaslikVeIcerik.Icerik || txtBaslik.Text != seciliBaslikVeIcerik.Baslik)
                {

                    DialogResult dr = MessageBox.Show("İçerikte değişiklikler algılandı ve kaydedilmedi kaydedip çıkılsın mı ?", "Programdan Çıkılıyor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Kaydet();
                    }
                    else if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }

        }

        private void txtBaslik_TextChanged(object sender, EventArgs e)
        {
            int seciliIndeks = lstYazilarim.SelectedIndex;
            int arananseciliIndex = lstArananlar.SelectedIndex;
            Yazi seciliBaslikVeIcerik = gunlukler[seciliIndeks];

            if (lstArananlar.Visible == true)
            {
                Yazi arananseciliIcerik = arananlar[arananseciliIndex];
                if (txtBaslik.Text != arananseciliIcerik.Baslik)
                {
                    this.Text = "Gunluk 1.0(*)";
                }
                else
                {
                    this.Text = "Gunluk 1.0";
                }

            }
            else
            {
                if (txtBaslik.Text != seciliBaslikVeIcerik.Baslik)
                {
                    this.Text = "Gunluk 1.0(*)";
                }
                else
                {
                    this.Text = "Gunluk 1.0";
                }
            }

        }

        private void rtxtNotAlani_TextChanged(object sender, EventArgs e)
        {
            int seciliIndeks = lstYazilarim.SelectedIndex;
            int arananseciliIndex = lstArananlar.SelectedIndex;


            Yazi seciliBaslikVeIcerik = gunlukler[seciliIndeks];
            if (lstArananlar.Visible == true)
            {
                Yazi aramadanGelenBaslikVeIcerik = arananlar[arananseciliIndex];
                if (rtxtNotAlani.Text != aramadanGelenBaslikVeIcerik.Icerik)
                {
                    this.Text = "Gunluk 1.0(*)";
                }
                else
                {
                    this.Text = "Gunluk 1.0";

                }
            }
            else
            {
                if (rtxtNotAlani.Text != seciliBaslikVeIcerik.Icerik)
                {
                    this.Text = "Gunluk 1.0(*)";
                }
                else
                {
                    this.Text = "Gunluk 1.0";
                }
            }
        }
    }
}
