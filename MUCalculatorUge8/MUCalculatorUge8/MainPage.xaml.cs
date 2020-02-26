using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MUCalculatorUge8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            OnClear(null, null);
        }

        int curretState;
        string mathOperator;
        double firstNumber;
        double secondNumber;

        private void OnSelectNumber(object sender, EventArgs e)
        {
            
            if(curretState <0)
            {
                curretState = -1;
            }

            resultText.Text = ((Button)sender).Text;
            
            if (curretState == 1)
            {
                firstNumber = Convert.ToDouble(((Button)sender).Text);
            }
            else
            {
                secondNumber = Convert.ToDouble(((Button)sender).Text);
            }
            
        }

        private void OnSelectoperator(object sender, EventArgs e)
        {
                curretState = -2;
                mathOperator = ((Button)sender).Text;
        }

        private void OnClear(object sender, EventArgs e)
        {
            resultText.Text = "0";
            curretState = 1;
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            if (mathOperator == "+")
            {
                resultText.Text = Convert.ToString(firstNumber + secondNumber);
            }
            else if (mathOperator == "-")
            {
                resultText.Text = Convert.ToString(firstNumber - secondNumber);
            }
            else if (mathOperator == "X")
            {
                resultText.Text = Convert.ToString(firstNumber * secondNumber);
            }
            else if (mathOperator == "/")
            {
                resultText.Text = Convert.ToString(firstNumber / secondNumber);
            }

            curretState = -1;
            firstNumber = Convert.ToDouble(resultText.Text);
        }

        private async void toPageTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
