using Binary_Converter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Binary_Converter.Views
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