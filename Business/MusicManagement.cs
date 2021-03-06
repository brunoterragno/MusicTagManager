﻿using System.Collections.Generic;
using System.IO;
using MusicTagManager.Extensions;
using MusicTagManager.Helper;
using System.Drawing;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;

namespace MusicTagManager.Business
{
    public class MusicManagement
    {
        string _path;
        public TagLib.IPicture Cover { get; set; }
        public BindingList<TagLib.File> Files { get; set; }

        public MusicManagement()
        {
            Files = new BindingList<TagLib.File>();
        }

        public MusicManagement(string path)
            : this()
        {
            _path = path;
            FillList();
        }

        public Image CreatePicture(string path, int width, int height)
        {
            var image = Image.FromFile(path);
            Cover = new TagLib.Picture(path);
            return image.GetThumbnailImage(width, height, null, new IntPtr());

        }

        public void FillList()
        {
            ClearList();
            Files = new BindingList<TagLib.File>(FileHelper.MusicFilesFromDirectory(_path));
        }

        public void ClearList()
        {
            Files.Clear();
        }

        public void ChangeFileNameToTitleTag()
        {
            foreach (var item in Files)
            {
                FileInfo file = new FileInfo(item.Name);
                file.Rename(item.Tag.Title + Path.GetExtension(item.Name));
            }

            FillList();
        }

        public void ChangeAlbumTittle(string album)
        {
            foreach (var item in Files)
            {
                item.Tag.Album = album;
            }
        }

        public void SaveChanges()
        {
            Files.ToList().ForEach(x => x.Save());
        }

        public void ChangeAlbumArtist(string[] artists)
        {
            foreach (var item in Files)
            {
                item.Tag.AlbumArtists = artists;
            }
        }

        public void ChangeContributingArtists(string[] artists)
        {
            foreach (var item in Files)
            {
                item.Tag.Artists = artists;
            }
        }

        public void ChangeAlbumCover()
        {
            if (Cover != null)
            {
                foreach (var item in Files)
                {
                    item.Tag.Pictures = new TagLib.IPicture[] { Cover };
                }
            }
        }

        public void ChangeAlbumYear(uint year)
        {
            foreach (var item in Files)
            {
                item.Tag.Year = year;
            }
        }

        public void ChangeTitleTagToFileName()
        {
            foreach (var item in Files)
            {
                item.Tag.Title = Path.GetFileNameWithoutExtension(item.Name);
            }
        }
    }
}
