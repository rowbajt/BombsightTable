using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombSightTable
{
    public partial class BombSightTableForm : Form
    {
        public BombSightTableForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // create empty string to collect the Errors
            string errorMessages = String.Empty;
            string fieldFocus = String.Empty;

            // perform the checks and collect the errors
            if (inputWindSpeedMasked.Text == "")
            {
                errorMessages = "Please enter the forecast wind speed!\r\n" + errorMessages;
                fieldFocus = "4";
                //inputWindSpeedMasked.Focus();
                //return;
            }

            if (inputWindHeadingMasked.Text == "")
            {
                errorMessages = "Please enter the forecast wind direction!\r\n" + errorMessages;
                fieldFocus = "3";
                //inputWindHeadingMasked.Focus();
                //return;
            }

            if (inputAltitudeMasked.Text == "")
            {
                errorMessages = "Please enter your desired approach altitude!\r\n" + errorMessages;
                fieldFocus = "2";
                //inputAltitudeMasked.Focus();
                //return;
            }

            if (inputApproachHeadingMasked.Text == "")
            {
                errorMessages = "Please enter your desired target approach heading!\r\n" + errorMessages;
                fieldFocus = "1";
                //inputApproachHeadingMasked.Focus();
                //return;
            }
            else
            {
                if((Convert.ToInt32(inputApproachHeadingMasked.Text)) > 360)
                {
                    errorMessages = "Please enter your desired target approach heading!\r\nThe max value for approach heading is 360!\r\n" + errorMessages;
                    fieldFocus = "1";
                    //inputApproachHeadingMasked.Focus();
                    //return;
                }
            }


            // debug fieldFocus vaiable
            if (fieldFocus != "")
            {
                MessageBox.Show(fieldFocus);
            }

            // output collected Errors
            if (!String.IsNullOrEmpty(errorMessages))
            {
                MessageBox.Show(errorMessages, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                // put focus on first error
                if (fieldFocus == "1")
                {
                    ActiveControl = inputApproachHeadingMasked;
                }
                if (fieldFocus == "2")
                {
                    ActiveControl = inputAltitudeMasked;
                }
                if (fieldFocus == "3")
                {
                    ActiveControl = inputWindHeadingMasked;
                }
                if (fieldFocus == "4")
                {
                    ActiveControl = inputWindSpeedMasked;
                }

            }
            else
            {
                // loop to create a certain range of outputs based on calculated results

                // convert all form strings to int values
                int acHeading = 0;
                int acAltitude = 0;
                int wHeading = 0;
                int wSpeed = 0;

                acHeading = Int32.Parse(inputApproachHeadingMasked.Text);
                acAltitude = Int32.Parse(inputAltitudeMasked.Text);
                wHeading = Int32.Parse(inputWindHeadingMasked.Text);
                wSpeed = Int32.Parse(inputWindSpeedMasked.Text);

                // define some variables
                int circle = 360;
                int correction = 0;
                string sideCorrection = string.Empty;
                int i = -10;

                while(i <= 10)
                {
                    if(i==-10)
                    {
                        acHeading = acHeading + i;
                        correction = correction + i;
                    }
                    else
                    {
                        acHeading = acHeading + 1;
                        correction = correction + 1;
                    }

                    // correction fro crosing 360
                    if (correction < 0)
                    {
                        correction = 360 + correction;
                    }
                    if(acHeading < 0)
                    {
                        acHeading = 360 + acHeading;
                    }

                    // calculate left / right
                    if (acHeading > wHeading)
                    {
                        // substract approach heading from widn heading if result is bigger than 180
                        correction = (acHeading - wHeading);

                        sideCorrection = "left";

                        if (correction > 180)
                        {
                            correction = (circle - acHeading) + wHeading;
                            sideCorrection = "right";
                        }

                    }
                    else
                    {
                        //substract  wHeading from acHeading and check if result is bigger then 180
                        // set offset variable accordingly
                        correction = wHeading - acHeading;

                        sideCorrection = "right";

                        if (correction > 180)
                        {
                            correction = (circle - wHeading) + acHeading;
                            sideCorrection = "left";
                        }
                    }

                    // debug output sideCorrection
                    MessageBox.Show("sideCorrection:\r\n" + sideCorrection);

                    // debug acHeading
                    MessageBox.Show("acHeading:\r\n" + acHeading);

                    // debug correction
                    MessageBox.Show("correction:\r\n" + correction);

                    i = i + 1;

                }

            }
                
        }

        private void inputApproachHeading_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
