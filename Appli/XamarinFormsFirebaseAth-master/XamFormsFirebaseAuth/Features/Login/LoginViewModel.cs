using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamFormsFirebaseAuth.Features.Common;
using XamFormsFirebaseAuth.Framework;
using XamFormsFirebaseAuth.Features.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SQLite;
using XamFormsFirebaseAuth.Features.Home;

using Firebase.Database;
using Firebase.Database.Query;
using Shared;
using Xamarin.Essentials;
using XamFormsFirebaseAuth;

namespace XamFormsFirebaseAuth.Features.Login
{
    public class LoginPageModel : BaseViewModel
    {
        private string password;
        public string email;
        
        

        public LoginPageModel()
        {
      
            SignInCommand = new Command(OnSignIn);
            ForgotPasswordCommand = new Command(OnForgotPassword);
        }

        private async void OnForgotPassword()
        {
            await Xamarin.Forms.Shell.Current.GoToAsync("//ForgotPasswordPage");
        }

        public async void OnSignIn()
        {
            try
            {
                var authService = DependencyService.Resolve<IAuthenticationService>();
                var token = await authService.SignIn(Email, Password);

                await Xamarin.Forms.Shell.Current.GoToAsync("//EspacePage");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                await Xamarin.Forms.Shell.Current
                    .DisplayAlert("Erreur", "Mot de passe incorrect", "OK");
            }
        }

        


        #region Properties
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        #endregion

        #region Commands

        public ICommand ForgotPasswordCommand { get; }

        public ICommand SignInCommand { get; }

        public ICommand SignUpCommand { get; }

        #endregion
    }
}
