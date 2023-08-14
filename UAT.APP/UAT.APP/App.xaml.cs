using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UAT.APP.Services;
using UAT.APP.Views;

namespace UAT.APP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
