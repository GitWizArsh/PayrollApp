using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_vertime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                hoursWorked = decimal.Parse(txtHours.Text);
                hourlyPayRate = decimal.Parse(txtHours.Text);
                

                if(hoursWorked>BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;

                    overtimeHours = hoursWorked - BASE_HOURS;

                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    grossPay = basePay + overtimePay;

                }
                else
                {
                    grossPay = hourlyPayRate * hoursWorked;
                }
                lblG_pay.Text = grossPay.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtPay.Text = "";
          

            lblG_pay.Text = "";

            txtHours.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
