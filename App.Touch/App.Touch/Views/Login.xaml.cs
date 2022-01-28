using App.Touch.Views.ViewHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO304"&&txtClave.Text=="12345678910")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrecta", "Ok");
            }
        }
    }
}