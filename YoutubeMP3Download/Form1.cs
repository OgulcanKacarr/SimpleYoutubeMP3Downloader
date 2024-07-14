using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMP3Download
{
    public partial class Form1 : Form
    {
        private DownloadClass downloadClass = new DownloadClass();

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            label_status.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Konum seç
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_path.Text = dialog.SelectedPath;
                    SaveSettings(); // Konumu kaydedelim
                }
            }
        }

        private async void button_download_Click_1(object sender, EventArgs e)
        {
            string videoUrl = textBox_download_url.Text;
            string outputDir = textBox_path.Text;

            // Önce ProgressBar'u sıfırlayalım veya başlangıç değerine getirelim
            progressBar1.Value = 0;
            label_status.Visible = true;
            button_download.Enabled = false;
            textBox_download_url.Enabled = false;

            try
            {
                // İlerleme raporlaması için bir Progress<double> nesnesi oluşturalım
                var progress = new Progress<double>(percent =>
                {
                    // ProgressBar'un değerini yüzde olarak ayarlayalım
                    int intValue = (int)(percent * 100);
                    progressBar1.Value = intValue;
                });

                await downloadClass.DownloadMp3Async(videoUrl, outputDir, progress);
                downloadClass.ListDownloadedFiles(outputDir, dataGridView1);

                // İşlem tamamlandıktan sonra kullanıcıya mesaj verelim
           
                label_status.Visible = false;
                button_download.Enabled = true;
                textBox_download_url.Text = null;
                textBox_download_url.Enabled = true;

                // Ses dosyasını çal
                await PlayNotificationSound();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya hata mesajı gösterelim
                MessageBox.Show($"An error occurred: {ex.Message}");
                label_status.Visible = false;
                textBox_download_url.Text = null;
                button_download.Enabled = true;
            }
        }

        private void button_open_folder_Click(object sender, EventArgs e)
        {
            string outputDir = textBox_path.Text;
            try
            {
                // İndirilen dosyaların bulunduğu klasörü Windows Explorer ile aç
                if (!string.IsNullOrEmpty(outputDir) && Directory.Exists(outputDir))
                {
                    Process.Start(outputDir);
                }
                else
                {
                    MessageBox.Show("Output directory is not valid or does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the output folder: {ex.Message}");
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.dir_path = textBox_path.Text;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            string savedOutputDir = Properties.Settings.Default.dir_path;
            if (!string.IsNullOrEmpty(savedOutputDir) && Directory.Exists(savedOutputDir))
            {
                textBox_path.Text = savedOutputDir;
            }
        }
        private async Task PlayNotificationSound()
        {
            string soundFilePath = Path.Combine(Application.StartupPath, "button.mp3");

            if (File.Exists(soundFilePath))
            {
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play();
            }
            else
            {
               
            }
        }
    }



}
