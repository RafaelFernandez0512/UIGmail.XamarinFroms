using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace UIGmail.Converters
{
    public class IntToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (int)value;
            switch (color)
            {
                case 1:
                    {
                        return Color.FromHex("#a08bc4");
                    }
                case 2:
                    {
                        return Color.FromHex("#d8a2c4");
                    }
                case 3:
                    {
                        return Color.FromHex("#febfc7");
                    }
                case 4:
                    {
                        return Color.FromHex("#7d74a1");
                    }
                case 5:
                    {
                        return Color.FromHex("#333a44");
                    }
                case 6:
                    {
                        return Color.FromHex("#85807d");
                    }
                case 7:
                    {
                        return Color.FromHex("#f73428");
                    }
                case 8:
                    {
                        return Color.FromHex("#d79c5e");
                    }
                case 9:
                    {
                        return Color.FromHex("#8a5d3c");
                    }
                case 10:
                    {
                        return Color.FromHex("#462325");
                    }
                case 11:
                    {
                        return Color.FromHex("#8B5D4C");
                    }
                default:
                    return Color.FromHex("#162437");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromHex("#a08bc4");
        }
    }
}
