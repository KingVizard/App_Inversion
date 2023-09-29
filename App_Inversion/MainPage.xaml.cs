using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static App_Inversion.MainPage;
using static System.Net.Mime.MediaTypeNames;

namespace App_Inversion
{
    public partial class MainPage : ContentPage
    {
        public static class VARIABLE
        {
            public static string VARIABLE__1;
            public static string VARIABLE__2;
            public static string VARIABLE__3;
            public static string VARIABLE__total;
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            var monto_1 = double.Parse(montoInversionista_1.Text);
            var monto_2 = double.Parse(montoInversionista_2.Text); 
            var monto_3 = double.Parse(montoInversionista_3.Text);

            double total = monto_1 + monto_2 + monto_3;
            
            VARIABLE.VARIABLE__1 = ((monto_1 / total) * 100).ToString("F1");
            VARIABLE.VARIABLE__2 = ((monto_2 / total) * 100).ToString("F1");
            VARIABLE.VARIABLE__3 = ((monto_3 / total) * 100).ToString("F1");
            VARIABLE.VARIABLE__total = total.ToString("F1");
            await Navigation.PushAsync(new ResultadosInversion());


        }

        private void btnCampos_Clicked(object sender, EventArgs e)
        {
            montoInversionista_1.Text = string.Empty;
            montoInversionista_2.Text = string.Empty;
            montoInversionista_3.Text = string.Empty;
        }
    }

}
