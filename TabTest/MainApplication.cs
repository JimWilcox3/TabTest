using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using TabTest.Core;

namespace TabTest.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
        public override void OnCreate()
        {
            base.OnCreate();
        }
    }
}