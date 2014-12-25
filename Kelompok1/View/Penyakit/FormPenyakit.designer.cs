namespace Kelompok1
{
    partial class FormPenyakit
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
            this.labelnamapenyakit = new System.Windows.Forms.Label();
            this.textBoxnamapenyakit = new System.Windows.Forms.TextBox();
            this.buttonsimpannamapenyakit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnamapenyakit
            // 
            this.labelnamapenyakit.AutoSize = true;
            this.labelnamapenyakit.BackColor = System.Drawing.Color.Transparent;
            this.labelnamapenyakit.ForeColor = System.Drawing.Color.White;
            this.labelnamapenyakit.Location = new System.Drawing.Point(12, 86);
            this.labelnamapenyakit.Name = "labelnamapenyakit";
            this.labelnamapenyakit.Size = new System.Drawing.Size(35, 13);
            this.labelnamapenyakit.TabIndex = 0;
            this.labelnamapenyakit.Text = "Nama";
            // 
            // textBoxnamapenyakit
            // 
            this.textBoxnamapenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxnamapenyakit.Location = new System.Drawing.Point(153, 83);
            this.textBoxnamapenyakit.Name = "textBoxnamapenyakit";
            this.textBoxnamapenyakit.Size = new System.Drawing.Size(163, 20);
            this.textBoxnamapenyakit.TabIndex = 1;
            // 
            // buttonsimpannamapenyakit
            // 
            this.buttonsimpannamapenyakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsimpannamapenyakit.Image = global::Kelompok1.Properties.Resources.b_save;
            this.buttonsimpannamapenyakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsimpannamapenyakit.Location = new System.Drawing.Point(216, 137);
            this.buttonsimpannamapenyakit.Name = "buttonsimpannamapenyakit";
            this.buttonsimpannamapenyakit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonsimpannamapenyakit.Size = new System.Drawing.Size(100, 30);
            this.buttonsimpannamapenyakit.TabIndex = 2;
            this.buttonsimpannamapenyakit.Text = "Simpan";
            this.buttonsimpannamapenyakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsimpannamapenyakit.UseVisualStyleBackColor = true;
            this.buttonsimpannamapenyakit.Click += new System.EventHandler(this.buttonsimpannamapenyakit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Kelompok1.Properties.Resources.gradient;
            this.groupBox1.Controls.Add(this.labelJudul);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.BackColor = System.Drawing.Color.Transparent;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(95, 20);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(225, 31);
            this.labelJudul.TabIndex = 16;
            this.labelJudul.Text = "Tambah Penyakit";
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
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(-13, 125);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(349, 54);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(328, 179);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // FormPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kelompok1.Properties.Resources.soft_skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(328, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonsimpannamapenyakit);
            this.Controls.Add(this.textBoxnamapenyakit);
            this.Controls.Add(this.labelnamapenyakit);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPenyakit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Penyakit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnamapenyakit;
        private System.Windows.Forms.TextBox textBoxnamapenyakit;
        private System.Windows.Forms.Button buttonsimpannamapenyakit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}