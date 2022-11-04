using Coffee_Shop_App.ViewModels;
using Coffee_Shop_App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Coffee_Shop_App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
