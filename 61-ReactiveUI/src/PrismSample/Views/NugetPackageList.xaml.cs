using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NugetPackageList : ContentPageBase<NugetPackageListViewModel>
    {
        public NugetPackageList()
        {
            InitializeComponent();
        }
    }
}