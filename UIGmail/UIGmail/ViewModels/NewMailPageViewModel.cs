using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UIGmail.Services;

namespace UIGmail.ViewModels
{
    public class NewMailPageViewModel:BaseViewModel
    {
        public DelegateCommand OrientacionCommand { get; set; }
        public NewMailPageViewModel(INavigationService inavigarionServices, IPageDialogService dialogService, IUserServices userServices, IDeviceOrientationService deviceOrientationService, IDependencyService dependencyService) : base(inavigarionServices, dialogService, userServices, deviceOrientationService, dependencyService)
        {
            deviceOrientationService.GetOrientation();
        }
    }
}
