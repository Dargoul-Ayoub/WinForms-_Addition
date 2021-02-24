using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_nbr2_TextChanged(object sender, EventArgs e)
        {
            int nbr1 = 0;
            int nbr2 = 0;
            //check if the user has entered a number
            if (txtbox_nbr1.Text == "")
                nbr1 = 0;
            else
            nbr1 = int.Parse(txtbox_nbr1.Text);//convert to int from string

            if (textBox_nbr2.Text== "")
                nbr2 = 0;
            else
            nbr2 = int.Parse(textBox_nbr2.Text);

            textBox_somme.Text = Convert.ToString(nbr1 + nbr2); // convert to string
        }

        private void textBox_somme_TextChanged(object sender, EventArgs e)
        {

        }

        //Again btn
        private void btn_remis_Click(object sender, EventArgs e)
        {
            txtbox_nbr1.Text=null;
            textBox_nbr2.Text = null;
            textBox_somme.Text = null;
            txtbox_nbr1.Focus();// make the cursor on the first text box
            
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            string message = "By by...";
            string title = "Good By";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

                Environment.Exit(0);
               
            }



        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //show the dialog box
            if (MessageBox.Show("By by...", "Good By", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else 
                e.Cancel = true;
        }

        

    }
}