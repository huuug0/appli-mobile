using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Shared;
using Xamarin.Essentials;
using XamFormsFirebaseAuth.Features.Home;
using XamFormsFirebaseAuth;
using XamFormsFirebaseAuth.Features.Login;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsFirebaseAuth.Features.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page6 : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public page6()
        {
            InitializeComponent();
        }
        private void OnSavePageButtonClicked(object sender, EventArgs e)
        {


            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


             

                Aptitude = newAptitude.SelectedItem.ToString(),
                DateSignature = newDateSignature.Date.ToString("dd/MM/yyyy"),
                Signature1 = lblBase64Value.Text

            });

            newAptitude.AutomationId = "";
            newDateSignature.AutomationId = "";
            lblBase64Value.Text = "";


            Navigation.PushModalAsync(new RealtimeDBExample.MainPage());

        }
       
        private void ClearButtonClicked(object sender, EventArgs e)
        {
            signature.Clear();
        }


        public async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            try
            {
                var image = await signature.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Png);
                var mStream = (MemoryStream)image;
                byte[] data = mStream.ToArray();
                string base64Val = Convert.ToBase64String(data);
                lblBase64Value.Text = base64Val;
                imgSignature.Source = ImageSource.FromStream(() => mStream);
                


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }




    }

}



