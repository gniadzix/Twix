namespace Twix
{
    partial class Okno
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
            this.buttonOknoZaloguj = new System.Windows.Forms.Button();
            this.buttonOknoZarejestruj = new System.Windows.Forms.Button();
            this.buttonOknoWyjdz = new System.Windows.Forms.Button();
            this.panelLogowanie = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogowanieHaslo = new System.Windows.Forms.Label();
            this.labelLogowanieLogin = new System.Windows.Forms.Label();
            this.buttonLogowanieWroc = new System.Windows.Forms.Button();
            this.panelRejestracja = new System.Windows.Forms.Panel();
            this.textBoxRejestracjaHaslo = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaLogin = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaNrDowodu = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaPesel = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxRejetracjaImie = new System.Windows.Forms.TextBox();
            this.labelRejestracjaHaslo = new System.Windows.Forms.Label();
            this.labelRejestracjaLogin = new System.Windows.Forms.Label();
            this.labelRejestracjaNrDowodu = new System.Windows.Forms.Label();
            this.labelRejestracjaPesel = new System.Windows.Forms.Label();
            this.labelRejestracjaNazwisko = new System.Windows.Forms.Label();
            this.labelRejestracjaImie = new System.Windows.Forms.Label();
            this.buttonRejestracjaZarejestruj = new System.Windows.Forms.Button();
            this.buttonRejestracjaWroc = new System.Windows.Forms.Button();
            this.buttonLogowanieZaloguj = new System.Windows.Forms.Button();
            this.textBoxLogowanieHaslo = new System.Windows.Forms.TextBox();
            this.textBoxLogowanieLogin = new System.Windows.Forms.TextBox();
            this.epLogowanieLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.twixDataSet1 = new Twix.twixDataSet();
            this.panelLogowanie.SuspendLayout();
            this.panelRejestracja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLogowanieLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twixDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOknoZaloguj
            // 
            this.buttonOknoZaloguj.Location = new System.Drawing.Point(12, 104);
            this.buttonOknoZaloguj.Name = "buttonOknoZaloguj";
            this.buttonOknoZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoZaloguj.TabIndex = 0;
            this.buttonOknoZaloguj.Text = "Zaloguj";
            this.buttonOknoZaloguj.UseVisualStyleBackColor = true;
            this.buttonOknoZaloguj.Click += new System.EventHandler(this.buttonOknoZaloguj_Click);
            // 
            // buttonOknoZarejestruj
            // 
            this.buttonOknoZarejestruj.Location = new System.Drawing.Point(197, 103);
            this.buttonOknoZarejestruj.Name = "buttonOknoZarejestruj";
            this.buttonOknoZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoZarejestruj.TabIndex = 1;
            this.buttonOknoZarejestruj.Text = "Zarejestruj";
            this.buttonOknoZarejestruj.UseVisualStyleBackColor = true;
            this.buttonOknoZarejestruj.Click += new System.EventHandler(this.buttonOknoZarejestruj_Click);
            // 
            // buttonOknoWyjdz
            // 
            this.buttonOknoWyjdz.Location = new System.Drawing.Point(196, 226);
            this.buttonOknoWyjdz.Name = "buttonOknoWyjdz";
            this.buttonOknoWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoWyjdz.TabIndex = 2;
            this.buttonOknoWyjdz.Text = "Wyjdz";
            this.buttonOknoWyjdz.UseVisualStyleBackColor = true;
            this.buttonOknoWyjdz.Click += new System.EventHandler(this.buttonOknoWyjdz_Click);
            // 
            // panelLogowanie
            // 
            this.panelLogowanie.Controls.Add(this.label1);
            this.panelLogowanie.Controls.Add(this.labelLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.labelLogowanieLogin);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieWroc);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieZaloguj);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieLogin);
            this.panelLogowanie.Location = new System.Drawing.Point(287, 4);
            this.panelLogowanie.Name = "panelLogowanie";
            this.panelLogowanie.Size = new System.Drawing.Size(282, 257);
            this.panelLogowanie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // labelLogowanieHaslo
            // 
            this.labelLogowanieHaslo.AutoSize = true;
            this.labelLogowanieHaslo.Location = new System.Drawing.Point(182, 83);
            this.labelLogowanieHaslo.Name = "labelLogowanieHaslo";
            this.labelLogowanieHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelLogowanieHaslo.TabIndex = 5;
            this.labelLogowanieHaslo.Text = "Hasło";
            // 
            // labelLogowanieLogin
            // 
            this.labelLogowanieLogin.AutoSize = true;
            this.labelLogowanieLogin.Location = new System.Drawing.Point(50, 83);
            this.labelLogowanieLogin.Name = "labelLogowanieLogin";
            this.labelLogowanieLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogowanieLogin.TabIndex = 4;
            this.labelLogowanieLogin.Text = "Login";
            // 
            // buttonLogowanieWroc
            // 
            this.buttonLogowanieWroc.Location = new System.Drawing.Point(196, 225);
            this.buttonLogowanieWroc.Name = "buttonLogowanieWroc";
            this.buttonLogowanieWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonLogowanieWroc.TabIndex = 3;
            this.buttonLogowanieWroc.Text = "Wróć";
            this.buttonLogowanieWroc.UseVisualStyleBackColor = true;
            this.buttonLogowanieWroc.Click += new System.EventHandler(this.buttonLogowanieWroc_Click);
            // 
            // panelRejestracja
            // 
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaHaslo);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaLogin);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaNrDowodu);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaPesel);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaNazwisko);
            this.panelRejestracja.Controls.Add(this.textBoxRejetracjaImie);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaHaslo);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaLogin);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaNrDowodu);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaPesel);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaNazwisko);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaImie);
            this.panelRejestracja.Controls.Add(this.buttonRejestracjaZarejestruj);
            this.panelRejestracja.Controls.Add(this.buttonRejestracjaWroc);
            this.panelRejestracja.Location = new System.Drawing.Point(0, 4);
            this.panelRejestracja.Name = "panelRejestracja";
            this.panelRejestracja.Size = new System.Drawing.Size(281, 270);
            this.panelRejestracja.TabIndex = 4;
            // 
            // textBoxRejestracjaHaslo
            // 
            this.textBoxRejestracjaHaslo.Location = new System.Drawing.Point(86, 144);
            this.textBoxRejestracjaHaslo.Name = "textBoxRejestracjaHaslo";
            this.textBoxRejestracjaHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaHaslo.TabIndex = 13;
            // 
            // textBoxRejestracjaLogin
            // 
            this.textBoxRejestracjaLogin.Location = new System.Drawing.Point(86, 117);
            this.textBoxRejestracjaLogin.Name = "textBoxRejestracjaLogin";
            this.textBoxRejestracjaLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaLogin.TabIndex = 12;
            // 
            // textBoxRejestracjaNrDowodu
            // 
            this.textBoxRejestracjaNrDowodu.Location = new System.Drawing.Point(86, 90);
            this.textBoxRejestracjaNrDowodu.Name = "textBoxRejestracjaNrDowodu";
            this.textBoxRejestracjaNrDowodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNrDowodu.TabIndex = 11;
            // 
            // textBoxRejestracjaPesel
            // 
            this.textBoxRejestracjaPesel.Location = new System.Drawing.Point(86, 63);
            this.textBoxRejestracjaPesel.Name = "textBoxRejestracjaPesel";
            this.textBoxRejestracjaPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaPesel.TabIndex = 10;
            // 
            // textBoxRejestracjaNazwisko
            // 
            this.textBoxRejestracjaNazwisko.Location = new System.Drawing.Point(86, 38);
            this.textBoxRejestracjaNazwisko.Name = "textBoxRejestracjaNazwisko";
            this.textBoxRejestracjaNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNazwisko.TabIndex = 9;
            // 
            // textBoxRejetracjaImie
            // 
            this.textBoxRejetracjaImie.Location = new System.Drawing.Point(86, 11);
            this.textBoxRejetracjaImie.Name = "textBoxRejetracjaImie";
            this.textBoxRejetracjaImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejetracjaImie.TabIndex = 8;
            // 
            // labelRejestracjaHaslo
            // 
            this.labelRejestracjaHaslo.AutoSize = true;
            this.labelRejestracjaHaslo.Location = new System.Drawing.Point(28, 151);
            this.labelRejestracjaHaslo.Name = "labelRejestracjaHaslo";
            this.labelRejestracjaHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelRejestracjaHaslo.TabIndex = 7;
            this.labelRejestracjaHaslo.Text = "Hasło";
            // 
            // labelRejestracjaLogin
            // 
            this.labelRejestracjaLogin.AutoSize = true;
            this.labelRejestracjaLogin.Location = new System.Drawing.Point(28, 124);
            this.labelRejestracjaLogin.Name = "labelRejestracjaLogin";
            this.labelRejestracjaLogin.Size = new System.Drawing.Size(33, 13);
            this.labelRejestracjaLogin.TabIndex = 6;
            this.labelRejestracjaLogin.Text = "Login";
            // 
            // labelRejestracjaNrDowodu
            // 
            this.labelRejestracjaNrDowodu.AutoSize = true;
            this.labelRejestracjaNrDowodu.Location = new System.Drawing.Point(28, 97);
            this.labelRejestracjaNrDowodu.Name = "labelRejestracjaNrDowodu";
            this.labelRejestracjaNrDowodu.Size = new System.Drawing.Size(59, 13);
            this.labelRejestracjaNrDowodu.TabIndex = 5;
            this.labelRejestracjaNrDowodu.Text = "Nr dowodu";
            // 
            // labelRejestracjaPesel
            // 
            this.labelRejestracjaPesel.AutoSize = true;
            this.labelRejestracjaPesel.Location = new System.Drawing.Point(28, 70);
            this.labelRejestracjaPesel.Name = "labelRejestracjaPesel";
            this.labelRejestracjaPesel.Size = new System.Drawing.Size(41, 13);
            this.labelRejestracjaPesel.TabIndex = 4;
            this.labelRejestracjaPesel.Text = "PESEL";
            // 
            // labelRejestracjaNazwisko
            // 
            this.labelRejestracjaNazwisko.AutoSize = true;
            this.labelRejestracjaNazwisko.Location = new System.Drawing.Point(28, 45);
            this.labelRejestracjaNazwisko.Name = "labelRejestracjaNazwisko";
            this.labelRejestracjaNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelRejestracjaNazwisko.TabIndex = 3;
            this.labelRejestracjaNazwisko.Text = "Nazwisko";
            // 
            // labelRejestracjaImie
            // 
            this.labelRejestracjaImie.AutoSize = true;
            this.labelRejestracjaImie.Location = new System.Drawing.Point(28, 18);
            this.labelRejestracjaImie.Name = "labelRejestracjaImie";
            this.labelRejestracjaImie.Size = new System.Drawing.Size(26, 13);
            this.labelRejestracjaImie.TabIndex = 2;
            this.labelRejestracjaImie.Text = "Imię";
            // 
            // buttonRejestracjaZarejestruj
            // 
            this.buttonRejestracjaZarejestruj.Location = new System.Drawing.Point(111, 207);
            this.buttonRejestracjaZarejestruj.Name = "buttonRejestracjaZarejestruj";
            this.buttonRejestracjaZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonRejestracjaZarejestruj.TabIndex = 1;
            this.buttonRejestracjaZarejestruj.Text = "Zarejestruj";
            this.buttonRejestracjaZarejestruj.UseVisualStyleBackColor = true;
            // 
            // buttonRejestracjaWroc
            // 
            this.buttonRejestracjaWroc.Location = new System.Drawing.Point(194, 234);
            this.buttonRejestracjaWroc.Name = "buttonRejestracjaWroc";
            this.buttonRejestracjaWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonRejestracjaWroc.TabIndex = 0;
            this.buttonRejestracjaWroc.Text = "Wróć";
            this.buttonRejestracjaWroc.UseVisualStyleBackColor = true;
            this.buttonRejestracjaWroc.Click += new System.EventHandler(this.buttonRejestracjaWroc_Click);
            // 
            // buttonLogowanieZaloguj
            // 
            this.buttonLogowanieZaloguj.Location = new System.Drawing.Point(103, 141);
            this.buttonLogowanieZaloguj.Name = "buttonLogowanieZaloguj";
            this.buttonLogowanieZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonLogowanieZaloguj.TabIndex = 2;
            this.buttonLogowanieZaloguj.Text = "Zaloguj";
            this.buttonLogowanieZaloguj.UseVisualStyleBackColor = true;
            this.buttonLogowanieZaloguj.Click += new System.EventHandler(this.buttonLogowanieZaloguj_Click);
            // 
            // textBoxLogowanieHaslo
            // 
            this.textBoxLogowanieHaslo.Location = new System.Drawing.Point(148, 103);
            this.textBoxLogowanieHaslo.Name = "textBoxLogowanieHaslo";
            this.textBoxLogowanieHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieHaslo.TabIndex = 1;
            this.textBoxLogowanieHaslo.Leave += new System.EventHandler(this.textBoxLogowanieHaslo_Leave);
            // 
            // textBoxLogowanieLogin
            // 
            this.textBoxLogowanieLogin.Location = new System.Drawing.Point(12, 102);
            this.textBoxLogowanieLogin.Name = "textBoxLogowanieLogin";
            this.textBoxLogowanieLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieLogin.TabIndex = 0;
            this.textBoxLogowanieLogin.Leave += new System.EventHandler(this.textBoxLogowanieLogin_Leave);
            // 
            // epLogowanieLogin
            // 
            this.epLogowanieLogin.ContainerControl = this;
            // 
            // twixDataSet1
            // 
            this.twixDataSet1.DataSetName = "twixDataSet";
            this.twixDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 439);
            this.Controls.Add(this.panelRejestracja);
            this.Controls.Add(this.panelLogowanie);
            this.Controls.Add(this.buttonOknoWyjdz);
            this.Controls.Add(this.buttonOknoZarejestruj);
            this.Controls.Add(this.buttonOknoZaloguj);
            this.Name = "Okno";
            this.Text = "Twix";
            this.panelLogowanie.ResumeLayout(false);
            this.panelLogowanie.PerformLayout();
            this.panelRejestracja.ResumeLayout(false);
            this.panelRejestracja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLogowanieLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twixDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOknoZaloguj;
        private System.Windows.Forms.Button buttonOknoZarejestruj;
        private System.Windows.Forms.Button buttonOknoWyjdz;
        private System.Windows.Forms.Panel panelLogowanie;
        private System.Windows.Forms.Label labelLogowanieHaslo;
        private System.Windows.Forms.Label labelLogowanieLogin;
        private System.Windows.Forms.Button buttonLogowanieWroc;
        private System.Windows.Forms.Button buttonLogowanieZaloguj;
        private System.Windows.Forms.TextBox textBoxLogowanieHaslo;
        private System.Windows.Forms.TextBox textBoxLogowanieLogin;
        private System.Windows.Forms.ErrorProvider epLogowanieLogin;
        private System.Windows.Forms.Label label1;
        public twixDataSet twixDataSet1;
        private System.Windows.Forms.Panel panelRejestracja;
        private System.Windows.Forms.TextBox textBoxRejestracjaHaslo;
        private System.Windows.Forms.TextBox textBoxRejestracjaLogin;
        private System.Windows.Forms.TextBox textBoxRejestracjaNrDowodu;
        private System.Windows.Forms.TextBox textBoxRejestracjaPesel;
        private System.Windows.Forms.TextBox textBoxRejestracjaNazwisko;
        private System.Windows.Forms.TextBox textBoxRejetracjaImie;
        private System.Windows.Forms.Label labelRejestracjaHaslo;
        private System.Windows.Forms.Label labelRejestracjaLogin;
        private System.Windows.Forms.Label labelRejestracjaNrDowodu;
        private System.Windows.Forms.Label labelRejestracjaPesel;
        private System.Windows.Forms.Label labelRejestracjaNazwisko;
        private System.Windows.Forms.Label labelRejestracjaImie;
        private System.Windows.Forms.Button buttonRejestracjaZarejestruj;
        private System.Windows.Forms.Button buttonRejestracjaWroc;
    }
}

