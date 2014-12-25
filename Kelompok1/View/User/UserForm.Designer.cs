namespace Kelompok1
{
    partial class UserForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCariPenyakit = new System.Windows.Forms.Button();
            this.textBoxCariPenyakit = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.GroupBox();
            this.buttonHapusPenyakit = new System.Windows.Forms.Button();
            this.buttontambah = new System.Windows.Forms.Button();
            this.buttonUbahPenyakit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPenyakit = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.btnPass.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonCariPenyakit);
            this.groupBox2.Controls.Add(this.textBoxCariPenyakit);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 50);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari";
            // 
            // buttonCariPenyakit
            // 
            this.buttonCariPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCariPenyakit.BackgroundImage = global::Kelompok1.Properties.Resources.b_search;
            this.buttonCariPenyakit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCariPenyakit.ForeColor = System.Drawing.Color.Black;
            this.buttonCariPenyakit.Location = new System.Drawing.Point(723, 16);
            this.buttonCariPenyakit.Name = "buttonCariPenyakit";
            this.buttonCariPenyakit.Size = new System.Drawing.Size(25, 25);
            this.buttonCariPenyakit.TabIndex = 6;
            this.buttonCariPenyakit.UseVisualStyleBackColor = true;
            // 
            // textBoxCariPenyakit
            // 
            this.textBoxCariPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCariPenyakit.Location = new System.Drawing.Point(511, 19);
            this.textBoxCariPenyakit.Name = "textBoxCariPenyakit";
            this.textBoxCariPenyakit.Size = new System.Drawing.Size(206, 20);
            this.textBoxCariPenyakit.TabIndex = 7;
            // 
            // btnPass
            // 
            this.btnPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPass.BackColor = System.Drawing.Color.Transparent;
            this.btnPass.Controls.Add(this.button1);
            this.btnPass.Controls.Add(this.buttonHapusPenyakit);
            this.btnPass.Controls.Add(this.buttontambah);
            this.btnPass.Controls.Add(this.buttonUbahPenyakit);
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.Location = new System.Drawing.Point(8, 417);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(754, 55);
            this.btnPass.TabIndex = 15;
            this.btnPass.TabStop = false;
            this.btnPass.Text = "Tools";
            // 
            // buttonHapusPenyakit
            // 
            this.buttonHapusPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHapusPenyakit.ForeColor = System.Drawing.Color.Black;
            this.buttonHapusPenyakit.Image = global::Kelompok1.Properties.Resources.b_drop;
            this.buttonHapusPenyakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapusPenyakit.Location = new System.Drawing.Point(218, 19);
            this.buttonHapusPenyakit.Name = "buttonHapusPenyakit";
            this.buttonHapusPenyakit.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonHapusPenyakit.Size = new System.Drawing.Size(100, 30);
            this.buttonHapusPenyakit.TabIndex = 9;
            this.buttonHapusPenyakit.Text = "Hapus";
            this.buttonHapusPenyakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHapusPenyakit.UseVisualStyleBackColor = true;
            this.buttonHapusPenyakit.Click += new System.EventHandler(this.buttonHapusPenyakit_Click);
            // 
            // buttontambah
            // 
            this.buttontambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttontambah.ForeColor = System.Drawing.Color.Black;
            this.buttontambah.Image = global::Kelompok1.Properties.Resources.plus;
            this.buttontambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttontambah.Location = new System.Drawing.Point(6, 19);
            this.buttontambah.Name = "buttontambah";
            this.buttontambah.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttontambah.Size = new System.Drawing.Size(100, 30);
            this.buttontambah.TabIndex = 1;
            this.buttontambah.Text = "Tambah";
            this.buttontambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttontambah.UseVisualStyleBackColor = true;
            this.buttontambah.Click += new System.EventHandler(this.buttontambah_Click);
            // 
            // buttonUbahPenyakit
            // 
            this.buttonUbahPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUbahPenyakit.ForeColor = System.Drawing.Color.Black;
            this.buttonUbahPenyakit.Image = global::Kelompok1.Properties.Resources.b_edit;
            this.buttonUbahPenyakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUbahPenyakit.Location = new System.Drawing.Point(112, 19);
            this.buttonUbahPenyakit.Name = "buttonUbahPenyakit";
            this.buttonUbahPenyakit.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.buttonUbahPenyakit.Size = new System.Drawing.Size(100, 30);
            this.buttonUbahPenyakit.TabIndex = 8;
            this.buttonUbahPenyakit.Text = "Ubah";
            this.buttonUbahPenyakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUbahPenyakit.UseVisualStyleBackColor = true;
            this.buttonUbahPenyakit.Click += new System.EventHandler(this.buttonUbahPenyakit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(-7, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 76);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPenyakit
            // 
            this.dgvPenyakit.AllowUserToAddRows = false;
            this.dgvPenyakit.AllowUserToDeleteRows = false;
            this.dgvPenyakit.AllowUserToResizeColumns = false;
            this.dgvPenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenyakit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenyakit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPenyakit.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenyakit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenyakit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.username,
            this.level,
            this.id_dokter,
            this.nama_dokter});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPenyakit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPenyakit.Location = new System.Drawing.Point(8, 149);
            this.dgvPenyakit.MultiSelect = false;
            this.dgvPenyakit.Name = "dgvPenyakit";
            this.dgvPenyakit.ReadOnly = true;
            this.dgvPenyakit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenyakit.Size = new System.Drawing.Size(754, 256);
            this.dgvPenyakit.TabIndex = 13;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "ID User";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // id_dokter
            // 
            this.id_dokter.DataPropertyName = "id_dokter";
            this.id_dokter.HeaderText = "ID Dokter";
            this.id_dokter.Name = "id_dokter";
            this.id_dokter.ReadOnly = true;
            this.id_dokter.Visible = false;
            // 
            // nama_dokter
            // 
            this.nama_dokter.DataPropertyName = "nama_dokter";
            this.nama_dokter.HeaderText = "User Dokter";
            this.nama_dokter.Name = "nama_dokter";
            this.nama_dokter.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Kelompok1.Properties.Resources.b_primary;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(324, 19);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 17, 0);
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ubah Password";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPenyakit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.btnPass.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCariPenyakit;
        private System.Windows.Forms.TextBox textBoxCariPenyakit;
        private System.Windows.Forms.GroupBox btnPass;
        private System.Windows.Forms.Button buttonHapusPenyakit;
        private System.Windows.Forms.Button buttontambah;
        private System.Windows.Forms.Button buttonUbahPenyakit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPenyakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_dokter;
        private System.Windows.Forms.Button button1;

    }
}