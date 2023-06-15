using System.ComponentModel.DataAnnotations;

namespace libraries
{
    public class ImageModel
    {
        [Key]
        public string ImagePath { get; set; } = "";
        public string ImageBatch { get; set; } = "";
        public string ImageFileSize { get; set; } = "";
        public string ImageCRC32 { get; set; } = "";
        public string ImageHeight { get; set; } = "";
        public string ImageWidth { get; set; } = "";
        public string ImageOrientation { get; set; } = "";
        public string ImageTags { get; set; } = "";
        public string ImageDescription { get; set; } = "";
        public string ImageObjects { get; set; } = "";
        public string ImagePeople { get; set; } = "";
    }
}
