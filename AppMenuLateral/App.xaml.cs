using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMenuLateral
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new FlyoutPageMenu();
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
