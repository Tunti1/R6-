namespace Projekt
{
    partial class formaispisa
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
            this.lista = new System.Windows.Forms.ListView();
            this.Sifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrijeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(859, 414);
            this.lista.TabIndex = 6;
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
            // formaispisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.lista);
            this.Name = "formaispisa";
            this.Text = "Svi servisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader Sifra;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.ColumnHeader Vrijeme;
        private System.Windows.Forms.ColumnHeader Rok;
    }
}