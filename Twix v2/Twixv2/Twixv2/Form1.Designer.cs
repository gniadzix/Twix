namespace Twixv2
{
    partial class Form1
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
            this.buttonOknoGlowneZaloguj = new System.Windows.Forms.Button();
            this.buttonOknoGlowneZarejestruj = new System.Windows.Forms.Button();
            this.buttonOknoGlowneWyjdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOknoGlowneZaloguj
            // 
            this.buttonOknoGlowneZaloguj.Location = new System.Drawing.Point(45, 113);
            this.buttonOknoGlowneZaloguj.Name = "buttonOknoGlowneZaloguj";
            this.buttonOknoGlowneZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoGlowneZaloguj.TabIndex = 0;
            this.buttonOknoGlowneZaloguj.Text = "Zaloguj";
            this.buttonOknoGlowneZaloguj.UseVisualStyleBackColor = true;
            // 
            // buttonOknoGlowneZarejestruj
            // 
            this.buttonOknoGlowneZarejestruj.Location = new System.Drawing.Point(173, 112);
            this.buttonOknoGlowneZarejestruj.Name = "buttonOknoGlowneZarejestruj";
            this.buttonOknoGlowneZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoGlowneZarejestruj.TabIndex = 1;
            this.buttonOknoGlowneZarejestruj.Text = "Zarejestruj";
            this.buttonOknoGlowneZarejestruj.UseVisualStyleBackColor = true;
            // 
            // buttonOknoGlowneWyjdz
            // 
            this.buttonOknoGlowneWyjdz.Location = new System.Drawing.Point(200, 228);
            this.buttonOknoGlowneWyjdz.Name = "buttonOknoGlowneWyjdz";
            this.buttonOknoGlowneWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoGlowneWyjdz.TabIndex = 2;
            this.buttonOknoGlowneWyjdz.Text = "Wyjdź";
            this.buttonOknoGlowneWyjdz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Controls.Add(this.buttonOknoGlowneWyjdz);
            this.Controls.Add(this.buttonOknoGlowneZarejestruj);
            this.Controls.Add(this.buttonOknoGlowneZaloguj);
            this.Name = "Form1";
            this.Text = "oknoGlowne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOknoGlowneZaloguj;
        private System.Windows.Forms.Button buttonOknoGlowneZarejestruj;
        private System.Windows.Forms.Button buttonOknoGlowneWyjdz;
    }
}

