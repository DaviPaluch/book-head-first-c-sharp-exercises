using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_a_cabeca_capitulo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseClient);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseClient.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseClient.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isClientCheckBox.CheckState != CheckState.Unchecked)
            {

            }

        }

        private void isClientCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(isClientCheckBox.CheckState == CheckState.Checked)
            {
                isClientCheckBox.Text = "he is client";
            }
            else if(isClientCheckBox.CheckState == CheckState.Unchecked)
            {
                isClientCheckBox.Text = "he isn't client";
            }
            else
            {
                isClientCheckBox.Text = "'please check the box to continue!";
            }
        }
    }
}
