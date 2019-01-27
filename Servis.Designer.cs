namespace Projekt
{
    partial class Servis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servis));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sifratxt = new System.Windows.Forms.TextBox();
            this.MarkaTxt = new System.Windows.Forms.TextBox();
            this.ModelTxT = new System.Windows.Forms.TextBox();
            this.KomponentaTxt = new System.Windows.Forms.TextBox();
            this.Spremi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RokTxT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CijenaTxtic = new System.Windows.Forms.TextBox();
            this.RokKraj = new System.Windows.Forms.DateTimePicker();
            this.Vrijeme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 611);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Izadji);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sifra ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Komponenta za popraviti";
            // 
            // Sifratxt
            // 
            this.Sifratxt.Location = new System.Drawing.Point(189, 12);
            this.Sifratxt.Name = "Sifratxt";
            this.Sifratxt.Size = new System.Drawing.Size(122, 22);
            this.Sifratxt.TabIndex = 7;
            // 
            // MarkaTxt
            // 
            this.MarkaTxt.Location = new System.Drawing.Point(189, 59);
            this.MarkaTxt.Name = "MarkaTxt";
            this.MarkaTxt.Size = new System.Drawing.Size(122, 22);
            this.MarkaTxt.TabIndex = 8;
            // 
            // ModelTxT
            // 
            this.ModelTxT.Location = new System.Drawing.Point(189, 110);
            this.ModelTxT.Name = "ModelTxT";
            this.ModelTxT.Size = new System.Drawing.Size(122, 22);
            this.ModelTxT.TabIndex = 9;
            // 
            // KomponentaTxt
            // 
            this.KomponentaTxt.Location = new System.Drawing.Point(189, 153);
            this.KomponentaTxt.Name = "KomponentaTxt";
            this.KomponentaTxt.Size = new System.Drawing.Size(122, 22);
            this.KomponentaTxt.TabIndex = 10;
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(188, 348);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(142, 38);
            this.Spremi.TabIndex = 11;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.SpremiUredjaj);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 64);
            this.button3.TabIndex = 12;
            this.button3.Text = "Napravi narudzbenicu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Otvori_Narudzbenicu);
            // 
            // RokTxT
            // 
            this.RokTxT.AutoSize = true;
            this.RokTxT.Location = new System.Drawing.Point(8, 205);
            this.RokTxT.Name = "RokTxT";
            this.RokTxT.Size = new System.Drawing.Size(71, 17);
            this.RokTxT.TabIndex = 13;
            this.RokTxT.Text = "Krajnji rok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cijena popravka";
            // 
            // CijenaTxtic
            // 
            this.CijenaTxtic.Location = new System.Drawing.Point(189, 259);
            this.CijenaTxtic.Name = "CijenaTxtic";
            this.CijenaTxtic.Size = new System.Drawing.Size(122, 22);
            this.CijenaTxtic.TabIndex = 16;
            // 
            // RokKraj
            // 
            this.RokKraj.CustomFormat = "yyyy-MM-dd";
            this.RokKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RokKraj.Location = new System.Drawing.Point(153, 205);
            this.RokKraj.Name = "RokKraj";
            this.RokKraj.Size = new System.Drawing.Size(200, 22);
            this.RokKraj.TabIndex = 17;
            this.RokKraj.Value = new System.DateTime(2019, 1, 17, 0, 0, 0, 0);
            // 
            // Vrijeme
            // 
            this.Vrijeme.Location = new System.Drawing.Point(189, 308);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Size = new System.Drawing.Size(122, 22);
            this.Vrijeme.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vrijeme popravka";
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 605);
            this.Controls.Add(this.Vrijeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RokKraj);
            this.Controls.Add(this.CijenaTxtic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RokTxT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.KomponentaTxt);
            this.Controls.Add(this.ModelTxT);
            this.Controls.Add(this.MarkaTxt);
            this.Controls.Add(this.Sifratxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Servis";
            this.Text = "Servis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sifratxt;
        private System.Windows.Forms.TextBox MarkaTxt;
        private System.Windows.Forms.TextBox ModelTxT;
        private System.Windows.Forms.TextBox KomponentaTxt;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label RokTxT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CijenaTxtic;
        private System.Windows.Forms.DateTimePicker RokKraj;
        private System.Windows.Forms.TextBox Vrijeme;
        private System.Windows.Forms.Label label6;
    }
}