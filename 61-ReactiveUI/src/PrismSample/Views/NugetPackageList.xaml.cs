using System.Reactive.Disposables;
using System.Reactive.Linq;
using PrismSample.ViewModels;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NugetPackageList : ContentPageBase<NugetPackageListViewModel>
    {
        public NugetPackageList()
        {
            InitializeComponent();

            this.Bind(ViewModel, x => x.SearchText, x => x.SearchBar.Text).DisposeWith(ViewBindings);

            NugetPackageListView
                .Events()
                .ItemTapped
                .ObserveOn(RxApp.MainThreadScheduler)
                .InvokeCommand(this, x => x.ViewModel.PackageDetails)
                .DisposeWith(ViewBindings);
        }
    }
}