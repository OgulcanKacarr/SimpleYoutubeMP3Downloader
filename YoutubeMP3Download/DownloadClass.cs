using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos.Streams;

namespace YoutubeMP3Download
{
    internal class DownloadClass
    {
        // Videoyu MP3 olarak indirme işlemi ve ilerleme raporlama
        public async Task DownloadMp3Async(string videoUrl, string outputDir, IProgress<double> progress)
        {
            if (string.IsNullOrWhiteSpace(videoUrl) || string.IsNullOrWhiteSpace(outputDir))
            {
                throw new ArgumentException("Lütfen geçerli bir YouTube URL'si girin ve bir çıkış dizini seçin.");
            }

            try
            {
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(videoUrl);

                // Video akış belgesini al
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                // Ses akışlarını al ve en yüksek bit hızına sahip olanı seç
                var audioStreams = streamManifest.GetAudioStreams();
                var audioStreamInfo = audioStreams.OrderByDescending(s => s.Bitrate).FirstOrDefault();

                if (audioStreamInfo == null)
                {
                    throw new Exception("Belirtilen video için ses akışı bulunamadı.");
                }

                // İndirilecek MP3 dosyasının yolunu ayarla
                var dosyaYolu = Path.Combine(outputDir, $"{video.Title}.mp3");

                // İlerleme ile ses akışını belirtilen dosya yoluna indir
                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, dosyaYolu, progress);
            }
            catch (VideoUnavailableException)
            {
                throw new Exception("Video kullanılamıyor veya kısıtlanmış durumda.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Bir hata oluştu: {ex.Message}");
            }
        }




        // İndirilen dosyaları DataGridView içinde listeleme
        public void ListDownloadedFiles(string outputDir, DataGridView dataGridView)
        {
            try
            {
                // DataGridView'in görünüm ayarlarını yapılandır
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                dataGridView.RowHeadersVisible = false; // Satır başlıklarını gizle
                dataGridView.ColumnHeadersVisible = true; // Sütun başlıklarını göster

                // Dosya adı için sütun ekle
                var fileNameColumn = new DataGridViewTextBoxColumn();
                fileNameColumn.Name = "FileNameColumn";
                fileNameColumn.HeaderText = "İndirilen Dosyalar";
                dataGridView.Columns.Add(fileNameColumn);

                // Sütun başlığını ortalama
                dataGridView.Columns["FileNameColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Hizalama
                dataGridView.Columns["FileNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Genişlik ayarı
                dataGridView.AllowUserToAddRows = false; // Kullanıcıya yeni satır eklemeyi devre dışı bırak
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Çıkış dizinindeki tüm dosyaları al
                var downloadedFiles = Directory.GetFiles(outputDir);

                // .mp3 ve .mp4 dosya adlarını DataGridView içine ekle
                foreach (var file in downloadedFiles)
                {
                    var extension = Path.GetExtension(file);
                    if (extension.Equals(".mp3", StringComparison.OrdinalIgnoreCase) ||
                        extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridView.Rows.Add(Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"İndirilen dosyalar listelenirken bir hata oluştu: {ex.Message}");
            }
        }

    }
}