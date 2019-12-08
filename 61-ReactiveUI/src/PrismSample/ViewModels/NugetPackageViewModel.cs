using System.Reactive;
using System.Threading.Tasks;
using NuGet.Protocol.Core.Types;
using ReactiveUI;
using Xamarin.Forms;

namespace PrismSample.ViewModels
{
    public class NugetPackageViewModel : ViewModelBase
    {
        private readonly IPackageSearchMetadata _packageSearchMetadata;
        private string _name;

        public NugetPackageViewModel(IPackageSearchMetadata packageSearchMetadata)
        {
            _packageSearchMetadata = packageSearchMetadata;

            Name = _packageSearchMetadata.Identity.Id;
        }

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }
    }
}