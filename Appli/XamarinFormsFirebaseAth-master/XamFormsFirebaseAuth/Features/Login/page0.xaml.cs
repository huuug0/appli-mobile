using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using Newtonsoft.Json;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page0 : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page0()
        {
            InitializeComponent();
          


        }


        public void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {



                DateAdaptationEnvironnement = newDateAdaptationEnvironnement.Date.ToString("dd/MM/yyyy"),
            DateApportTheoriqueSUAP = newDateApportTheoriqueSUAP.Date.ToString("dd/MM/yyyy"),
            DatePSC1 = newDatePSC1.Date.ToString("dd/MM/yyyy"),
            PSC1 = newPSC1.SelectedItem.ToString(),
            DateRegleSante = newDateReglesSanté.Date.ToString("dd/MM/yyyy"),

        }); 

            newDateApportTheoriqueSUAP.AutomationId = "";
            newDatePSC1.AutomationId = "";
            newDateReglesSanté.AutomationId = "";
            newDateAdaptationEnvironnement.AutomationId = "";
            newPSC1.AutomationId = "";

         

            
            Navigation.PushModalAsync(new page1());


    }
  }
}