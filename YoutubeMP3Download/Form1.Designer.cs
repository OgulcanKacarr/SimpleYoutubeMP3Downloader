namespace YoutubeMP3Download
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_download_url = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.button_download = new System.Windows.Forms.Button();
            this.button_select_path = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_from = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_open_folder = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_download_url
            // 
            this.textBox_download_url.Location = new System.Drawing.Point(106, 37);
            this.textBox_download_url.Name = "textBox_download_url";
            this.textBox_download_url.Size = new System.Drawing.Size(582, 20);
            this.textBox_download_url.TabIndex = 0;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_text.Location = new System.Drawing.Point(38, 31);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(62, 26);
            this.label_text.TabIndex = 1;
            this.label_text.Text = "URL:";
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(695, 35);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(75, 23);
            this.button_download.TabIndex = 2;
            this.button_download.Text = "İNDİR";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click_1);
            // 
            // button_select_path
            // 
            this.button_select_path.Location = new System.Drawing.Point(694, 76);
            this.button_select_path.Name = "button_select_path";
            this.button_select_path.Size = new System.Drawing.Size(75, 23);
            this.button_select_path.TabIndex = 3;
            this.button_select_path.Text = "Gözat";
            this.button_select_path.UseVisualStyleBackColor = true;
            this.button_select_path.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(106, 76);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(582, 20);
            this.textBox_path.TabIndex = 4;
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_path.Location = new System.Drawing.Point(12, 70);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(88, 26);
            this.label_path.TabIndex = 1;
            this.label_path.Text = "Konum:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(106, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(582, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_from.ForeColor = System.Drawing.Color.Black;
            this.label_from.Location = new System.Drawing.Point(332, 433);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(27, 13);
            this.label_from.TabIndex = 6;
            this.label_from.Text = "from";
            this.label_from.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(365, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oğulcan KAÇAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 264);
            this.dataGridView1.TabIndex = 8;
            // 
            // button_open_folder
            // 
            this.button_open_folder.Location = new System.Drawing.Point(695, 105);
            this.button_open_folder.Name = "button_open_folder";
            this.button_open_folder.Size = new System.Drawing.Size(75, 23);
            this.button_open_folder.TabIndex = 9;
            this.button_open_folder.Text = "Konuma git";
            this.button_open_folder.UseVisualStyleBackColor = true;
            this.button_open_folder.Click += new System.EventHandler(this.button_open_folder_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(304, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(198, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.github.com/OgulcanKacarr";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(353, 105);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(82, 13);
            this.label_status.TabIndex = 12;
            this.label_status.Text = "indirme başladı..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_open_folder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_select_path);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.textBox_download_url);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube MP3 Download";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_download_url;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button_select_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_open_folder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_status;
    }
}

