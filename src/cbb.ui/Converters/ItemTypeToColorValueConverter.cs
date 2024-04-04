using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
using cbb.core;
using System.Windows.Media;

namespace cbb.ui
{
    public class ItemTypeToColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((ItemType)value)
            {
                case ItemType.Project:
                    return new SolidColorBrush(Colors.OrangeRed);
                case ItemType.Family:
                    return new SolidColorBrush(Colors.CornflowerBlue);
                case ItemType.Cad:
                    return new SolidColorBrush(Colors.PaleGreen);
                case ItemType.Document:
                    return new SolidColorBrush(Colors.YellowGreen);
                case ItemType.None:
                    return new SolidColorBrush(Colors.Black);
            }

            return new SolidColorBrush(Colors.Magenta);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
