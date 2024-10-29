using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TabTest.Core.ViewModels.MessageDialogViewModel;

namespace TabTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string? Answer;

        private readonly IMvxNavigationService _navigationService;
        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            TabsCommand = new MvxAsyncCommand(async () =>
            {
                await _navigationService.Navigate<DataViewModel>();
            });

            DialogCommand = new MvxAsyncCommand(async () =>
            {
                var args = new MessageDialogViewModel.Args
                {
                    Message = "Test Dialog"
                };
                await _navigationService.Navigate<MessageDialogViewModel, MessageDialogViewModel.Args>(args);
            });
        }

        public override Task Initialize()
        {
            Answer = "42";
            return base.Initialize();
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

        public IMvxAsyncCommand TabsCommand { get; private set; }

        public IMvxAsyncCommand DialogCommand { get; private set; }

        protected override void SaveStateToBundle(IMvxBundle bundle)
        {
            base.SaveStateToBundle(bundle);
            bundle.Data["Answer"] = Answer ?? "";
        }

        protected override void ReloadFromBundle(IMvxBundle state)
        {
            base.ReloadFromBundle(state);
            Answer = state.Data["Answer"];
        }

    }
}
