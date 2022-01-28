using App.Touch.Views;
using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Touch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new TransitionNavigationPage(new Login());
           /// TransitionNavigationPage d = new TransitionNavigationPage(new Login());
           // d.TransitionType = TransitionType.Fade;
             MainPage = new NavigationPage (new Login());
            // MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
