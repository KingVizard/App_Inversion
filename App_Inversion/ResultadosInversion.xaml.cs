using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App_Inversion.MainPage;

namespace App_Inversion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultadosInversion : ContentPage
	{
        

        public ResultadosInversion ()
		{
			InitializeComponent ();

            acumulacionTotal.Text = VARIABLE.VARIABLE__total;
            porcentajeInversionista_1.Text = VARIABLE.VARIABLE__1 + "%";
            porcentajeInversionista_2.Text = VARIABLE.VARIABLE__2 + "%";
            porcentajeInversionista_3.Text = VARIABLE.VARIABLE__3 + "%" ;


        }


    }
}