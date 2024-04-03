using Microsoft.Maui.Controls;
using UnitConverter.ViewModels;

namespace UnitConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
