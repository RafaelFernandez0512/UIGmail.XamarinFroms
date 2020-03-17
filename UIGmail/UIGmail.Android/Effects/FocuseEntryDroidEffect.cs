using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UIGmail.Controls;
using UIGmail.Droid.Effects;
using UIGmail.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ResolutionGroupName("UIGmail")]
[assembly: ExportEffect(typeof(FocuseEntryDroidEffect), "IsFocusedEffect")]
namespace UIGmail.Droid.Effects
{
    public class FocuseEntryDroidEffect: PlatformEffect
    {
        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(250,213,66);
        Android.Graphics.Color backgroundColor;

        protected override void OnAttached()
        {
                backgroundColor = Android.Graphics.Color.White;
                Control.SetBackgroundColor(backgroundColor);
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
        }

    }
}