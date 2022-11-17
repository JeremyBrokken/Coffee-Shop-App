using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coffee_Shop_App.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Espresso(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Espresso());
        }
        async void Hot_Drinks(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hot_Drinks());
        }
        async void Cold_Drinks(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cold_Drinks());
        }
        async void Quick_Bites(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Quick_Bites());
        }

    }
}