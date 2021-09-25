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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj(new Log4NetAdapter());
            mesaj.Save();
        }
    }
}
//Adaptör dizaynı
class Mesaj
{
    private ILogger _logger;

    public Mesaj(ILogger logger)
    {
        _logger = logger;
    }

    public void Save()
    {
        _logger.Log("Kayıt");
        MessageBox.Show("Mesajınız gönderildi");
    }
}

interface ILogger
{
    void Log(string message);
}

class EdLogger : ILogger
{
    public void Log(string message)
    {
        MessageBox.Show("Kayıt, {0}", message);
    }
}

//Nuget
class Log4Net
{
    public void LogMessage(string message)
    {
        MessageBox.Show("Adaptör dizaynı çalıştı", message);
    }
}

class Log4NetAdapter : ILogger
{
    public void Log(string message)
    {
        Log4Net log4Net = new Log4Net();
        log4Net.LogMessage(message);
    }
}

