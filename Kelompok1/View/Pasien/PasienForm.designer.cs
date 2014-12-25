namespace Kelompok1
{
    partial class PasienForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPasien = new System.Windows.Forms.DataGridView();
            this.id_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gol_darah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cekup_pasien = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.radioButtonNama = new System.Windows.Forms.RadioButton();
            this.radioButtonKelamin = new System.Windows.Forms.RadioButton();
            this.comboBoxKelamin = new System.Windows.Forms.ComboBox();
            this.radioButtonAlamat = new System.Windows.Forms.RadioButton();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.grb = new System.Windows.Forms.GroupBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).BeginInit();
            this.grb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasien
            // 
            this.dgvPasien.AllowUserToAddRows = false;
            this.dgvPasien.AllowUserToDeleteRows = false;
            this.dgvPasien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPasien.BackgroundColor = System.Drawing.Color.White;
            this.dgvPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pasien,
            this.nama_pasien,
            this.jenis_kelamin,
            this.tgl_lahir,
            this.alamat,
            this.gol_darah,
            this.no_telepon,
            this.cekup_pasien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPasien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPasien.Location = new System.Drawing.Point(12, 138);
            this.dgvPasien.MultiSelect = false;
            this.dgvPasien.Name = "dgvPasien";
            this.dgvPasien.ReadOnly = true;
            this.dgvPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasien.Size = new System.Drawing.Size(744, 246);
            this.dgvPasien.TabIndex = 0;
            this.dgvPasien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasien_CellClick);
            // 
            // id_pasien
            // 
            this.id_pasien.DataPropertyName = "id_pasien";
            this.id_pasien.HeaderText = "ID";
            this.id_pasien.Name = "id_pasien";
            this.id_pasien.ReadOnly = true;
            // 
            // nama_pasien
            // 
            this.nama_pasien.DataPropertyName = "nama_pasien";
            this.nama_pasien.HeaderText = "Nama Pasien";
            this.nama_pasien.Name = "nama_pasien";
            this.nama_pasien.ReadOnly = true;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.ReadOnly = true;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.DataPropertyName = "tgl_lahir";
            this.tgl_lahir.HeaderText = "Tanggal Lahir";
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // gol_darah
            // 
            this.gol_darah.DataPropertyName = "gol_darah";
            this.gol_darah.HeaderText = "Gol. Darah";
            this.gol_darah.Name = "gol_darah";
            this.gol_darah.ReadOnly = true;
            // 
            // no_telepon
            // 
            this.no_telepon.DataPropertyName = "no_telepon";
            this.no_telepon.HeaderText = "No. Telp.";
            this.no_telepon.Name = "no_telepon";
            this.no_telepon.ReadOnly = true;
            // 
            // cekup_pasien
            // 
            this.cekup_pasien.HeaderText = "";
            this.cekup_pasien.Name = "cekup_pasien";
            this.cekup_pasien.ReadOnly = true;
            this.cekup_pasien.Text = "Cekup";
            this.cekup_pasien.UseColumnTextForButtonValue = true;
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
            // buttonUbah
            // 
            this.buttonUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUbah.ForeColor = System.Drawing.Color.Black;
            this.buttonUbah.Image = global::Kelompok1.Properties.Resources.b_edit;
            this.buttonUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUbah.Location = new System.Drawing.Point(112, 19);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonUbah.Size = new System.Drawing.Size(100, 30);
            this.buttonUbah.TabIndex = 2;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHapus.ForeColor = System.Drawing.Color.Black;
            this.buttonHapus.Image = global::Kelompok1.Properties.Resources.b_drop;
            this.buttonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapus.Location = new System.Drawing.Point(218, 19);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonHapus.Size = new System.Drawing.Size(100, 30);
            this.buttonHapus.TabIndex = 3;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // radioButtonNama
            // 
            this.radioButtonNama.AutoSize = true;
            this.radioButtonNama.Checked = true;
            this.radioButtonNama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonNama.Location = new System.Drawing.Point(11, 20);
            this.radioButtonNama.Name = "radioButtonNama";
            this.radioButtonNama.Size = new System.Drawing.Size(88, 17);
            this.radioButtonNama.TabIndex = 4;
            this.radioButtonNama.TabStop = true;
            this.radioButtonNama.Text = "Nama Pasien";
            this.radioButtonNama.UseVisualStyleBackColor = true;
            this.radioButtonNama.CheckedChanged += new System.EventHandler(this.radioButtonNama_CheckedChanged);
            // 
            // radioButtonKelamin
            // 
            this.radioButtonKelamin.AutoSize = true;
            this.radioButtonKelamin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonKelamin.Location = new System.Drawing.Point(105, 20);
            this.radioButtonKelamin.Name = "radioButtonKelamin";
            this.radioButtonKelamin.Size = new System.Drawing.Size(89, 17);
            this.radioButtonKelamin.TabIndex = 5;
            this.radioButtonKelamin.Text = "Jenis Kelamin";
            this.radioButtonKelamin.UseVisualStyleBackColor = true;
            this.radioButtonKelamin.CheckedChanged += new System.EventHandler(this.radioButtonKelamin_CheckedChanged);
            // 
            // comboBoxKelamin
            // 
            this.comboBoxKelamin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKelamin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKelamin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKelamin.FormattingEnabled = true;
            this.comboBoxKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.comboBoxKelamin.Location = new System.Drawing.Point(441, 18);
            this.comboBoxKelamin.Name = "comboBoxKelamin";
            this.comboBoxKelamin.Size = new System.Drawing.Size(266, 21);
            this.comboBoxKelamin.TabIndex = 6;
            this.comboBoxKelamin.Visible = false;
            // 
            // radioButtonAlamat
            // 
            this.radioButtonAlamat.AutoSize = true;
            this.radioButtonAlamat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonAlamat.Location = new System.Drawing.Point(200, 20);
            this.radioButtonAlamat.Name = "radioButtonAlamat";
            this.radioButtonAlamat.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAlamat.TabIndex = 7;
            this.radioButtonAlamat.Text = "Alamat";
            this.radioButtonAlamat.UseVisualStyleBackColor = true;
            this.radioButtonAlamat.CheckedChanged += new System.EventHandler(this.radioButtonAlamat_CheckedChanged);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCari.Location = new System.Drawing.Point(441, 18);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(266, 20);
            this.textBoxCari.TabIndex = 8;
            // 
            // grb
            // 
            this.grb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grb.BackColor = System.Drawing.Color.Transparent;
            this.grb.Controls.Add(this.radioButtonNama);
            this.grb.Controls.Add(this.buttonCari);
            this.grb.Controls.Add(this.radioButtonKelamin);
            this.grb.Controls.Add(this.textBoxCari);
            this.grb.Controls.Add(this.comboBoxKelamin);
            this.grb.Controls.Add(this.radioButtonAlamat);
            this.grb.ForeColor = System.Drawing.Color.White;
            this.grb.Location = new System.Drawing.Point(12, 82);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(744, 50);
            this.grb.TabIndex = 10;
            this.grb.TabStop = false;
            this.grb.Text = "Cari";
            // 
            // buttonCari
            // 
            this.buttonCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCari.BackColor = System.Drawing.Color.Transparent;
            this.buttonCari.BackgroundImage = global::Kelompok1.Properties.Resources.b_search;
            this.buttonCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCari.Location = new System.Drawing.Point(713, 16);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(24, 24);
            this.buttonCari.TabIndex = 9;
            this.buttonCari.UseVisualStyleBackColor = false;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonHapus);
            this.groupBox1.Controls.Add(this.buttonTambah);
            this.groupBox1.Controls.Add(this.buttonUbah);
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
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Daftar Pasien";
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
            // PasienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.dgvPasien);
            this.MinimumSize = new System.Drawing.Size(784, 496);
            this.Name = "PasienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pasien";
            this.Load += new System.EventHandler(this.PasienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasien;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.RadioButton radioButtonNama;
        private System.Windows.Forms.RadioButton radioButtonKelamin;
        private System.Windows.Forms.ComboBox comboBoxKelamin;
        private System.Windows.Forms.RadioButton radioButtonAlamat;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gol_darah;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_telepon;
        private System.Windows.Forms.DataGridViewButtonColumn cekup_pasien;
    }
}