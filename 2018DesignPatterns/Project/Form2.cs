using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secim customerManager = new Secim();
            customerManager.MusteriTipi = new DirektGiris();
            customerManager.SecimiKaydet();
            Form4 form4sec = new Form4();
            form4sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secim customerManager = new Secim();
            customerManager.MusteriTipi = new DirektGiris();
            customerManager.SecimiKaydet();
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }
    }
}
//STRATEGY DESENİ
abstract class MusteriTipi : IMusteriTipi
{
    public abstract void Sec();
}

internal interface IMusteriTipi
{
}

class DirektGiris : MusteriTipi
{
    public override void Sec()
    {
        MessageBox.Show("Giriş sayfasına yönlendirliyorsunuz...");
    }
}

class Giris : MusteriTipi
{
    public override void Sec()
    {
        MessageBox.Show("Demo Sayfasına Yönlendirliyorsunuz.");
    }
}

class Secim
{
    public MusteriTipi MusteriTipi { get; set; }

    public void SecimiKaydet()
    {
        MessageBox.Show("Strateji Deseni Aktif.");
        MusteriTipi.Sec();

    }
}

