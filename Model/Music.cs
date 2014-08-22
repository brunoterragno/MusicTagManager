using System.Drawing;
using System.IO;

namespace MusicTagManager.Model
{
    public class Music
    {
        public TagLib.File File { get; set; }
        public uint Track { get { return File.Tag.Track; } set { File.Tag.Track = value; } }
        public string Filename { get { return Path.GetFileName(File.Name); } }
        public string Tittle { get { return File.Tag.Title; } set { File.Tag.Title = value; } }
        public string AlbumTittle { get { return File.Tag.Album; } }
        public string[] AlbumArtists { get { return File.Tag.AlbumArtists; } }
        public string[] ContributingArtists { get { return File.Tag.Artists; } }
        public uint AlbumYear { get { return File.Tag.Year; } }

        public Music(TagLib.File file)
        {
            this.File = file;
        }
    }
}
