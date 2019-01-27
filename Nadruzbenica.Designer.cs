namespace Projekt
{
    partial class Narudzbenica
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Djelovi = new System.Windows.Forms.TextBox();
            this.Spremi_Narudzbu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.KomboKop = new System.Windows.Forms.ComboBox();
            this.Sifra_1 = new System.Windows.Forms.ComboBox();
            this.servisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_ProjektaDataSet = new Projekt.Baza_ProjektaDataSet();
            this.servisTableAdapter = new Projekt.Baza_ProjektaDataSetTableAdapters.ServisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_ProjektaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra uređaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kooperant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Djelovi";
            // 
            // Djelovi
            // 
            this.Djelovi.Location = new System.Drawing.Point(170, 121);
            this.Djelovi.Name = "Djelovi";
            this.Djelovi.Size = new System.Drawing.Size(121, 22);
            this.Djelovi.TabIndex = 4;
            // 
            // Spremi_Narudzbu
            // 
            this.Spremi_Narudzbu.Location = new System.Drawing.Point(50, 235);
            this.Spremi_Narudzbu.Name = "Spremi_Narudzbu";
            this.Spremi_Narudzbu.Size = new System.Drawing.Size(140, 56);
            this.Spremi_Narudzbu.TabIndex = 6;
            this.Spremi_Narudzbu.Text = "Spremi";
            this.Spremi_Narudzbu.UseVisualStyleBackColor = true;
            this.Spremi_Narudzbu.Click += new System.EventHandler(this.Spremi_narudzbenicu);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Novi kooperant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Stvori_novog);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Nazad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Izlaz);
            // 
            // KomboKop
            // 
            this.KomboKop.FormattingEnabled = true;
            this.KomboKop.Location = new System.Drawing.Point(170, 157);
            this.KomboKop.Name = "KomboKop";
            this.KomboKop.Size = new System.Drawing.Size(121, 24);
            this.KomboKop.TabIndex = 9;
            // 
            // Sifra_1
            // 
            this.Sifra_1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servisBindingSource, "Sifra", true));
            this.Sifra_1.FormattingEnabled = true;
            this.Sifra_1.Location = new System.Drawing.Point(170, 76);
            this.Sifra_1.Name = "Sifra_1";
            this.Sifra_1.Size = new System.Drawing.Size(121, 24);
            this.Sifra_1.TabIndex = 10;
            // 
            // servisBindingSource
            // 
            this.servisBindingSource.DataMember = "Servis";
            this.servisBindingSource.DataSource = this.baza_ProjektaDataSet;
            // 
            // baza_ProjektaDataSet
            // 
            this.baza_ProjektaDataSet.DataSetName = "Baza_ProjektaDataSet";
            this.baza_ProjektaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisTableAdapter
            // 
            this.servisTableAdapter.ClearBeforeFill = true;
            // 
            // Narudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 470);
            this.Controls.Add(this.Sifra_1);
            this.Controls.Add(this.KomboKop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Spremi_Narudzbu);
            this.Controls.Add(this.Djelovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Narudzbenica";
            this.Text = "Nadruzbenica";
            this.Load += new System.EventHandler(this.Narudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_ProjektaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Djelovi;
        private System.Windows.Forms.Button Spremi_Narudzbu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox KomboKop;
        private System.Windows.Forms.ComboBox Sifra_1;
        private Baza_ProjektaDataSet baza_ProjektaDataSet;
        private System.Windows.Forms.BindingSource servisBindingSource;
        private Baza_ProjektaDataSetTableAdapters.ServisTableAdapter servisTableAdapter;
    }
}