using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFreamwork
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntitiyUrunEntities db = new DbEntitiyUrunEntities();
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.URUNMARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.TBLKATEGORİ.AD,
                                            x.DURUM
                                        }).ToList();
                                           
          
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtUrunAd.Text;
            t.URUNMARKA = txtMarka.Text;
            t.STOK =short.Parse(txtStok.Text);
            t.FİYAT = decimal.Parse(txtFiyat.Text);
            t.DURUM = true;
            t.KATEGORİ = int.Parse(cmbKategori.SelectedValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN SİSTEME KAYDEDİLDİ");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN SİSTEMDEN SİLİNDİ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbKategori.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txtUrunAd.Text;
            urun.STOK =short.Parse(txtStok.Text);
            urun.URUNMARKA = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show(" ÜRÜN GÜCENLLENDİ SİSTEMİ YENİLEYİN ");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORİ

                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
                             
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtDurum.Text = " ";
            txtFiyat.Text = " ";
            txtID.Text = " ";
            txtMarka.Text = " ";
            txtStok.Text = " ";
            txtUrunAd.Text = " ";
            cmbKategori.Text = " ";
            MessageBox.Show("SİSTEM TEMİZLENDİ");
        }
    }
}
