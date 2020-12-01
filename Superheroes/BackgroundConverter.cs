using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Superheroes
{
    class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return new SolidColorBrush(Colors.PaleGreen);
            }
            else
            {
                return new SolidColorBrush(Colors.IndianRed);
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
