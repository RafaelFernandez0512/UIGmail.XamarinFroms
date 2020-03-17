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
    public partial class ItemMasterView : ContentView
    {
        public static readonly BindableProperty ItemImageProperty = BindableProperty.Create(nameof(ItemImage),typeof(string),typeof(ContentView));
        public string ItemImage
        { 
            get=>(string)GetValue(ItemImageProperty); 
            set=>SetValue(ItemImageProperty,value); 
        }
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(ContentView));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public static readonly BindableProperty SubTitleProperty = BindableProperty.Create(nameof(SubTitle), typeof(string), typeof(ContentView));
        public string SubTitle
        {
            get => (string)GetValue(SubTitleProperty);
            set => SetValue(SubTitleProperty, value);
        }

        public ItemMasterView()
        {
            InitializeComponent();
        }
    }
}