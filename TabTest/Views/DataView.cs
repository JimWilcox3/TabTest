using Android.Views;
using AndroidX.CoordinatorLayout.Widget;
using Google.Android.Material.Tabs;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using System.Diagnostics;
using TabTest.Core.ViewModels;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace TabTest.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "Data View", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class DataView : MvxActivity<DataViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            try
            {
                SetContentView(Resource.Layout.TabTestParentView);
            }
            catch (Exception e) 
            {
                var s = e.ToString();
                Debug.Print(s);
            }

            Window.SetSoftInputMode(SoftInput.AdjustPan);

            var toolbar = (Toolbar)FindViewById(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

        }
    }
}
