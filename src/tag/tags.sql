DROP TABLE IF EXISTS "images";

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