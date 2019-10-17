using DialogPrismSample.ViewModels;
using DialogPrismSample.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace DialogPrismSample
{
    [AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<DialogView, DialogViewModel>();
        }
    }
}
