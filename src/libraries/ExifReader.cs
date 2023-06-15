using System.Drawing;
using System.Drawing.Imaging;

namespace libraries
{
    public class ExifReader
    {
        public TagInformationDTO ReadExifData(string imagePath)
        {
            TagInformationDTO tag = new TagInformationDTO();

            Bitmap image = new Bitmap(imagePath);
            PropertyItem[] properties = image.PropertyItems;

            foreach (PropertyItem prop in properties)
            {
                if (prop.Id == EXIFCODES.ORIENTATION)
                {
                    tag.orientation = BitConverter.ToUInt16(prop.Value, 0).ToString();
                }
                else if (prop.Id == EXIFCODES.WIDTH)
                {
                    tag.width = BitConverter.ToInt32(prop.Value, 0).ToString();
                }
                else if (prop.Id == EXIFCODES.HEIGHT)
                {
                    tag.height = BitConverter.ToInt32(prop.Value, 0).ToString();
                }
                else
                {
                    //Console.WriteLine("{0}: {1}", prop.Id, prop.Value);
                }
            }

            if(tag.height == "")
            {
                using (var img = Image.FromFile(imagePath))
                {
                    tag.width = img.Width.ToString();
                    tag.height = img.Height.ToString();
                }
            }

            return tag;
        }
    }
}
