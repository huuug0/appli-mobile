using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormatteurPage : ContentPage
    {
        public FormatteurPage()
        {
            InitializeComponent();
        }
        public async void Remplir2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new XamFormsFirebaseAuth.Features.Home.HomePage());
        }
        public async void Consulte2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RealtimeDBExample.MainPage());
        }
    }
}