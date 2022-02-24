using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Shared;
using Firebase.Database;
using Xamarin.Forms;
using XamFormsFirebaseAuth.Features.Login;

using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using SQLite;
using XamFormsFirebaseAuth.Features.Home;
using Firebase.Database.Query;
using Xamarin.Essentials;
using XamFormsFirebaseAuth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;
using Firebase.Database.Query;
using XamFormsFirebaseAuth.Features.Login;


       

namespace RealtimeDBExample.ViewModels
    {
        /// <summary>
        /// MainPage example of Firebase Realtime Database operations
        /// </summary>
        /// 

  
        public class MainPageViewModel : BaseViewModel
        {
            /// <summary>
          
            public static string FirebaseClient = "https://sdis-4b447-default-rtdb.europe-west1.firebasedatabase.app/";
            public static string FrebaseSecret = "v8sLrRHnYABoCRJKBnJtrcmAPsIKSRMXeUrAiNy0";

            public FirebaseClient fc = new FirebaseClient(FirebaseClient,
                                       new FirebaseOptions { AuthTokenAsyncFactory = () => Task.FromResult(FrebaseSecret) });
        
            /// </summary>

            public ICommand RefreshListCommand { get; set; }
            public ICommand PostCommand { get; set; }
            public ICommand DeleteCommand { get; set; }
            public ICommand UpdateCommand { get; set; }

            

            /// <summary>
            /// MainPage View Model initializiation
            /// </summary>
            public MainPageViewModel()
            {
                RefreshListCommand = new Command(PerformRefresh);
                PostCommand = new Command(Post);
                DeleteCommand = new Command(Delete);
                UpdateCommand = new Command(Update);

                GetData();
            }



        /// <summary>
        /// Gets a list of ItemsModel
        /// </summary>
        public async void GetData()
        {


            Items = new ObservableCollection<MyDatabaseRecord>();

            var GetItems = (await fc
              .Child("Livret individuel de suivi pédagogique").Child("Utilisateurs")
              .OnceAsync<MyDatabaseRecord>()).Select(item => new MyDatabaseRecord
              {

                  Prenom = item.Object.Prenom,
                  Nom = item.Object.Nom,
                  Key = item.Key,
                  DateNaissance = item.Object.DateNaissance,
                  Grade = item.Object.Grade,
                  CIS = item.Object.CIS,
                  DateRecrutement = item.Object.DateRecrutement,
                  Observations = item.Object.Observations
              });

            int count = 0;
            foreach (var item in GetItems)
            {

                Items.Add(item);
                count++;

            }

        }

            /// <summary>
            /// Posts a new ItemsModel
            /// </summary>
            private async void Post()
            {

              

            }

            /// <summary>
            /// Deletes one of the ItemsModel from the Items listview
            /// </summary>
            private async void Delete()
            {
                var selected = Items.Where(k => k.Key == SelectedKey.Key).FirstOrDefault();

                await fc.Child("Livret individuel de suivi pédagogique").Child("MyDatabaseRecord").Child(selected.Key).DeleteAsync();

                Items.Remove(selected);
            }

            /// <summary>
            /// Updates the Description of a specified ItemsModel in the Items listview
            /// </summary>
            private async void Update()
            {
                var selected = Items.Where(k => k.Key == SelectedKey.Key).FirstOrDefault();

                await fc.Child("Livret individuel de suivi pédagogique").Child("MyDatabaseRecord").Child(selected.Key).PutAsync(new MyDatabaseRecord() { Prenom = selected.Prenom, Nom = selected.Nom, DateNaissance = selected.DateNaissance, Grade= selected.Grade, CIS= selected.CIS, DateRecrutement= selected.DateRecrutement});

            }


            /// <summary>
            /// Refreshes the listview
            /// </summary>
            private void PerformRefresh()
            {
                GetData();
            }

            private ObservableCollection<MyDatabaseRecord> items;
            public ObservableCollection<MyDatabaseRecord> Items
            {
                get { return items; }
                set
                {
                    items = value;
                    OnPropertyChanged();
                }
            }

   




        private MyDatabaseRecord selectedkey;
            public MyDatabaseRecord SelectedKey
            {
                get => selectedkey;
                set
                {

                    selectedkey = value;
                    OnPropertyChanged();
              

            }
        }

            private bool isRefreshing = false;
            public bool IsRefreshing
            {
                get { return isRefreshing; }
                set
                {
                    isRefreshing = value;
                    OnPropertyChanged();
                }
            }
        }

    }



