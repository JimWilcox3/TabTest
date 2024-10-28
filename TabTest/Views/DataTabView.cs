using Android.Graphics;
using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabTest.Core.ViewModels;
using static Android.Provider.DocumentsContract;

namespace TabTest.Droid.Views
{
    [MvxTabLayoutPresentation(TabLayoutResourceId = Resource.Id.tabs, ViewPagerResourceId = Resource.Id.viewpager, ActivityHostViewModelType = typeof(DataViewModel))]
    [Register(nameof(DataTabView))]
    public class DataTabView : MvxFragment<DataTabViewModel>, IMvxOverridePresentationAttribute
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.TabTestTabView, null);

            return view;
        }


        public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
        {
            var irequest = request as MvxViewModelInstanceRequest;

            if (irequest == null)
                return null;

            var instance = irequest.ViewModelInstance as DataTabViewModel;

            return new MvxTabLayoutPresentationAttribute()
            {
                TabLayoutResourceId = Resource.Id.tabs,
                ViewPagerResourceId = Resource.Id.viewpager,
                Title = instance.Title,
                ActivityHostViewModelType = typeof(DataViewModel)
            };
        }

    }
}
