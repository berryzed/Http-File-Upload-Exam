using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

/**
 * @author Berryzed
 * 
 */

namespace HttpFileUploadExam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Selectfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "video files (*.mp4)|*.mp4";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            btn_Upload.Enabled = true;
            txt_Filepath.Text = openFileDialog1.FileName;
            FileInfo file = new FileInfo(openFileDialog1.FileName);
            lbl_Filesize.Text = "File Size: " + GetFileSize(file.Length);

            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(openFileDialog1.FileName);
            Console.WriteLine(TimeSpan.FromSeconds(clip.duration));
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            btn_Selectfile.Enabled = false;
            btn_Upload.Enabled = false;

            using (WebClient client = new WebClient())
            {
                string fileName = openFileDialog1.FileName;
                Uri url_upload = new Uri("change recive remote url");

                NameValueCollection nvc = new NameValueCollection();

                // data insert
                // nvc.Add("userid", "user01");
                // nvc.Add("workid", "work01");

                client.QueryString = nvc;
                client.UploadFileCompleted += (s, e1) =>
                {
                    string msg;

                    btn_Selectfile.Enabled = true;
                    btn_Upload.Enabled = true;

                    msg = Encoding.UTF8.GetString(e1.Result);

                    MessageBox.Show(msg);
                };
                client.UploadProgressChanged += (s, e1) =>
                {
                    double BytesSent = e1.BytesSent;
                    double TotalBytesToSend = e1.TotalBytesToSend;
                    int percent = (int)((BytesSent / TotalBytesToSend) * 100.0);

                    prog_Upload.Value = percent;
                    lbl_Percent.Text = percent + "%";

                };

                client.UploadFileAsync(url_upload, fileName);

                client.Dispose();
            }
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }
    }
}
