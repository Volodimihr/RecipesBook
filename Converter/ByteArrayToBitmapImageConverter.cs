﻿using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Recipe_book_ExamWPF_Karvatyuk.Converter
{
    [ValueConversion(typeof(byte[]), typeof(BitmapImage))]
    public class ByteArrayToBitmapImageConverter : IValueConverter
    {
        public static BitmapImage ConvertByteArrayToBitMapImage(byte[] imageByteArray)
        {
            BitmapImage img = new BitmapImage();
            using (MemoryStream memStream = new MemoryStream(imageByteArray))
            {
                img.BeginInit();
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.StreamSource = memStream;
                img.EndInit();
                img.Freeze();
            }
            return img;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageByteArray = value as byte[];
            if (imageByteArray == null) return null;
            return ConvertByteArrayToBitMapImage(imageByteArray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
