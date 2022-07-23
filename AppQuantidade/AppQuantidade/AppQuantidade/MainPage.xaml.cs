using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;

namespace AppQuantidade
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class MainPage : ContentPage
    {
        double média, preço, km, pedagio;
        double resultado = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Oper
        (object sender, double e)
        {
            double newText = e;
            média = newText;
        }
        private void Oper_1
        (object sender, double e)
        {
            double newText = e;
            preço = newText;
        }

        private void Oper_2
       (object sender, double e)
        {
            double newText = e;
            km = newText;
        }

        private void Oper_3
        (object sender, double e)
        {
            double newText = e;
            pedagio = newText;
        }

        private void Final(object sender, EventArgs e)
        {
            double OperOne = km / média;
            double OperTwo = (preço * OperOne) + pedagio;
            resultado = OperTwo;
            Result.Text = "R$" + resultado.ToString("f2", CultureInfo.InvariantCulture);
        }

        private void Zerar(object sender, EventArgs e)
        {
            Zerarcamp_0.Text = 0.ToString();
            Zerarcamp_1.Text = 0.ToString();
            Zerarcamp_2.Text = 0.ToString();
            Zerarcamp_3.Text = 0.ToString();
            resultado = 0;


            Result.Text = resultado.ToString();
            
            



        }
    }
}