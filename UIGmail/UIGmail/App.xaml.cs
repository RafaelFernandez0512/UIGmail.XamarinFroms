using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using UIGmail.Helpers;
using UIGmail.Services;
using UIGmail.ViewModels;
using UIGmail.Views;
using UIGmail.Views.TagsViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIGmail
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {

        }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync(new Uri($"{ConfigPage.MenuMasterDetailPage}{ConfigPage.NavigationPage}{ConfigPage.ReceivedPage}",UriKind.Relative));
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IUserServices>(new GmailServices());
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ReceivedPage, ReceivedPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuMasterDetailPage, MenuMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AllMailPage>();
            containerRegistry.RegisterForNavigation<DraftsPage>();
            containerRegistry.RegisterForNavigation<FeaturedPage>();
            containerRegistry.RegisterForNavigation<ImportantPage>();
            containerRegistry.RegisterForNavigation<OutboxPage>();
            containerRegistry.RegisterForNavigation<PostponedPage>();
            containerRegistry.RegisterForNavigation<RecycleBinPage>();
            containerRegistry.RegisterForNavigation<ScheduledPage>();
            containerRegistry.RegisterForNavigation<SendsPage>();
            containerRegistry.RegisterForNavigation<SpamPage>();
            containerRegistry.RegisterForNavigation<NewMailPage, NewMailPageViewModel >();

        }
    }
}
