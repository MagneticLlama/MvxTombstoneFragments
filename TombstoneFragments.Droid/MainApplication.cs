using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using TomestoneFragments.Core;

namespace TombstoneFragments.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}