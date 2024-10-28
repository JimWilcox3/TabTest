using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace TabTest.Core.ViewModels
{
    public class MessageDialogViewModel : MvxViewModel<MessageDialogViewModel.Args>
    {
        public delegate void ResultCallback(Result result);

        public class Args
        {
            public ResultCallback? Callback;
            public string? Message;
        }

        public class Result
        {
            public Result(bool parm)
            {
                Success = parm;
            }

            public bool Success { get; set; }
        }

        private ResultCallback? Callback;
        private readonly IMvxNavigationService _navigationService;
        private ILogger<MessageDialogViewModel> _logger;
        public MessageDialogViewModel(IMvxNavigationService navigationService,
            ILogger<MessageDialogViewModel> logger)
        {
            _navigationService = navigationService;
            _logger = logger;

            CloseCommand = new MvxAsyncCommand(async () =>
            {
                await _navigationService.Close(this);
                Callback?.Invoke(new Result(true));
            });
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public override void Prepare(Args args)
        {
            base.Prepare();
            Callback = args.Callback;
            Message = args.Message;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            _logger.LogInformation($"View Appeared: {this}");
        }

        public IMvxAsyncCommand CloseCommand { get; private set; }

        private string? _Message;
        public string? Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
                RaisePropertyChanged(() => Message);
            }
        }




    }
}
