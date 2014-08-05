using MusicTagManager.Business;
using MusicTagManager.Helper;
using MusicTagManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MusicTagManager
{
    public partial class Main : Form
    {
        MusicManagement _management;
        //TagLib.IPicture _cover;

        public Main()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = fbdPath.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCover_Click(object sender, EventArgs e)
        {
            fdgPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            fdgPicture.InitialDirectory = txtPath.Text;
            if (fdgPicture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picCover.Image = _management.CreatePicture(fdgPicture.FileName, picCover.Width, picCover.Height);
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private string JoinNames(IEnumerable<string> pred)
        {
            return string.Join(",", pred);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
               
                if (chkChangeArtist.Checked)
                {
                    var albumArtists = txtArtist.Text.Split(',');
                    _management.ChangeAlbumArtist(albumArtists);
                }

                if (chkChangeContribArtist.Checked)
                {
                    var contributingArtists = txtContribArtist.Text.Split(',');
                    _management.ChangeContributingArtists(contributingArtists);
                }

                if (chkChangeAlbumTittle.Checked)
                    _management.ChangeAlbumTittle(txtAlbum.Text);

                if (chkChangeAlbumYear.Checked)
                    _management.ChangeAlbumYear(Convert.ToUInt32(txtYear.Text));

                if (chkChangeCover.Checked)
                    _management.ChangeAlbumCover();

                if (chkChangeTittle.Checked)
                    _management.ChangeTitleTagToFileName();

                _management.SaveChanges();

                if (chkChangeFilename.Checked)
                    _management.ChangeFileNameToTitleTag();               

                MessageBox.Show("Done!");

                LoadFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! Something went wrong... Message:" + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadFiles()
        {
            if (Directory.Exists(txtPath.Text))
            {
                _management = new MusicManagement(txtPath.Text);
                var musicFiles = _management.Files.Select(x => new Music(x)).ToList();
                dgvFiles.DataSource = musicFiles;

                //load individual tags
                txtArtist.Text = JoinNames(musicFiles.SelectMany(x => x.AlbumArtists).Distinct());
                txtContribArtist.Text = JoinNames(musicFiles.SelectMany(x => x.ContributingArtists).Distinct());
                txtAlbum.Text = JoinNames(musicFiles.Select(x => x.AlbumTittle).Distinct());
                txtYear.Text = JoinNames(musicFiles.Select(x => x.AlbumYear.ToString()).Distinct());

                //load cover
                picCover.Image = null;
                var images = _management.Files.SelectMany(x => x.Tag.Pictures).Distinct();
                images = images.Where(x => x.Data.Data.Length > 0);

                //default
                _management.Cover = images.FirstOrDefault();

                if (_management.Cover != null && _management.Cover.Data.Data.Length != 0)
                {
                    var firstImageExtracted = ImageHelper.ExtractImage(_management.Cover);
                    picCover.Image = firstImageExtracted.GetThumbnailImage(picCover.Width, picCover.Height, null, new IntPtr());
                }
            }
        }
    }
}
