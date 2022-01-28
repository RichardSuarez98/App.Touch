using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views.ViewHome.Ingreso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeIngreso : ContentPage
    {
        public HomeIngreso()
        {
            InitializeComponent();
        }


        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisitasDelivery()); 
        }
    }
}