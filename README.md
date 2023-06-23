# tag.cs
Image Tagger

## Features

* Confirms datbase file exists beforfe running the application.
* Title displays the name of the current image file opened.
* Supported image types by extension: jpg, jpeg, png, gif
* Shows cursor as busy while scanning.
* Remembers a batch on muliple scans.
* Builds an SQLite database of basic photo tags, with preview.
* Backs up images when "empty" is requested while using Command Line Interface.
* Option to auto save tags as you type in.

## Database of tags

```
CREATE TABLE "images" (
  "ImagePath"	TEXT NOT NULL,
  "ImageBatch"	TEXT NOT NULL,
  "ImageFileSize"	TEXT NOT NULL,
  "ImageCRC32"	TEXT NOT NULL,
  "ImageHeight"	TEXT NOT NULL,
  "ImageWidth"	TEXT NOT NULL,
  "ImageOrientation"	TEXT NOT NULL,
  "ImageTags"	TEXT NOT NULL,
  "ImageDescription"	TEXT NOT NULL,
  "ImageObjects"	TEXT NOT NULL,
  "ImagePeople"	TEXT NOT NULL
);
```

## Interface

![image](https://github.com/anytizer/tag.cs/assets/5563341/2d6de159-8448-4e29-acf2-7057e536a3f9)

## Keyboard Shortcut:

key combination    | What does it do
-------------------|--------------------------------------------
ctrl + o           | Opens a directory to scan
ctrl + s           | Save tag information back to the database
ctrl + left arrow  | Navigate to previous image
ctrl + right arrow | Navigate to next image
ctrl + page up     | Jump navigator to next 10th image
ctrl + page down   | Jump navigator to previous 10th image
ctrl + home        | Jump to the first image
ctrl + end         | Jump the last image.
enter              | Seach on tags
f1                 | Help

## Frequently Asked Questions

Is it a portable version? Yes, it is. Drop tags.db file within the application folder, if missing.

Does it modify the photo file itself to insert the tags? No, it won't. It keeps a database of tags in separate [SQLite Database](tags.db).

What if I moved the files in a different location after scanning? Fix the database of paths, or re-scan the new path.

How many files can it tag at once? It is subject to available RAM memory. Put the files in folders first, before starting to tag.

How long does it take to scan at least 100 photos? It might take a while, because it collects CRC32 hash, at the same time.