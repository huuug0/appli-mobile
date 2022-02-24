using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using RealtimeDBExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealtimeDBExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/");
        public DetailPage()
        {
            InitializeComponent();
        }

        private void OnSavePageButtonClicked2(object sender, EventArgs e)
        {


            _ = firebaseClient.Child("Livret individuel de suivi pédagogique").Child("Utilisateurs").PostAsync(new MyDatabaseRecord
            {


                Signature2 = lblBase64Value2.Text

            });

          
            lblBase64Value2.Text = "";




            Navigation.PushModalAsync(new LoginPage());

        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            signature2.Clear();
        }



        public async void BtnSubmit_Clicked2(object sender, EventArgs e)
        {
            try
            {
                var image = await signature2.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Png);
                var mStream = (MemoryStream)image;
                byte[] data = mStream.ToArray();
                string base64Val = Convert.ToBase64String(data);
                lblBase64Value2.Text = base64Val;
                imgSignature2.Source = ImageSource.FromStream(() => mStream);



            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
    }
}