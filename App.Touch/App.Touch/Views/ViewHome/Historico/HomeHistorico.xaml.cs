using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views.ViewHome.Historico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeHistorico : ContentPage
    {
        public HomeHistorico()
        {
            InitializeComponent();
        }

        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}