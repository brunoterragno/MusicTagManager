using System.IO;

namespace MusicTagManager.Extensions
{
    public static class ExtensionMethods
    {
        public static void Rename(this FileInfo fileInfo, string newName)
        {
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName);
        }
    }
}
