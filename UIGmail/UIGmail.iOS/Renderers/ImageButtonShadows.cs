using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIGmail.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ResolutionGroupName("UIGmail")]
[assembly: ExportEffect(typeof(ShadowButtonEffect), "IosImageButtonShadows")]
namespace UIGmail.iOS.Renderers
{
    public class IosImageButtonShadows : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (ShadowButtonEffect)Element.Effects.FirstOrDefault(e => e is ShadowButtonEffect);
                if (effect != null)
                {
                    Control.Layer.CornerRadius = effect.Radius;
                    Control.Layer.ShadowColor = effect.Color.ToCGColor();
                    Control.Layer.ShadowOffset = new CGSize(effect.DistanceX, effect.DistanceY);
                    Control.Layer.ShadowOpacity = 1.0f;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
         
        }
    }
}