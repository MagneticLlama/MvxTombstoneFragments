using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCross.ViewModels;
using MvvmCross.Views;

namespace TombstoneFragments.Droid.Views
{
    public abstract class BaseFragment<TViewModel> : MvxFragment<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        private TextView viewModelError;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(FragmentId, null);
            this.viewModelError = view.FindViewById<TextView>(Resource.Id.ViewModelError);
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();
            try
            {
                // Trying to access the ViewModel will cause an InvalidCastException if we've been tombstoned
                Console.WriteLine($"We have a view moodel of type {ViewModel?.GetType().Name}");
                this.viewModelError.Visibility = ViewStates.Gone;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                var errorString = $"{e.GetType().Name} upon ViewModel get \n\n";

                errorString += $"Fragment associated view model type: {this.FindAssociatedViewModelTypeOrNull()?.Name} \n\n";
                errorString += $"Fragment data context type: {DataContext?.GetType().Name}";

                this.viewModelError.Text = errorString;
                this.viewModelError.Visibility = ViewStates.Visible;
            }
        }

        protected abstract int FragmentId { get; }
    }
}