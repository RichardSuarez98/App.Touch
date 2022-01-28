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
    public partial class VisitaAnunciada : ContentPage
    {
        public VisitaAnunciada()
        {
            InitializeComponent();
        }

        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}