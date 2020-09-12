using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        int Val1, Val2, Result;
        string op = "";
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            Val1 = 0;
            Val2 = 0;
            op = "";
        }

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Val2 = int.Parse(txtValue.Text);
                if (op == "+")
                {
                    Result = Val1 + Val2;
                }
                else if (op == "-")
                {
                    Result = Val1 - Val2;
                }
                else if (op == "*")
                {
                    Result = Val1 * Val2;
                }
                else if (op == "/")
                {
                    Result = Val1 / Val2;
                }
                txtValue.Text = Result.ToString();
            }
            catch (Exception ex) {
                txtValue.Text = "0";

}
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void DoNumClick(object sender,EventArgs e)
        {
            Button b = sender as Button;
            int v = int.Parse(b.Text);
            int Val = int.Parse(txtValue.Text);
            Val = Val * 10 + v;
            txtValue.Text = Val.ToString();
        }
        private void DoOperatorClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            op = b.Text;
            Val1 = int.Parse(txtValue.Text);
            txtValue.Text = "0";

        }
    }
}
