using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeDownloader
{
    public partial class HomeForm : Form
    {

        #region Dichiarazione Variabili

        #region Emoji

        string squareVoidEmoji = "◻";
        string squareDoubleEmoji = "❐";

        #endregion Emoji

        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion Move Form

        bool checkPlaylist;

        bool videoRadioButtonStatus;
        bool audioRadioButtonStatus;

        #endregion Dichiarazione Variabili


        #region Costruttore

        public HomeForm()
        {
            InitializeComponent();

            videoRadioButton.Checked = true;

            checkPlaylist = false;
        }

        #endregion Costruttore

        #region Metodi Bottoni Dimensioni Form

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                resizeButton.Text = squareVoidEmoji;
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                resizeButton.Text = squareDoubleEmoji;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodi per lo spostamento della schermata
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Metodo usato per il muovimento del Form
        private void headerTitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (resizeButton.Text != squareVoidEmoji)
                {
                    resizeButton.Text = squareVoidEmoji;
                }
                else
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        #endregion Metodi Bottoni Dimensioni Form

        //Quando viene premuto il bottone download
        private void downloadButton_Click(object sender, EventArgs e)
        {
            //Salvo stato radioButton
            videoRadioButtonStatus = videoRadioButton.Checked;
            audioRadioButtonStatus = audioRadioButton.Checked;

            //Controllo che il campo testale non sia vuoto
            if (!linkTextBox.Text.Replace(" ", "").Equals("") && !videoTitleTextBox.Text.Replace(" ", "").Equals(""))
            {
                //Controllo se il link può essere corretto
                if (linkTextBox.Text.ToLower().Contains("youtube.com/"))
                {
                    //Controllo se il link riguarda una playlista o un video singolo
                    if (linkTextBox.Text.ToLower().Contains("youtube.com/playlist?list="))
                    {
                        //In caso di playlist

                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;

                            //Client Youtube
                            var youtube = new YoutubeClient();

                            var youtubeLink = "";
                            var titleVideo = "";

                            if (InvokeRequired)
                            {
                                try
                                {
                                    this.Invoke(new MethodInvoker(delegate
                                    {
                                        //Estrazione link e titolo video
                                        youtubeLink = linkTextBox.Text;
                                        titleVideo = videoTitleTextBox.Text.ToLower().Replace(" ", "");

                                        errLabel.ForeColor = Color.FromName("#404040");
                                        errLabel.Visible = true;
                                        errLabel.Text = "Download Start";

                                        downloadButton.Enabled = false;
                                    }));
                                }
                                catch (Exception)
                                { }
                            }

                            downloadPlaylist(youtube, youtubeLink, titleVideo);

                            while (checkPlaylist == true) { }

                            if (InvokeRequired)
                            {
                                try
                                {
                                    this.Invoke(new MethodInvoker(delegate
                                    {
                                        errLabel.ForeColor = Color.FromName("#404040");
                                        errLabel.Visible = true;
                                        errLabel.Text = "Download Finish";

                                        downloadButton.Enabled = true;
                                    }));
                                }
                                catch (Exception)
                                { }
                            }

                        }).Start();
                    }
                    else if (linkTextBox.Text.ToLower().Contains("youtube.com/watch?v="))
                    {
                        //In caso di video singolo

                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;

                            //Client Youtube
                            var youtube = new YoutubeClient();

                            var youtubeLink = "";
                            var titleVideo = "";

                            if (InvokeRequired)
                            {
                                try
                                {
                                    this.Invoke(new MethodInvoker(delegate
                                    {
                                        //Estrazione link e titolo video
                                        youtubeLink = linkTextBox.Text;
                                        titleVideo = videoTitleTextBox.Text.ToLower().Replace(" ", "");

                                        errLabel.ForeColor = Color.FromName("#404040");
                                        errLabel.Visible = true;
                                        errLabel.Text = "Download Start";

                                        downloadButton.Enabled = false;
                                    }));
                                }
                                catch (Exception)
                                { }
                            }

                            if (videoRadioButtonStatus == true)
                            {
                                //Download del video
                                youtube.Videos.DownloadAsync(youtubeLink, $"..//..//..//..//Download//Video//{titleVideo}.mp4").GetAwaiter().GetResult();

                            }
                            else if (audioRadioButtonStatus == true)
                            {
                                //Download dell'audio
                                youtube.Videos.DownloadAsync(youtubeLink, $"..//..//..//..//Download//Audio//{titleVideo}.mp3").GetAwaiter().GetResult();

                            }


                            if (InvokeRequired)
                            {
                                try
                                {
                                    this.Invoke(new MethodInvoker(delegate
                                    {
                                        errLabel.ForeColor = Color.FromName("#404040");
                                        errLabel.Visible = true;
                                        errLabel.Text = "Download Finish";

                                        downloadButton.Enabled = true;
                                    }));
                                }
                                catch (Exception)
                                { }
                            }


                        }).Start();
                    }
                    else
                    {
                        errLabel.Visible = true;
                        errLabel.ForeColor = Color.Red;
                        errLabel.Text = "Wrong Link";
                    }
                }
                else
                {
                    errLabel.Visible = true;
                    errLabel.ForeColor = Color.Red;
                    errLabel.Text = "Wrong Link";
                }
            }
            else
            {
                errLabel.Visible = true;
                errLabel.ForeColor = Color.Red;
                errLabel.Text = "Mandatory Blank Field";
            }
        }

        public async void downloadPlaylist(YoutubeClient youtube, string linkPlaylist, string titlePlaylist)
        {
            checkPlaylist = true;

            int countLoop = 1;

            

            await foreach (var video in youtube.Playlists.GetVideosAsync(linkPlaylist))
            {
                var titleVideo = video.Title;
                var linkVideo = video.Url;

                if (InvokeRequired)
                {
                    try
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            errLabel.ForeColor = Color.FromName("#404040");
                            errLabel.Visible = true;
                            errLabel.Text = $"Download Song {countLoop}: {titleVideo}";


                        }));
                    }
                    catch (Exception)
                    { }
                }

                if (videoRadioButtonStatus == true)
                {
                    //Crea la cartella se non esiste
                    if (!Directory.Exists($"..//..//..//..//Download//Video//{titlePlaylist}"))
                    {
                        Directory.CreateDirectory($"..//..//..//..//Download//Video//{titlePlaylist}");
                    }

                    //Download del video
                    youtube.Videos.DownloadAsync(linkVideo, $"..//..//..//..//Download//Video//{titlePlaylist}//{titleVideo.Replace(" ","")}.mp4").GetAwaiter().GetResult();

                }
                else if (audioRadioButtonStatus == true)
                {
                    //Crea la cartella se non esiste
                    if (!Directory.Exists($"..//..//..//..//Download//Audio//{titlePlaylist}"))
                    {
                        Directory.CreateDirectory($"..//..//..//..//Download//Audio//{titlePlaylist}");
                    }

                    //Download dell'audio
                    youtube.Videos.DownloadAsync(linkVideo, $"..//..//..//..//Download//Audio//{titlePlaylist}//{titleVideo.Replace(" ", "")}.mp3").GetAwaiter().GetResult();

                }

                countLoop++;
            }

            if (InvokeRequired)
            {
                try
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        errLabel.ForeColor = Color.FromName("#404040");
                        errLabel.Visible = true;
                        errLabel.Text = "Download Finish";
                    }));
                }
                catch (Exception)
                { }
            }

            checkPlaylist = false;
        }
    }
}
