namespace Projet_PFC_Gestion_Systeme_Hotelier.Views.Admin
{
    partial class Admin_page
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
            this.tab_admin_page = new System.Windows.Forms.TabControl();
            this.tab_ajouter = new System.Windows.Forms.TabPage();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label_matricule = new System.Windows.Forms.Label();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.label_mdp = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.text_mdp = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.text_matricule = new System.Windows.Forms.TextBox();
            this.tab_gerer = new System.Windows.Forms.TabPage();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_afficher = new System.Windows.Forms.Button();
            this.text_nomG = new System.Windows.Forms.TextBox();
            this.text_prenomG = new System.Windows.Forms.TextBox();
            this.text_mdpG = new System.Windows.Forms.TextBox();
            this.text_matriculeG = new System.Windows.Forms.TextBox();
            this.dataGrid_gestionHotel = new System.Windows.Forms.DataGridView();
            this.label_nomG = new System.Windows.Forms.Label();
            this.label_prenomG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_admin_page.SuspendLayout();
            this.tab_ajouter.SuspendLayout();
            this.tab_gerer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gestionHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_admin_page
            // 
            this.tab_admin_page.Controls.Add(this.tab_ajouter);
            this.tab_admin_page.Controls.Add(this.tab_gerer);
            this.tab_admin_page.Location = new System.Drawing.Point(5, 3);
            this.tab_admin_page.Name = "tab_admin_page";
            this.tab_admin_page.SelectedIndex = 0;
            this.tab_admin_page.Size = new System.Drawing.Size(487, 373);
            this.tab_admin_page.TabIndex = 20;
            // 
            // tab_ajouter
            // 
            this.tab_ajouter.Controls.Add(this.text_prenom);
            this.tab_ajouter.Controls.Add(this.button_ajouter);
            this.tab_ajouter.Controls.Add(this.label_matricule);
            this.tab_ajouter.Controls.Add(this.text_nom);
            this.tab_ajouter.Controls.Add(this.label_mdp);
            this.tab_ajouter.Controls.Add(this.label_prenom);
            this.tab_ajouter.Controls.Add(this.text_mdp);
            this.tab_ajouter.Controls.Add(this.label_nom);
            this.tab_ajouter.Controls.Add(this.text_matricule);
            this.tab_ajouter.Location = new System.Drawing.Point(4, 22);
            this.tab_ajouter.Name = "tab_ajouter";
            this.tab_ajouter.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ajouter.Size = new System.Drawing.Size(479, 347);
            this.tab_ajouter.TabIndex = 0;
            this.tab_ajouter.Text = "Ajouter";
            this.tab_ajouter.UseVisualStyleBackColor = true;
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(226, 145);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(154, 20);
            this.text_prenom.TabIndex = 24;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.button_ajouter.Location = new System.Drawing.Point(226, 225);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(154, 33);
            this.button_ajouter.TabIndex = 26;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label_matricule
            // 
            this.label_matricule.AutoSize = true;
            this.label_matricule.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label_matricule.Location = new System.Drawing.Point(110, 66);
            this.label_matricule.Name = "label_matricule";
            this.label_matricule.Size = new System.Drawing.Size(78, 17);
            this.label_matricule.TabIndex = 18;
            this.label_matricule.Text = "Matricule";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(225, 184);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(155, 20);
            this.text_nom.TabIndex = 25;
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label_mdp.Location = new System.Drawing.Point(110, 104);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(110, 17);
            this.label_mdp.TabIndex = 19;
            this.label_mdp.Text = "Mot de passe";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label_prenom.Location = new System.Drawing.Point(110, 146);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(68, 17);
            this.label_prenom.TabIndex = 20;
            this.label_prenom.Text = "Prenom";
            // 
            // text_mdp
            // 
            this.text_mdp.Location = new System.Drawing.Point(226, 103);
            this.text_mdp.Name = "text_mdp";
            this.text_mdp.Size = new System.Drawing.Size(154, 20);
            this.text_mdp.TabIndex = 23;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label_nom.Location = new System.Drawing.Point(110, 185);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(43, 17);
            this.label_nom.TabIndex = 21;
            this.label_nom.Text = "Nom";
            // 
            // text_matricule
            // 
            this.text_matricule.Location = new System.Drawing.Point(226, 65);
            this.text_matricule.Name = "text_matricule";
            this.text_matricule.Size = new System.Drawing.Size(154, 20);
            this.text_matricule.TabIndex = 22;
            // 
            // tab_gerer
            // 
            this.tab_gerer.Controls.Add(this.button_supprimer);
            this.tab_gerer.Controls.Add(this.button_modifier);
            this.tab_gerer.Controls.Add(this.button_chercher);
            this.tab_gerer.Controls.Add(this.button_afficher);
            this.tab_gerer.Controls.Add(this.text_nomG);
            this.tab_gerer.Controls.Add(this.text_prenomG);
            this.tab_gerer.Controls.Add(this.text_mdpG);
            this.tab_gerer.Controls.Add(this.text_matriculeG);
            this.tab_gerer.Controls.Add(this.dataGrid_gestionHotel);
            this.tab_gerer.Controls.Add(this.label_nomG);
            this.tab_gerer.Controls.Add(this.label_prenomG);
            this.tab_gerer.Controls.Add(this.label2);
            this.tab_gerer.Controls.Add(this.label1);
            this.tab_gerer.Location = new System.Drawing.Point(4, 22);
            this.tab_gerer.Name = "tab_gerer";
            this.tab_gerer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_gerer.Size = new System.Drawing.Size(479, 347);
            this.tab_gerer.TabIndex = 1;
            this.tab_gerer.Text = "Gerer";
            this.tab_gerer.UseVisualStyleBackColor = true;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(360, 99);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(112, 23);
            this.button_supprimer.TabIndex = 25;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(242, 99);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(112, 23);
            this.button_modifier.TabIndex = 24;
            this.button_modifier.Text = "Modifier MDP";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(124, 99);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(112, 23);
            this.button_chercher.TabIndex = 23;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            this.button_chercher.Click += new System.EventHandler(this.button_chercher_Click);
            // 
            // button_afficher
            // 
            this.button_afficher.Location = new System.Drawing.Point(6, 99);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(112, 23);
            this.button_afficher.TabIndex = 22;
            this.button_afficher.Text = "Afficher tout";
            this.button_afficher.UseVisualStyleBackColor = true;
            this.button_afficher.Click += new System.EventHandler(this.button_afficher_Click);
            // 
            // text_nomG
            // 
            this.text_nomG.Location = new System.Drawing.Point(310, 61);
            this.text_nomG.Name = "text_nomG";
            this.text_nomG.Size = new System.Drawing.Size(161, 20);
            this.text_nomG.TabIndex = 21;
            // 
            // text_prenomG
            // 
            this.text_prenomG.Location = new System.Drawing.Point(310, 23);
            this.text_prenomG.Name = "text_prenomG";
            this.text_prenomG.Size = new System.Drawing.Size(161, 20);
            this.text_prenomG.TabIndex = 20;
            // 
            // text_mdpG
            // 
            this.text_mdpG.Location = new System.Drawing.Point(86, 61);
            this.text_mdpG.Name = "text_mdpG";
            this.text_mdpG.Size = new System.Drawing.Size(161, 20);
            this.text_mdpG.TabIndex = 19;
            // 
            // text_matriculeG
            // 
            this.text_matriculeG.Location = new System.Drawing.Point(86, 23);
            this.text_matriculeG.Name = "text_matriculeG";
            this.text_matriculeG.Size = new System.Drawing.Size(161, 20);
            this.text_matriculeG.TabIndex = 18;
            // 
            // dataGrid_gestionHotel
            // 
            this.dataGrid_gestionHotel.AllowUserToAddRows = false;
            this.dataGrid_gestionHotel.AllowUserToDeleteRows = false;
            this.dataGrid_gestionHotel.AllowUserToOrderColumns = true;
            this.dataGrid_gestionHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_gestionHotel.Location = new System.Drawing.Point(19, 128);
            this.dataGrid_gestionHotel.Name = "dataGrid_gestionHotel";
            this.dataGrid_gestionHotel.ReadOnly = true;
            this.dataGrid_gestionHotel.Size = new System.Drawing.Size(440, 213);
            this.dataGrid_gestionHotel.TabIndex = 17;
            // 
            // label_nomG
            // 
            this.label_nomG.AutoSize = true;
            this.label_nomG.Location = new System.Drawing.Point(269, 64);
            this.label_nomG.Name = "label_nomG";
            this.label_nomG.Size = new System.Drawing.Size(35, 13);
            this.label_nomG.TabIndex = 16;
            this.label_nomG.Text = "Nom :";
            // 
            // label_prenomG
            // 
            this.label_prenomG.AutoSize = true;
            this.label_prenomG.Location = new System.Drawing.Point(255, 26);
            this.label_prenomG.Name = "label_prenomG";
            this.label_prenomG.Size = new System.Drawing.Size(49, 13);
            this.label_prenomG.TabIndex = 15;
            this.label_prenomG.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "MotDePasse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Matricule :";
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 375);
            this.Controls.Add(this.tab_admin_page);
            this.Name = "Admin_page";
            this.Text = "Admin_page";
            this.tab_admin_page.ResumeLayout(false);
            this.tab_ajouter.ResumeLayout(false);
            this.tab_ajouter.PerformLayout();
            this.tab_gerer.ResumeLayout(false);
            this.tab_gerer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gestionHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_admin_page;
        private System.Windows.Forms.TabPage tab_ajouter;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label_matricule;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.TextBox text_mdp;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox text_matricule;
        private System.Windows.Forms.TabPage tab_gerer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.TextBox text_nomG;
        private System.Windows.Forms.TextBox text_prenomG;
        private System.Windows.Forms.TextBox text_mdpG;
        private System.Windows.Forms.TextBox text_matriculeG;
        public System.Windows.Forms.DataGridView dataGrid_gestionHotel;
        private System.Windows.Forms.Label label_nomG;
        private System.Windows.Forms.Label label_prenomG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}