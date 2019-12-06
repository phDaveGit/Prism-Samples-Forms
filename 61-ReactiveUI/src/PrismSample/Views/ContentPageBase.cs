using System.Reactive.Disposables;
using PrismSample.ViewModels;
using ReactiveUI.XamForms;

namespace PrismSample.Views
{
    public abstract class ContentPageBase<T> : ReactiveContentPage<T>
        where T : ViewModelBase
    {
        protected readonly CompositeDisposable ViewBindings = new CompositeDisposable();

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewBindings.Clear();
        }
    }
}