using Prism.Navigation;
using Prism.Services.Dialogs;
using UIGmail.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Prism.Services;
using Xamarin.Forms.Internals;

namespace UIGmail.ViewModels
{
    public abstract class BaseViewModel:INotifyPropertyChanged
    {
        protected INavigationService navigationService;
        protected IPageDialogService dialogService;
        protected IUserServices userServices;
        protected IDeviceOrientationService  deviceOrientationService;
        protected const bool IsPresent = true;

        public BaseViewModel(INavigationService navigationService, IPageDialogService dialogService, IUserServices userServices, IDeviceOrientationService deviceOrientationService,IDependencyService dependencyService)
        {
            DeviceOrientation orientation  = deviceOrientationService.GetOrientation();
            this.navigationService =  navigationService;
            this.dialogService = dialogService;
            this.userServices = userServices;
            this.deviceOrientationService = deviceOrientationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
