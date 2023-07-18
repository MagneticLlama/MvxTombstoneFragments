## Update: 7/18/2023
**MvvmCross 9.10 fixes this issue**


# MvxTombstoneFragments
Demonstrates that Android fragments cannot recover from tombstoning in MvvmCross

As of MvvmCross 9.0.9, fragments will not have a valid view model after tombstoning. The data context of the fragment will consistently be MvxNullViewModel. Accessing the ViewModel property of the fragment will trigger an InvalidCastException (assuming the fragment had some other view model in the first place.)

The project includes MainView activity, and two Fragments, FirstView and SecondView. SecondView isn't technically needed for the demonstration.
When the error occurs, the view will be populated with the exception type, the fragment's expected view model type, and current data context type.

# Steps
1. Launch the app without the debugger attached, and either leave the app on View 1 or click Next to navigate to View 2.
2. Press the home button to leave the app.
3. Flood the device memory. [Android Toolbelt](https://play.google.com/store/apps/details?id=com.tspoon.androidtoolbelt) is useful for this.
3. Return to the app. An error message will show the failed state of the app.
