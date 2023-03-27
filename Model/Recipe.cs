using System.IO;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Recipe_book_ExamWPF_Karvatyuk.Model
{
    public class Recipe
    {
        public string Title { get; set; }
        public byte[] ImageFile { get; set; }
        public string Doc { get; set; }
        public string Country { get; set; }

        public Recipe()
        {
            Title = string.Empty;

            // Default image
            ImageFile = ImageSourceToBytes(new JpegBitmapEncoder(), new BitmapImage(new System.Uri(@"pack://application:,,,/Image/nopreview.jpg")));

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(new Paragraph(new Bold(new Run("Components:"))));
            List compList = new List();
            compList.ListItems.Add(new ListItem(new Paragraph(new Run())));
            doc.Blocks.Add(compList);
            doc.Blocks.Add(new Paragraph(new Bold(new Run("Instruction:"))));
            List instrList = new List();
            instrList.ListItems.Add(new ListItem(new Paragraph(new Run())));
            doc.Blocks.Add(instrList);

            Doc = XamlWriter.Save(doc);

            Country = string.Empty;
        }

        // Convert BitmapImage to byte array
        public byte[] ImageSourceToBytes(BitmapEncoder encoder, ImageSource imageSource)
        {
            byte[] bytes = null;
            var bitmapSource = imageSource as BitmapSource;

            if (bitmapSource != null)
            {
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    bytes = stream.ToArray();
                }
            }

            return bytes;
        }
    }
}
