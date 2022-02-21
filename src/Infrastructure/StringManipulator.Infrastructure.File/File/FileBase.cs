namespace StringManipulator.Infrastructure
{
    /// <summary>
    /// This is the proxy class of file system
    /// </summary>
    internal abstract class FileBase
    {
        protected string Combine(string path1, string Path2) => Path.Combine(path1, Path2);
        protected bool IsDirectoryExist(string directory) => Directory.Exists(directory);

        protected void CreateNewDirectory(string directory)
        {
            if (IsDirectoryExist(directory))
                Directory.CreateDirectory(directory);
        }
        protected bool IsFileExists(string filePath)=>File.Exists(filePath);
    }
}
