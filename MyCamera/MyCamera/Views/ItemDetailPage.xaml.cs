using MyCamera.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyCamera.Views
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