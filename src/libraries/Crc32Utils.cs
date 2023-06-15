using System;

namespace libraries
{
    public class Crc32Utils
    {
        private const uint Polynomial = 0xEDB88320;

        private uint[] crcTable;

        public Crc32Utils()
        {
            crcTable = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (int j = 0; j < 8; j++)
                {
                    crc = (crc & 1) == 1 ? (crc >> 1) ^ Polynomial : crc >> 1;
                }
                crcTable[i] = crc;
            }
        }

        public string CalculateCrc32(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                uint crc32 = 0xFFFFFFFF;
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        crc32 = (crc32 >> 8) ^ crcTable[(crc32 & 0xFF) ^ buffer[i]];
                    }
                }
                crc32 ^= 0xFFFFFFFF;
                return crc32.ToString("X8");
            }
        }
    }
}