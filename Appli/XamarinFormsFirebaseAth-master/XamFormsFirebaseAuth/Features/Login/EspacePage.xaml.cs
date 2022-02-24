using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsFirebaseAuth.Features.Login;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EspacePage : ContentPage
    {
        public EspacePage()
        {
            InitializeComponent();
        }

        public async void Formatteur2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FormatteurPage());
        }
        public async void Stagiaire2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RealtimeDBExample.MainPage());
        }
    }
}