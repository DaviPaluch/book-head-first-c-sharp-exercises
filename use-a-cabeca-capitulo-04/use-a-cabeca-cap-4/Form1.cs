using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_a_cabeca_cap_4
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = .39, amountOwed;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled+"milhas","Milhas Viajadas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = Convert.ToInt32(domainUpDown1.Text);
            endingMileage = Convert.ToInt32(domainUpDown2.Text);

            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label1.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("A milha inicial necessita ser menor do que a milha final"
                    , "Não consigo calcular a milhagem");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
