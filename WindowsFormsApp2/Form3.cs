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


    public partial class Form3 : Form
    {

        public Form3()
        {
           
            InitializeComponent();
            DisableOutputTextBox();
            DisableRadioButton();

        }


        public double value,result,resultRound;

        

        public void DisableOutputTextBox()
        {

            OutputTextBox.Enabled = false;
        }



       public void DisableRadioButton()

        {

            FahrenheitToCelciusRadioButton.Checked = false;
            CelciusToFahrenheitRadioButton.Checked = false;
            CelciusToKelvinRadioButton.Checked = false;
            KelvinToCelciusRadioButton.Checked = false;
            FahrenheitToKelvinRadioButton.Checked = false;

        }



        public void FahrenheitToCelcius()
        {
          

                value = Convert.ToDouble(InputTextBox.Text);
                result = ((0.5556) * (value - 32));                       //Fahrenheit to Celsius	° C = 5/9 (° F - 32)
                resultRound = Math.Round(result,2);
                
                OutputTextBox.Text = resultRound.ToString();
                

        }


        public void CelciusToFarenheit()
        {
           
            
            value = Convert.ToDouble(InputTextBox.Text);
            result = ((1.8)*(value)) + 32;                               //Celcius to Fahrenheit	° F = 9/5 ( ° C) + 32

            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();


        }


        public void CelciusToKelvin()

        {
          
            
            value = Convert.ToDouble(InputTextBox.Text);
            result = value + 273;                                        //Celsius to Kelvin	K = ° C + 273
            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();



        }


        public void KelvinToCelcius()

        {
            
            value = Convert.ToDouble(InputTextBox.Text);
            result = value - 273;                                        //Kelvin to Celsius	° C = K - 273

            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();


        }


        public void FahrenheitToKelvin()

        {
           
            value = Convert.ToDouble(InputTextBox.Text);
            result = ((0.5556) *(value - 32))+273;                         // Fahrenheit to Kelvin	K = 5/9 (° F - 32) + 273

            resultRound = Math.Round(result, 2);

            OutputTextBox.Text = resultRound.ToString();

        }




      
        //Convert Button

        private void button1_Click(object sender, EventArgs e)
        {
            
      
           if(FahrenheitToCelciusRadioButton.Checked==true)

            {
               
                FahrenheitToCelcius();
            }


           else if(CelciusToFahrenheitRadioButton.Checked == true)
            {
                CelciusToFarenheit();
            }


            else if (CelciusToKelvinRadioButton.Checked == true)
            {
                CelciusToKelvin();
            }


            else if (KelvinToCelciusRadioButton.Checked == true)
            {
                KelvinToCelcius(); 
            }


            else if (FahrenheitToKelvinRadioButton.Checked == true)
            {
                FahrenheitToKelvin();
            }
            
        }





        //Reset Button

        private void button2_Click(object sender, EventArgs e)
        {

            InputTextBox.Clear();
            OutputTextBox.Clear();
            FahrenheitToCelciusRadioButton.Checked = false;
            CelciusToFahrenheitRadioButton.Checked = false;
            CelciusToKelvinRadioButton.Checked = false;
            KelvinToCelciusRadioButton.Checked = false;
            FahrenheitToKelvinRadioButton.Checked = false;

        }









   



        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void FahrenheitToCelciusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        private void CelciusToFahrenheitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
         

        }

        private void CelciusToKelvinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void KelvinToCelciusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           

        }
     
        private void FahrenheitToKelvinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void CelciusToKelvinRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
        }


    }

