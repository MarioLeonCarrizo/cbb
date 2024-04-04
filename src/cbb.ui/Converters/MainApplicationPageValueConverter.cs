using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Autodesk.Revit.Creation;
using cbb.core;

namespace cbb.ui
{
    public class MainApplicationPageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((ApplicationPageType)value)
            {
                case ApplicationPageType.Family:
                    return new FamilyPage();
                case ApplicationPageType.Preferences:
                    return new PreferencesPage();
                default:
                    return new FamilyPage();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
