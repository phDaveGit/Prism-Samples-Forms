using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NugetViewCell : ContentViewBase<NugetPackageViewModel>
    {
        public NugetViewCell()
        {
            InitializeComponent();
        }
    }
}