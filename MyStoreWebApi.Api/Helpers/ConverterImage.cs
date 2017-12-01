
using System.IO;

namespace MyWebAPI.Api.Helpers
{
    public class ConverterImage
    {
        public static byte[] ConvertImageToBiteArray(string path)
        {
            byte[] fileData = null;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    fileData = binaryReader.ReadBytes((int)fs.Length);
                }
            }
            return fileData;
        }
    }
}