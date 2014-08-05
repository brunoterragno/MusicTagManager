using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MusicTagManager.Helper
{
    public static class FileHelper
    {
        public static List<TagLib.File> MusicFilesFromDirectory(string path)
        {
            List<string> files = new List<string>();
            var filters = new string[] { "*.mp3", "*.flac", "*.m4a", "*.mp4" };

            foreach (var filter in filters)
            {
                files.AddRange(Directory.GetFiles(path, filter, SearchOption.AllDirectories).ToList());
            }

            List<TagLib.File> musicFiles = new List<TagLib.File>();
            files.ForEach(filename => musicFiles.Add(TagLib.File.Create(filename)));

            return musicFiles;
        }

        public static void CopyToAnotherPath(List<TagLib.File> files, string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);

            Directory.CreateDirectory(path);

            files.ForEach(x => File.Copy(x.Name, path + Path.GetFileName(x.Name)));
        }
    }
}
