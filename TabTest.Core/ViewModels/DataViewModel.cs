using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TabTest.Core.Models;
using TabTest.Core.Services;

namespace TabTest.Core.ViewModels
{
    public class DataViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IDataService _dataService;
        public DataViewModel(IMvxNavigationService navigationService, IDataService dataService)
        {
            _navigationService = navigationService;
            _dataService = dataService;

        }

        public async override Task Initialize()
        {
            Data = _dataService.Data;

            await Task.Delay(1000);

            await ShowTabs();

            //return base.Initialize();
        }

        private string? _Title = "Tab Test";
        public string? Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                RaisePropertyChanged(() => Title);
            }

        }


        public Task ShowTabs()
        {
            var tasks = new List<Task>();

            var parameter = new DataTabViewModel.Parms()
            {
                Data = Data,
                Page = 1
            };
            tasks.Add(_navigationService.Navigate<DataTabViewModel, DataTabViewModel.Parms>(parameter));

            parameter = new DataTabViewModel.Parms()
            {
                Data = Data,
                Page = 2
            };
            tasks.Add(_navigationService.Navigate<DataTabViewModel, DataTabViewModel.Parms>(parameter));

            parameter = new DataTabViewModel.Parms()
            {
                Data = Data,
                Page = 3
            };
            tasks.Add(_navigationService.Navigate<DataTabViewModel, DataTabViewModel.Parms>(parameter));

            parameter = new DataTabViewModel.Parms()
            {
                Data = Data,
                Page = 4
            };
            tasks.Add(_navigationService.Navigate<DataTabViewModel, DataTabViewModel.Parms>(parameter));

            ThrobberVisible = false;

            return Task.WhenAll(tasks);
        }

        private bool _ThrobberVisible = true;
        public bool ThrobberVisible
        {
            get
            {
                return _ThrobberVisible;
            }
            set
            {
                _ThrobberVisible = value;
                RaisePropertyChanged(() => ThrobberVisible);
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

        //This gets called when the app sleeps
        protected override void SaveStateToBundle(IMvxBundle bundle)
        {
            base.SaveStateToBundle(bundle);
        }

        //This does not get called when the app wakes back up.  If it did, then Initialize would run and create the tabes correctly.
        protected override void ReloadFromBundle(IMvxBundle state)
        {
            base.ReloadFromBundle(state);
        }

    }
}
