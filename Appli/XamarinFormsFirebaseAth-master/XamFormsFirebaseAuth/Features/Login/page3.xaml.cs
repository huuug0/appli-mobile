using System;
using System.Collections.Generic;
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




namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page3 : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page3()
        {
            InitializeComponent();
           
        }
    
    private void OnNextPageButtonClicked(object sender, EventArgs e)
    {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                ImplicationActivite = newImplicationActivite.Date.ToString("dd/MM/yyyy"),
                CapaciteOperationnelle = newCapaciteOperationnelle.Date.ToString("dd/MM/yyyy"),
             


            }); ;

            newImplicationActivite.AutomationId = "";
            newCapaciteOperationnelle.AutomationId = "";
           

            Navigation.PushModalAsync(new page4());

    }

}
}
