using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_PFC_Gestion_Systeme_Hotelier.Views.Authentification
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            var auth = new Model.Authentification.Authentification();
            auth.auth(text_login.Text, text_mdp.Text);
        }
    }
}
