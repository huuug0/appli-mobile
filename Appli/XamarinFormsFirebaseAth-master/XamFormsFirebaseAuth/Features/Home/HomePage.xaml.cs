using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Database;
using Firebase.Database.Query;
using Shared;
using Xamarin.Essentials;
using XamFormsFirebaseAuth.Features.Home;
using XamFormsFirebaseAuth;
using XamFormsFirebaseAuth.Features.Login;
using Syncfusion.SfPicker;
using Firebase.Database;
using SQLite;


namespace XamFormsFirebaseAuth.Features.Home
{

    public partial class HomePage : INotifyPropertyChanged
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
       


        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();

           


        }
        

        void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            { 



    Nom = newUser.Text,
                Prenom = newPrenom.Text,
            Email = newEmail.Text,
                  CIS = newCIS.Text,
            Grade = newGrade.Text,
            DateRecrutement = newDateRecrutement.Date.ToString("dd/MM/yyyy"),
            DateNaissance = newDateNaissance.Date.ToString("dd/MM/yyyy"),
            Aptitude = newAptitudeMedicale.SelectedItem.ToString(),
            Observations = newObservations.Text,



            });

         


             



                newUser.Text = "";
            newPrenom.Text = "";
            newDateNaissance.AutomationId = "";
            newCIS.Text = "";
            newGrade.Text = "";
            newDateRecrutement.AutomationId = "";
            newObservations.Text = "";
            newAptitudeMedicale.AutomationId = "";






            Navigation.PushModalAsync(new page0());



        }
   



    }

}


   

