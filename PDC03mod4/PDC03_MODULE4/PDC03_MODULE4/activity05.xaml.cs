using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Jesel De Jesus",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Kozey De Jesus",
                Age = 22,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Aurvic De Jesus",
                Age = 23,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Jes De Jesus",
                Age = 19,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Sel De Jesus",
                Age = 25,
                Occupation = "Student",
                Country = "Philippines"

            });
        }
    }
}