namespace Kelompok1
{
    partial class FormDokterForm
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
            this.labelNamaDokter = new System.Windows.Forms.Label();
            this.labelSpesialis = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNoTelp = new System.Windows.Forms.Label();
            this.textBoxNamaDokter = new System.Windows.Forms.TextBox();
            this.textBoxSpesialis = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNoTelp = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTambah = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNamaDokter
            // 
            this.labelNamaDokter.AutoSize = true;
            this.labelNamaDokter.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaDokter.ForeColor = System.Drawing.Color.White;
            this.labelNamaDokter.Location = new System.Drawing.Point(12, 93);
            this.labelNamaDokter.Name = "labelNamaDokter";
            this.labelNamaDokter.Size = new System.Drawing.Size(70, 13);
            this.labelNamaDokter.TabIndex = 0;
            this.labelNamaDokter.Text = "Nama Dokter";
            // 
            // labelSpesialis
            // 
            this.labelSpesialis.AutoSize = true;
            this.labelSpesialis.BackColor = System.Drawing.Color.Transparent;
            this.labelSpesialis.ForeColor = System.Drawing.Color.White;
            this.labelSpesialis.Location = new System.Drawing.Point(12, 119);
            this.labelSpesialis.Name = "labelSpesialis";
            this.labelSpesialis.Size = new System.Drawing.Size(48, 13);
            this.labelSpesialis.TabIndex = 1;
            this.labelSpesialis.Text = "Spesialis";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.BackColor = System.Drawing.Color.Transparent;
            this.labelAlamat.ForeColor = System.Drawing.Color.White;
            this.labelAlamat.Location = new System.Drawing.Point(12, 145);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(39, 13);
            this.labelAlamat.TabIndex = 2;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNoTelp
            // 
            this.labelNoTelp.AutoSize = true;
            this.labelNoTelp.BackColor = System.Drawing.Color.Transparent;
            this.labelNoTelp.ForeColor = System.Drawing.Color.White;
            this.labelNoTelp.Location = new System.Drawing.Point(12, 171);
            this.labelNoTelp.Name = "labelNoTelp";
            this.labelNoTelp.Size = new System.Drawing.Size(66, 13);
            this.labelNoTelp.TabIndex = 3;
            this.labelNoTelp.Text = "No. Telepon";
            // 
            // textBoxNamaDokter
            // 
            this.textBoxNamaDokter.Location = new System.Drawing.Point(140, 90);
            this.textBoxNamaDokter.Name = "textBoxNamaDokter";
            this.textBoxNamaDokter.Size = new System.Drawing.Size(176, 20);
            this.textBoxNamaDokter.TabIndex = 4;
            // 
            // textBoxSpesialis
            // 
            this.textBoxSpesialis.Location = new System.Drawing.Point(140, 116);
            this.textBoxSpesialis.Name = "textBoxSpesialis";
            this.textBoxSpesialis.Size = new System.Drawing.Size(176, 20);
            this.textBoxSpesialis.TabIndex = 5;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(140, 142);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(176, 20);
            this.textBoxAlamat.TabIndex = 6;
            // 
            // textBoxNoTelp
            // 
            this.textBoxNoTelp.Location = new System.Drawing.Point(140, 168);
            this.textBoxNoTelp.Name = "textBoxNoTelp";
            this.textBoxNoTelp.Size = new System.Drawing.Size(176, 20);
            this.textBoxNoTelp.TabIndex = 7;
            this.textBoxNoTelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNoTelp_KeyDown);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimpan.Image = global::Kelompok1.Properties.Resources.b_save;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(226, 219);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSimpan.Size = new System.Drawing.Size(90, 30);
            this.buttonSimpan.TabIndex = 8;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 75);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox2.Controls.Add(this.labelTambah);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(-87, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // labelTambah
            // 
            this.labelTambah.BackColor = System.Drawing.Color.Transparent;
            this.labelTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambah.Location = new System.Drawing.Point(173, 25);
            this.labelTambah.Name = "labelTambah";
            this.labelTambah.Size = new System.Drawing.Size(240, 30);
            this.labelTambah.TabIndex = 15;
            this.labelTambah.Text = "Tambah Dokter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelompok1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(92, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 208);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(329, 54);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(328, 261);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // FormDokterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxNoTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxSpesialis);
            this.Controls.Add(this.textBoxNamaDokter);
            this.Controls.Add(this.labelNoTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelSpesialis);
            this.Controls.Add(this.labelNamaDokter);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDokterForm";
            this.Text = "Tambah Data Dokter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaDokter;
        private System.Windows.Forms.Label labelSpesialis;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNoTelp;
        private System.Windows.Forms.TextBox textBoxNamaDokter;
        private System.Windows.Forms.TextBox textBoxSpesialis;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNoTelp;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;

        public System.EventHandler FormDokterForm_Load { get; set; }
    }
}