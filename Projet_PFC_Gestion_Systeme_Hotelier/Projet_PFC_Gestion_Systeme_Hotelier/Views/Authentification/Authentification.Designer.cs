namespace Projet_PFC_Gestion_Systeme_Hotelier.Views.Authentification
{
    partial class Authentification
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
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_mdp = new System.Windows.Forms.TextBox();
            this.label_matricule = new System.Windows.Forms.Label();
            this.label_mdp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_auth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(301, 47);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(147, 20);
            this.text_login.TabIndex = 0;
            // 
            // text_mdp
            // 
            this.text_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mdp.Location = new System.Drawing.Point(301, 82);
            this.text_mdp.Name = "text_mdp";
            this.text_mdp.PasswordChar = '•';
            this.text_mdp.Size = new System.Drawing.Size(147, 24);
            this.text_mdp.TabIndex = 1;
            // 
            // label_matricule
            // 
            this.label_matricule.AutoSize = true;
            this.label_matricule.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_matricule.Location = new System.Drawing.Point(228, 50);
            this.label_matricule.Name = "label_matricule";
            this.label_matricule.Size = new System.Drawing.Size(67, 13);
            this.label_matricule.TabIndex = 2;
            this.label_matricule.Text = "Matricule";
            this.label_matricule.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.Location = new System.Drawing.Point(203, 85);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(92, 13);
            this.label_mdp.TabIndex = 3;
            this.label_mdp.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_PFC_Gestion_Systeme_Hotelier.Properties.Resources.Students;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_auth
            // 
            this.button_auth.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.button_auth.Location = new System.Drawing.Point(301, 118);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(147, 28);
            this.button_auth.TabIndex = 5;
            this.button_auth.Text = "Authentifier";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 177);
            this.Controls.Add(this.button_auth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_mdp);
            this.Controls.Add(this.label_matricule);
            this.Controls.Add(this.text_mdp);
            this.Controls.Add(this.text_login);
            this.Name = "Authentification";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_mdp;
        private System.Windows.Forms.Label label_matricule;
        private System.Windows.Forms.Label label_mdp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_auth;
    }
}