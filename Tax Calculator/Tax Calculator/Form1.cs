using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class Form1 : Form
    {
        double iTax, ISubTotal, iTotal;

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnterQuantity.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult iExit;

            iExit = MessageBox.Show("Are you Sure you want to Exit?","Leave an application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if(txtEnterQuantity.Text == "")
            {
                MessageBox.Show("Please Enter At Least 1 As A Number Of Quantity", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            else
            {
                cTax Cost = new cTax();

                Cost.item1 = Convert.ToDouble(txtEnterQuantity.Text);

                ISubTotal = Cost.GetAmount();
                iTax = Cost.cFindTax(ISubTotal);

                iTotal = ISubTotal + iTax;

                txtTax.Text = String.Format("{0:C}",iTax);
                txtSubTotal.Text = String.Format("{0:C}", ISubTotal);
                txtTotal.Text = String.Format("{0:C}", iTotal);
            }
                
        }
    }
}
