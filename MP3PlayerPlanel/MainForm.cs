using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using NAudio.Wave.SampleProviders;
using System.Drawing;
using PackoAmp.Properties;

namespace MP3PlayerPlanel
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private static Random rnd = new Random();
        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;
        private List<string> _songFiles = new List<string>();
        private int _songIndex;
        private Action<float> _setVolumeDelegate;
        private string _lastPath;
        private const string _supportedExtentions = "*.wav;*.aiff;*.mp3;*.aac";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!_songFiles.Any())
            {
                btnAddFolder_Click(sender, e);
                return;
            }

            btnPlay.Text = ";";

            if (_waveOutDevice != null)
            {
                if (_waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    _waveOutDevice.Pause();
                    btnPlay.Text = "4";
                    return;
                }
                else if (_waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    _waveOutDevice.Play();
                    btnPlay.Text = ";";
                    return;
                }
            }

            
            
            _songIndex = lbSongs.SelectedIndex;

            PlaySong(_songIndex);

        }

        private void PlaySong(int songIndex)
        {
            
            //Create Wave
            _waveOutDevice = new WaveOut();
            ISampleProvider sampleProvider;

            try
            {
                sampleProvider = CreateInputStream(_songFiles.ElementAt(songIndex));
            }
            catch (Exception createException)
            {
                sampleProvider = CreateInputStream(_songFiles.First());
                lbSongs.SelectedIndex = 0;
            }

            //Length of the song
            lblTotalTime.Text = string.Format("{0:00}:{1:00}", (int)_audioFileReader.TotalTime.TotalMinutes, _audioFileReader.TotalTime.Seconds);

            //Set name and description
            string path;

            try
            {
                path = _songFiles.ElementAt(songIndex);
            }
            catch (Exception)
            {
                path = _songFiles.First();
            }

            TagLib.File file = TagLib.File.Create(path);

            lblPerformer.Text = file.Tag.FirstPerformer;

            lblTitle.Text = file.Tag.Title;
            lblTitle.Left = (panelBottom.Width / 2) - (lblTitle.Width / 2);

            lblAlbum.Text = file.Tag.Album;
            lblYear.Text = file.Tag.Year.ToString();
            lblGenre.Text = file.Tag.FirstGenre;

            //Set artwork
            TagLib.IPicture pic;
            MemoryStream stream;
            Bitmap image;

            if (file.Tag.Pictures.Length > 0)
            {
                pic = file.Tag.Pictures[0];

                stream = new MemoryStream(pic.Data.Data);
                image = new Bitmap(stream);
                new Bitmap(stream);

                pbSongImg.Image = image;
            }
            else
            {
                pbSongImg.Image = null;
            }

            //Play song :P
            _waveOutDevice.Init(sampleProvider);
            _setVolumeDelegate(volumeSlider.Volume);
            _waveOutDevice.Play();
        }

        private void AddSongsToLists(string song)
        {
            string name;
            TagLib.File file;

            file = TagLib.File.Create(song);

            try
            {
                name = string.Format("{0} - {1}", file.Tag.Performers[0], file.Tag.Title);
            }
            catch (IndexOutOfRangeException ex)
            {
                name = Path.GetFileNameWithoutExtension(song);
            }
            
            _songFiles.Add(song);

            lbSongs.Items.Add(name);
        }

        private ISampleProvider CreateInputStream(string fileName)
        {
            try
            {
                _audioFileReader = new AudioFileReader(fileName);
            }
            catch (FileNotFoundException ex)
            {
                _audioFileReader = new AudioFileReader(_songFiles.First());
            }

            var sampleChannel = new SampleChannel(_audioFileReader, true);
            _setVolumeDelegate = vol => sampleChannel.Volume = vol;
            var postVolumeMeter = new MeteringSampleProvider(sampleChannel);

            return postVolumeMeter;
        }

        private void lbSongs_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSongs.IndexFromPoint(e.Location);
            _songIndex = lbSongs.SelectedIndex;

            if (index != ListBox.NoMatches)
            {
                lblTitle.Text = lbSongs.SelectedItem.ToString();

                if (_waveOutDevice == null)
                {
                    PlaySong(_songIndex);
                }
                else if (_waveOutDevice != null)
                {
                    _waveOutDevice.Stop();
                    PlaySong(_songIndex);
                }

                btnPlay.Text = ";";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_waveOutDevice != null)
            {
                btnPlay.Text = "4";
                ClearAll();
                lbSongs.SelectedIndex = -1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PrevNextSong('+');
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PrevNextSong('-');
        }

        private void PrevNextSong(char sym)
        {
            if (_waveOutDevice == null)
            {
                return;
            }

            _waveOutDevice.Stop();



            //Shuffle
            if (chkShuffle.Checked)
            {
                int rndIndex = rnd.Next(0, lbSongs.Items.Count);

                if (rndIndex == lbSongs.SelectedIndex)
                {
                    rndIndex = rnd.Next(0, lbSongs.Items.Count);
                }

                lbSongs.SelectedIndex = rndIndex;
                PlaySong(rndIndex);

                return;
            }

            //Change songs
            int songIndex;

            if (sym == '+')
            {
                songIndex = lbSongs.SelectedIndex + 1;
            }
            else if (sym == '-')
            {
                songIndex = lbSongs.SelectedIndex - 1;
            }
            else return;

            try
            {
                lbSongs.SelectedIndex = songIndex;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                if (sym == '+')
                {

                    PlaySong(_songFiles.IndexOf("0"));
                    lbSongs.SelectedIndex = 0;
                }
                else if (sym == '-')
                {
                    MessageBox.Show("Test");
                    PlaySong(_songFiles.Count - 1);
                    lbSongs.SelectedIndex = lbSongs.Items.Count - 1;
                }
                return;
            }

            PlaySong(songIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_waveOutDevice != null && _audioFileReader != null)
            {
                TimeSpan currentTime = (_waveOutDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : _audioFileReader.CurrentTime;
                trbTime.Value = Math.Min(trbTime.Maximum, (int)(100 * currentTime.TotalSeconds / _audioFileReader.TotalTime.TotalSeconds));
                lblCurrentTime.Text = string.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes, currentTime.Seconds);

                

            }
            else
            {
                trbTime.Value = 0;
            }
        }

        private void trbTime_Scroll(object sender, EventArgs e)
        {
            if (_audioFileReader != null)
            {
                _audioFileReader.CurrentTime = TimeSpan.FromSeconds(_audioFileReader.TotalTime.TotalSeconds * trbTime.Value / 100.0);
            }

            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogMpl = new OpenFileDialog();
            openFileDialogMpl.Filter = string.Format("All Supported Files|{0}|All Files (*.*)|*.*", _supportedExtentions);

            openFileDialogMpl.Multiselect = true;

            if (openFileDialogMpl.ShowDialog() == DialogResult.OK)
            {
                foreach (string song in openFileDialogMpl.FileNames)
                {
                    if (!_songFiles.Contains(song))
                    {
                        AddSongsToLists(song);
                    }
                }
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = false;

            try
            {
                folderBrowser.SelectedPath = _lastPath;
            }
            catch (ArgumentNullException ex)
            {
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            }

            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string extensions = "*.mp3";
                var paths = Directory.GetFiles(folderBrowser.SelectedPath, extensions, SearchOption.AllDirectories);

                foreach (string path in paths)
                {
                    if (!_songFiles.Contains(path))
                    {
                        AddSongsToLists(path);
                    }
                }
            }

            _lastPath = folderBrowser.SelectedPath;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _songIndex = lbSongs.SelectedIndex;

            try
            {
                lbSongs.Items.RemoveAt(_songIndex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return;
            }

            _songFiles.RemoveAt(_songIndex);

            ClearAll();

            btnNext_Click(sender, e);
        }
        
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lbSongs.Items.Count > 0)
            {
                btnStop_Click(sender, e);

                lbSongs.Items.Clear();
                _songFiles.Clear();

                ClearAll();

                CloseWaveOut();
                //timer1.Stop();
            }
        }

        private void CloseWaveOut()
        {
            if (_waveOutDevice != null)
            {
                _waveOutDevice.Stop();
            }
            if (_waveOutDevice != null)
            {
                _waveOutDevice.Dispose();
                _waveOutDevice = null;
            }
        }

        private void ClearAll()
        {
            _waveOutDevice.Stop();

            lblCurrentTime.Text = "0:00";
            lblTotalTime.Text = "0:00";
            lblTitle.Text = string.Empty;
            lblPerformer.Text = string.Empty;
            lblAlbum.Text = string.Empty;
            lblGenre.Text = string.Empty;
            lblYear.Text = string.Empty;

            pbSongImg.Image = null;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            if (_setVolumeDelegate != null)
            {
                _setVolumeDelegate(volumeSlider.Volume);
            }
        }

        private void chkShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShuffle.Checked) ;
            else chkShuffle.BackColor = Color.FromArgb(54, 54, 54);
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMute.Checked)
            {
                volumeSlider.Volume = 0;
            }
            else
            {
                volumeSlider.Volume = 100;
            }
        }

        private void lbSongs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnRemove_Click(sender, e);
            }
            if (e.KeyCode == Keys.Space)
            {
                btnPlay_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPerformer.Text = string.Empty;
            lblTitle.Text = string.Empty;
            lblGenre.Text = string.Empty;
            lblYear.Text = string.Empty;
        }

        private void trbTime_ValueChanged(object sender, EventArgs e)
        {
            if (trbTime.Value == trbTime.Maximum)
            {
                PrevNextSong('+');
            }
        }

        private void panelBottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
