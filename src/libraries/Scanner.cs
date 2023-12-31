﻿using configurations;
using libraries.dtos;
using libraries.models;
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

        private string code()
        {
            return this.id().Substring(0, 8);
        }

        public string build(string path)
        {
            string[] imageFiles = this.list(path);
            string batch = this.code();
            
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
                image.ImageDescription = new FileInfo(imageFile).Directory?.Name + "; " + new FileInfo(imageFile).Name;
                image.ImageObjects = "";
                image.ImagePeople = "";

                dbc.images.Add(image);
                dbc.SaveChanges();
            }

            return batch;
        }

        public TagInformationDTO getTags(string path)
        {
            ExifReader er = new ExifReader();
            TagInformationDTO tag = er.ReadExifData(path);
            return tag;
        }

        // scan on live folders
        public string[] list(string directoryPath)
        {
            string searchPattern = "*";
            string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);
            string[] imageExtensions = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string[] imageFiles = files.Where(file => imageExtensions.Contains(Path.GetExtension(file).ToLower())).ToArray();

            return imageFiles;
        }

        public string empty()
        {
            string code = this.code();

            this.dbc.Database.ExecuteSqlRaw($"DROP TABLE IF EXISTS `images_{code}`;");
            this.dbc.Database.ExecuteSqlRaw($"CREATE TABLE `images_{code}` AS SELECT * FROM images;");
            this.dbc.Database.ExecuteSqlRaw("DELETE FROM images;");
            this.dbc.Database.ExecuteSqlRaw("VACUUM \"temp\";");
            this.dbc.Database.ExecuteSqlRaw("VACUUM \"main\";");
            this.dbc.SaveChanges();

            return code;
        }

        public void newDB()
        {
            File.Create(Configs.DATABASE); // touch the file.

            this.dbc.Database.ExecuteSqlRaw(File.ReadAllText("tags.sql"));
            this.dbc.SaveChanges();
        }

        public string[] search(string portion)
        {
            TaggerContext dbc = new TaggerContext();
            string[] images = dbc.images.Where(x =>
                x.ImageTags.ToLower().Contains(portion) ||
                x.ImageObjects.ToLower().Contains(portion) ||
                x.ImagePeople.ToLower().Contains(portion) ||
                x.ImageDescription.ToLower().Contains(portion) ||
                x.ImageNotes.ToLower().Contains(portion) ||
                x.ImageColors.ToLower().Contains(portion)
            ).Select(x => x.ImagePath).ToArray();
            return images;

        }

        public string[] scan_image_db()
        {
            TaggerContext dbc = new TaggerContext();
            string[] images = dbc.images.Select(x => x.ImagePath).ToArray();
            return images;
        }

        public void update(TagInformationDTO tag)
        {
            TaggerContext dbc = new TaggerContext();
            ImageModel? image = dbc.images.Where(x => x.ImagePath == tag.path).FirstOrDefault();
            if (image != null)
            {
                image.ImageTags = tag.tags;
                image.ImageObjects = tag.objects;
                image.ImagePeople = tag.people;
                image.ImageDescription = tag.description;
                image.ImageNotes = tag.notes;
                image.ImageColors = tag.colors;

                dbc.SaveChanges();
            }
        }
    }
}