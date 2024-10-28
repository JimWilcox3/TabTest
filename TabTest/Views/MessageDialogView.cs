using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;
using TabTest.Core.ViewModels;

namespace TabTest.Droid.Views
{
    [MvxDialogFragmentPresentation]
    [Register(nameof(MessageDialogView))]
    public class MessageDialogView : MvxDialogFragment<MessageDialogViewModel>
    {
        public MessageDialogView()
        {
        }

        protected MessageDialogView(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.MessageDialogView, null);

            return view;
        }
    }
}