using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace UIGmail.iOS.Effects
{
    public class RemoveLineIosEffect : PlatformEffect
    {
        UIColor backgroundColor;

        protected override void OnAttached()
        {
            if (Control is UITextField text)
            {
                text.BorderStyle = UITextBorderStyle.None;
            }

        }

        protected override void OnDetached()
        {
            
        }
    }
}