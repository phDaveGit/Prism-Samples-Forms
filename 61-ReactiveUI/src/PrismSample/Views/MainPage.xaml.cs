using System.ComponentModel;
using PrismSample.ViewModels;

namespace PrismSample.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPageBase<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
