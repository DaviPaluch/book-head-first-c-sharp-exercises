using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_a_cabeca_capitulo_02
{
    public partial class Form1 : Form
    {
        bool B = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                
                
                if(label1.BackColor != Color.Blue)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("You don't checked the box");
                label1.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Something is wrong!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
