using System;
using VERSUCH_.Services;
using VERSUCH_.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VERSUCH_
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
