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
    public partial class page1 : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page1()
        {
            InitializeComponent();
        }

        public async void OnNextPageButtonClicked(object sender, EventArgs e)
        {

            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                ModalitéConnexion = newModalitéConnexion.Date.ToString("dd/MM/yyyy"),
                ReferencielTechnique = newReferencielTechnique.Date.ToString("dd/MM/yyyy"),
                FicheMateriel = newFicheMateriel.Date.ToString("dd/MM/yyyy"),
                MaitriseMateriel = newMaitriseMateriel.Date.ToString("dd/MM/yyyy"),
                ProcedureDesinfection = newProcedureDesinfection.Date.ToString("dd/MM/yyyy"),
                RoleStationnaire = newRoleStationnaire.Date.ToString("dd/MM/yyyy"),
                MaitriseTerminaux = newMaitriseTerminaux.Date.ToString("dd/MM/yyyy"),
                MaitriseBip = newMaitriseBip.Date.ToString("dd/MM/yyyy"),
                ConnaissanceEPI = newConnaissanceEPI.Date.ToString("dd/MM/yyyy"),
                GesteSecours = newGesteSecours.Date.ToString("dd/MM/yyyy")


            }); ;

            newModalitéConnexion.AutomationId = "";
            newReferencielTechnique.AutomationId = "";
            newFicheMateriel.AutomationId = "";
            newMaitriseMateriel.AutomationId = "";
            newProcedureDesinfection.AutomationId = "";
            newRoleStationnaire.AutomationId = "";
            newMaitriseTerminaux.AutomationId = "";
            newMaitriseBip.AutomationId = "";
            newConnaissanceEPI.AutomationId = "";
            newGesteSecours.AutomationId = "";

            await Navigation.PushModalAsync(new page3());
        }
    }
}