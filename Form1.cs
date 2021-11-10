using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversions
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(choiceBox.Text);
            double value = Convert.ToDouble(inputBox.Text);
           

            if(choice == 1)
            {
                double result = InToCm(value);
                outputLabel.Text = $"{value} inches is {result} cm";
            }
            else if(choice == 2)
            {
                double result = FtToCm(value);
                outputLabel.Text = $"{value} feet is {result} cm";
            }
            else if(choice == 3)
            {
               double result = YdToM(value);
               outputLabel.Text = $"{value} yards is {result} m";
            }
            else if (choice == 4)
            {
                double result = MiToKm(value);
                outputLabel.Text = $"{value} miles is {result} km";
            }

        }

        public double InToCm(double inch)
        {
            double cm = inch * 2.54;
            return cm;
        }

        public double FtToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        public double YdToM(double yard)
        {
            double m = yard * 0.91;
            return m;
        }

        public double MiToKm(double miles)
        {
            double km = miles * 1.6;
            return km;
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
