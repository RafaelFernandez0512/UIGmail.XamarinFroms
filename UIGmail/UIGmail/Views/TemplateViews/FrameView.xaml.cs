using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIGmail.Views.TemplateViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameView : ContentView
    {
        public FrameView()
        {
            InitializeComponent();
        }
    }
}