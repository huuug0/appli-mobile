using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamFormsFirebaseAuth.Features.Login;
using RealtimeDBExample.ViewModels;
using Shared;


namespace RealtimeDBExample
{


    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

     

        //(pour la barre de recherche )
        //  public void search1_textchanged(object sender, TextChangedEventArgs e)
        //  {
        //    var searchresult = MainPageViewModel.Items.Where(c => c.Nom.ToLower().Contains(search1.Text.ToLower()));
        //      listview1.ItemsSource = searchresult;
        //  }


        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DetailPage());
        }
    }
}
