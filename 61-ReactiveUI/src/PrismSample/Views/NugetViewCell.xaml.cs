using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using PrismSample.ViewModels;
using ReactiveUI;
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

            this.OneWayBind(ViewModel, x => x.Name, x => x.PackageName.Text).DisposeWith(ViewCellBindings);
        }
    }
}