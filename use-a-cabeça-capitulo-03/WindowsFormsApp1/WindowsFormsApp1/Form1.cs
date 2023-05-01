using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using use_a_cabeca_csharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Cara joe = new Cara() {Name = "Joe", Cash = 50};

        Cara bob = new Cara() {Name = "Bob", Cash = 100};

        int bank = 100;

        


        public void UpdateForm()
        {

            joesCash.Text = joe.Name + " tem R$ " + joe.Cash;
            bobsCash.Text = bob.Name + " tem R$ " + bob.Cash;
            bankCash.Text = "O banco tem R$ " + bank;
        }
       
        public Form1()
        {

            InitializeComponent();
            joesCash.Text = joe.Name + " tem R$ " + joe.Cash;
            bobsCash.Text = bob.Name + " tem R$ " + bob.Cash;
            bankCash.Text = "O banco tem R$ " + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O banco está sem dinheiro.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);

            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
