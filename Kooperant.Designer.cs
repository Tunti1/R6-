namespace Projekt
{
    partial class Kooperant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kooperant));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Spremi_KOP = new System.Windows.Forms.Button();
            this.OIB = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Izlaz);
            // 
            // Spremi_KOP
            // 
            this.Spremi_KOP.Location = new System.Drawing.Point(155, 254);
            this.Spremi_KOP.Name = "Spremi_KOP";
            this.Spremi_KOP.Size = new System.Drawing.Size(117, 53);
            this.Spremi_KOP.TabIndex = 4;
            this.Spremi_KOP.Text = "Spremi";
            this.Spremi_KOP.UseVisualStyleBackColor = true;
            this.Spremi_KOP.Click += new System.EventHandler(this.Spremi_KOP_Click);
            // 
            // OIB
            // 
            this.OIB.Location = new System.Drawing.Point(139, 91);
            this.OIB.Name = "OIB";
            this.OIB.Size = new System.Drawing.Size(173, 22);
            this.OIB.TabIndex = 5;
            // 
            // Naziv
            // 
            this.Naziv.Location = new System.Drawing.Point(139, 137);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(173, 22);
            this.Naziv.TabIndex = 6;
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(139, 188);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(173, 22);
            this.Adresa.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Kooperant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.OIB);
            this.Controls.Add(this.Spremi_KOP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kooperant";
            this.Text = "Kooperant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Spremi_KOP;
        private System.Windows.Forms.TextBox OIB;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}