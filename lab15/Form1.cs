using System;
using System.IO;
using System.Net;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Підключення до сервера
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                lstFiles.Items.Clear();
                while (!reader.EndOfStream)
                {
                    lstFiles.Items.Add(reader.ReadLine());
                }

                lblStatus.Text = "Connected";
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to FTP server: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string destinationPath = tbHost.Text + "/" + Path.GetFileName(fileName);

                try
                {
                    // Завантаження файлу на сервер
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(destinationPath);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    byte[] file = File.ReadAllBytes(fileName);
                    Stream strz = request.GetRequestStream();
                    strz.Write(file, 0, file.Length);
                    strz.Close();

                    MessageBox.Show(Path.GetFileName(fileName) + " uploaded successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message);
                }
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                // Створення каталогу на сервері
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbNewDir.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                MessageBox.Show("Directory " + tbNewDir.Text + " created successfully");
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating directory: " + ex.Message);
            }
        }
    }
}
