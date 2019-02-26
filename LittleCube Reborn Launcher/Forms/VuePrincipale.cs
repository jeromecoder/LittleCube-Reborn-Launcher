using LittleCube_Reborn_Launcher.Classes;
using LittleCube_Reborn_Launcher.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleCube_Reborn_Launcher
{
    public partial class VuePrincipale : Form
    {
        private Boolean _isMouseHoverShowPasswordButton = false;

        public VuePrincipale()
        {
            InitializeComponent();
            this.Size = Statics.FormSize;
            this.HideAllPanelsExeptMe(PanelInformations);
            richtext_informations.Rtf = Resources.No_server;
            UserPanel.Visible = false;
        }

        #region Déplacement de la fenêtre
        private Point lastLocation;
        private Boolean mouseDown;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        #endregion

        #region Gestion de l'affichage des panels
        private void HideAllPanelsExeptMe(Panel p)
        {
            foreach(Control c in this.Controls)
            {
                if(c is Panel)
                {
                    Panel cc = (Panel)c;
                    if (!cc.Name.Equals(p.Name) && !(cc.Name.Equals(panel_menu.Name)))
                    {
                        cc.Hide();
                    }
                    else
                    {
                        cc.Show();
                        cc.Size = Statics.PanelSize;
                        cc.Location = Statics.PanelLocation;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.HideAllPanelsExeptMe(this.PanelInformations);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.HideAllPanelsExeptMe(this.PanelIdentifiants);
            this.UpdateIdentifiantsListe();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.HideAllPanelsExeptMe(this.PanelJouer);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            HideAllPanelsExeptMe(panelProfils);
            UpdateIdentifiantsListeProfils();
        }
        #endregion

        #region Identifiants
        #region ShowPassword or not
        private void showPassword_MouseHover(object sender, EventArgs e)
        {
            showPassword.BackColor = Color.SeaGreen;
            this._isMouseHoverShowPasswordButton = true;
        }
        private void showPassword_MouseLeave(object sender, EventArgs e)
        {
            showPassword.BackColor = Color.Transparent;
            this._isMouseHoverShowPasswordButton = false;
            TextBox_Pass.UseSystemPasswordChar = !this._isMouseHoverShowPasswordButton;
        }
        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox_Pass.UseSystemPasswordChar = !this._isMouseHoverShowPasswordButton;
        }
        private void PanelIdentifiants_MouseHover(object sender, EventArgs e)
        {
            showPassword.BackColor = Color.Transparent;
            this._isMouseHoverShowPasswordButton = false;
            TextBox_Pass.UseSystemPasswordChar = !this._isMouseHoverShowPasswordButton;
        }
        #endregion
        private void UpdateIdentifiantsListe()
        {
            listbox_identifiants.Items.Clear();
            ArrayList a = Fonctions.GetAllUsers();
            if (!(a is null)) listbox_identifiants.Items.AddRange(a.ToArray());
        }
        private void listbox_identifiants_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int n = this.listbox_identifiants.IndexFromPoint(e.X, e.Y);
                if (n != ListBox.NoMatches)
                    this.listbox_identifiants.SelectedIndex = n;
            }
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listbox_identifiants.SelectedIndex == -1)
                return;

            string user = listbox_identifiants.SelectedItem.ToString().Replace("[Défaut]", "");
            this.listbox_identifiants.Items.RemoveAt(this.listbox_identifiants.SelectedIndex);            
            Fonctions.deleteUserFromRegistry(user);
        }
        private void compteParDéfautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listbox_identifiants.SelectedIndex > -1)
            {
                Fonctions.SetCompteAsDefault(this.listbox_identifiants.SelectedItem.ToString());
                for (var i = 0; i <= listbox_identifiants.Items.Count - 1; i++)
                {
                    if (this.listbox_identifiants.Items[i].Equals(this.listbox_identifiants.SelectedItem))
                        this.listbox_identifiants.Items[i] = listbox_identifiants.Items[i] + "[Défaut]";
                    else
                        this.listbox_identifiants.Items[i] = listbox_identifiants.Items[i].ToString().Replace("[Défaut]", "");
                }
            }
        }
        private void listbox_identifiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listbox_identifiants.SelectedIndex > -1)
            {
                string s = this.listbox_identifiants.SelectedItem.ToString();
                if (s.Contains("[Défaut]"))
                    s = s.Replace("[Défaut]", "");

                ArrayList a = Fonctions.GetUser(s);
                if (a.Count > 0)
                {
                    this.TextBox_User.Text = a[0].ToString();
                    this.TextBox_Pass.Text = a[1].ToString();
                }
            }
        }
        private void Enregistrer_identifiant_Click(object sender, EventArgs e)
        {
            Boolean success;
            TextBox_User.Enabled = false;
            TextBox_Pass.Enabled = false;
            ArrayList list = Fonctions.Authentification(TextBox_User.Text, TextBox_Pass.Text);
            if(list.Count>1 && !list[0].Equals("Erreur")){
                Fonctions.WriteIdentifiantToRegistry(TextBox_User.Text, TextBox_Pass.Text, CheckBox_Defaut.Checked);
                TextBox_User.Text = "";
                TextBox_Pass.Text = "";
                CheckBox_Defaut.Checked = false;
                this.UpdateIdentifiantsListe();
                success = true;
            }
            else
            {
                success = false;
            }

            Thread t = new Thread(() => startColorAnimationAfterIdentifiantIsEnregistrer(success));
            t.Start();
        }
        private void startColorAnimationAfterIdentifiantIsEnregistrer(Boolean success)
        {
            Color previous = TextBox_User.BackColor;
            Color c;
            if (success)
                c = Color.DarkGreen;
            else
                c = Color.DarkRed;
            ChangeTextBoxBackColor(TextBox_User, c);
            ChangeTextBoxBackColor(TextBox_Pass, c);
            Thread.Sleep(1500);
            ChangeTextBoxBackColor(TextBox_User, previous);
            ChangeTextBoxBackColor(TextBox_Pass, previous);
            ChangeEnabledTextbox(TextBox_User, true);
            ChangeEnabledTextbox(TextBox_Pass, true);
        }
        private void ChangeTextBoxBackColor(WindowsFormsControlLibrary1.BunifuCustomTextbox control, Color color)
        {
            control.Invoke((MethodInvoker)delegate { control.BackColor=color; });
        }
        private void ChangeEnabledTextbox(WindowsFormsControlLibrary1.BunifuCustomTextbox control, Boolean enabled)
        {
            control.Invoke((MethodInvoker)delegate { control.Enabled = enabled; });
        }
        #endregion

        #region Profils
        private void UpdateIdentifiantsListeProfils()
        {
            listbox_Profil.Items.Clear();
            ArrayList a = Fonctions.GetAllUsers();
            if (!(a is null)) listbox_Profil.Items.AddRange(a.ToArray());
        }
        #endregion

    }
}
