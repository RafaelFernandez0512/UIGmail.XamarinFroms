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
using UIGmail.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(RemoveLineDroidEffect), "LineRemovingEffect")]
namespace UIGmail.Droid.Effects
{
    public class RemoveLineDroidEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {
                Control.SetBackground(null);
            }
        }

        protected override void OnDetached()
        {
            
        }
    }
}