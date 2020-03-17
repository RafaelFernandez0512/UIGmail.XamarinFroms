using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace UIGmail.iOS.Effects
{
    public class FocuseEntryIosEffect:PlatformEffect
    {
		UIColor backgroundColor;

		protected override void OnAttached()
		{
				Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 153, 255);
		}

		protected override void OnDetached()
		{
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);

			if (args.PropertyName == "IsFocused")
			{
				if (Control.BackgroundColor == backgroundColor)
				{
					Control.BackgroundColor = UIColor.White;
				}
				else
				{
					Control.BackgroundColor = backgroundColor;
				}
			}
		}
	}
}