namespace Kelompok1
{
    partial class FormCekup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tboxDosis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxObat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTambahObat = new System.Windows.Forms.Button();
            this.dgvObat = new System.Windows.Forms.DataGridView();
            this.id_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_obat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTambahPenyakit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxPenyakit = new System.Windows.Forms.ComboBox();
            this.dgvPenyakit = new System.Windows.Forms.DataGridView();
            this.id_penyakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_penyakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus_penyakit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTanggal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.tboxBiaya = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tboxDosis);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboxObat);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonTambahObat);
            this.groupBox3.Controls.Add(this.dgvObat);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 191);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Obat";
            // 
            // tboxDosis
            // 
            this.tboxDosis.Location = new System.Drawing.Point(239, 25);
            this.tboxDosis.Name = "tboxDosis";
            this.tboxDosis.Size = new System.Drawing.Size(128, 20);
            this.tboxDosis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dosis";
            // 
            // cboxObat
            // 
            this.cboxObat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxObat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxObat.FormattingEnabled = true;
            this.cboxObat.Location = new System.Drawing.Point(73, 25);
            this.cboxObat.Name = "cboxObat";
            this.cboxObat.Size = new System.Drawing.Size(121, 21);
            this.cboxObat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Obat";
            // 
            // buttonTambahObat
            // 
            this.buttonTambahObat.ForeColor = System.Drawing.Color.Black;
            this.buttonTambahObat.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttonTambahObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambahObat.Location = new System.Drawing.Point(373, 19);
            this.buttonTambahObat.Name = "buttonTambahObat";
            this.buttonTambahObat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonTambahObat.Size = new System.Drawing.Size(100, 30);
            this.buttonTambahObat.TabIndex = 5;
            this.buttonTambahObat.Text = "Tambah";
            this.buttonTambahObat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambahObat.UseVisualStyleBackColor = true;
            this.buttonTambahObat.Click += new System.EventHandler(this.buttonTambahObat_Click);
            // 
            // dgvObat
            // 
            this.dgvObat.AllowUserToAddRows = false;
            this.dgvObat.AllowUserToDeleteRows = false;
            this.dgvObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObat.BackgroundColor = System.Drawing.Color.White;
            this.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_obat,
            this.nama_obat,
            this.dosis,
            this.hapus_obat});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObat.Location = new System.Drawing.Point(6, 55);
            this.dgvObat.MultiSelect = false;
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.ReadOnly = true;
            this.dgvObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObat.Size = new System.Drawing.Size(467, 131);
            this.dgvObat.TabIndex = 0;
            this.dgvObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObat_CellClick);
            // 
            // id_obat
            // 
            this.id_obat.DataPropertyName = "id_obat";
            this.id_obat.HeaderText = "ID";
            this.id_obat.Name = "id_obat";
            this.id_obat.ReadOnly = true;
            // 
            // nama_obat
            // 
            this.nama_obat.DataPropertyName = "nama_obat";
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.ReadOnly = true;
            // 
            // dosis
            // 
            this.dosis.DataPropertyName = "dosis";
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            this.dosis.ReadOnly = true;
            // 
            // hapus_obat
            // 
            this.hapus_obat.HeaderText = "";
            this.hapus_obat.Name = "hapus_obat";
            this.hapus_obat.ReadOnly = true;
            this.hapus_obat.Text = "Hapus";
            this.hapus_obat.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonTambahPenyakit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxPenyakit);
            this.groupBox2.Controls.Add(this.dgvPenyakit);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Penyakit";
            // 
            // buttonTambahPenyakit
            // 
            this.buttonTambahPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTambahPenyakit.ForeColor = System.Drawing.Color.Black;
            this.buttonTambahPenyakit.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttonTambahPenyakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambahPenyakit.Location = new System.Drawing.Point(373, 19);
            this.buttonTambahPenyakit.Name = "buttonTambahPenyakit";
            this.buttonTambahPenyakit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonTambahPenyakit.Size = new System.Drawing.Size(100, 30);
            this.buttonTambahPenyakit.TabIndex = 4;
            this.buttonTambahPenyakit.Text = "Tambah";
            this.buttonTambahPenyakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambahPenyakit.UseVisualStyleBackColor = true;
            this.buttonTambahPenyakit.Click += new System.EventHandler(this.buttonTambahPenyakit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Penyakit";
            // 
            // cboxPenyakit
            // 
            this.cboxPenyakit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPenyakit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPenyakit.FormattingEnabled = true;
            this.cboxPenyakit.Location = new System.Drawing.Point(107, 23);
            this.cboxPenyakit.Name = "cboxPenyakit";
            this.cboxPenyakit.Size = new System.Drawing.Size(260, 21);
            this.cboxPenyakit.TabIndex = 1;
            // 
            // dgvPenyakit
            // 
            this.dgvPenyakit.AllowUserToAddRows = false;
            this.dgvPenyakit.AllowUserToDeleteRows = false;
            this.dgvPenyakit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenyakit.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenyakit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenyakit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_penyakit,
            this.nama_penyakit,
            this.hapus_penyakit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPenyakit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPenyakit.Location = new System.Drawing.Point(6, 55);
            this.dgvPenyakit.MultiSelect = false;
            this.dgvPenyakit.Name = "dgvPenyakit";
            this.dgvPenyakit.ReadOnly = true;
            this.dgvPenyakit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenyakit.Size = new System.Drawing.Size(467, 131);
            this.dgvPenyakit.TabIndex = 0;
            this.dgvPenyakit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenyakit_CellClick);
            // 
            // id_penyakit
            // 
            this.id_penyakit.HeaderText = "ID";
            this.id_penyakit.Name = "id_penyakit";
            this.id_penyakit.ReadOnly = true;
            // 
            // nama_penyakit
            // 
            this.nama_penyakit.HeaderText = "Nama Penyakit";
            this.nama_penyakit.Name = "nama_penyakit";
            this.nama_penyakit.ReadOnly = true;
            // 
            // hapus_penyakit
            // 
            this.hapus_penyakit.HeaderText = "";
            this.hapus_penyakit.Name = "hapus_penyakit";
            this.hapus_penyakit.ReadOnly = true;
            this.hapus_penyakit.Text = "Hapus";
            this.hapus_penyakit.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTanggal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNamaPasien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Cekup";
            // 
            // txtTanggal
            // 
            this.txtTanggal.AutoSize = true;
            this.txtTanggal.Location = new System.Drawing.Point(112, 50);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(65, 13);
            this.txtTanggal.TabIndex = 3;
            this.txtTanggal.Text = "10/10/2010";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tanggal Cekup";
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.AutoSize = true;
            this.txtNamaPasien.Location = new System.Drawing.Point(112, 24);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(164, 13);
            this.txtNamaPasien.TabIndex = 1;
            this.txtNamaPasien.Text = "Muhammad Resna Rizki Pratama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pasien";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox4.Controls.Add(this.labelJudul);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(-1, -9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 75);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(95, 25);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(157, 31);
            this.labelJudul.TabIndex = 16;
            this.labelJudul.Text = "Cekup Baru";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(-3, 564);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(507, 54);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(503, 618);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSimpan.Image = global::Kelompok1.Properties.Resources.b_save;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(391, 576);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSimpan.Size = new System.Drawing.Size(100, 30);
            this.buttonSimpan.TabIndex = 10;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // tboxBiaya
            // 
            this.tboxBiaya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxBiaya.Location = new System.Drawing.Point(91, 582);
            this.tboxBiaya.Name = "tboxBiaya";
            this.tboxBiaya.Size = new System.Drawing.Size(128, 20);
            this.tboxBiaya.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Biaya Cekup";
            // 
            // FormCekup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 618);
            this.Controls.Add(this.tboxBiaya);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCekup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCekup";
            this.Load += new System.EventHandler(this.FormCekup_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvObat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPenyakit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtTanggal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtNamaPasien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxPenyakit;
        private System.Windows.Forms.TextBox tboxDosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxObat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTambahObat;
        private System.Windows.Forms.Button buttonTambahPenyakit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox tboxBiaya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewButtonColumn hapus_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_penyakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_penyakit;
        private System.Windows.Forms.DataGridViewButtonColumn hapus_penyakit;

    }
}