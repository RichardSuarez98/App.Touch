using App.Touch.Views.ViewHome.Historico;
using App.Touch.Views.ViewHome.Ingreso;
using App.Touch.Views.ViewHome.MiQr;
using App.Touch.Views.ViewHome.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views.ViewHome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeDetail : ContentPage
    {
        public HomeDetail()
        {
            InitializeComponent();
        }

        private void btnIngresoInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeIngreso());
        }

        private void btnHomeHistorico_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeHistorico());
        }

        private void btnHomeTickets_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeTickets());
        }

        private void btnHomeMiQr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeMiQr());
        }
    }
}