using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Yazi_Ile
{
    public partial class Sayiyi_Yaziyla_Yaz : Form
    {
        private string Sayi0, Sonuc0;
        private int Basamak, Basamak0, Basamak3;

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FontDialog1 = new FontDialog();
            if (FontDialog1.ShowDialog() == DialogResult.OK)
                Sonuc.Font = FontDialog1.Font;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            DialogResult Dialog_Kontrol;
            SaveFileDialog1.FileName = "ByIdris";
            SaveFileDialog1.Filter = "*.txt Uzantılı Dosya (*.txt)|*.txt";
            do
            {
                Dialog_Kontrol = SaveFileDialog1.ShowDialog();
            } while (SaveFileDialog1.FileName == null && Dialog_Kontrol == DialogResult.OK);
            if (Dialog_Kontrol == DialogResult.OK)
                File.WriteAllText(SaveFileDialog1.FileName, Sonuc.Text);
        }

        private void Sayi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Yaz_Click(sender, e);
        }

        private void Sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '\b')
                e.Handled = false;
        }

        private void Sonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Sonuc_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Sayiyi_Yaziyla_Yaz()
        {
            InitializeComponent();
        }

        private void Yaz_Click(object sender, EventArgs e)
        {
            if (Sayi.Text != "")
            {
                Sayi_Islemleri SI = new Sayi_Islemleri();
                Basamak_Islemleri BI = new Basamak_Islemleri();
                Sonuc.Text = null;
                Sonuc0 = null;
                Sayi0 = Sayi.Text;
                Basamak = Sayi.Text.Length;
                Basamak0 = Basamak;
                Basamak3 = Basamak % 3;
                for (int i = 0; i < Basamak; i++)
                {
                    Sonuc0 += SI.Sayilar(Sayi0[i], ref Basamak, ref Basamak3);
                    Sonuc0 += BI.Uclu_Basamaklar(ref Sayi0, ref Basamak0, ref Basamak3);
                    Basamak3--;
                    if (Basamak3 < 0)
                        Basamak3 += 3;
                }
                Basamak = Sonuc0.Length;
                Sonuc0 = Sonuc0.Remove(Basamak - 1, 1);
                Sonuc.Text = Sonuc0;
            }
        }
    }
}
