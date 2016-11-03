using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GasolineApp.Views;

using Xamarin.Forms;

namespace GasolineApp
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new NewRefill());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
