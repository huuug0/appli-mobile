using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using XamFormsFirebaseAuth.Features.Home;
using XamFormsFirebaseAuth.Features.Login;
using System.ComponentModel;
using SQLite;


using Firebase.Database;
using Firebase.Database.Query;
using Shared;
using Xamarin.Essentials;
using XamFormsFirebaseAuth;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageModel();

        }

        public partial class ImageButtonDemoPage : ContentPage
        {
            int clickTotal;


        }

       

            void OnImageButtonTwitterClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/sdis42?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor"));
        }


        void OnImageButtonFacebookClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://fr-fr.facebook.com/Sapeurs.pompiers.loire/"));
        }


        void OnImageButtonGoogleClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.sdis42.fr/"));
        }

        void OnImageButtonInstagramClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/sdis42/?hl=fr"));
        }

        
        
        
    }
}