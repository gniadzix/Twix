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
            this.components = new System.ComponentModel.Container();
            this.buttonOknoGlowneZaloguj = new System.Windows.Forms.Button();
            this.buttonOknoGlowneZarejestruj = new System.Windows.Forms.Button();
            this.buttonOknoGlowneWyjdz = new System.Windows.Forms.Button();
            this.panelLogowanie = new System.Windows.Forms.Panel();
            this.labelLogowanieHaslo = new System.Windows.Forms.Label();
            this.labelLogowanieLogin = new System.Windows.Forms.Label();
            this.textBoxLogowanieHaslo = new System.Windows.Forms.TextBox();
            this.textBoxLogowanieLogin = new System.Windows.Forms.TextBox();
            this.buttonLogowanieZaloguj = new System.Windows.Forms.Button();
            this.buttonLogowanieWroc = new System.Windows.Forms.Button();
            this.errorProviderLogowanie = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRejestracja = new System.Windows.Forms.Panel();
            this.buttonRejestracjaZarejestruj = new System.Windows.Forms.Button();
            this.textBoxRejestracjaPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.labelRejestracjaPowtorzHaslo = new System.Windows.Forms.Label();
            this.labelRejestracjaHaslo = new System.Windows.Forms.Label();
            this.textBoxRejestracjaHaslo = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaLogin = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaNrDowodu = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaPesel = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxRejestracjaImie = new System.Windows.Forms.TextBox();
            this.labelRejestracjaLogin = new System.Windows.Forms.Label();
            this.labelRejestracjaNrDowodu = new System.Windows.Forms.Label();
            this.labelRejestracjaPesel = new System.Windows.Forms.Label();
            this.labelRejestracjaNazwisko = new System.Windows.Forms.Label();
            this.labelRejestracjaImie = new System.Windows.Forms.Label();
            this.buttonRejestracjaWroc = new System.Windows.Forms.Button();
            this.errorProviderRejestracjaHaslo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelZaktualizujDane = new System.Windows.Forms.Panel();
            this.buttonZaktualizujDaneWroc = new System.Windows.Forms.Button();
            this.textBoxZaktualizujDaneImie = new System.Windows.Forms.TextBox();
            this.textBoxZaktualizujDaneNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxZaktualizujDanePesel = new System.Windows.Forms.TextBox();
            this.textBoxZaktualizujDaneNrDowodu = new System.Windows.Forms.TextBox();
            this.textBoxZaktualizujDaneLogin = new System.Windows.Forms.TextBox();
            this.textBoxZaktualizujDaneHaslo = new System.Windows.Forms.TextBox();
            this.checkBoxZaktualizujDaneCzyAdministrator = new System.Windows.Forms.CheckBox();
            this.textBoxZaktualizujDaneWyszukajImie = new System.Windows.Forms.TextBox();
            this.buttonZaktualizujDaneWyszukaj = new System.Windows.Forms.Button();
            this.textBoxZaktualizujDaneWyszukajPesel = new System.Windows.Forms.TextBox();
            this.buttonZaktualizujDaneZmienDane = new System.Windows.Forms.Button();
            this.buttonZaktualizujDaneZatwierdz = new System.Windows.Forms.Button();
            this.panelLogowanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogowanie)).BeginInit();
            this.panelRejestracja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRejestracjaHaslo)).BeginInit();
            this.panelZaktualizujDane.SuspendLayout();
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
            this.buttonOknoGlowneZaloguj.Click += new System.EventHandler(this.buttonOknoGlowneZaloguj_Click);
            // 
            // buttonOknoGlowneZarejestruj
            // 
            this.buttonOknoGlowneZarejestruj.Location = new System.Drawing.Point(173, 112);
            this.buttonOknoGlowneZarejestruj.Name = "buttonOknoGlowneZarejestruj";
            this.buttonOknoGlowneZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoGlowneZarejestruj.TabIndex = 1;
            this.buttonOknoGlowneZarejestruj.Text = "Zarejestruj";
            this.buttonOknoGlowneZarejestruj.UseVisualStyleBackColor = true;
            this.buttonOknoGlowneZarejestruj.Click += new System.EventHandler(this.buttonOknoGlowneZarejestruj_Click);
            // 
            // buttonOknoGlowneWyjdz
            // 
            this.buttonOknoGlowneWyjdz.Location = new System.Drawing.Point(200, 228);
            this.buttonOknoGlowneWyjdz.Name = "buttonOknoGlowneWyjdz";
            this.buttonOknoGlowneWyjdz.Size = new System.Drawing.Size(75, 23);
            this.buttonOknoGlowneWyjdz.TabIndex = 2;
            this.buttonOknoGlowneWyjdz.Text = "Wyjdź";
            this.buttonOknoGlowneWyjdz.UseVisualStyleBackColor = true;
            this.buttonOknoGlowneWyjdz.Click += new System.EventHandler(this.buttonOknoGlowneWyjdz_Click);
            // 
            // panelLogowanie
            // 
            this.panelLogowanie.Controls.Add(this.labelLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.labelLogowanieLogin);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieLogin);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieZaloguj);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieWroc);
            this.panelLogowanie.Location = new System.Drawing.Point(0, 0);
            this.panelLogowanie.Name = "panelLogowanie";
            this.panelLogowanie.Size = new System.Drawing.Size(288, 263);
            this.panelLogowanie.TabIndex = 3;
            // 
            // labelLogowanieHaslo
            // 
            this.labelLogowanieHaslo.AutoSize = true;
            this.labelLogowanieHaslo.Location = new System.Drawing.Point(212, 96);
            this.labelLogowanieHaslo.Name = "labelLogowanieHaslo";
            this.labelLogowanieHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelLogowanieHaslo.TabIndex = 5;
            this.labelLogowanieHaslo.Text = "Hasło";
            // 
            // labelLogowanieLogin
            // 
            this.labelLogowanieLogin.AutoSize = true;
            this.labelLogowanieLogin.Location = new System.Drawing.Point(52, 97);
            this.labelLogowanieLogin.Name = "labelLogowanieLogin";
            this.labelLogowanieLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogowanieLogin.TabIndex = 4;
            this.labelLogowanieLogin.Text = "Login";
            // 
            // textBoxLogowanieHaslo
            // 
            this.textBoxLogowanieHaslo.Location = new System.Drawing.Point(173, 112);
            this.textBoxLogowanieHaslo.Name = "textBoxLogowanieHaslo";
            this.textBoxLogowanieHaslo.PasswordChar = '*';
            this.textBoxLogowanieHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieHaslo.TabIndex = 3;
            this.textBoxLogowanieHaslo.Leave += new System.EventHandler(this.textBoxLogowanieHaslo_Leave);
            // 
            // textBoxLogowanieLogin
            // 
            this.textBoxLogowanieLogin.Location = new System.Drawing.Point(20, 112);
            this.textBoxLogowanieLogin.Name = "textBoxLogowanieLogin";
            this.textBoxLogowanieLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieLogin.TabIndex = 2;
            this.textBoxLogowanieLogin.Leave += new System.EventHandler(this.textBoxLogowanieLogin_Leave);
            // 
            // buttonLogowanieZaloguj
            // 
            this.buttonLogowanieZaloguj.Location = new System.Drawing.Point(108, 158);
            this.buttonLogowanieZaloguj.Name = "buttonLogowanieZaloguj";
            this.buttonLogowanieZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonLogowanieZaloguj.TabIndex = 1;
            this.buttonLogowanieZaloguj.Text = "Zaloguj";
            this.buttonLogowanieZaloguj.UseVisualStyleBackColor = true;
            this.buttonLogowanieZaloguj.Click += new System.EventHandler(this.buttonLogowanieZaloguj_Click);
            // 
            // buttonLogowanieWroc
            // 
            this.buttonLogowanieWroc.Location = new System.Drawing.Point(200, 228);
            this.buttonLogowanieWroc.Name = "buttonLogowanieWroc";
            this.buttonLogowanieWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonLogowanieWroc.TabIndex = 0;
            this.buttonLogowanieWroc.Text = "Wróć";
            this.buttonLogowanieWroc.UseVisualStyleBackColor = true;
            this.buttonLogowanieWroc.Click += new System.EventHandler(this.buttonLogowanieWroc_Click);
            // 
            // errorProviderLogowanie
            // 
            this.errorProviderLogowanie.ContainerControl = this;
            // 
            // panelRejestracja
            // 
            this.panelRejestracja.Controls.Add(this.buttonRejestracjaZarejestruj);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaPowtorzHaslo);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaPowtorzHaslo);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaHaslo);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaHaslo);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaLogin);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaNrDowodu);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaPesel);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaNazwisko);
            this.panelRejestracja.Controls.Add(this.textBoxRejestracjaImie);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaLogin);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaNrDowodu);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaPesel);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaNazwisko);
            this.panelRejestracja.Controls.Add(this.labelRejestracjaImie);
            this.panelRejestracja.Controls.Add(this.buttonRejestracjaWroc);
            this.panelRejestracja.Location = new System.Drawing.Point(0, 0);
            this.panelRejestracja.Name = "panelRejestracja";
            this.panelRejestracja.Size = new System.Drawing.Size(288, 263);
            this.panelRejestracja.TabIndex = 4;
            // 
            // buttonRejestracjaZarejestruj
            // 
            this.buttonRejestracjaZarejestruj.Enabled = false;
            this.buttonRejestracjaZarejestruj.Location = new System.Drawing.Point(126, 200);
            this.buttonRejestracjaZarejestruj.Name = "buttonRejestracjaZarejestruj";
            this.buttonRejestracjaZarejestruj.Size = new System.Drawing.Size(75, 23);
            this.buttonRejestracjaZarejestruj.TabIndex = 15;
            this.buttonRejestracjaZarejestruj.Text = "Zarejestruj";
            this.buttonRejestracjaZarejestruj.UseVisualStyleBackColor = true;
            this.buttonRejestracjaZarejestruj.Click += new System.EventHandler(this.buttonRejestracjaZarejestruj_Click);
            // 
            // textBoxRejestracjaPowtorzHaslo
            // 
            this.textBoxRejestracjaPowtorzHaslo.Location = new System.Drawing.Point(99, 173);
            this.textBoxRejestracjaPowtorzHaslo.Name = "textBoxRejestracjaPowtorzHaslo";
            this.textBoxRejestracjaPowtorzHaslo.PasswordChar = '*';
            this.textBoxRejestracjaPowtorzHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaPowtorzHaslo.TabIndex = 14;
            this.textBoxRejestracjaPowtorzHaslo.Leave += new System.EventHandler(this.textBoxRejestracjaPowtorzHaslo_Leave);
            // 
            // labelRejestracjaPowtorzHaslo
            // 
            this.labelRejestracjaPowtorzHaslo.AutoSize = true;
            this.labelRejestracjaPowtorzHaslo.Location = new System.Drawing.Point(18, 180);
            this.labelRejestracjaPowtorzHaslo.Name = "labelRejestracjaPowtorzHaslo";
            this.labelRejestracjaPowtorzHaslo.Size = new System.Drawing.Size(75, 13);
            this.labelRejestracjaPowtorzHaslo.TabIndex = 13;
            this.labelRejestracjaPowtorzHaslo.Text = "Powtórz hasło";
            // 
            // labelRejestracjaHaslo
            // 
            this.labelRejestracjaHaslo.AutoSize = true;
            this.labelRejestracjaHaslo.Location = new System.Drawing.Point(18, 154);
            this.labelRejestracjaHaslo.Name = "labelRejestracjaHaslo";
            this.labelRejestracjaHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelRejestracjaHaslo.TabIndex = 12;
            this.labelRejestracjaHaslo.Text = "Hasło";
            // 
            // textBoxRejestracjaHaslo
            // 
            this.textBoxRejestracjaHaslo.Location = new System.Drawing.Point(99, 147);
            this.textBoxRejestracjaHaslo.Name = "textBoxRejestracjaHaslo";
            this.textBoxRejestracjaHaslo.PasswordChar = '*';
            this.textBoxRejestracjaHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaHaslo.TabIndex = 11;
            // 
            // textBoxRejestracjaLogin
            // 
            this.textBoxRejestracjaLogin.Location = new System.Drawing.Point(99, 121);
            this.textBoxRejestracjaLogin.Name = "textBoxRejestracjaLogin";
            this.textBoxRejestracjaLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaLogin.TabIndex = 10;
            // 
            // textBoxRejestracjaNrDowodu
            // 
            this.textBoxRejestracjaNrDowodu.Location = new System.Drawing.Point(99, 95);
            this.textBoxRejestracjaNrDowodu.Name = "textBoxRejestracjaNrDowodu";
            this.textBoxRejestracjaNrDowodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNrDowodu.TabIndex = 9;
            // 
            // textBoxRejestracjaPesel
            // 
            this.textBoxRejestracjaPesel.Location = new System.Drawing.Point(99, 69);
            this.textBoxRejestracjaPesel.Name = "textBoxRejestracjaPesel";
            this.textBoxRejestracjaPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaPesel.TabIndex = 8;
            // 
            // textBoxRejestracjaNazwisko
            // 
            this.textBoxRejestracjaNazwisko.Location = new System.Drawing.Point(99, 43);
            this.textBoxRejestracjaNazwisko.Name = "textBoxRejestracjaNazwisko";
            this.textBoxRejestracjaNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNazwisko.TabIndex = 7;
            // 
            // textBoxRejestracjaImie
            // 
            this.textBoxRejestracjaImie.Location = new System.Drawing.Point(99, 17);
            this.textBoxRejestracjaImie.Name = "textBoxRejestracjaImie";
            this.textBoxRejestracjaImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaImie.TabIndex = 6;
            // 
            // labelRejestracjaLogin
            // 
            this.labelRejestracjaLogin.AutoSize = true;
            this.labelRejestracjaLogin.Location = new System.Drawing.Point(18, 128);
            this.labelRejestracjaLogin.Name = "labelRejestracjaLogin";
            this.labelRejestracjaLogin.Size = new System.Drawing.Size(33, 13);
            this.labelRejestracjaLogin.TabIndex = 5;
            this.labelRejestracjaLogin.Text = "Login";
            // 
            // labelRejestracjaNrDowodu
            // 
            this.labelRejestracjaNrDowodu.AutoSize = true;
            this.labelRejestracjaNrDowodu.Location = new System.Drawing.Point(18, 102);
            this.labelRejestracjaNrDowodu.Name = "labelRejestracjaNrDowodu";
            this.labelRejestracjaNrDowodu.Size = new System.Drawing.Size(59, 13);
            this.labelRejestracjaNrDowodu.TabIndex = 4;
            this.labelRejestracjaNrDowodu.Text = "Nr dowodu";
            // 
            // labelRejestracjaPesel
            // 
            this.labelRejestracjaPesel.AutoSize = true;
            this.labelRejestracjaPesel.Location = new System.Drawing.Point(18, 76);
            this.labelRejestracjaPesel.Name = "labelRejestracjaPesel";
            this.labelRejestracjaPesel.Size = new System.Drawing.Size(33, 13);
            this.labelRejestracjaPesel.TabIndex = 3;
            this.labelRejestracjaPesel.Text = "Pesel";
            // 
            // labelRejestracjaNazwisko
            // 
            this.labelRejestracjaNazwisko.AutoSize = true;
            this.labelRejestracjaNazwisko.Location = new System.Drawing.Point(18, 50);
            this.labelRejestracjaNazwisko.Name = "labelRejestracjaNazwisko";
            this.labelRejestracjaNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelRejestracjaNazwisko.TabIndex = 2;
            this.labelRejestracjaNazwisko.Text = "Nazwisko";
            // 
            // labelRejestracjaImie
            // 
            this.labelRejestracjaImie.AutoSize = true;
            this.labelRejestracjaImie.Location = new System.Drawing.Point(18, 24);
            this.labelRejestracjaImie.Name = "labelRejestracjaImie";
            this.labelRejestracjaImie.Size = new System.Drawing.Size(26, 13);
            this.labelRejestracjaImie.TabIndex = 1;
            this.labelRejestracjaImie.Text = "Imię";
            // 
            // buttonRejestracjaWroc
            // 
            this.buttonRejestracjaWroc.Location = new System.Drawing.Point(210, 237);
            this.buttonRejestracjaWroc.Name = "buttonRejestracjaWroc";
            this.buttonRejestracjaWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonRejestracjaWroc.TabIndex = 0;
            this.buttonRejestracjaWroc.Text = "Wróć";
            this.buttonRejestracjaWroc.UseVisualStyleBackColor = true;
            this.buttonRejestracjaWroc.Click += new System.EventHandler(this.buttonRejestracjaWroc_Click);
            // 
            // errorProviderRejestracjaHaslo
            // 
            this.errorProviderRejestracjaHaslo.ContainerControl = this;
            // 
            // panelZaktualizujDane
            // 
            this.panelZaktualizujDane.Controls.Add(this.buttonZaktualizujDaneZatwierdz);
            this.panelZaktualizujDane.Controls.Add(this.buttonZaktualizujDaneZmienDane);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneWyszukajPesel);
            this.panelZaktualizujDane.Controls.Add(this.buttonZaktualizujDaneWyszukaj);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneWyszukajImie);
            this.panelZaktualizujDane.Controls.Add(this.checkBoxZaktualizujDaneCzyAdministrator);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneHaslo);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneLogin);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneNrDowodu);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDanePesel);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneNazwisko);
            this.panelZaktualizujDane.Controls.Add(this.textBoxZaktualizujDaneImie);
            this.panelZaktualizujDane.Controls.Add(this.buttonZaktualizujDaneWroc);
            this.panelZaktualizujDane.Location = new System.Drawing.Point(343, 12);
            this.panelZaktualizujDane.Name = "panelZaktualizujDane";
            this.panelZaktualizujDane.Size = new System.Drawing.Size(284, 263);
            this.panelZaktualizujDane.TabIndex = 5;
            // 
            // buttonZaktualizujDaneWroc
            // 
            this.buttonZaktualizujDaneWroc.Location = new System.Drawing.Point(206, 236);
            this.buttonZaktualizujDaneWroc.Name = "buttonZaktualizujDaneWroc";
            this.buttonZaktualizujDaneWroc.Size = new System.Drawing.Size(75, 23);
            this.buttonZaktualizujDaneWroc.TabIndex = 0;
            this.buttonZaktualizujDaneWroc.Text = "Wróć";
            this.buttonZaktualizujDaneWroc.UseVisualStyleBackColor = true;
            // 
            // textBoxZaktualizujDaneImie
            // 
            this.textBoxZaktualizujDaneImie.Enabled = false;
            this.textBoxZaktualizujDaneImie.Location = new System.Drawing.Point(13, 12);
            this.textBoxZaktualizujDaneImie.Name = "textBoxZaktualizujDaneImie";
            this.textBoxZaktualizujDaneImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneImie.TabIndex = 1;
            // 
            // textBoxZaktualizujDaneNazwisko
            // 
            this.textBoxZaktualizujDaneNazwisko.Enabled = false;
            this.textBoxZaktualizujDaneNazwisko.Location = new System.Drawing.Point(13, 39);
            this.textBoxZaktualizujDaneNazwisko.Name = "textBoxZaktualizujDaneNazwisko";
            this.textBoxZaktualizujDaneNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneNazwisko.TabIndex = 2;
            // 
            // textBoxZaktualizujDanePesel
            // 
            this.textBoxZaktualizujDanePesel.Enabled = false;
            this.textBoxZaktualizujDanePesel.Location = new System.Drawing.Point(13, 66);
            this.textBoxZaktualizujDanePesel.Name = "textBoxZaktualizujDanePesel";
            this.textBoxZaktualizujDanePesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDanePesel.TabIndex = 3;
            // 
            // textBoxZaktualizujDaneNrDowodu
            // 
            this.textBoxZaktualizujDaneNrDowodu.Enabled = false;
            this.textBoxZaktualizujDaneNrDowodu.Location = new System.Drawing.Point(13, 93);
            this.textBoxZaktualizujDaneNrDowodu.Name = "textBoxZaktualizujDaneNrDowodu";
            this.textBoxZaktualizujDaneNrDowodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneNrDowodu.TabIndex = 4;
            // 
            // textBoxZaktualizujDaneLogin
            // 
            this.textBoxZaktualizujDaneLogin.Enabled = false;
            this.textBoxZaktualizujDaneLogin.Location = new System.Drawing.Point(13, 120);
            this.textBoxZaktualizujDaneLogin.Name = "textBoxZaktualizujDaneLogin";
            this.textBoxZaktualizujDaneLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneLogin.TabIndex = 5;
            // 
            // textBoxZaktualizujDaneHaslo
            // 
            this.textBoxZaktualizujDaneHaslo.Enabled = false;
            this.textBoxZaktualizujDaneHaslo.Location = new System.Drawing.Point(13, 147);
            this.textBoxZaktualizujDaneHaslo.Name = "textBoxZaktualizujDaneHaslo";
            this.textBoxZaktualizujDaneHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneHaslo.TabIndex = 6;
            // 
            // checkBoxZaktualizujDaneCzyAdministrator
            // 
            this.checkBoxZaktualizujDaneCzyAdministrator.AutoSize = true;
            this.checkBoxZaktualizujDaneCzyAdministrator.Enabled = false;
            this.checkBoxZaktualizujDaneCzyAdministrator.Location = new System.Drawing.Point(13, 174);
            this.checkBoxZaktualizujDaneCzyAdministrator.Name = "checkBoxZaktualizujDaneCzyAdministrator";
            this.checkBoxZaktualizujDaneCzyAdministrator.Size = new System.Drawing.Size(112, 17);
            this.checkBoxZaktualizujDaneCzyAdministrator.TabIndex = 7;
            this.checkBoxZaktualizujDaneCzyAdministrator.Text = "Czy Administrator?";
            this.checkBoxZaktualizujDaneCzyAdministrator.UseVisualStyleBackColor = true;
            // 
            // textBoxZaktualizujDaneWyszukajImie
            // 
            this.textBoxZaktualizujDaneWyszukajImie.Location = new System.Drawing.Point(165, 11);
            this.textBoxZaktualizujDaneWyszukajImie.Name = "textBoxZaktualizujDaneWyszukajImie";
            this.textBoxZaktualizujDaneWyszukajImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneWyszukajImie.TabIndex = 8;
            // 
            // buttonZaktualizujDaneWyszukaj
            // 
            this.buttonZaktualizujDaneWyszukaj.Location = new System.Drawing.Point(180, 74);
            this.buttonZaktualizujDaneWyszukaj.Name = "buttonZaktualizujDaneWyszukaj";
            this.buttonZaktualizujDaneWyszukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonZaktualizujDaneWyszukaj.TabIndex = 9;
            this.buttonZaktualizujDaneWyszukaj.Text = "Wyszukaj";
            this.buttonZaktualizujDaneWyszukaj.UseVisualStyleBackColor = true;
            this.buttonZaktualizujDaneWyszukaj.Click += new System.EventHandler(this.buttonZaktualizujDaneWyszukaj_Click);
            // 
            // textBoxZaktualizujDaneWyszukajPesel
            // 
            this.textBoxZaktualizujDaneWyszukajPesel.Location = new System.Drawing.Point(165, 38);
            this.textBoxZaktualizujDaneWyszukajPesel.Name = "textBoxZaktualizujDaneWyszukajPesel";
            this.textBoxZaktualizujDaneWyszukajPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaktualizujDaneWyszukajPesel.TabIndex = 10;
            // 
            // buttonZaktualizujDaneZmienDane
            // 
            this.buttonZaktualizujDaneZmienDane.Location = new System.Drawing.Point(13, 197);
            this.buttonZaktualizujDaneZmienDane.Name = "buttonZaktualizujDaneZmienDane";
            this.buttonZaktualizujDaneZmienDane.Size = new System.Drawing.Size(75, 23);
            this.buttonZaktualizujDaneZmienDane.TabIndex = 11;
            this.buttonZaktualizujDaneZmienDane.Text = "Zmień dane";
            this.buttonZaktualizujDaneZmienDane.UseVisualStyleBackColor = true;
            this.buttonZaktualizujDaneZmienDane.Click += new System.EventHandler(this.buttonZaktualizujDaneZmienDane_Click);
            // 
            // buttonZaktualizujDaneZatwierdz
            // 
            this.buttonZaktualizujDaneZatwierdz.Enabled = false;
            this.buttonZaktualizujDaneZatwierdz.Location = new System.Drawing.Point(13, 225);
            this.buttonZaktualizujDaneZatwierdz.Name = "buttonZaktualizujDaneZatwierdz";
            this.buttonZaktualizujDaneZatwierdz.Size = new System.Drawing.Size(112, 23);
            this.buttonZaktualizujDaneZatwierdz.TabIndex = 12;
            this.buttonZaktualizujDaneZatwierdz.Text = "Zatwierdź zmiany";
            this.buttonZaktualizujDaneZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZaktualizujDaneZatwierdz.Visible = false;
            this.buttonZaktualizujDaneZatwierdz.Click += new System.EventHandler(this.buttonZaktualizujDaneZatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 662);
            this.Controls.Add(this.panelZaktualizujDane);
            this.Controls.Add(this.panelRejestracja);
            this.Controls.Add(this.panelLogowanie);
            this.Controls.Add(this.buttonOknoGlowneWyjdz);
            this.Controls.Add(this.buttonOknoGlowneZarejestruj);
            this.Controls.Add(this.buttonOknoGlowneZaloguj);
            this.Name = "Form1";
            this.Text = "Twix";
            this.panelLogowanie.ResumeLayout(false);
            this.panelLogowanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogowanie)).EndInit();
            this.panelRejestracja.ResumeLayout(false);
            this.panelRejestracja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRejestracjaHaslo)).EndInit();
            this.panelZaktualizujDane.ResumeLayout(false);
            this.panelZaktualizujDane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOknoGlowneZaloguj;
        private System.Windows.Forms.Button buttonOknoGlowneZarejestruj;
        private System.Windows.Forms.Button buttonOknoGlowneWyjdz;
        private System.Windows.Forms.Panel panelLogowanie;
        private System.Windows.Forms.Label labelLogowanieLogin;
        private System.Windows.Forms.TextBox textBoxLogowanieHaslo;
        private System.Windows.Forms.TextBox textBoxLogowanieLogin;
        private System.Windows.Forms.Button buttonLogowanieZaloguj;
        private System.Windows.Forms.Button buttonLogowanieWroc;
        private System.Windows.Forms.Label labelLogowanieHaslo;
        private System.Windows.Forms.ErrorProvider errorProviderLogowanie;
        private System.Windows.Forms.Panel panelRejestracja;
        private System.Windows.Forms.TextBox textBoxRejestracjaLogin;
        private System.Windows.Forms.TextBox textBoxRejestracjaNrDowodu;
        private System.Windows.Forms.TextBox textBoxRejestracjaPesel;
        private System.Windows.Forms.TextBox textBoxRejestracjaNazwisko;
        private System.Windows.Forms.TextBox textBoxRejestracjaImie;
        private System.Windows.Forms.Label labelRejestracjaLogin;
        private System.Windows.Forms.Label labelRejestracjaNrDowodu;
        private System.Windows.Forms.Label labelRejestracjaPesel;
        private System.Windows.Forms.Label labelRejestracjaNazwisko;
        private System.Windows.Forms.Label labelRejestracjaImie;
        private System.Windows.Forms.Button buttonRejestracjaWroc;
        private System.Windows.Forms.Button buttonRejestracjaZarejestruj;
        private System.Windows.Forms.TextBox textBoxRejestracjaPowtorzHaslo;
        private System.Windows.Forms.Label labelRejestracjaPowtorzHaslo;
        private System.Windows.Forms.Label labelRejestracjaHaslo;
        private System.Windows.Forms.TextBox textBoxRejestracjaHaslo;
        private System.Windows.Forms.ErrorProvider errorProviderRejestracjaHaslo;
        private System.Windows.Forms.Panel panelZaktualizujDane;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneWyszukajPesel;
        private System.Windows.Forms.Button buttonZaktualizujDaneWyszukaj;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneWyszukajImie;
        private System.Windows.Forms.CheckBox checkBoxZaktualizujDaneCzyAdministrator;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneHaslo;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneLogin;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneNrDowodu;
        private System.Windows.Forms.TextBox textBoxZaktualizujDanePesel;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneNazwisko;
        private System.Windows.Forms.TextBox textBoxZaktualizujDaneImie;
        private System.Windows.Forms.Button buttonZaktualizujDaneWroc;
        private System.Windows.Forms.Button buttonZaktualizujDaneZatwierdz;
        private System.Windows.Forms.Button buttonZaktualizujDaneZmienDane;
    }
}

