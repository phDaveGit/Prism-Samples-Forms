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

        public NugetPackageViewModel(IPackageSearchMetadata packageSearchMetadata)
        {
            _packageSearchMetadata = packageSearchMetadata;
        }
    }
}