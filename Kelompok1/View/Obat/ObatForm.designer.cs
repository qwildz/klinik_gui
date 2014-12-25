namespace Kelompok1
{
    partial class ObatForm
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
            this.dgvObat = new System.Windows.Forms.DataGridView();
            this.buttonTambahObat = new System.Windows.Forms.Button();
            this.buttonUbahObat = new System.Windows.Forms.Button();
            this.buttonHapusObat = new System.Windows.Forms.Button();
            this.buttonCariObat = new System.Windows.Forms.Button();
            this.textBoxCariObat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObat
            // 
            this.dgvObat.AllowUserToAddRows = false;
            this.dgvObat.AllowUserToDeleteRows = false;
            this.dgvObat.AllowUserToResizeColumns = false;
            this.dgvObat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObat.BackgroundColor = System.Drawing.Color.White;
            this.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObat.Location = new System.Drawing.Point(12, 149);
            this.dgvObat.MultiSelect = false;
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.ReadOnly = true;
            this.dgvObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObat.Size = new System.Drawing.Size(754, 246);
            this.dgvObat.TabIndex = 0;
            // 
            // buttonTambahObat
            // 
            this.buttonTambahObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTambahObat.ForeColor = System.Drawing.Color.Black;
            this.buttonTambahObat.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttonTambahObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambahObat.Location = new System.Drawing.Point(6, 19);
            this.buttonTambahObat.Name = "buttonTambahObat";
            this.buttonTambahObat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonTambahObat.Size = new System.Drawing.Size(100, 30);
            this.buttonTambahObat.TabIndex = 1;
            this.buttonTambahObat.Text = "Tambah";
            this.buttonTambahObat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambahObat.UseVisualStyleBackColor = true;
            this.buttonTambahObat.Click += new System.EventHandler(this.buttonTambahObat_Click);
            // 
            // buttonUbahObat
            // 
            this.buttonUbahObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUbahObat.ForeColor = System.Drawing.Color.Black;
            this.buttonUbahObat.Image = global::Kelompok1.Properties.Resources.b_edit;
            this.buttonUbahObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUbahObat.Location = new System.Drawing.Point(112, 19);
            this.buttonUbahObat.Name = "buttonUbahObat";
            this.buttonUbahObat.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonUbahObat.Size = new System.Drawing.Size(100, 30);
            this.buttonUbahObat.TabIndex = 2;
            this.buttonUbahObat.Text = "Ubah";
            this.buttonUbahObat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUbahObat.UseVisualStyleBackColor = true;
            this.buttonUbahObat.Click += new System.EventHandler(this.buttonUbahObat_Click);
            // 
            // buttonHapusObat
            // 
            this.buttonHapusObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHapusObat.ForeColor = System.Drawing.Color.Black;
            this.buttonHapusObat.Image = global::Kelompok1.Properties.Resources.b_drop;
            this.buttonHapusObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapusObat.Location = new System.Drawing.Point(218, 19);
            this.buttonHapusObat.Name = "buttonHapusObat";
            this.buttonHapusObat.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonHapusObat.Size = new System.Drawing.Size(100, 30);
            this.buttonHapusObat.TabIndex = 3;
            this.buttonHapusObat.Text = "Hapus";
            this.buttonHapusObat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHapusObat.UseVisualStyleBackColor = true;
            this.buttonHapusObat.Click += new System.EventHandler(this.buttonHapusObat_Click);
            // 
            // buttonCariObat
            // 
            this.buttonCariObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCariObat.BackgroundImage = global::Kelompok1.Properties.Resources.b_search;
            this.buttonCariObat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCariObat.ForeColor = System.Drawing.Color.White;
            this.buttonCariObat.Location = new System.Drawing.Point(723, 16);
            this.buttonCariObat.Name = "buttonCariObat";
            this.buttonCariObat.Size = new System.Drawing.Size(25, 25);
            this.buttonCariObat.TabIndex = 4;
            this.buttonCariObat.UseVisualStyleBackColor = true;
            this.buttonCariObat.Click += new System.EventHandler(this.buttonCariObat_Click);
            // 
            // textBoxCariObat
            // 
            this.textBoxCariObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCariObat.Location = new System.Drawing.Point(511, 19);
            this.textBoxCariObat.Name = "textBoxCariObat";
            this.textBoxCariObat.Size = new System.Drawing.Size(206, 20);
            this.textBoxCariObat.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonTambahObat);
            this.groupBox1.Controls.Add(this.buttonUbahObat);
            this.groupBox1.Controls.Add(this.buttonHapusObat);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxCariObat);
            this.groupBox2.Controls.Add(this.buttonCariObat);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(-3, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 75);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Obat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ObatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvObat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ObatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ObatForm";
            this.Load += new System.EventHandler(this.ObatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObat;
        private System.Windows.Forms.Button buttonTambahObat;
        private System.Windows.Forms.Button buttonUbahObat;
        private System.Windows.Forms.Button buttonHapusObat;
        private System.Windows.Forms.Button buttonCariObat;
        private System.Windows.Forms.TextBox textBoxCariObat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}