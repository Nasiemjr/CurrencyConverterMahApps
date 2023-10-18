using CurrencyConverterMahApps.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyConverterMahApps.Helper_Classes.EnumHelper;
using System.Windows.Data;
using System.Windows.Markup;

namespace CurrencyConverterMahApps.Converters;

[ValueConversion(typeof(Enum), typeof(IEnumerable<ValueDescription>))]
public class EnumToCollectionConverter : MarkupExtension, IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return EnumHelper.GetAllValuesAndDescriptions(value.GetType()).Where(v => !string.IsNullOrEmpty((string?)v.Description));
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}