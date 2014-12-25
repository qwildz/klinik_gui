namespace Kelompok1
{
    partial class FormObat
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
            this.labelNObat = new System.Windows.Forms.Label();
            this.labelJObat = new System.Windows.Forms.Label();
            this.textBoxNObat = new System.Windows.Forms.TextBox();
            this.comboBoxJObat = new System.Windows.Forms.ComboBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNObat
            // 
            this.labelNObat.AutoSize = true;
            this.labelNObat.BackColor = System.Drawing.Color.Transparent;
            this.labelNObat.ForeColor = System.Drawing.Color.White;
            this.labelNObat.Location = new System.Drawing.Point(12, 86);
            this.labelNObat.Name = "labelNObat";
            this.labelNObat.Size = new System.Drawing.Size(61, 13);
            this.labelNObat.TabIndex = 4;
            this.labelNObat.Text = "Nama Obat";
            // 
            // labelJObat
            // 
            this.labelJObat.AutoSize = true;
            this.labelJObat.BackColor = System.Drawing.Color.Transparent;
            this.labelJObat.ForeColor = System.Drawing.Color.White;
            this.labelJObat.Location = new System.Drawing.Point(12, 112);
            this.labelJObat.Name = "labelJObat";
            this.labelJObat.Size = new System.Drawing.Size(57, 13);
            this.labelJObat.TabIndex = 3;
            this.labelJObat.Text = "Jenis Obat";
            // 
            // textBoxNObat
            // 
            this.textBoxNObat.Location = new System.Drawing.Point(145, 83);
            this.textBoxNObat.Name = "textBoxNObat";
            this.textBoxNObat.Size = new System.Drawing.Size(135, 20);
            this.textBoxNObat.TabIndex = 1;
            // 
            // comboBoxJObat
            // 
            this.comboBoxJObat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxJObat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxJObat.FormattingEnabled = true;
            this.comboBoxJObat.Items.AddRange(new object[] {
            "kapsul",
            "puyer",
            "salep",
            "sirup",
            "tablet"});
            this.comboBoxJObat.Location = new System.Drawing.Point(145, 109);
            this.comboBoxJObat.Name = "comboBoxJObat";
            this.comboBoxJObat.Size = new System.Drawing.Size(135, 21);
            this.comboBoxJObat.TabIndex = 6;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Image = global::Kelompok1.Properties.Resources.b_save;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(180, 160);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonSimpan.Size = new System.Drawing.Size(100, 30);
            this.buttonSimpan.TabIndex = 3;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox1.Controls.Add(this.labelJudul);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(95, 25);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(179, 31);
            this.labelJudul.TabIndex = 16;
            this.labelJudul.Text = "Tambah Obat";
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
            this.rectangleShape1.Location = new System.Drawing.Point(-10, 148);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(320, 54);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(292, 202);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // FormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.comboBoxJObat);
            this.Controls.Add(this.textBoxNObat);
            this.Controls.Add(this.labelJObat);
            this.Controls.Add(this.labelNObat);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Obat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNObat;
        private System.Windows.Forms.Label labelJObat;
        private System.Windows.Forms.TextBox textBoxNObat;
        private System.Windows.Forms.ComboBox comboBoxJObat;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelJudul;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}