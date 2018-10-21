namespace DataGridFormatting
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class NumericFormatConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double number = System.Convert.ToDouble(values[0]);
            string formatSpecifier = System.Convert.ToString(values[1]);
            int precision = System.Convert.ToInt16(values[2]);
            string format = "{0:" + formatSpecifier + precision + "}"; // eg. {0:P4}, {0:N2}
            return string.Format(format, number);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
