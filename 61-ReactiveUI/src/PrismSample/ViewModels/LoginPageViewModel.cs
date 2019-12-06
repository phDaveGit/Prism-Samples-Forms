using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using ReactiveUI;

namespace PrismSample.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _username;
        private string _password;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            var enabled = this.WhenAnyValue(x => x.Username, x => x.Password, (username, password) => false);

            Login = ReactiveCommand.CreateFromTask(ExecuteLogin, enabled);
        }

        private async Task ExecuteLogin() => await _navigationService.NavigateAsync("MainPage");

        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        public string Username
        {
            get => _username;
            set => this.RaiseAndSetIfChanged(ref _username, value);
        }

        public ReactiveCommand<Unit, Unit> Login { get; set; }
    }
}