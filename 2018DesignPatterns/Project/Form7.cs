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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var customerObserver = new CustomerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach(customerObserver);
            productManager.Attach(new EmployeeObserver());
            productManager.Detach(customerObserver);
            productManager.UpdatePrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
class ProductManager
{
    List<Observer> _observers = new List<Observer>();
    public void UpdatePrice()
    {
        MessageBox.Show("Observer Deseni::: Bildirimler açıldı.");
        Notify();
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

abstract class Observer
{
    public abstract void Update();
}

class CustomerObserver : Observer
{
    public override void Update()
    {
        MessageBox.Show("Bir okunmamış mesaj : Product price changed!");
    }
}

class EmployeeObserver : Observer
{
    public override void Update()
    {
        MessageBox.Show("Bir okunmamış Mesaj : Product price changed!");
    }
}




