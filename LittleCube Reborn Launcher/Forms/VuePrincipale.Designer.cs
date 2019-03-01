namespace LittleCube_Reborn_Launcher
{
    partial class VuePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VuePrincipale));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelInformations = new System.Windows.Forms.Panel();
            this.richtext_informations = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelIdentifiants = new System.Windows.Forms.Panel();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.Enregistrer_identifiant = new System.Windows.Forms.Button();
            this.CheckBox_Defaut = new Bunifu.Framework.UI.BunifuCheckbox();
            this.text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextBox_Pass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextBox_User = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listbox_identifiants = new System.Windows.Forms.ListBox();
            this.contextMenu_Identifiants = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteParDéfautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelJouer = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelProfils = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.GroupBox();
            this.SaveProfil = new System.Windows.Forms.Button();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.JavaVersion = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RamAllocation = new Bunifu.Framework.UI.BunifuDropdown();
            this.UserHead = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listbox_Profil = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelIdentifiants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            this.contextMenu_Identifiants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PanelJouer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelProfils.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button9);
            this.panel_menu.Controls.Add(this.button4);
            this.panel_menu.Controls.Add(this.button3);
            this.panel_menu.Controls.Add(this.button2);
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 653);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.panel_menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button9
            // 
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 303);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 45);
            this.button9.TabIndex = 5;
            this.button9.Text = "Profils";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Jouer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Identifiants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LittleCube_Reborn_Launcher.Properties.Resources.LittleCube_Reborn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 215);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // PanelInformations
            // 
            this.PanelInformations.Controls.Add(this.richtext_informations);
            this.PanelInformations.Controls.Add(this.pictureBox2);
            this.PanelInformations.Location = new System.Drawing.Point(1093, 12);
            this.PanelInformations.Name = "PanelInformations";
            this.PanelInformations.Size = new System.Drawing.Size(119, 191);
            this.PanelInformations.TabIndex = 8;
            this.PanelInformations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.PanelInformations.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.PanelInformations.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // richtext_informations
            // 
            this.richtext_informations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.richtext_informations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtext_informations.Location = new System.Drawing.Point(3, 136);
            this.richtext_informations.Name = "richtext_informations";
            this.richtext_informations.Size = new System.Drawing.Size(600, 280);
            this.richtext_informations.TabIndex = 2;
            this.richtext_informations.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::LittleCube_Reborn_Launcher.Properties.Resources.Informations;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // PanelIdentifiants
            // 
            this.PanelIdentifiants.Controls.Add(this.showPassword);
            this.PanelIdentifiants.Controls.Add(this.Enregistrer_identifiant);
            this.PanelIdentifiants.Controls.Add(this.CheckBox_Defaut);
            this.PanelIdentifiants.Controls.Add(this.text);
            this.PanelIdentifiants.Controls.Add(this.TextBox_Pass);
            this.PanelIdentifiants.Controls.Add(this.bunifuCustomLabel4);
            this.PanelIdentifiants.Controls.Add(this.TextBox_User);
            this.PanelIdentifiants.Controls.Add(this.bunifuCustomLabel3);
            this.PanelIdentifiants.Controls.Add(this.bunifuCustomLabel2);
            this.PanelIdentifiants.Controls.Add(this.bunifuCustomLabel1);
            this.PanelIdentifiants.Controls.Add(this.listbox_identifiants);
            this.PanelIdentifiants.Controls.Add(this.pictureBox3);
            this.PanelIdentifiants.Location = new System.Drawing.Point(862, 228);
            this.PanelIdentifiants.Name = "PanelIdentifiants";
            this.PanelIdentifiants.Size = new System.Drawing.Size(365, 413);
            this.PanelIdentifiants.TabIndex = 9;
            this.PanelIdentifiants.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.PanelIdentifiants.MouseHover += new System.EventHandler(this.PanelIdentifiants_MouseHover);
            this.PanelIdentifiants.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.PanelIdentifiants.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // showPassword
            // 
            this.showPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(548, 259);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(24, 23);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassword.TabIndex = 13;
            this.showPassword.TabStop = false;
            this.showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassword_MouseDown);
            this.showPassword.MouseLeave += new System.EventHandler(this.showPassword_MouseLeave);
            this.showPassword.MouseHover += new System.EventHandler(this.showPassword_MouseHover);
            // 
            // Enregistrer_identifiant
            // 
            this.Enregistrer_identifiant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Enregistrer_identifiant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Enregistrer_identifiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer_identifiant.Location = new System.Drawing.Point(342, 321);
            this.Enregistrer_identifiant.Name = "Enregistrer_identifiant";
            this.Enregistrer_identifiant.Size = new System.Drawing.Size(200, 45);
            this.Enregistrer_identifiant.TabIndex = 5;
            this.Enregistrer_identifiant.Text = "Enregistrer";
            this.Enregistrer_identifiant.UseVisualStyleBackColor = true;
            this.Enregistrer_identifiant.Click += new System.EventHandler(this.Enregistrer_identifiant_Click);
            // 
            // CheckBox_Defaut
            // 
            this.CheckBox_Defaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBox_Defaut.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBox_Defaut.Checked = false;
            this.CheckBox_Defaut.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBox_Defaut.ForeColor = System.Drawing.Color.White;
            this.CheckBox_Defaut.Location = new System.Drawing.Point(352, 292);
            this.CheckBox_Defaut.Margin = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.CheckBox_Defaut.Name = "CheckBox_Defaut";
            this.CheckBox_Defaut.Size = new System.Drawing.Size(20, 20);
            this.CheckBox_Defaut.TabIndex = 12;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(376, 296);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(161, 12);
            this.text.TabIndex = 11;
            this.text.Text = "Utiliser par defaut";
            // 
            // TextBox_Pass
            // 
            this.TextBox_Pass.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextBox_Pass.Font = new System.Drawing.Font("Minecraft", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Pass.Location = new System.Drawing.Point(342, 259);
            this.TextBox_Pass.Name = "TextBox_Pass";
            this.TextBox_Pass.Size = new System.Drawing.Size(200, 23);
            this.TextBox_Pass.TabIndex = 7;
            this.TextBox_Pass.UseSystemPasswordChar = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(388, 243);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(112, 12);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Mot de passe";
            // 
            // TextBox_User
            // 
            this.TextBox_User.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextBox_User.Font = new System.Drawing.Font("Minecraft", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_User.Location = new System.Drawing.Point(342, 201);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(200, 23);
            this.TextBox_User.TabIndex = 5;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(397, 186);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 12);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Identifiant";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(111, 167);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 12);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Utilisateurs";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 366);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(248, 48);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Cliquez sur un utilisateur \r\npour charger les identifiants\r\nou\r\nClic droit pour p" +
    "lus d\'options";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listbox_identifiants
            // 
            this.listbox_identifiants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listbox_identifiants.ContextMenuStrip = this.contextMenu_Identifiants;
            this.listbox_identifiants.Font = new System.Drawing.Font("Minecraft", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_identifiants.ForeColor = System.Drawing.Color.White;
            this.listbox_identifiants.FormattingEnabled = true;
            this.listbox_identifiants.Location = new System.Drawing.Point(3, 188);
            this.listbox_identifiants.Name = "listbox_identifiants";
            this.listbox_identifiants.Size = new System.Drawing.Size(313, 173);
            this.listbox_identifiants.TabIndex = 1;
            this.listbox_identifiants.SelectedIndexChanged += new System.EventHandler(this.listbox_identifiants_SelectedIndexChanged);
            this.listbox_identifiants.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listbox_identifiants_MouseDown);
            // 
            // contextMenu_Identifiants
            // 
            this.contextMenu_Identifiants.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.compteParDéfautToolStripMenuItem});
            this.contextMenu_Identifiants.Name = "contextMenu_Identifiants";
            this.contextMenu_Identifiants.Size = new System.Drawing.Size(175, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // compteParDéfautToolStripMenuItem
            // 
            this.compteParDéfautToolStripMenuItem.Name = "compteParDéfautToolStripMenuItem";
            this.compteParDéfautToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.compteParDéfautToolStripMenuItem.Text = "Compte par défaut";
            this.compteParDéfautToolStripMenuItem.Click += new System.EventHandler(this.compteParDéfautToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::LittleCube_Reborn_Launcher.Properties.Resources.Identifiants;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(365, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // PanelJouer
            // 
            this.PanelJouer.Controls.Add(this.pictureBox4);
            this.PanelJouer.Location = new System.Drawing.Point(984, 12);
            this.PanelJouer.Name = "PanelJouer";
            this.PanelJouer.Size = new System.Drawing.Size(103, 142);
            this.PanelJouer.TabIndex = 10;
            this.PanelJouer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.PanelJouer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.PanelJouer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = global::LittleCube_Reborn_Launcher.Properties.Resources.Jouer;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 158);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button5
            // 
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(855, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 45);
            this.button5.TabIndex = 11;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Minecrafter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(813, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 45);
            this.button6.TabIndex = 12;
            this.button6.Text = "_";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelProfils
            // 
            this.panelProfils.Controls.Add(this.UserPanel);
            this.panelProfils.Controls.Add(this.bunifuCustomLabel5);
            this.panelProfils.Controls.Add(this.bunifuCustomLabel7);
            this.panelProfils.Controls.Add(this.listbox_Profil);
            this.panelProfils.Controls.Add(this.pictureBox5);
            this.panelProfils.Location = new System.Drawing.Point(201, 1);
            this.panelProfils.Name = "panelProfils";
            this.panelProfils.Size = new System.Drawing.Size(700, 551);
            this.panelProfils.TabIndex = 13;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.SaveProfil);
            this.UserPanel.Controls.Add(this.bunifuCustomLabel10);
            this.UserPanel.Controls.Add(this.JavaVersion);
            this.UserPanel.Controls.Add(this.bunifuCustomLabel8);
            this.UserPanel.Controls.Add(this.RamAllocation);
            this.UserPanel.Controls.Add(this.UserHead);
            this.UserPanel.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPanel.Location = new System.Drawing.Point(335, 171);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(347, 264);
            this.UserPanel.TabIndex = 7;
            this.UserPanel.TabStop = false;
            this.UserPanel.Text = "groupBox1";
            // 
            // SaveProfil
            // 
            this.SaveProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.SaveProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProfil.Image = ((System.Drawing.Image)(resources.GetObject("SaveProfil.Image")));
            this.SaveProfil.Location = new System.Drawing.Point(267, 169);
            this.SaveProfil.Name = "SaveProfil";
            this.SaveProfil.Size = new System.Drawing.Size(77, 79);
            this.SaveProfil.TabIndex = 6;
            this.SaveProfil.UseVisualStyleBackColor = true;
            this.SaveProfil.Click += new System.EventHandler(this.SaveProfil_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(15, 205);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(132, 12);
            this.bunifuCustomLabel10.TabIndex = 11;
            this.bunifuCustomLabel10.Text = "Version de JAVA";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JavaVersion
            // 
            this.JavaVersion.BackColor = System.Drawing.Color.Transparent;
            this.JavaVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JavaVersion.Font = new System.Drawing.Font("Minecraft", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaVersion.ForeColor = System.Drawing.Color.White;
            this.JavaVersion.Items = new string[0];
            this.JavaVersion.Location = new System.Drawing.Point(16, 223);
            this.JavaVersion.Margin = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.JavaVersion.Name = "JavaVersion";
            this.JavaVersion.NomalColor = System.Drawing.Color.Transparent;
            this.JavaVersion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.JavaVersion.selectedIndex = -1;
            this.JavaVersion.Size = new System.Drawing.Size(240, 25);
            this.JavaVersion.TabIndex = 9;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(14, 153);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(127, 12);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Allocation RAM";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RamAllocation
            // 
            this.RamAllocation.BackColor = System.Drawing.Color.Transparent;
            this.RamAllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RamAllocation.Font = new System.Drawing.Font("Minecraft", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamAllocation.ForeColor = System.Drawing.Color.White;
            this.RamAllocation.Items = new string[0];
            this.RamAllocation.Location = new System.Drawing.Point(16, 169);
            this.RamAllocation.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.RamAllocation.Name = "RamAllocation";
            this.RamAllocation.NomalColor = System.Drawing.Color.Transparent;
            this.RamAllocation.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.RamAllocation.selectedIndex = -1;
            this.RamAllocation.Size = new System.Drawing.Size(240, 25);
            this.RamAllocation.TabIndex = 1;
            // 
            // UserHead
            // 
            this.UserHead.Location = new System.Drawing.Point(15, 27);
            this.UserHead.Name = "UserHead";
            this.UserHead.Size = new System.Drawing.Size(126, 106);
            this.UserHead.TabIndex = 0;
            this.UserHead.TabStop = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(118, 164);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 12);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Utilisateurs";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Minecrafter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(53, 360);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(233, 72);
            this.bunifuCustomLabel7.TabIndex = 5;
            this.bunifuCustomLabel7.Text = "Cliquez sur un utilisateur \r\npour modifier son profil.\r\n\r\nPour ajouter un utilisa" +
    "teur\r\nrendez vous dans l\'onglet \r\n\"Identifiants\".";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listbox_Profil
            // 
            this.listbox_Profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listbox_Profil.ContextMenuStrip = this.contextMenu_Identifiants;
            this.listbox_Profil.Font = new System.Drawing.Font("Minecraft", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_Profil.ForeColor = System.Drawing.Color.White;
            this.listbox_Profil.FormattingEnabled = true;
            this.listbox_Profil.Location = new System.Drawing.Point(16, 180);
            this.listbox_Profil.Name = "listbox_Profil";
            this.listbox_Profil.Size = new System.Drawing.Size(313, 173);
            this.listbox_Profil.TabIndex = 4;
            this.listbox_Profil.SelectedIndexChanged += new System.EventHandler(this.listbox_Profil_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(700, 126);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // VuePrincipale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1214, 653);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panelProfils);
            this.Controls.Add(this.PanelInformations);
            this.Controls.Add(this.PanelJouer);
            this.Controls.Add(this.PanelIdentifiants);
            this.Controls.Add(this.panel_menu);
            this.Font = new System.Drawing.Font("Minecrafter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VuePrincipale";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelIdentifiants.ResumeLayout(false);
            this.PanelIdentifiants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            this.contextMenu_Identifiants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PanelJouer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelProfils.ResumeLayout(false);
            this.panelProfils.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelInformations;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelIdentifiants;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel PanelJouer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richtext_informations;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ListBox listbox_identifiants;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Identifiants;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteParDéfautToolStripMenuItem;
        private System.Windows.Forms.Button Enregistrer_identifiant;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBox_Defaut;
        private Bunifu.Framework.UI.BunifuCustomLabel text;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextBox_Pass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextBox_User;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panelProfils;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ListBox listbox_Profil;
        private System.Windows.Forms.GroupBox UserPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuDropdown RamAllocation;
        private System.Windows.Forms.PictureBox UserHead;
        private System.Windows.Forms.Button SaveProfil;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuDropdown JavaVersion;
        private System.Windows.Forms.PictureBox showPassword;
    }
}

