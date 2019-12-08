using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using PrismSample.Services;
using ReactiveUI;
using Xamarin.Forms;

namespace PrismSample.ViewModels
{
    public class NugetPackageListViewModel : ViewModelBase
    {
        private readonly INugetPackageService _nugetPackageService;
        private string _searchText;
        private ObservableAsPropertyHelper<IEnumerable<NugetPackageViewModel>> _searchResults;

        public NugetPackageListViewModel(INugetPackageService nugetPackageService)
        {
            _nugetPackageService = nugetPackageService;

            PackageDetails = ReactiveCommand.CreateFromTask<ItemTappedEventArgs>(ExecutePackageDetails);
            
            _searchResults = this
                .WhenAnyValue(x => x.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(800))
                .Select(term => term?.Trim())
                .DistinctUntilChanged()
                .Where(term => !string.IsNullOrWhiteSpace(term))
                .SelectMany(SearchNuGetPackages)
                .ObserveOn(RxApp.MainThreadScheduler)
                .ToProperty(this, x => x.SearchResults);
        }

        public string SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public IEnumerable<NugetPackageViewModel> SearchResults => _searchResults.Value;
        
        public ReactiveCommand<ItemTappedEventArgs, Unit> PackageDetails { get; set; }
        
        private async Task ExecutePackageDetails(ItemTappedEventArgs itemTappedEventArgs)
        {
            await Task.CompletedTask;
        }

        private async Task<IEnumerable<NugetPackageViewModel>> SearchNuGetPackages(string term, CancellationToken token)
        {
            var result = await _nugetPackageService.SearchNuGetPackages(term, token);
            return result.Select(x => new NugetPackageViewModel(x));
        }
    }
}