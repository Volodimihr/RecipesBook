using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Markup;

namespace Recipe_book_ExamWPF_Karvatyuk.Converter
{
    [ValueConversion(typeof(string), typeof(FlowDocument))]
    public class StringDocToFlowDocumentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringDoc = (string)value;
            if (stringDoc == null) return null;

            return XamlReader.Load(new MemoryStream(Encoding.Default.GetBytes(stringDoc))) as FlowDocument;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            FlowDocument flowDocument = (FlowDocument)value;
            if (flowDocument == null) return null;

            return XamlWriter.Save(flowDocument);
        }
    }
}
