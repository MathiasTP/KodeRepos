using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Where2Drink_01.Services;
using Where2Drink_01.Views;
using Where2Drink_01.Views.BarViews;

namespace Where2Drink_01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
