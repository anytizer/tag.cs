# tag.cs
Image Tagger

Builds an SQLite database of basic photo tags, with preview.

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
* ctrl + o
* ctrl + s
* ctrl + left arrow
* ctrl + right arrow
* ctrl + page up
* ctrl + page down
