using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Shared;
using Xamarin.Essentials;
using XamFormsFirebaseAuth.Features.Home;
using XamFormsFirebaseAuth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page5 : ContentPage
    {

                FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page5()
        {
            InitializeComponent();
        }

        


        private void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                PLanAction = newPlanAction.Text,
                Suivi = newSuivi.Text,
                DateEcheance = newDateEcheance.Date.ToString("dd/MM/yyyy")

            }); ;

            newPlanAction.Text = "";
            newSuivi.Text = "";
            newDateEcheance.AutomationId = "";



            Navigation.PushModalAsync(new page6());

        }

        private void newRubriqueButtonClicked(object sender, EventArgs e)
        {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                PLanAction = newPlanAction.Text,
                Suivi = newSuivi.Text,
                DateEcheance = newDateEcheance.Date.ToString("dd/MM/yyyy")
           
            }); ;

            newPlanAction.Text = "";
            newSuivi.Text = "";
            newDateEcheance.AutomationId = "";
    






            Navigation.PushModalAsync(new page5());




        }   
    }
}