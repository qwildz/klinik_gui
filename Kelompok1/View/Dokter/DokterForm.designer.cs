namespace Kelompok1
{
    partial class DokterForm
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
            this.dgvDokter = new System.Windows.Forms.DataGridView();
            this.buttonTambahDokter = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.radioButtonNDokter = new System.Windows.Forms.RadioButton();
            this.radioButtonSpesialis = new System.Windows.Forms.RadioButton();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.groupBoxCari = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxCari.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDokter
            // 
            this.dgvDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDokter.BackgroundColor = System.Drawing.Color.White;
            this.dgvDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokter.Location = new System.Drawing.Point(12, 124);
            this.dgvDokter.Name = "dgvDokter";
            this.dgvDokter.ReadOnly = true;
            this.dgvDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDokter.Size = new System.Drawing.Size(699, 216);
            this.dgvDokter.TabIndex = 0;
            // 
            // buttonTambahDokter
            // 
            this.buttonTambahDokter.ForeColor = System.Drawing.Color.Black;
            this.buttonTambahDokter.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttonTambahDokter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambahDokter.Location = new System.Drawing.Point(6, 19);
            this.buttonTambahDokter.Name = "buttonTambahDokter";
            this.buttonTambahDokter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonTambahDokter.Size = new System.Drawing.Size(100, 30);
            this.buttonTambahDokter.TabIndex = 1;
            this.buttonTambahDokter.Text = "Tambah";
            this.buttonTambahDokter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambahDokter.UseVisualStyleBackColor = true;
            this.buttonTambahDokter.Click += new System.EventHandler(this.buttonTambahDokter_Click);
            // 
            // buttonUbah
            // 
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
            // buttonCari
            // 
            this.buttonCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCari.BackgroundImage = global::Kelompok1.Properties.Resources.b_search;
            this.buttonCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCari.ForeColor = System.Drawing.Color.Black;
            this.buttonCari.Location = new System.Drawing.Point(667, 16);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(25, 25);
            this.buttonCari.TabIndex = 3;
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCari.ForeColor = System.Drawing.Color.Black;
            this.textBoxCari.Location = new System.Drawing.Point(464, 19);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(197, 20);
            this.textBoxCari.TabIndex = 4;
            // 
            // radioButtonNDokter
            // 
            this.radioButtonNDokter.AutoSize = true;
            this.radioButtonNDokter.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNDokter.ForeColor = System.Drawing.Color.White;
            this.radioButtonNDokter.Location = new System.Drawing.Point(13, 20);
            this.radioButtonNDokter.Name = "radioButtonNDokter";
            this.radioButtonNDokter.Size = new System.Drawing.Size(57, 17);
            this.radioButtonNDokter.TabIndex = 5;
            this.radioButtonNDokter.TabStop = true;
            this.radioButtonNDokter.Text = "Dokter";
            this.radioButtonNDokter.UseVisualStyleBackColor = false;
            // 
            // radioButtonSpesialis
            // 
            this.radioButtonSpesialis.AutoSize = true;
            this.radioButtonSpesialis.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSpesialis.ForeColor = System.Drawing.Color.White;
            this.radioButtonSpesialis.Location = new System.Drawing.Point(76, 20);
            this.radioButtonSpesialis.Name = "radioButtonSpesialis";
            this.radioButtonSpesialis.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSpesialis.TabIndex = 6;
            this.radioButtonSpesialis.TabStop = true;
            this.radioButtonSpesialis.Text = "Spesialis";
            this.radioButtonSpesialis.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            this.buttonHapus.ForeColor = System.Drawing.Color.Black;
            this.buttonHapus.Image = global::Kelompok1.Properties.Resources.b_drop;
            this.buttonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapus.Location = new System.Drawing.Point(218, 19);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonHapus.Size = new System.Drawing.Size(100, 30);
            this.buttonHapus.TabIndex = 7;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTools.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTools.Controls.Add(this.buttonTambahDokter);
            this.groupBoxTools.Controls.Add(this.buttonHapus);
            this.groupBoxTools.Controls.Add(this.buttonUbah);
            this.groupBoxTools.ForeColor = System.Drawing.Color.White;
            this.groupBoxTools.Location = new System.Drawing.Point(12, 346);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(699, 55);
            this.groupBoxTools.TabIndex = 8;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools";
            // 
            // groupBoxCari
            // 
            this.groupBoxCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCari.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCari.Controls.Add(this.buttonCari);
            this.groupBoxCari.Controls.Add(this.radioButtonSpesialis);
            this.groupBoxCari.Controls.Add(this.textBoxCari);
            this.groupBoxCari.Controls.Add(this.radioButtonNDokter);
            this.groupBoxCari.ForeColor = System.Drawing.Color.White;
            this.groupBoxCari.Location = new System.Drawing.Point(13, 68);
            this.groupBoxCari.Name = "groupBoxCari";
            this.groupBoxCari.Size = new System.Drawing.Size(698, 50);
            this.groupBoxCari.TabIndex = 9;
            this.groupBoxCari.TabStop = false;
            this.groupBoxCari.Text = "Cari";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Dokter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DokterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDokter);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.groupBoxCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DokterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokter";
            this.Load += new System.EventHandler(this.DokterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).EndInit();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxCari.ResumeLayout(false);
            this.groupBoxCari.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDokter;
        private System.Windows.Forms.Button buttonTambahDokter;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.RadioButton radioButtonNDokter;
        private System.Windows.Forms.RadioButton radioButtonSpesialis;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxCari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}