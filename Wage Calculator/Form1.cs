using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class wageCalculator : Form
    {
        private readonly DateTime START_DATE = DateTime.Parse("1/16/2022");
        private readonly DateTime END_DATE = DateTime.Parse("1/31/2022");
        public wageCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this event will close the app
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear results
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
            txtRaise.Clear();

            //clear results
            lblResults.ResetText();

            //set focus on name control
            txtName.Clear();    
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hours, rate, result;
            decimal raisePercent, raiseAmount;


            //exception handling
            try
            {
                //convert the string value of the txtHours control to decimal and
                //stored in the hours variable
                hours = Convert.ToDecimal(txtHours.Text);
                rate = decimal.Parse(txtRate.Text);
                decimal.TryParse(txtRaise.Text, out raisePercent);



                //compute wages
                result = hours * rate;
                raiseAmount = result * raisePercent / 100;

                //display results
                lblResults.Text = txtName.Text + " you earned " + result.ToString("c") + " with your " +
                    raisePercent.ToString() + "% raise you earned " + raiseAmount.ToString("c") + " for a total of " +
                    (result + raiseAmount).ToString("c");
            }
            catch (FormatException)
            {
                lblResults.Text = "Invalid format. Please use numbers";
                txtHours.SelectAll();
                txtHours.Focus();
            }
            catch (Exception ex)
            {
                lblResults.Text = ex.ToString();
            }

        }

        private void wageCalculator_Load(object sender, EventArgs e)
        {
            ////display current date and time
            textBox1.Text = DateTime.Now.ToString("F");     // full date and time

            //set focus
            txtName.Focus();


            //// display default values for period start and end
            txtStartDate.Text = START_DATE.ToString("d");
            txtEndDate.Text = END_DATE.ToString("d");

           

            
        }
    }
}
