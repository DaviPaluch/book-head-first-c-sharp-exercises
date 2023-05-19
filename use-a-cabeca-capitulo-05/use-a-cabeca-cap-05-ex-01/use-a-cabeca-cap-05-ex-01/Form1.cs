using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_a_cabeca_cap_05_ex_01
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            domainUpDown1.Text = "5";
            dinnerParty = new DinnerParty(5,checkBox2.Checked,checkBox2.Checked);
            DisplayDinnerPartyCost();
            
        }
        


        
        private void DisplayDinnerPartyCost()
        {
            dinnerParty.SetNumberOfPeople(Convert.ToInt32(domainUpDown1.Text));
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            decimal Cost = dinnerParty.CalculeCost(checkBox2.Checked);
            costLabel.Text = Cost.ToString("0.00");
        }



        private void domainUpDown1_KeyDown(object sender, KeyEventArgs e) //seta para cima adiciona e para baixo remove
        {

            if(e.KeyCode == Keys.Up) 
            {
                domainUpDown1.Text = (Convert.ToInt32(domainUpDown1.Text) + 1).ToString();
                DisplayDinnerPartyCost();


            } else if(e.KeyCode == Keys.Down)
            {
                domainUpDown1.Text = (Convert.ToInt32(domainUpDown1.Text) - 1).ToString();
                DisplayDinnerPartyCost();

            }


        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(domainUpDown1.Text);
                if (i < 0)
                {
                    throw new Exception(" Uma festa deve ter no mínimo uma pessoa!");
                }
            } catch (Exception ex)
            {
                domainUpDown1.Text = "1"; //se não for digitado um numero zera a quantidade
                
                MessageBox.Show( ex.Message,"Atention!");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                DisplayDinnerPartyCost();   
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                DisplayDinnerPartyCost();
        }

    }
}
