using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcNoSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            tckimlikno.KPSPublic kps = new tckimlikno.KPSPublic();
            bool kontrol = kps.TCKimlikNoDogrula(long.Parse(tcNo_txtBox.Text), isim_txtBox.Text.ToUpper(), soyisim_txtBox.Text.ToUpper(), int.Parse(dogumYili_txtBox.Text));
            if (kontrol)
            {
                MessageBox.Show("Bilgileriniz Doğru", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}