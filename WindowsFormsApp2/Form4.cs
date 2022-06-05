using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {

        public Form4()
        {

            InitializeComponent();
            DisableOutputTextBox();
            DisableRadioButton();

        }


        public double value, result, resultRound;



        public void DisableOutputTextBox()
        {
            OutputTextBox.Enabled = false;
        }



        public void DisableRadioButton()

        {

            CentimeterToMeterRadioButton.Checked = false;
            MeterToKilometerRadioButton.Checked = false;
            MeterToFootRadioButton.Checked = false;
            MeterToMileRadioButton.Checked = false;

        }

        public void CentimeterToMeter()
        {
            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 100;                       // 1 cm = 0,01 m
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();
        }

        public void MeterToKilometer()
        {
            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 1000;                       // 1 m = 0,001 km
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();
        }

        public void MeterToFoot()
        {
            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 0.3048;                       // 1 m = 3.280839895 ft
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();
        }

        public void MeterToMile()
        {
            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 1609.344;                       // 1 m = 0.00062137119224 mi
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            CentimeterToMeterRadioButton.Checked = false;
            MeterToKilometerRadioButton.Checked = false;
            MeterToFootRadioButton.Checked = false;
            MeterToMileRadioButton.Checked = false;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (CentimeterToMeterRadioButton.Checked == true)

            {

                CentimeterToMeter();
            }


            else if (MeterToKilometerRadioButton.Checked == true)
            {
                MeterToKilometer();
            }


            else if (MeterToFootRadioButton.Checked == true)
            {
                MeterToFoot();
            }


            else if (MeterToMileRadioButton.Checked == true)
            {
                MeterToMile();
            }

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CentimeterToMeterRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MeterToKilometerRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MeterToMileRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MeterToFootRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
