using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System.Windows.Input;
using MvvmCross.ViewModels;

namespace TomestoneFragments.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public SecondViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseViewCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
        }

        public ICommand CloseViewCommand { get; private set; }
        public string Label { get; set; }

        public override async Task Initialize()
        {
            await base.Initialize();
            Label = "View 2";
        }

    }
}
