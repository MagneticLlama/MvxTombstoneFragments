using MvvmCross;
using MvvmCross.ViewModels;
using TomestoneFragments.Core.ViewModels;

namespace TomestoneFragments.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
            //RegisterAppStart<MainViewModel>();
        }
    }
}