namespace dodajUzytkownika
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
            this.panelDodajUzytkownika = new System.Windows.Forms.Panel();
            this.buttonWrocDoPaneluUzytkownika = new System.Windows.Forms.Button();
            this.buttonDodajUzytkownika = new System.Windows.Forms.Button();
            this.textboxDodajNrDowodu = new System.Windows.Forms.TextBox();
            this.textboxDodajPesel = new System.Windows.Forms.TextBox();
            this.textboxDodajNazwisko = new System.Windows.Forms.TextBox();
            this.textboxDodajImie = new System.Windows.Forms.TextBox();
            this.checkBoxCzyAdmin = new System.Windows.Forms.CheckBox();
            this.panelDodajUzytkownika.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDodajUzytkownika
            // 
            this.panelDodajUzytkownika.AccessibleName = "panelDodajUzytkownika";
            this.panelDodajUzytkownika.Controls.Add(this.checkBoxCzyAdmin);
            this.panelDodajUzytkownika.Controls.Add(this.buttonWrocDoPaneluUzytkownika);
            this.panelDodajUzytkownika.Controls.Add(this.buttonDodajUzytkownika);
            this.panelDodajUzytkownika.Controls.Add(this.textboxDodajNrDowodu);
            this.panelDodajUzytkownika.Controls.Add(this.textboxDodajPesel);
            this.panelDodajUzytkownika.Controls.Add(this.textboxDodajNazwisko);
            this.panelDodajUzytkownika.Controls.Add(this.textboxDodajImie);
            this.panelDodajUzytkownika.Location = new System.Drawing.Point(0, 0);
            this.panelDodajUzytkownika.Name = "panelDodajUzytkownika";
            this.panelDodajUzytkownika.Size = new System.Drawing.Size(325, 289);
            this.panelDodajUzytkownika.TabIndex = 0;
            this.panelDodajUzytkownika.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonWrocDoPaneluUzytkownika
            // 
            this.buttonWrocDoPaneluUzytkownika.AccessibleName = "buttonWrocDoPaneluUzytkownika";
            this.buttonWrocDoPaneluUzytkownika.Location = new System.Drawing.Point(207, 241);
            this.buttonWrocDoPaneluUzytkownika.Name = "buttonWrocDoPaneluUzytkownika";
            this.buttonWrocDoPaneluUzytkownika.Size = new System.Drawing.Size(75, 23);
            this.buttonWrocDoPaneluUzytkownika.TabIndex = 5;
            this.buttonWrocDoPaneluUzytkownika.Text = "Wróć";
            this.buttonWrocDoPaneluUzytkownika.UseVisualStyleBackColor = true;
            // 
            // buttonDodajUzytkownika
            // 
            this.buttonDodajUzytkownika.AccessibleName = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Location = new System.Drawing.Point(48, 242);
            this.buttonDodajUzytkownika.Name = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajUzytkownika.TabIndex = 4;
            this.buttonDodajUzytkownika.Text = "Dodaj";
            this.buttonDodajUzytkownika.UseVisualStyleBackColor = true;
            this.buttonDodajUzytkownika.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // textboxDodajNrDowodu
            // 
            this.textboxDodajNrDowodu.AccessibleName = "textboxDodajNrDowodu";
            this.textboxDodajNrDowodu.Location = new System.Drawing.Point(93, 145);
            this.textboxDodajNrDowodu.Name = "textboxDodajNrDowodu";
            this.textboxDodajNrDowodu.Size = new System.Drawing.Size(111, 20);
            this.textboxDodajNrDowodu.TabIndex = 3;
            this.textboxDodajNrDowodu.Text = "Wpisz numer dowodu";
            this.textboxDodajNrDowodu.Click += new System.EventHandler(this.textboxDodajNrDowodu_Click);
            // 
            // textboxDodajPesel
            // 
            this.textboxDodajPesel.AccessibleName = "textboxDodajPesel";
            this.textboxDodajPesel.Location = new System.Drawing.Point(93, 119);
            this.textboxDodajPesel.MaxLength = 11;
            this.textboxDodajPesel.Name = "textboxDodajPesel";
            this.textboxDodajPesel.Size = new System.Drawing.Size(111, 20);
            this.textboxDodajPesel.TabIndex = 2;
            this.textboxDodajPesel.Text = "Wpisz PESEL";
            this.textboxDodajPesel.Click += new System.EventHandler(this.textboxDodajPesel_Click);
            this.textboxDodajPesel.TextChanged += new System.EventHandler(this.textboxDodajPesel_TextChanged);
            // 
            // textboxDodajNazwisko
            // 
            this.textboxDodajNazwisko.AccessibleName = "textboxDodajNazwisko";
            this.textboxDodajNazwisko.Location = new System.Drawing.Point(93, 92);
            this.textboxDodajNazwisko.Name = "textboxDodajNazwisko";
            this.textboxDodajNazwisko.Size = new System.Drawing.Size(111, 20);
            this.textboxDodajNazwisko.TabIndex = 1;
            this.textboxDodajNazwisko.Text = "Wpisz nazwisko";
            this.textboxDodajNazwisko.Click += new System.EventHandler(this.textboxDodajNazwisko_Click);
            this.textboxDodajNazwisko.TextChanged += new System.EventHandler(this.textboxDodajNazwisko_TextChanged);
            // 
            // textboxDodajImie
            // 
            this.textboxDodajImie.AccessibleName = "textboxDodajImie";
            this.textboxDodajImie.Location = new System.Drawing.Point(93, 65);
            this.textboxDodajImie.Name = "textboxDodajImie";
            this.textboxDodajImie.Size = new System.Drawing.Size(111, 20);
            this.textboxDodajImie.TabIndex = 0;
            this.textboxDodajImie.Text = "Wpisz imię";
            this.textboxDodajImie.Click += new System.EventHandler(this.textboxDodajImie_Click);
            this.textboxDodajImie.TextChanged += new System.EventHandler(this.textboxDodajImie_TextChanged);
            // 
            // checkBoxCzyAdmin
            // 
            this.checkBoxCzyAdmin.AccessibleName = "checkBoxCzyAdmin";
            this.checkBoxCzyAdmin.AutoSize = true;
            this.checkBoxCzyAdmin.Location = new System.Drawing.Point(93, 171);
            this.checkBoxCzyAdmin.Name = "checkBoxCzyAdmin";
            this.checkBoxCzyAdmin.Size = new System.Drawing.Size(61, 17);
            this.checkBoxCzyAdmin.TabIndex = 6;
            this.checkBoxCzyAdmin.Text = "Admin?";
            this.checkBoxCzyAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 290);
            this.Controls.Add(this.panelDodajUzytkownika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDodajUzytkownika.ResumeLayout(false);
            this.panelDodajUzytkownika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDodajUzytkownika;
        private System.Windows.Forms.Button buttonDodajUzytkownika;
        private System.Windows.Forms.TextBox textboxDodajNrDowodu;
        private System.Windows.Forms.TextBox textboxDodajPesel;
        private System.Windows.Forms.TextBox textboxDodajNazwisko;
        private System.Windows.Forms.TextBox textboxDodajImie;
        private System.Windows.Forms.Button buttonWrocDoPaneluUzytkownika;
        private System.Windows.Forms.CheckBox checkBoxCzyAdmin;
    }
}

