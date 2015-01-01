using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OddsCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CalculateOdds_Click(object sender, EventArgs e)
        {
            double percentValue = double.Parse(PercentValue.Text);
            DisplayPrice.Text = "Back the horse if the price is greater than " + CalculatePrice(percentValue);
        }

        private string CalculatePrice(double percentValue)
        {
            string price = "";
            if (percentValue >= 99.00) price = "1/100";
            else if (percentValue >= 98.03) price = "1/50";
            else if (percentValue >= 97.08) price = "1/33";
            else if (percentValue >= 96.15) price = "1/25";
            else if (percentValue >= 95.23) price = "1/20";
            else if (percentValue >= 94.34) price = "1/16";
            else if (percentValue >= 93.45) price = "1/14";
            else if (percentValue >= 92.59) price = "1/12";
            else if (percentValue >= 90.90) price = "1/10";
            else if (percentValue >= 88.50) price = "1/8";
            else if (percentValue >= 86.95) price = "2/13";
            else if (percentValue >= 85.47) price = "1/6";
            else if (percentValue >= 84.74) price = "2/11";
            else if (percentValue >= 83.33) price = "1/5";
            else if (percentValue >= 81.30) price = "2/9";
            else if (percentValue >= 80.00) price = "1/4";
            else if (percentValue >= 77.80) price = "2/7";
            else if (percentValue >= 76.70) price = "3/10";
            else if (percentValue >= 75.00) price = "1/3";
            else if (percentValue >= 73.33) price = "4/11";
            else if (percentValue >= 71.43) price = "2/5";
            else if (percentValue >= 69.23) price = "4/9";
            else if (percentValue >= 66.67) price = "1/2";
            else if (percentValue >= 65.50) price = "8/15";
            else if (percentValue >= 63.64) price = "4/7";
            else if (percentValue >= 61.90) price = "8/13";
            else if (percentValue >= 60.00) price = "4/6";
            else if (percentValue >= 58.48) price = "5/7";
            else if (percentValue >= 57.89) price = "8/11";
            else if (percentValue >= 55.56) price = "4/5";
            else if (percentValue >= 54.55) price = "5/6";
            else if (percentValue >= 52.38) price = "10/11";
            else if (percentValue >= 51.13) price = "19/20";
            else if (percentValue >= 50.00) price = "1/1";
            else if (percentValue >= 48.78) price = "21/20";
            else if (percentValue >= 47.62) price = "11/10";
            else if (percentValue >= 45.45) price = "6/5";
            else if (percentValue >= 44.44) price = "5/4";
            else if (percentValue >= 42.11) price = "11/8";
            else if (percentValue >= 40.00) price = "6/4";
            else if (percentValue >= 38.10) price = "13/8";
            else if (percentValue >= 36.36) price = "7/4";
            else if (percentValue >= 35.71) price = "9/5";
            else if (percentValue >= 34.78) price = "15/8";
            else if (percentValue >= 33.33) price = "2/1";
            else if (percentValue >= 30.77) price = "9/4";
            else if (percentValue >= 28.57) price = "5/2";
            else if (percentValue >= 26.67) price = "11/4";
            else if (percentValue >= 25.00) price = "3/1";
            else if (percentValue >= 23.08) price = "10/3";
            else if (percentValue >= 22.22) price = "7/2";
            else if (percentValue >= 20.00) price = "4/1";
            else if (percentValue >= 18.18) price = "9/2";
            else if (percentValue >= 16.67) price = "5/1";
            else if (percentValue >= 15.38) price = "11/2";
            else if (percentValue >= 14.29) price = "6/1";
            else if (percentValue >= 13.33) price = "13/2";
            else if (percentValue >= 12.50) price = "7/1";
            else if (percentValue >= 11.11) price = "8/1";
            else if (percentValue >= 10.00) price = "9/1";
            else if (percentValue >= 9.09) price = "10/1";
            else if (percentValue >= 7.69) price = "12/1";
            else if (percentValue >= 6.67) price = "14/1";
            else if (percentValue >= 5.88) price = "16/1";
            else if (percentValue >= 4.76) price = "20/1";
            else if (percentValue >= 2.94) price = "33/1";
            else if (percentValue >= 1.96) price = "50/1";
            else if (percentValue >= 0.00) price = "100/1";
            else price = "something went wrong!!";

            return price;
        }
    }
}