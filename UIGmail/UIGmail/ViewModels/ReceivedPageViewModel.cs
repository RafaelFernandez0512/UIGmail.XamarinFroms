using Prism.Navigation;
using Prism.Services.Dialogs;
using UIGmail.Models;
using UIGmail.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Prism.Services;
using Prism.Commands;
using Xamarin.Forms;
using UIGmail.Helpers;

namespace UIGmail.ViewModels
{
    public class ReceivedPageViewModel:BaseViewModel
    {
        public ObservableCollection<User> Contacts { get; set; }
        public DelegateCommand NewMailCommand { get; set; }
        public DelegateCommand IsPresentCommand { get; set; }

        public ReceivedPageViewModel(INavigationService inavigarionServices, IPageDialogService dialogService, IUserServices userServices, IDeviceOrientationService deviceOrientationService, IDependencyService dependencyService) :base(inavigarionServices, dialogService, userServices, deviceOrientationService, dependencyService)
        {
            LoadList();
            IsPresentCommand = new DelegateCommand(() =>
            {
                MessagingCenter.Send(this, "IsPresentKey", IsPresent);
                
            });
            NewMailCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync(new Uri($"{ConfigPage.MenuMasterDetailPage}{ConfigPage.NavigationPage}{ConfigPage.ReceivedPage}{ConfigPage.NewMailPage}"));
            });

        }
        async Task LoadList()
        {
            try
            {
                var list = await userServices.GetAllContacts();
                Contacts = new ObservableCollection<User>(list);
            }
            catch (Exception err)
            {
                await dialogService.DisplayAlertAsync("Error", $"{err.Message}", "ok");
            }

        }
    }
}
