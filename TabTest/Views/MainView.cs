using Android.Views;
using MvvmCross.Platforms.Android.Views;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace TabTest.Droid.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Window.SetSoftInputMode(SoftInput.AdjustPan);

            var toolbar = (Toolbar)FindViewById(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}