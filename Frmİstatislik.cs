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
    public partial class Frmİstatislik : Form
    {
        public Frmİstatislik()
        {
            InitializeComponent();
        }
        DbEntitiyUrunEntities db = new DbEntitiyUrunEntities();
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Frmİstatislik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORİ.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERİ.Count(x => x.DURUM == true).ToString();
            label7.Text = db.TBLMUSTERİ.Count(x => x.DURUM == false).ToString();
            label13.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            label21.Text = db.TBLSATIS.Sum(x => x.FİYAT).ToString()+ " TL " ;
            label9.Text = (from x in db.TBLURUN orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            label11.Text = (from x in db.TBLURUN orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            label15.Text = db.TBLURUN.Count(x => x.KATEGORİ == 1).ToString();
            label19.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.TBLMUSTERİ select x.SEHIR).Distinct().Count().ToString();
            label17.Text = db.URUNMARKAGETIR().FirstOrDefault();
        }
    }
}
