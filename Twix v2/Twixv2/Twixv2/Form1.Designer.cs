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
            System.Windows.Forms.Button buttonDodajPracownika;
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
            this.panelPanelPracownika = new System.Windows.Forms.Panel();
            this.panelDodajUzytkownika = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxDodajLogin = new System.Windows.Forms.TextBox();
            this.buttonWrocDoPaneluPracownika = new System.Windows.Forms.Button();
            this.checkBoxCzyAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxDodajNrDowodu = new System.Windows.Forms.TextBox();
            this.textBoxDodajPesel = new System.Windows.Forms.TextBox();
            this.textBoxDodajNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxDodajImie = new System.Windows.Forms.TextBox();
            this.buttonDodajUzytkownika = new System.Windows.Forms.Button();
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
            buttonDodajPracownika = new System.Windows.Forms.Button();
            this.panelLogowanie.SuspendLayout();
            this.panelPanelPracownika.SuspendLayout();
            this.panelDodajUzytkownika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogowanie)).BeginInit();
            this.panelRejestracja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRejestracjaHaslo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodajPracownika
            // 
            buttonDodajPracownika.BackgroundImage = global::Twixv2.Properties.Resources.button_Add_user;
            buttonDodajPracownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonDodajPracownika.Location = new System.Drawing.Point(18, 154);
            buttonDodajPracownika.Name = "buttonDodajPracownika";
            buttonDodajPracownika.Size = new System.Drawing.Size(159, 39);
            buttonDodajPracownika.TabIndex = 0;
            buttonDodajPracownika.UseVisualStyleBackColor = true;
            buttonDodajPracownika.Click += new System.EventHandler(this.buttonDodajPracownika_Click);
            // 
            // buttonOknoGlowneZaloguj
            // 
            this.buttonOknoGlowneZaloguj.BackColor = System.Drawing.Color.Transparent;
            this.buttonOknoGlowneZaloguj.BackgroundImage = global::Twixv2.Properties.Resources.button_zaloguj;
            this.buttonOknoGlowneZaloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOknoGlowneZaloguj.Location = new System.Drawing.Point(630, 164);
            this.buttonOknoGlowneZaloguj.Name = "buttonOknoGlowneZaloguj";
            this.buttonOknoGlowneZaloguj.Size = new System.Drawing.Size(138, 46);
            this.buttonOknoGlowneZaloguj.TabIndex = 0;
            this.buttonOknoGlowneZaloguj.UseVisualStyleBackColor = false;
            this.buttonOknoGlowneZaloguj.Click += new System.EventHandler(this.buttonOknoGlowneZaloguj_Click);
            // 
            // buttonOknoGlowneZarejestruj
            // 
            this.buttonOknoGlowneZarejestruj.BackgroundImage = global::Twixv2.Properties.Resources.button_zarejestruj;
            this.buttonOknoGlowneZarejestruj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOknoGlowneZarejestruj.Location = new System.Drawing.Point(545, 257);
            this.buttonOknoGlowneZarejestruj.Name = "buttonOknoGlowneZarejestruj";
            this.buttonOknoGlowneZarejestruj.Size = new System.Drawing.Size(223, 46);
            this.buttonOknoGlowneZarejestruj.TabIndex = 1;
            this.buttonOknoGlowneZarejestruj.UseVisualStyleBackColor = true;
            this.buttonOknoGlowneZarejestruj.Click += new System.EventHandler(this.buttonOknoGlowneZarejestruj_Click);
            // 
            // buttonOknoGlowneWyjdz
            // 
            this.buttonOknoGlowneWyjdz.BackgroundImage = global::Twixv2.Properties.Resources.button_zamknij;
            this.buttonOknoGlowneWyjdz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOknoGlowneWyjdz.Location = new System.Drawing.Point(618, 409);
            this.buttonOknoGlowneWyjdz.Name = "buttonOknoGlowneWyjdz";
            this.buttonOknoGlowneWyjdz.Size = new System.Drawing.Size(150, 43);
            this.buttonOknoGlowneWyjdz.TabIndex = 2;
            this.buttonOknoGlowneWyjdz.UseVisualStyleBackColor = true;
            this.buttonOknoGlowneWyjdz.Click += new System.EventHandler(this.buttonOknoGlowneWyjdz_Click);
            // 
            // panelLogowanie
            // 
            this.panelLogowanie.BackgroundImage = global::Twixv2.Properties.Resources.Zaloguj_background;
            this.panelLogowanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogowanie.Controls.Add(this.labelLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.labelLogowanieLogin);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieHaslo);
            this.panelLogowanie.Controls.Add(this.textBoxLogowanieLogin);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieZaloguj);
            this.panelLogowanie.Controls.Add(this.buttonLogowanieWroc);
            this.panelLogowanie.Location = new System.Drawing.Point(0, 0);
            this.panelLogowanie.Name = "panelLogowanie";
            this.panelLogowanie.Size = new System.Drawing.Size(800, 600);
            this.panelLogowanie.TabIndex = 3;
            // 
            // labelLogowanieHaslo
            // 
            this.labelLogowanieHaslo.AutoSize = true;
            this.labelLogowanieHaslo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogowanieHaslo.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogowanieHaslo.Location = new System.Drawing.Point(559, 231);
            this.labelLogowanieHaslo.Name = "labelLogowanieHaslo";
            this.labelLogowanieHaslo.Size = new System.Drawing.Size(46, 18);
            this.labelLogowanieHaslo.TabIndex = 5;
            this.labelLogowanieHaslo.Text = "Hasło";
            // 
            // labelLogowanieLogin
            // 
            this.labelLogowanieLogin.AutoSize = true;
            this.labelLogowanieLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogowanieLogin.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogowanieLogin.Location = new System.Drawing.Point(399, 232);
            this.labelLogowanieLogin.Name = "labelLogowanieLogin";
            this.labelLogowanieLogin.Size = new System.Drawing.Size(40, 18);
            this.labelLogowanieLogin.TabIndex = 4;
            this.labelLogowanieLogin.Text = "Login";
            // 
            // textBoxLogowanieHaslo
            // 
            this.textBoxLogowanieHaslo.Location = new System.Drawing.Point(534, 253);
            this.textBoxLogowanieHaslo.Name = "textBoxLogowanieHaslo";
            this.textBoxLogowanieHaslo.PasswordChar = '*';
            this.textBoxLogowanieHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieHaslo.TabIndex = 3;
            this.textBoxLogowanieHaslo.Leave += new System.EventHandler(this.textBoxLogowanieHaslo_Leave);
            // 
            // textBoxLogowanieLogin
            // 
            this.textBoxLogowanieLogin.Location = new System.Drawing.Point(381, 253);
            this.textBoxLogowanieLogin.Name = "textBoxLogowanieLogin";
            this.textBoxLogowanieLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogowanieLogin.TabIndex = 2;
            this.textBoxLogowanieLogin.Leave += new System.EventHandler(this.textBoxLogowanieLogin_Leave);
            // 
            // buttonLogowanieZaloguj
            // 
            this.buttonLogowanieZaloguj.BackgroundImage = global::Twixv2.Properties.Resources.button_zaloguj;
            this.buttonLogowanieZaloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogowanieZaloguj.Location = new System.Drawing.Point(469, 299);
            this.buttonLogowanieZaloguj.Name = "buttonLogowanieZaloguj";
            this.buttonLogowanieZaloguj.Size = new System.Drawing.Size(105, 36);
            this.buttonLogowanieZaloguj.TabIndex = 1;
            this.buttonLogowanieZaloguj.UseVisualStyleBackColor = true;
            this.buttonLogowanieZaloguj.Click += new System.EventHandler(this.buttonLogowanieZaloguj_Click);
            // 
            // buttonLogowanieWroc
            // 
            this.buttonLogowanieWroc.BackgroundImage = global::Twixv2.Properties.Resources.button_cofnij;
            this.buttonLogowanieWroc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogowanieWroc.Location = new System.Drawing.Point(545, 362);
            this.buttonLogowanieWroc.Name = "buttonLogowanieWroc";
            this.buttonLogowanieWroc.Size = new System.Drawing.Size(89, 32);
            this.buttonLogowanieWroc.TabIndex = 0;
            this.buttonLogowanieWroc.UseVisualStyleBackColor = true;
            this.buttonLogowanieWroc.Click += new System.EventHandler(this.buttonLogowanieWroc_Click);
            // 
            // panelPanelPracownika
            // 
            this.panelPanelPracownika.BackgroundImage = global::Twixv2.Properties.Resources.PanelPracownika_background;
            this.panelPanelPracownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPanelPracownika.Controls.Add(buttonDodajPracownika);
            this.panelPanelPracownika.Location = new System.Drawing.Point(0, 0);
            this.panelPanelPracownika.Name = "panelPanelPracownika";
            this.panelPanelPracownika.Size = new System.Drawing.Size(800, 600);
            this.panelPanelPracownika.TabIndex = 6;
            // 
            // panelDodajUzytkownika
            // 
            this.panelDodajUzytkownika.BackgroundImage = global::Twixv2.Properties.Resources.Dodaj_uzytkownika_background;
            this.panelDodajUzytkownika.Controls.Add(this.checkBox1);
            this.panelDodajUzytkownika.Controls.Add(this.textBoxDodajLogin);
            this.panelDodajUzytkownika.Controls.Add(this.buttonWrocDoPaneluPracownika);
            this.panelDodajUzytkownika.Controls.Add(this.checkBoxCzyAdmin);
            this.panelDodajUzytkownika.Controls.Add(this.textBoxDodajNrDowodu);
            this.panelDodajUzytkownika.Controls.Add(this.textBoxDodajPesel);
            this.panelDodajUzytkownika.Controls.Add(this.textBoxDodajNazwisko);
            this.panelDodajUzytkownika.Controls.Add(this.textBoxDodajImie);
            this.panelDodajUzytkownika.Controls.Add(this.buttonDodajUzytkownika);
            this.panelDodajUzytkownika.Font = new System.Drawing.Font("Pricedown Bl", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelDodajUzytkownika.Location = new System.Drawing.Point(0, 0);
            this.panelDodajUzytkownika.Name = "panelDodajUzytkownika";
            this.panelDodajUzytkownika.Size = new System.Drawing.Size(800, 600);
            this.panelDodajUzytkownika.TabIndex = 1;
            this.panelDodajUzytkownika.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDodajUzytkownika_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(40, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxDodajLogin
            // 
            this.textBoxDodajLogin.Location = new System.Drawing.Point(40, 145);
            this.textBoxDodajLogin.Name = "textBoxDodajLogin";
            this.textBoxDodajLogin.Size = new System.Drawing.Size(100, 21);
            this.textBoxDodajLogin.TabIndex = 7;
            this.textBoxDodajLogin.Text = "Login";
            this.textBoxDodajLogin.Click += new System.EventHandler(this.textBoxDodajLogin_Click);
            this.textBoxDodajLogin.TextChanged += new System.EventHandler(this.textBoxDodajLogin_TextChanged);
            // 
            // buttonWrocDoPaneluPracownika
            // 
            this.buttonWrocDoPaneluPracownika.Location = new System.Drawing.Point(50, 276);
            this.buttonWrocDoPaneluPracownika.Name = "buttonWrocDoPaneluPracownika";
            this.buttonWrocDoPaneluPracownika.Size = new System.Drawing.Size(75, 23);
            this.buttonWrocDoPaneluPracownika.TabIndex = 6;
            this.buttonWrocDoPaneluPracownika.Text = "Wróć";
            this.buttonWrocDoPaneluPracownika.UseVisualStyleBackColor = true;
            this.buttonWrocDoPaneluPracownika.Click += new System.EventHandler(this.buttonWrocDoPaneluPracownika_Click);
            // 
            // checkBoxCzyAdmin
            // 
            this.checkBoxCzyAdmin.AutoSize = true;
            this.checkBoxCzyAdmin.Location = new System.Drawing.Point(40, 209);
            this.checkBoxCzyAdmin.Name = "checkBoxCzyAdmin";
            this.checkBoxCzyAdmin.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCzyAdmin.TabIndex = 5;
            this.checkBoxCzyAdmin.Text = "ADMIN ?";
            this.checkBoxCzyAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxDodajNrDowodu
            // 
            this.textBoxDodajNrDowodu.Location = new System.Drawing.Point(40, 117);
            this.textBoxDodajNrDowodu.MaxLength = 9;
            this.textBoxDodajNrDowodu.Name = "textBoxDodajNrDowodu";
            this.textBoxDodajNrDowodu.Size = new System.Drawing.Size(100, 21);
            this.textBoxDodajNrDowodu.TabIndex = 4;
            this.textBoxDodajNrDowodu.Text = "Nr Dowodu";
            this.textBoxDodajNrDowodu.Click += new System.EventHandler(this.textBoxDodajNrDowodu_Click);
            // 
            // textBoxDodajPesel
            // 
            this.textBoxDodajPesel.Location = new System.Drawing.Point(40, 89);
            this.textBoxDodajPesel.MaxLength = 11;
            this.textBoxDodajPesel.Name = "textBoxDodajPesel";
            this.textBoxDodajPesel.Size = new System.Drawing.Size(100, 21);
            this.textBoxDodajPesel.TabIndex = 3;
            this.textBoxDodajPesel.Text = "Pesel";
            this.textBoxDodajPesel.Click += new System.EventHandler(this.textBoxDodajPesel_Click);
            this.textBoxDodajPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDodajPesel_KeyPress);
            // 
            // textBoxDodajNazwisko
            // 
            this.textBoxDodajNazwisko.Location = new System.Drawing.Point(40, 61);
            this.textBoxDodajNazwisko.Name = "textBoxDodajNazwisko";
            this.textBoxDodajNazwisko.Size = new System.Drawing.Size(100, 21);
            this.textBoxDodajNazwisko.TabIndex = 2;
            this.textBoxDodajNazwisko.Text = "Nazwisko";
            this.textBoxDodajNazwisko.Click += new System.EventHandler(this.textBoxDodajNazwisko_Click);
            // 
            // textBoxDodajImie
            // 
            this.textBoxDodajImie.Location = new System.Drawing.Point(40, 33);
            this.textBoxDodajImie.Name = "textBoxDodajImie";
            this.textBoxDodajImie.Size = new System.Drawing.Size(100, 21);
            this.textBoxDodajImie.TabIndex = 1;
            this.textBoxDodajImie.Text = "Imię";
            this.textBoxDodajImie.Click += new System.EventHandler(this.textBoxDodajImie_Click);
            // 
            // buttonDodajUzytkownika
            // 
            this.buttonDodajUzytkownika.Location = new System.Drawing.Point(193, 276);
            this.buttonDodajUzytkownika.Name = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajUzytkownika.TabIndex = 0;
            this.buttonDodajUzytkownika.Text = "Dodaj";
            this.buttonDodajUzytkownika.UseVisualStyleBackColor = true;
            this.buttonDodajUzytkownika.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // errorProviderLogowanie
            // 
            this.errorProviderLogowanie.ContainerControl = this;
            // 
            // panelRejestracja
            // 
            this.panelRejestracja.BackgroundImage = global::Twixv2.Properties.Resources.Rejestracja_background;
            this.panelRejestracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.panelRejestracja.Size = new System.Drawing.Size(800, 600);
            this.panelRejestracja.TabIndex = 4;
            // 
            // buttonRejestracjaZarejestruj
            // 
            this.buttonRejestracjaZarejestruj.BackgroundImage = global::Twixv2.Properties.Resources.button_zarejestruj;
            this.buttonRejestracjaZarejestruj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRejestracjaZarejestruj.Enabled = false;
            this.buttonRejestracjaZarejestruj.Location = new System.Drawing.Point(126, 200);
            this.buttonRejestracjaZarejestruj.Name = "buttonRejestracjaZarejestruj";
            this.buttonRejestracjaZarejestruj.Size = new System.Drawing.Size(100, 31);
            this.buttonRejestracjaZarejestruj.TabIndex = 15;
            this.buttonRejestracjaZarejestruj.UseVisualStyleBackColor = true;
            this.buttonRejestracjaZarejestruj.Click += new System.EventHandler(this.buttonRejestracjaZarejestruj_Click);
            // 
            // textBoxRejestracjaPowtorzHaslo
            // 
            this.textBoxRejestracjaPowtorzHaslo.Location = new System.Drawing.Point(126, 174);
            this.textBoxRejestracjaPowtorzHaslo.Name = "textBoxRejestracjaPowtorzHaslo";
            this.textBoxRejestracjaPowtorzHaslo.PasswordChar = '*';
            this.textBoxRejestracjaPowtorzHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaPowtorzHaslo.TabIndex = 14;
            this.textBoxRejestracjaPowtorzHaslo.Leave += new System.EventHandler(this.textBoxRejestracjaPowtorzHaslo_Leave);
            // 
            // labelRejestracjaPowtorzHaslo
            // 
            this.labelRejestracjaPowtorzHaslo.AutoSize = true;
            this.labelRejestracjaPowtorzHaslo.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaPowtorzHaslo.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaPowtorzHaslo.Location = new System.Drawing.Point(18, 180);
            this.labelRejestracjaPowtorzHaslo.Name = "labelRejestracjaPowtorzHaslo";
            this.labelRejestracjaPowtorzHaslo.Size = new System.Drawing.Size(110, 18);
            this.labelRejestracjaPowtorzHaslo.TabIndex = 13;
            this.labelRejestracjaPowtorzHaslo.Text = "Powtórz hasło";
            // 
            // labelRejestracjaHaslo
            // 
            this.labelRejestracjaHaslo.AutoSize = true;
            this.labelRejestracjaHaslo.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaHaslo.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaHaslo.Location = new System.Drawing.Point(18, 154);
            this.labelRejestracjaHaslo.Name = "labelRejestracjaHaslo";
            this.labelRejestracjaHaslo.Size = new System.Drawing.Size(46, 18);
            this.labelRejestracjaHaslo.TabIndex = 12;
            this.labelRejestracjaHaslo.Text = "Hasło";
            // 
            // textBoxRejestracjaHaslo
            // 
            this.textBoxRejestracjaHaslo.Location = new System.Drawing.Point(126, 148);
            this.textBoxRejestracjaHaslo.Name = "textBoxRejestracjaHaslo";
            this.textBoxRejestracjaHaslo.PasswordChar = '*';
            this.textBoxRejestracjaHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaHaslo.TabIndex = 11;
            // 
            // textBoxRejestracjaLogin
            // 
            this.textBoxRejestracjaLogin.Location = new System.Drawing.Point(126, 122);
            this.textBoxRejestracjaLogin.Name = "textBoxRejestracjaLogin";
            this.textBoxRejestracjaLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaLogin.TabIndex = 10;
            // 
            // textBoxRejestracjaNrDowodu
            // 
            this.textBoxRejestracjaNrDowodu.Location = new System.Drawing.Point(126, 96);
            this.textBoxRejestracjaNrDowodu.Name = "textBoxRejestracjaNrDowodu";
            this.textBoxRejestracjaNrDowodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNrDowodu.TabIndex = 9;
            // 
            // textBoxRejestracjaPesel
            // 
            this.textBoxRejestracjaPesel.Location = new System.Drawing.Point(126, 70);
            this.textBoxRejestracjaPesel.Name = "textBoxRejestracjaPesel";
            this.textBoxRejestracjaPesel.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaPesel.TabIndex = 8;
            // 
            // textBoxRejestracjaNazwisko
            // 
            this.textBoxRejestracjaNazwisko.Location = new System.Drawing.Point(126, 44);
            this.textBoxRejestracjaNazwisko.Name = "textBoxRejestracjaNazwisko";
            this.textBoxRejestracjaNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaNazwisko.TabIndex = 7;
            // 
            // textBoxRejestracjaImie
            // 
            this.textBoxRejestracjaImie.Location = new System.Drawing.Point(126, 18);
            this.textBoxRejestracjaImie.Name = "textBoxRejestracjaImie";
            this.textBoxRejestracjaImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxRejestracjaImie.TabIndex = 6;
            // 
            // labelRejestracjaLogin
            // 
            this.labelRejestracjaLogin.AutoSize = true;
            this.labelRejestracjaLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaLogin.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaLogin.Location = new System.Drawing.Point(18, 128);
            this.labelRejestracjaLogin.Name = "labelRejestracjaLogin";
            this.labelRejestracjaLogin.Size = new System.Drawing.Size(40, 18);
            this.labelRejestracjaLogin.TabIndex = 5;
            this.labelRejestracjaLogin.Text = "Login";
            // 
            // labelRejestracjaNrDowodu
            // 
            this.labelRejestracjaNrDowodu.AutoSize = true;
            this.labelRejestracjaNrDowodu.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaNrDowodu.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaNrDowodu.Location = new System.Drawing.Point(18, 102);
            this.labelRejestracjaNrDowodu.Name = "labelRejestracjaNrDowodu";
            this.labelRejestracjaNrDowodu.Size = new System.Drawing.Size(80, 18);
            this.labelRejestracjaNrDowodu.TabIndex = 4;
            this.labelRejestracjaNrDowodu.Text = "Nr dowodu";
            // 
            // labelRejestracjaPesel
            // 
            this.labelRejestracjaPesel.AutoSize = true;
            this.labelRejestracjaPesel.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaPesel.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaPesel.Location = new System.Drawing.Point(18, 76);
            this.labelRejestracjaPesel.Name = "labelRejestracjaPesel";
            this.labelRejestracjaPesel.Size = new System.Drawing.Size(46, 18);
            this.labelRejestracjaPesel.TabIndex = 3;
            this.labelRejestracjaPesel.Text = "Pesel";
            // 
            // labelRejestracjaNazwisko
            // 
            this.labelRejestracjaNazwisko.AutoSize = true;
            this.labelRejestracjaNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaNazwisko.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaNazwisko.Location = new System.Drawing.Point(18, 50);
            this.labelRejestracjaNazwisko.Name = "labelRejestracjaNazwisko";
            this.labelRejestracjaNazwisko.Size = new System.Drawing.Size(73, 18);
            this.labelRejestracjaNazwisko.TabIndex = 2;
            this.labelRejestracjaNazwisko.Text = "Nazwisko";
            // 
            // labelRejestracjaImie
            // 
            this.labelRejestracjaImie.AutoSize = true;
            this.labelRejestracjaImie.BackColor = System.Drawing.Color.Transparent;
            this.labelRejestracjaImie.Font = new System.Drawing.Font("Pricedown Bl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracjaImie.Location = new System.Drawing.Point(18, 24);
            this.labelRejestracjaImie.Name = "labelRejestracjaImie";
            this.labelRejestracjaImie.Size = new System.Drawing.Size(36, 18);
            this.labelRejestracjaImie.TabIndex = 1;
            this.labelRejestracjaImie.Text = "Imię";
            // 
            // buttonRejestracjaWroc
            // 
            this.buttonRejestracjaWroc.BackgroundImage = global::Twixv2.Properties.Resources.button_cofnij;
            this.buttonRejestracjaWroc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRejestracjaWroc.Location = new System.Drawing.Point(18, 399);
            this.buttonRejestracjaWroc.Name = "buttonRejestracjaWroc";
            this.buttonRejestracjaWroc.Size = new System.Drawing.Size(91, 33);
            this.buttonRejestracjaWroc.TabIndex = 0;
            this.buttonRejestracjaWroc.UseVisualStyleBackColor = true;
            this.buttonRejestracjaWroc.Click += new System.EventHandler(this.buttonRejestracjaWroc_Click);
            // 
            // errorProviderRejestracjaHaslo
            // 
            this.errorProviderRejestracjaHaslo.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Twixv2.Properties.Resources.Home_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 583);
            this.Controls.Add(this.panelRejestracja);
            this.Controls.Add(this.panelLogowanie);
            this.Controls.Add(this.panelPanelPracownika);
            this.Controls.Add(this.buttonOknoGlowneZarejestruj);
            this.Controls.Add(this.panelDodajUzytkownika);
            this.Controls.Add(this.buttonOknoGlowneWyjdz);
            this.Controls.Add(this.buttonOknoGlowneZaloguj);
            this.Name = "Form1";
            this.Text = "Twix";
            this.panelLogowanie.ResumeLayout(false);
            this.panelLogowanie.PerformLayout();
            this.panelPanelPracownika.ResumeLayout(false);
            this.panelDodajUzytkownika.ResumeLayout(false);
            this.panelDodajUzytkownika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogowanie)).EndInit();
            this.panelRejestracja.ResumeLayout(false);
            this.panelRejestracja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRejestracjaHaslo)).EndInit();
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
        private System.Windows.Forms.Panel panelPanelPracownika;
        private System.Windows.Forms.Panel panelDodajUzytkownika;
        private System.Windows.Forms.Button buttonDodajUzytkownika;
        private System.Windows.Forms.TextBox textBoxDodajImie;
        private System.Windows.Forms.TextBox textBoxDodajPesel;
        private System.Windows.Forms.TextBox textBoxDodajNazwisko;
        private System.Windows.Forms.TextBox textBoxDodajNrDowodu;
        private System.Windows.Forms.CheckBox checkBoxCzyAdmin;
        private System.Windows.Forms.Button buttonWrocDoPaneluPracownika;
        private System.Windows.Forms.TextBox textBoxDodajLogin;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

