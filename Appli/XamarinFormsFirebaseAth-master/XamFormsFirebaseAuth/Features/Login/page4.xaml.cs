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
    public partial class page4 : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page4()
        {
            InitializeComponent();
        }
        public async void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                Acquisition1 = newAcquisition1.SelectedItem.ToString(),
                MSP1 = newMSP1.Text,
                DateCompetence1 = newDateCompetence1.Date.ToString("dd/MM/yyyy"),
                Intervention1 = newIntervention1.Text,
                Theme1 = newTheme1.Text,
                Plan1 = newPlan1.Text,

                Acquisition2 = newAcquisition2.SelectedItem.ToString(),
               

                Acquisition3 = newAcquisition3.SelectedItem.ToString(),
              

                Acquisition4 = newAcquisition4.SelectedItem.ToString(),
             

                Acquisition5 = newAcquisition5.SelectedItem.ToString(),
             

                Acquisition6 = newAcquisition6.SelectedItem.ToString(),
         

                Acquisition7 = newAcquisition7.SelectedItem.ToString(),
            

                Acquisition8 = newAcquisition8.SelectedItem.ToString(),
         
         

                Acquisition9 = newAcquisition9.SelectedItem.ToString(),
           

                Acquisition10 = newAcquisition10.SelectedItem.ToString(),
  



            }); ;

            newAcquisition1.AutomationId = "";
            newMSP1.AutomationId = "";
            newDateCompetence1.AutomationId = "";
            newIntervention1.AutomationId = "";
            newTheme1.AutomationId = "";
            newPlan1.AutomationId = "";


            await Navigation.PushModalAsync(new page5());
        }
    }
}