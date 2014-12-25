namespace Kelompok1
{
    partial class FormUser
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
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPasswordKonfirmasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxDokter = new System.Windows.Forms.ComboBox();
            this.lDokter = new System.Windows.Forms.Label();
            this.lLevel = new System.Windows.Forms.Label();
            this.cboxLevel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxUsername
            // 
            this.tboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxUsername.Location = new System.Drawing.Point(151, 83);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(163, 20);
            this.tboxUsername.TabIndex = 10;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.BackColor = System.Drawing.Color.Transparent;
            this.lUsername.ForeColor = System.Drawing.Color.White;
            this.lUsername.Location = new System.Drawing.Point(12, 86);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 9;
            this.lUsername.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox1.Controls.Add(this.labelJudul);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-3, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(95, 20);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(178, 31);
            this.labelJudul.TabIndex = 16;
            this.labelJudul.Text = "Tambah User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Image = global::Kelompok1.Properties.Resources.b_save;
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpan.Location = new System.Drawing.Point(214, 238);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(-4, 226);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(349, 54);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(328, 280);
            this.shapeContainer2.TabIndex = 13;
            this.shapeContainer2.TabStop = false;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxPassword.Location = new System.Drawing.Point(151, 109);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(163, 20);
            this.tboxPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // tboxPasswordKonfirmasi
            // 
            this.tboxPasswordKonfirmasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxPasswordKonfirmasi.Location = new System.Drawing.Point(151, 135);
            this.tboxPasswordKonfirmasi.Name = "tboxPasswordKonfirmasi";
            this.tboxPasswordKonfirmasi.PasswordChar = '*';
            this.tboxPasswordKonfirmasi.Size = new System.Drawing.Size(163, 20);
            this.tboxPasswordKonfirmasi.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Konfirmasi Password";
            // 
            // cboxDokter
            // 
            this.cboxDokter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxDokter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxDokter.FormattingEnabled = true;
            this.cboxDokter.Location = new System.Drawing.Point(151, 188);
            this.cboxDokter.Name = "cboxDokter";
            this.cboxDokter.Size = new System.Drawing.Size(163, 21);
            this.cboxDokter.TabIndex = 18;
            // 
            // lDokter
            // 
            this.lDokter.AutoSize = true;
            this.lDokter.BackColor = System.Drawing.Color.Transparent;
            this.lDokter.ForeColor = System.Drawing.Color.White;
            this.lDokter.Location = new System.Drawing.Point(12, 191);
            this.lDokter.Name = "lDokter";
            this.lDokter.Size = new System.Drawing.Size(64, 13);
            this.lDokter.TabIndex = 19;
            this.lDokter.Text = "User Dokter";
            // 
            // lLevel
            // 
            this.lLevel.AutoSize = true;
            this.lLevel.BackColor = System.Drawing.Color.Transparent;
            this.lLevel.ForeColor = System.Drawing.Color.White;
            this.lLevel.Location = new System.Drawing.Point(12, 164);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(33, 13);
            this.lLevel.TabIndex = 21;
            this.lLevel.Text = "Level";
            // 
            // cboxLevel
            // 
            this.cboxLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxLevel.FormattingEnabled = true;
            this.cboxLevel.Items.AddRange(new object[] {
            "admin",
            "dokter",
            "resepsionis"});
            this.cboxLevel.Location = new System.Drawing.Point(151, 161);
            this.cboxLevel.Name = "cboxLevel";
            this.cboxLevel.Size = new System.Drawing.Size(163, 21);
            this.cboxLevel.TabIndex = 20;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.ClientSize = new System.Drawing.Size(328, 280);
            this.Controls.Add(this.lLevel);
            this.Controls.Add(this.cboxLevel);
            this.Controls.Add(this.lDokter);
            this.Controls.Add(this.cboxDokter);
            this.Controls.Add(this.tboxPasswordKonfirmasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lUsername;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPasswordKonfirmasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxDokter;
        private System.Windows.Forms.Label lDokter;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.ComboBox cboxLevel;
    }
}