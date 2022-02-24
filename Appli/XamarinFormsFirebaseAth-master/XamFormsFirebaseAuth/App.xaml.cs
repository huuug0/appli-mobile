using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsFirebaseAuth.Features.Shell;

using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Xamarin.Essentials;
using XamFormsFirebaseAuth.Features.Login;
using XamFormsFirebaseAuth;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]


namespace XamFormsFirebaseAuth
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
          
        }


        public string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");



       

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
