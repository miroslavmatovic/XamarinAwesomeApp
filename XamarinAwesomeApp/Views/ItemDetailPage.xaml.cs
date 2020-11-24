using System.ComponentModel;
using Xamarin.Forms;
using XamarinAwesomeApp.ViewModels;

namespace XamarinAwesomeApp.Views
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