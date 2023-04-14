﻿using Android.Runtime;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using TomestoneFragments.Core.ViewModels;

namespace TombstoneFragments.Droid.Views
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("tombstonefragments.droid.views.SecondView")]
    public class SecondView : BaseFragment<SecondViewModel>
    {
        protected override int FragmentId => Resource.Layout.SecondView;
    }
}