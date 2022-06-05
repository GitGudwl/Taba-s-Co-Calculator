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
    public partial class Form2 : Form
    {
        public Form2()
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
            
            MilligramToGramRadioButton.Checked = false;
            GramToOunceRadioButton.Checked = false;
            GramToKilogramRadioButton.Checked = false;
            KilogramToQuintalRadioButton.Checked = false;
            QuintalToTonneRadioButton.Checked = false;

        }

        public void MilligramToGram()
        {


            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 1000;                     // 1 mg = 0,001 g
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();


        }


        public void GramToOunce()
        {


            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 28.34952;                     // 1 g = 0.03527396195 oz
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();


        }


        public void GramToKilogram()

        {


            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 1000;                     // 1 g = 0,001 kg
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();



        }


        public void KilogramToQuintal()

        {

            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 100;                     // 1 kg = 0,01 quintal
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();


        }


        public void QuintalToTonne()

        {

            value = Convert.ToDouble(InputTextBox.Text);
            result = value / 10;                     // 1 quintal = 0,1 
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            MilligramToGramRadioButton.Checked = false;
            GramToOunceRadioButton.Checked = false;
            GramToKilogramRadioButton.Checked = false;
            KilogramToQuintalRadioButton.Checked = false;
            QuintalToTonneRadioButton.Checked = false;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (MilligramToGramRadioButton.Checked == true)

            {

                MilligramToGram();
            }


            else if (GramToOunceRadioButton.Checked == true)
            {
                GramToOunce();
            }


            else if (GramToKilogramRadioButton.Checked == true)
            {
                GramToKilogram();
            }


            else if (KilogramToQuintalRadioButton.Checked == true)
            {
                KilogramToQuintal();
            }


            else if (QuintalToTonneRadioButton.Checked == true)
            {
                QuintalToTonne();
            }

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MilligramToGramRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GramToOunceRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GramToKilogramRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KilogramToQuintalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuintalToTonneRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
