using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TomestoneFragments.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            NextViewCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<SecondViewModel>());
        }


        public ICommand NextViewCommand { get; private set; }

        public string Label { get; set; }

        public override async Task Initialize()
        {
            await base.Initialize();
            Label = "View 1";
        }
    }
}
