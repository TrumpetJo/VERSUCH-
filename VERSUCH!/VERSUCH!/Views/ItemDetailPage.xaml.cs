using System.ComponentModel;
using VERSUCH_.ViewModels;
using Xamarin.Forms;

namespace VERSUCH_.Views
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