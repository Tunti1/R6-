namespace Projekt
{
    partial class Planiranje
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListView();
            this.Sifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrijeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Popravi što više";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reverse_greedy);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Donesi što veći profit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.knapsack);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nazad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.izlaz);
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(358, 55);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(275, 22);
            this.rad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koliko sati ćete danas raditi?";
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sifra,
            this.Marka,
            this.Model,
            this.Cijena,
            this.Vrijeme,
            this.Rok});
            this.lista.Location = new System.Drawing.Point(272, 100);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(781, 307);
            this.lista.TabIndex = 5;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            // 
            // Sifra
            // 
            this.Sifra.Text = "Sifra";
            this.Sifra.Width = 150;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 150;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 150;
            // 
            // Cijena
            // 
            this.Cijena.Text = "Cijena";
            this.Cijena.Width = 100;
            // 
            // Vrijeme
            // 
            this.Vrijeme.Text = "Vrijeme rada";
            this.Vrijeme.Width = 100;
            // 
            // Rok
            // 
            this.Rok.Tag = "s";
            this.Rok.Text = "Rok";
            this.Rok.Width = 200;
            // 
            // Planiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 527);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Planiranje";
            this.Text = "Planiranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox rad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader Sifra;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.ColumnHeader Vrijeme;
        private System.Windows.Forms.ColumnHeader Rok;
    }
}