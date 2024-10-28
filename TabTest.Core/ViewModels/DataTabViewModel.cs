using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using TabTest.Core.Models;

namespace TabTest.Core.ViewModels
{
    public class DataTabViewModel : MvxViewModel<DataTabViewModel.Parms>
    {
        public class Parms
        {
            public TestData? Data { get; set; }

            public int? Page { get; set; }
        }

        private readonly IMvxNavigationService _navigationService;
        public DataTabViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare(Parms args)
        {
            base.Prepare();
            Data = args.Data;
            Page = args.Page;
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        private int? _Page;
        public int? Page
        {
            get
            {
                return _Page;
            }
            set
            {
                _Page = value;
                RaisePropertyChanged(() => Page);
                RaisePropertyChanged(() => Title);
            }
        }

        public string Title
        {
            get
            {
                return $"Page {Page}";
            }
        }


        private TestData? _Data;
        public TestData? Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
                RaisePropertyChanged(() => Data);
            }
        }

        public ObservableCollection<TestDataItem> Items
        {
            get
            {
                if (Data?.Items == null)
                    return new ObservableCollection<TestDataItem>();
                else
                {
                    return new ObservableCollection<TestDataItem>(Data.Items.Where(x => x.TabNo == Page).ToList());
                }
            }
        }

        //This gets called when the app sleeps
        protected override void SaveStateToBundle(IMvxBundle bundle)
        {
            base.SaveStateToBundle(bundle);
        }

        //This gets called when the app wakes back up.  It would be better if it didn't.
        protected override void ReloadFromBundle(IMvxBundle state)
        {
            base.ReloadFromBundle(state);
        }

    }
}
