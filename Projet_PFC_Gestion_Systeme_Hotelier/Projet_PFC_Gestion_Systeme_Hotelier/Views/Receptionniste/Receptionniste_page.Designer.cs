namespace Projet_PFC_Gestion_Systeme_Hotelier.Views.Receptionniste
{
    partial class Receptionniste_page
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_clients = new System.Windows.Forms.TabPage();
            this.tab_reservation = new System.Windows.Forms.TabPage();
            this.tab_chambre = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_adresse_clients = new System.Windows.Forms.TextBox();
            this.textBox_telephone_clients = new System.Windows.Forms.TextBox();
            this.textBox_nom_clients = new System.Windows.Forms.TextBox();
            this.textBox_prenom_clients = new System.Windows.Forms.TextBox();
            this.textBox_cin_prenom = new System.Windows.Forms.TextBox();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.button_afficher_clients = new System.Windows.Forms.Button();
            this.button_chercher_clients = new System.Windows.Forms.Button();
            this.button_supprimer_clients = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_clients.SuspendLayout();
            this.tab_reservation.SuspendLayout();
            this.tab_chambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_clients);
            this.tabControl1.Controls.Add(this.tab_reservation);
            this.tabControl1.Controls.Add(this.tab_chambre);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 346);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_clients
            // 
            this.tab_clients.Controls.Add(this.button_supprimer_clients);
            this.tab_clients.Controls.Add(this.button_chercher_clients);
            this.tab_clients.Controls.Add(this.button_afficher_clients);
            this.tab_clients.Controls.Add(this.dataGridView_clients);
            this.tab_clients.Controls.Add(this.label5);
            this.tab_clients.Controls.Add(this.label4);
            this.tab_clients.Controls.Add(this.label3);
            this.tab_clients.Controls.Add(this.label2);
            this.tab_clients.Controls.Add(this.label1);
            this.tab_clients.Controls.Add(this.textBox_adresse_clients);
            this.tab_clients.Controls.Add(this.textBox_telephone_clients);
            this.tab_clients.Controls.Add(this.textBox_nom_clients);
            this.tab_clients.Controls.Add(this.textBox_prenom_clients);
            this.tab_clients.Controls.Add(this.textBox_cin_prenom);
            this.tab_clients.Location = new System.Drawing.Point(4, 22);
            this.tab_clients.Name = "tab_clients";
            this.tab_clients.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clients.Size = new System.Drawing.Size(680, 320);
            this.tab_clients.TabIndex = 0;
            this.tab_clients.Text = "Clients";
            this.tab_clients.UseVisualStyleBackColor = true;
            // 
            // tab_reservation
            // 
            this.tab_reservation.Controls.Add(this.textBox2);
            this.tab_reservation.Controls.Add(this.label13);
            this.tab_reservation.Controls.Add(this.comboBox4);
            this.tab_reservation.Controls.Add(this.dateTimePicker2);
            this.tab_reservation.Controls.Add(this.button4);
            this.tab_reservation.Controls.Add(this.button1);
            this.tab_reservation.Controls.Add(this.button2);
            this.tab_reservation.Controls.Add(this.button3);
            this.tab_reservation.Controls.Add(this.dataGridView1);
            this.tab_reservation.Controls.Add(this.label11);
            this.tab_reservation.Controls.Add(this.label10);
            this.tab_reservation.Controls.Add(this.label9);
            this.tab_reservation.Controls.Add(this.label8);
            this.tab_reservation.Controls.Add(this.label7);
            this.tab_reservation.Controls.Add(this.label6);
            this.tab_reservation.Controls.Add(this.comboBox1);
            this.tab_reservation.Controls.Add(this.textBox3);
            this.tab_reservation.Controls.Add(this.textBox1);
            this.tab_reservation.Controls.Add(this.dateTimePicker1);
            this.tab_reservation.Location = new System.Drawing.Point(4, 22);
            this.tab_reservation.Name = "tab_reservation";
            this.tab_reservation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reservation.Size = new System.Drawing.Size(680, 320);
            this.tab_reservation.TabIndex = 1;
            this.tab_reservation.Text = "Reservations";
            this.tab_reservation.UseVisualStyleBackColor = true;
            this.tab_reservation.Click += new System.EventHandler(this.tab_reservation_Click);
            // 
            // tab_chambre
            // 
            this.tab_chambre.Controls.Add(this.dataGridView2);
            this.tab_chambre.Location = new System.Drawing.Point(4, 22);
            this.tab_chambre.Name = "tab_chambre";
            this.tab_chambre.Padding = new System.Windows.Forms.Padding(3);
            this.tab_chambre.Size = new System.Drawing.Size(680, 320);
            this.tab_chambre.TabIndex = 2;
            this.tab_chambre.Text = "Chambre";
            this.tab_chambre.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "CIN";
            // 
            // textBox_adresse_clients
            // 
            this.textBox_adresse_clients.Location = new System.Drawing.Point(326, 47);
            this.textBox_adresse_clients.Multiline = true;
            this.textBox_adresse_clients.Name = "textBox_adresse_clients";
            this.textBox_adresse_clients.Size = new System.Drawing.Size(150, 55);
            this.textBox_adresse_clients.TabIndex = 15;
            // 
            // textBox_telephone_clients
            // 
            this.textBox_telephone_clients.Location = new System.Drawing.Point(326, 10);
            this.textBox_telephone_clients.Name = "textBox_telephone_clients";
            this.textBox_telephone_clients.Size = new System.Drawing.Size(150, 20);
            this.textBox_telephone_clients.TabIndex = 14;
            // 
            // textBox_nom_clients
            // 
            this.textBox_nom_clients.Location = new System.Drawing.Point(63, 82);
            this.textBox_nom_clients.Name = "textBox_nom_clients";
            this.textBox_nom_clients.Size = new System.Drawing.Size(150, 20);
            this.textBox_nom_clients.TabIndex = 13;
            // 
            // textBox_prenom_clients
            // 
            this.textBox_prenom_clients.Location = new System.Drawing.Point(63, 47);
            this.textBox_prenom_clients.Name = "textBox_prenom_clients";
            this.textBox_prenom_clients.Size = new System.Drawing.Size(150, 20);
            this.textBox_prenom_clients.TabIndex = 12;
            // 
            // textBox_cin_prenom
            // 
            this.textBox_cin_prenom.Location = new System.Drawing.Point(63, 13);
            this.textBox_cin_prenom.Name = "textBox_cin_prenom";
            this.textBox_cin_prenom.Size = new System.Drawing.Size(150, 20);
            this.textBox_cin_prenom.TabIndex = 11;
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(17, 108);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(459, 206);
            this.dataGridView_clients.TabIndex = 21;
            // 
            // button_afficher_clients
            // 
            this.button_afficher_clients.Location = new System.Drawing.Point(501, 157);
            this.button_afficher_clients.Name = "button_afficher_clients";
            this.button_afficher_clients.Size = new System.Drawing.Size(150, 36);
            this.button_afficher_clients.TabIndex = 22;
            this.button_afficher_clients.Text = "Afficher Tout";
            this.button_afficher_clients.UseVisualStyleBackColor = true;
            // 
            // button_chercher_clients
            // 
            this.button_chercher_clients.Location = new System.Drawing.Point(501, 199);
            this.button_chercher_clients.Name = "button_chercher_clients";
            this.button_chercher_clients.Size = new System.Drawing.Size(150, 36);
            this.button_chercher_clients.TabIndex = 23;
            this.button_chercher_clients.Text = "Chercher";
            this.button_chercher_clients.UseVisualStyleBackColor = true;
            // 
            // button_supprimer_clients
            // 
            this.button_supprimer_clients.Location = new System.Drawing.Point(501, 241);
            this.button_supprimer_clients.Name = "button_supprimer_clients";
            this.button_supprimer_clients.Size = new System.Drawing.Size(150, 36);
            this.button_supprimer_clients.TabIndex = 24;
            this.button_supprimer_clients.Text = "Supprimer";
            this.button_supprimer_clients.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 50);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(28, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(393, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-25 %",
            "-40 %",
            "-70 %"});
            this.comboBox1.Location = new System.Drawing.Point(393, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CIN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Debut :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Fin :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Personnes  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Prix :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Promotions :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 203);
            this.dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Chercher";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 36);
            this.button3.TabIndex = 25;
            this.button3.Text = "Afficher Tout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 36);
            this.button4.TabIndex = 28;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker2.Location = new System.Drawing.Point(260, 50);
            this.dateTimePicker2.MaxDate = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(28, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.Value = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Chambre :";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1 pers.",
            "2 pers.",
            "4 pers.",
            "8 pers."});
            this.comboBox4.Location = new System.Drawing.Point(153, 84);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(135, 21);
            this.comboBox4.TabIndex = 30;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(130, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 187);
            this.dataGridView2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 32;
            // 
            // Receptionniste_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "Receptionniste_page";
            this.Text = "Receptionniste_page";
            this.tabControl1.ResumeLayout(false);
            this.tab_clients.ResumeLayout(false);
            this.tab_clients.PerformLayout();
            this.tab_reservation.ResumeLayout(false);
            this.tab_reservation.PerformLayout();
            this.tab_chambre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_clients;
        private System.Windows.Forms.TabPage tab_reservation;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_adresse_clients;
        private System.Windows.Forms.TextBox textBox_telephone_clients;
        private System.Windows.Forms.TextBox textBox_nom_clients;
        private System.Windows.Forms.TextBox textBox_prenom_clients;
        private System.Windows.Forms.TextBox textBox_cin_prenom;
        private System.Windows.Forms.TabPage tab_chambre;
        private System.Windows.Forms.Button button_supprimer_clients;
        private System.Windows.Forms.Button button_chercher_clients;
        private System.Windows.Forms.Button button_afficher_clients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
    }
}