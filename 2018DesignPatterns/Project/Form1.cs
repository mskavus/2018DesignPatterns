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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
            var araba = Araba.SingletonOlustur();
            araba.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8sec = new Form8();
            form8sec.Show();
            this.Hide();
        }
    }
}
//SİNGLETON DESENİ
class Araba  //singleton sınıfı oluşturduk. 
{
    private static Araba _Araba; //Static field oluşturduk.
    private Araba()  //Private bir constructor oluşturuldu.
    {

    }
    public static Araba SingletonOlustur()
    {
        if (_Araba == null) //Daha önce oluşturulmuş mu kontrol et.
        {
            _Araba = new Araba(); //Oluşturulmamışsa yenisini oluştur.
        }
        return _Araba; //Zaten oluşturulmuşsa varolanı döndür.
    }
    public void Show()
    {
        MessageBox.Show("Singleton sınıf çalıştı");
        MessageBox.Show("Mehmet Ali NÜNÜKOĞLU... Musa KAVUŞ", "Yapım");

    }
}
