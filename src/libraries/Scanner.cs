using Microsoft.EntityFrameworkCore;

namespace libraries
{
    public class Scanner
    {
        TaggerContext dbc = new TaggerContext();
        private string id()
        {
            return Guid.NewGuid().ToString().ToUpper();
        }

        public void list(string path)
        {
            string[] imageFiles = this.GetImageFiles(path);
            Console.WriteLine("{0} images found.", imageFiles.Length);

            foreach (string imageFile in imageFiles)
            {
                TagInformationDTO tag = this.getTags(imageFile);

                Console.WriteLine(imageFile);
                Console.WriteLine("  Orientation: " + tag.orientation);
                Console.WriteLine("  Width: " + tag.width);
                Console.WriteLine("  Height: " + tag.height);
                Console.WriteLine("  Size: " + tag.filesize);
                Console.WriteLine("");
            }
        }

        public string build(string path)
        {
            string[] imageFiles = this.GetImageFiles(path);
            string batch = this.id();
            foreach (string imageFile in imageFiles)
            {
                TagInformationDTO tag = this.getTags(imageFile);

                ImageModel image = new ImageModel();
                image.ImagePath = imageFile;
                image.ImageBatch = batch;
                image.ImageFileSize = new FileInfo(imageFile).Length.ToString();
                image.ImageCRC32 = new Crc32Utils().CalculateCrc32(imageFile);
                image.ImageHeight = tag.height;
                image.ImageWidth = tag.width;
                image.ImageOrientation = tag.orientation;
                image.ImageTags = "";
                image.ImageDescription = "";
                image.ImageObjects = "";
                image.ImagePeople = "";

                dbc.images.Add(image);
            }
            dbc.SaveChanges();

            return batch;
        }

        private TagInformationDTO getTags(string path)
        {
            ExifReader er = new ExifReader();
            TagInformationDTO tag = er.ReadExifData(path);
            return tag;
        }

        public string[] GetImageFiles(string directoryPath)
        {
            string searchPattern = "*";
            string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
            string[] imageExtensions = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string[] imageFiles = files.Where(file => imageExtensions.Contains(Path.GetExtension(file).ToLower())).ToArray();

            return imageFiles;
        }

        public void empty()
        {
            string code = this.id().Substring(0, 5);
            this.dbc.Database.ExecuteSqlRaw($"DROP TABLE IF EXISTS `images_{code}`;");
            this.dbc.Database.ExecuteSqlRaw($"CREATE TABLE `images_{code}` AS SELECT * FROM images;");
            this.dbc.Database.ExecuteSqlRaw("DELETE FROM images;");
            this.dbc.Database.ExecuteSqlRaw("VACUUM \"temp\";");
            this.dbc.Database.ExecuteSqlRaw("VACUUM \"main\";");
            this.dbc.SaveChanges();
        }
    }
}