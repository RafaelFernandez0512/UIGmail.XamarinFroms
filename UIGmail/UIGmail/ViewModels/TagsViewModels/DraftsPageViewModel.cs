using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UIGmail.Models;
using UIGmail.Services;
using Xamarin.Forms;
namespace UIGmail.ViewModels.TagsViewModels
{
    public class DraftsPageViewModel:BaseViewModel
    {
        public ObservableCollection<User> Contacts { get; set; } = new ObservableCollection<User>();

        public DelegateCommand IsPresentCommand { get; set; }
        public DraftsPageViewModel(INavigationService inavigarionServices, IPageDialogService dialogService, IUserServices userServices, IDeviceOrientationService deviceOrientationService, IDependencyService dependencyService) : base(inavigarionServices, dialogService, userServices, deviceOrientationService, dependencyService)
        {
            deviceOrientationService = dependencyService.Get<IDeviceOrientationService>();
            IsPresentCommand = new DelegateCommand(() =>
            {
                MessagingCenter.Send(this, "IsPresentKey", IsPresent);
            });


        }
    }
}
