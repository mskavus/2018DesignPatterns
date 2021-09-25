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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.Text)
            {
                case "Toyota":
                    {
                        pictureBox1.Image = Properties.Resources.toyota;
                        break;
                    }
                case "Honda":
                    {
                        pictureBox1.Image = Properties.Resources.honda;
                        break;
                    }
                case "Audi":
                    {
                        pictureBox1.Image = Properties.Resources.audi;
                        break;
                    }
                case "Mercedes":
                    {
                        pictureBox1.Image = Properties.Resources.mercedesbenz;
                        break;
                    }
                case "Fiat":
                    {
                        pictureBox1.Image = Properties.Resources.fiat;
                        break;
                    }
                case "Renault":
                    {
                        pictureBox1.Image = Properties.Resources.renault;
                        break;
                    }
                case "Ferrari":
                    {
                        pictureBox1.Image = Properties.Resources.ferrari;
                        break;
                    }
                case "Chevrolet":
                    {
                        pictureBox1.Image = Properties.Resources.chevrolet;
                        break;
                    }
                case "Hyundai":
                    {
                        pictureBox1.Image = Properties.Resources.hyundai;
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ilan customerManager = new Ilan();
            customerManager.Save();
            Form7 form7sec = new Form7();
            form7sec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ilan customerManager = new Ilan();
            customerManager.Save();
            Form7 form7sec = new Form7();
            form7sec.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//facade deseni
class Logging : ILogging
{
    public void Log()
    {
        MessageBox.Show("Facade deseni çalıştı");
    }
}

interface ILogging
{
    void Log();
}

class Caching : ICaching
{

    public void Cache()
    {
        MessageBox.Show("Önbelleğe Alındı.");
    }
}

interface ICaching
{
    void Cache();
}

class Authorize : IAuthorize
{
    public void CheckUser()
    {
        MessageBox.Show("Kullanıcı kontrol edildi.");
    }
}

internal interface IAuthorize
{
    void CheckUser();
}

class Validation : IValidate
{
    public void Validate()
    {
        MessageBox.Show("Onaylandı");
    }
}

internal interface IValidate
{
    void Validate();
}

class Ilan
{
    private CrossCuttongConcernsFacade _concerns;
    public Ilan()
    {
        _concerns = new CrossCuttongConcernsFacade();
    }

    public void Save()
    {
        _concerns.Caching.Cache();
        _concerns.Authorize.CheckUser();
        _concerns.Logging.Log();
        _concerns.Validation.Validate();
        MessageBox.Show("İlanınız Yayınlandı");
    }
}

class CrossCuttongConcernsFacade
{
    public ILogging Logging;
    public ICaching Caching;
    public IAuthorize Authorize;
    public IValidate Validation;


    public CrossCuttongConcernsFacade()
    {
        Logging = new Logging();
        Caching = new Caching();
        Authorize = new Authorize();
        Validation = new Validation();
    }
}


