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
    public partial class VisitasDelivery : ContentPage
    {
        public VisitasDelivery()
        {
            InitializeComponent();
        }

        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void compartir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisitaAnunciada());
        }
    }
}