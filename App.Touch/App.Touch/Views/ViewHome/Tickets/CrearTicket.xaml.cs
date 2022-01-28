using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views.ViewHome.Tickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearTicket : ContentPage
    {
        public CrearTicket()
        {
            InitializeComponent();
        }

        private void IconHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}