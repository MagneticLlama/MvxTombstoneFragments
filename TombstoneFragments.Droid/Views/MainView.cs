using MvvmCross.Platforms.Android.Views;
using TomestoneFragments.Core.ViewModels;

namespace TombstoneFragments.Droid.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.MainView);
        }
    }
}