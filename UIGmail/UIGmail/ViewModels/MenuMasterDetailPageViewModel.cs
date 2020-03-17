using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using UIGmail.Helpers;
using UIGmail.Models;
using UIGmail.Services;
using Xamarin.Forms;

namespace UIGmail.ViewModels
{
    public class MenuMasterDetailPageViewModel:BaseViewModel
    {
        public DelegateCommand<string> SelectPageCommand { get; set; }
        public ObservableCollection<ItemMasters> ItemsMasters { get; set; }
        private ItemMasters selectItemMaster;

        public ItemMasters SelectItemMaster
        {
            get { return selectItemMaster; }
            set {
                selectItemMaster = value;
                if (selectItemMaster!=null)
                {
                    NavigateAsync(SelectItemMaster.Page);
                }
            }
        }
        public bool IsPresent { get; set; }
        public MenuMasterDetailPageViewModel(INavigationService navigationService, IPageDialogService dialogService, IUserServices userServices, IDeviceOrientationService deviceOrientationService, IDependencyService dependencyService) : base(navigationService, dialogService, userServices, deviceOrientationService, dependencyService)
        {
         
            ItemsMasters = new ObservableCollection<ItemMasters>() {
            new ItemMasters(){
                Image= "OutBoxImage",
                Title = "Inbox",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.ReceivedPage}"
            }, new ItemMasters(){
                Image= "ic_action_star_borderBlack.png",
                Title = "Featureds",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.FeaturedPage}"
            }, new ItemMasters(){
                Image= "ic_action_access_time",
                Title = "Postponeds",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.PostponedPage}"
            }, new ItemMasters(){
                Image= "ic_action_label_important",
                Title = "Importants",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.ImportantPage}"
            }, new ItemMasters(){
                Image= "ic_action_send",
                Title = "Sends",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.SendsPage}"
            }, new ItemMasters(){
                Image= "ic_action_access_time",
                Title = "Scheduled",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.ScheduledPage}"
            }, new ItemMasters(){
                Image= "UploadImage",
                Title = "OutBox",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.OutboxPage}"
            }, new ItemMasters(){
                Image= "paperImage",
                Title = "Drafts",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.DraftsPage}"
            }, new ItemMasters(){
                Image= "emailImage",
                Title = "Alls",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.AllMailPage}"
            }, new ItemMasters(){
                Image= "ic_action_error_outline",
                Title = "Spam",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.SpamPage}"
            },new ItemMasters(){
                Image= "ic_action_delete_outline.png",
                Title = "Recycle Bin",
                Page = $"{ConfigPage.NavigationPage}{ConfigPage.RecycleBinPage}"
            }
            };
            SelectPageCommand = new DelegateCommand<string>(NavigateAsync);
            MessagingCenter.Subscribe<ReceivedPageViewModel,bool>(this, "IsPresentKey", (param,sender) =>
            {
                IsPresent = sender;
            });
        }
        async void NavigateAsync(string page)
        {
            await navigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }
    }
}
