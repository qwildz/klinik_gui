namespace Kelompok1
{
    partial class CekupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCekup = new System.Windows.Forms.DataGridView();
            this.id_cekup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biaya_cekup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_cekup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_cekup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelGoldarah = new System.Windows.Forms.Label();
            this.labelLahir = new System.Windows.Forms.Label();
            this.labelKelamin = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKartu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCekup
            // 
            this.dgvCekup.AllowUserToAddRows = false;
            this.dgvCekup.AllowUserToDeleteRows = false;
            this.dgvCekup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCekup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCekup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCekup.BackgroundColor = System.Drawing.Color.White;
            this.dgvCekup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCekup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cekup,
            this.nama_dokter,
            this.biaya_cekup,
            this.tanggal_cekup,
            this.detail_cekup});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCekup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCekup.Location = new System.Drawing.Point(12, 161);
            this.dgvCekup.MultiSelect = false;
            this.dgvCekup.Name = "dgvCekup";
            this.dgvCekup.ReadOnly = true;
            this.dgvCekup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCekup.Size = new System.Drawing.Size(744, 223);
            this.dgvCekup.TabIndex = 0;
            this.dgvCekup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCekup_CellClick);
            // 
            // id_cekup
            // 
            this.id_cekup.DataPropertyName = "id_cekup";
            this.id_cekup.HeaderText = "ID";
            this.id_cekup.Name = "id_cekup";
            this.id_cekup.ReadOnly = true;
            // 
            // nama_dokter
            // 
            this.nama_dokter.DataPropertyName = "nama_dokter";
            this.nama_dokter.HeaderText = "Pemeriksa";
            this.nama_dokter.Name = "nama_dokter";
            this.nama_dokter.ReadOnly = true;
            // 
            // biaya_cekup
            // 
            this.biaya_cekup.DataPropertyName = "biaya_cekup";
            this.biaya_cekup.HeaderText = "Biaya Cekup";
            this.biaya_cekup.Name = "biaya_cekup";
            this.biaya_cekup.ReadOnly = true;
            // 
            // tanggal_cekup
            // 
            this.tanggal_cekup.DataPropertyName = "tanggal_cekup";
            this.tanggal_cekup.HeaderText = "Tanggal Cekup";
            this.tanggal_cekup.Name = "tanggal_cekup";
            this.tanggal_cekup.ReadOnly = true;
            // 
            // detail_cekup
            // 
            this.detail_cekup.Name = "detail_cekup";
            this.detail_cekup.ReadOnly = true;
            this.detail_cekup.Text = "Detail Cekup";
            this.detail_cekup.UseColumnTextForButtonValue = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Black;
            this.buttonTambah.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambah.Location = new System.Drawing.Point(6, 19);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonTambah.Size = new System.Drawing.Size(100, 30);
            this.buttonTambah.TabIndex = 1;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHapus.ForeColor = System.Drawing.Color.Black;
            this.buttonHapus.Image = global::Kelompok1.Properties.Resources.b_drop;
            this.buttonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapus.Location = new System.Drawing.Point(112, 19);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonHapus.Size = new System.Drawing.Size(100, 30);
            this.buttonHapus.TabIndex = 3;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonKartu);
            this.groupBox1.Controls.Add(this.buttonHapus);
            this.groupBox1.Controls.Add(this.buttonTambah);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(-15, -6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Cekup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.labelGoldarah);
            this.groupBox3.Controls.Add(this.labelLahir);
            this.groupBox3.Controls.Add(this.labelKelamin);
            this.groupBox3.Controls.Add(this.labelNama);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 70);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail Pasien";
            // 
            // labelGoldarah
            // 
            this.labelGoldarah.AutoSize = true;
            this.labelGoldarah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoldarah.Location = new System.Drawing.Point(455, 43);
            this.labelGoldarah.Name = "labelGoldarah";
            this.labelGoldarah.Size = new System.Drawing.Size(110, 13);
            this.labelGoldarah.TabIndex = 20;
            this.labelGoldarah.Text = "Muhammad Resna";
            // 
            // labelLahir
            // 
            this.labelLahir.AutoSize = true;
            this.labelLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLahir.Location = new System.Drawing.Point(455, 22);
            this.labelLahir.Name = "labelLahir";
            this.labelLahir.Size = new System.Drawing.Size(110, 13);
            this.labelLahir.TabIndex = 19;
            this.labelLahir.Text = "Muhammad Resna";
            // 
            // labelKelamin
            // 
            this.labelKelamin.AutoSize = true;
            this.labelKelamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelamin.Location = new System.Drawing.Point(102, 43);
            this.labelKelamin.Name = "labelKelamin";
            this.labelKelamin.Size = new System.Drawing.Size(110, 13);
            this.labelKelamin.TabIndex = 18;
            this.labelKelamin.Text = "Muhammad Resna";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(102, 22);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(110, 13);
            this.labelNama.TabIndex = 17;
            this.labelNama.Text = "Muhammad Resna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gol. Darah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // buttonKartu
            // 
            this.buttonKartu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonKartu.ForeColor = System.Drawing.Color.Black;
            this.buttonKartu.Image = global::Kelompok1.Properties.Resources.b_browse;
            this.buttonKartu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKartu.Location = new System.Drawing.Point(218, 19);
            this.buttonKartu.Name = "buttonKartu";
            this.buttonKartu.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonKartu.Size = new System.Drawing.Size(128, 30);
            this.buttonKartu.TabIndex = 4;
            this.buttonKartu.Text = "Kartu Cekup";
            this.buttonKartu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKartu.UseVisualStyleBackColor = true;
            this.buttonKartu.Click += new System.EventHandler(this.buttonKartu_Click);
            // 
            // CekupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCekup);
            this.MinimumSize = new System.Drawing.Size(784, 496);
            this.Name = "CekupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pasien";
            this.Load += new System.EventHandler(this.CekupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCekup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCekup;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGoldarah;
        private System.Windows.Forms.Label labelLahir;
        private System.Windows.Forms.Label labelKelamin;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cekup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biaya_cekup;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_cekup;
        private System.Windows.Forms.DataGridViewButtonColumn detail_cekup;
        private System.Windows.Forms.Button buttonKartu;
    }
}