using Microsoft.Extensions.Options;
using StringManipulator.Application;
using System.Text;

namespace StringManipulator.Infrastructure
{
    /// <summary>
    /// This is the proxy class proxy streamreader
    /// </summary>
    internal class FileReader : FileBase, IFileReader
    {
        private readonly FileSettings fileSettings;
        public FileReader(IOptions<FileSettings> fileSettingsOptions)
        {
            fileSettings=fileSettingsOptions.Value;
        }
        /// <summary>
        /// read content from the given path of  file systems
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        string IFileReader.Read()
        {
            var filePath = this.Combine(this.fileSettings.RootPath, this.fileSettings.OriginalFileName);
            if (!this.IsFileExists(filePath))
            {
                throw new FileNotFoundException($"File does not exists in the given path: {filePath}");
            }
            var stringBuilder = new StringBuilder();
            using (StreamReader file = new StreamReader(filePath))
            {
                var line = string.Empty;
                while ((line = file.ReadLine()) != null)
                {
                    stringBuilder.Append(line.Trim());
                    stringBuilder.Append(" ");
                }
                file.Close();
            }
            return stringBuilder.ToString();
        }
    }
}
