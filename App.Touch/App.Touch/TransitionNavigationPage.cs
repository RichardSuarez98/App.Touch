using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App.Touch
{
    public enum TransitionType
    {
        Fade,
        Flip,
        Scale,
        SlideFromLeft,
        SlideFromRight,
        SlideFromTop,
        SlideFromBottom
    }

    public class TransitionNavigationPage : NavigationPage
    {
        public TransitionNavigationPage() : base()
        {

        }

        public TransitionNavigationPage(Page root) : base(root)
        {

        }

      

        public static readonly BindableProperty TransitionTypeProperty =
     BindableProperty.Create("TransitionType", typeof(TransitionType), typeof(TransitionNavigationPage), TransitionType.SlideFromLeft);

         public TransitionType TransitionType
        {
            get { return (TransitionType)GetValue(TransitionTypeProperty); }
            set { SetValue(TransitionTypeProperty, value); }
        }
       
    }
}
