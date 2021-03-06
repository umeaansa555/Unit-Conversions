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
                InToCm(value);
            }
            else if(choice == 2)
            {
                FtToCm(value);
            }
            else if(choice == 3)
            {
               YdToM(value);
            }
            else if (choice == 4)
            {
                MiToKm(value);
            }

        }

        public void InToCm(double inch)
        {
            double cm = inch * 2.54;
            outputLabel.Text = $"{inch} inches is {cm} cm";
        }

        public void FtToCm(double feet)
        {
            double cm = feet * 30.48;
            outputLabel.Text = $"{feet} feet is {cm} cm";
        }

        public void YdToM(double yard)
        {
            double m = yard * 0.91;
            outputLabel.Text = $"{yard} yards is {m} m";
        }

        public void MiToKm(double miles)
        {
            double km = miles * 1.6;
            outputLabel.Text = $"{miles} miles is {km} km";
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
