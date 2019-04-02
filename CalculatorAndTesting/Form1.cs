using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAndTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string res;

            try
            {
                double op1 = double.Parse(textBoxOp1.Text);
                double op2 = double.Parse(textBoxOp2.Text);
                res = MathModule.Sum(op1, op2).ToString();
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }

            labelResult.Text = res;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            string res;

            try
            {
                double op1 = double.Parse(textBoxOp1.Text);
                double op2 = double.Parse(textBoxOp2.Text);
                res = MathModule.Substract(op1, op2).ToString();
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }

            labelResult.Text = res;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string res;

            try
            {
                double op1 = double.Parse(textBoxOp1.Text);
                double op2 = double.Parse(textBoxOp2.Text);
                res = MathModule.Multiply(op1, op2).ToString();
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }

            labelResult.Text = res;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            string res;

            try
            {
                double op1 = double.Parse(textBoxOp1.Text);
                double op2 = double.Parse(textBoxOp2.Text);
                res = MathModule.Divide(op1, op2).ToString();
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }

            labelResult.Text = res;
        }
    }
}