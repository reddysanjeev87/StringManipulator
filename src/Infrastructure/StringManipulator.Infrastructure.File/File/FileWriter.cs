using Microsoft.Extensions.Options;
using StringManipulator.Application;

namespace StringManipulator.Infrastructure
{
    internal class FileWriter :FileBase, IFileWriter
    {
        private readonly FileSettings fileSettings;
        public FileWriter(IOptions<FileSettings> fileSettingsOptions)
        {
            fileSettings = fileSettingsOptions.Value;
        }
        void IFileWriter.Write(string content)
        {
            var filePath=this.Combine(this.fileSettings.RootPath, this.fileSettings.ReverseFileName);
            using (StreamWriter file = new(filePath))
            {
                file.Write(content);
            }
        }
    }
}
