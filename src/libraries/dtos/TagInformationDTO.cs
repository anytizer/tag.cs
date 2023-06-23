namespace libraries.dtos
{
    public class TagInformationDTO
    {
        public string batch { get; set; } = "";
        public string path { get; set; } = "";
        public string filesize { get; set; } = "";
        public string crc32 { get; set; } = "";
        public string width { get; set; } = "";
        public string height { get; set; } = "";
        public string orientation { get; set; } = "";
        public string tags { get; set; } = "";
        public string objects { get; set; } = "";
        public string people { get; set; } = "";
        public string description { get; set; } = "";
        public string notes { get; set; } = "";
        public string colors { get; set; } = "";
    }
}
