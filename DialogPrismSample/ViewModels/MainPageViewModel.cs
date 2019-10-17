using Prism.Commands;
using Prism.Services.Dialogs;

namespace DialogPrismSample.ViewModels
{
    public class MainPageViewModel
    {
        public DelegateCommand ShowDialogCommand { get; set; }

        public MainPageViewModel(IDialogService dialogService)
        {
            ShowDialogCommand = new DelegateCommand(async () =>
            {
                var param = new DialogParameters();
                param.Add("Message", "I'm a dialog");
                dialogService.ShowDialog("DialogView", param, CloseDialogCallback);
            });
        }

        void CloseDialogCallback(IDialogResult dialogResult)
        {

        }
    }
}
