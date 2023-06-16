# tag.cs
Image Tagger Software to build database of user defined tags.

## Features
* Window title displays the name of the current image file.
* Supported image types by extension: jpg, jpeg, png, gif
* Shows busy cursor sign while scanning a directory.
* Remembers a batch on muliple scans.
* Backs up images when "empty" is requested when using Command Line Interface.

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

## Keyboard shortcuts:

key combination      | What it does
---------------------|--------------
ctrl + o             | Opens a directory to scan
ctrl + s             | Save tag information back to the database
ctrl + left arrow    | Navigate to previous image
ctrl + right arrow   | Navigate to next image
ctrl + page up       | Jump navigator to next 10th image
ctrl + page down     | Jump navigator to previous 10th image

## Frequently Asked Questions

Is it a portable version? Yes, it is.

Does it modify the photo file itself to insert the tags? No, it won't. It keeps a datbase of tags in [SQLite](tags.db).

What if I moved the files in a different location after scanning? Fix the database of paths, or re-scan the new path.

How many files can it tag at once? It is subject to available RAM memory.

How long does it take to scan at least 100 photos? It might take a while, because it collects CRC32 hash.
