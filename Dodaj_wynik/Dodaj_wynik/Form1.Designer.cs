namespace Dodaj_wynik
{
    partial class Dodaj_wynik
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
            this.Dodaj = new System.Windows.Forms.Button();
            this.Wybierz_bron = new System.Windows.Forms.ComboBox();
            this.Wroc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(401, 212);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 0;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Wybierz_bron
            // 
            this.Wybierz_bron.FormattingEnabled = true;
            this.Wybierz_bron.Location = new System.Drawing.Point(50, 212);
            this.Wybierz_bron.Name = "Wybierz_bron";
            this.Wybierz_bron.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Wybierz_bron.Size = new System.Drawing.Size(121, 21);
            this.Wybierz_bron.TabIndex = 1;
            this.Wybierz_bron.Text = "         Wybierz Broń";
            this.Wybierz_bron.SelectedIndexChanged += new System.EventHandler(this.Wybierz_bron_SelectedIndexChanged);
            // 
            // Wroc
            // 
            this.Wroc.ForeColor = System.Drawing.Color.Black;
            this.Wroc.Location = new System.Drawing.Point(777, 465);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(75, 23);
            this.Wroc.TabIndex = 2;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Dodaj_wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Wroc);
            this.Controls.Add(this.Wybierz_bron);
            this.Controls.Add(this.Dodaj);
            this.Name = "Dodaj_wynik";
            this.Text = "Dodaj wynik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.ComboBox Wybierz_bron;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

