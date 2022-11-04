using Coffee_Shop_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Coffee_Shop_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}