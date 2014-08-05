using System.Drawing;
using System.IO;

namespace MusicTagManager.Model
{
    public class Music
    {
        private TagLib.File _file;
        public uint Track { get { return _file.Tag.Track; } set { _file.Tag.Track = value; } }
        public string Filename { get { return Path.GetFileName(_file.Name); } }
        public string Tittle { get { return _file.Tag.Title; } set { _file.Tag.Title = value; } }
        public string AlbumTittle { get { return _file.Tag.Album; } }
        public string[] AlbumArtists { get { return _file.Tag.AlbumArtists; } }
        public string[] ContributingArtists { get { return _file.Tag.Artists; } }
        public uint AlbumYear { get { return _file.Tag.Year; } }

        public Music(TagLib.File file)
        {
            this._file = file;
        }
    }
}
