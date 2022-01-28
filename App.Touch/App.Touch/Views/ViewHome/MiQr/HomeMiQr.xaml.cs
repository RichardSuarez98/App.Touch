using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views.ViewHome.MiQr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMiQr : ContentPage
    {
        public HomeMiQr()
        {
            InitializeComponent();
        }

        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}