using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIGmail.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace UIGmail.iOS.Services
{

    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}