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

namespace Projet_PFC_Gestion_Systeme_Hotelier.Views.Admin
{
    public partial class Admin_page : Form
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source = sarah-laptop\sqlexpress; Initial Catalog = gestionHotel; Integrated Security = True");
        SqlDataAdapter sda = new SqlDataAdapter();
        public Admin_page()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            var admin_actions = new Model.Admin_class.Admin_actions();
            admin_actions.ajouter_compte_receptionniste(text_matricule.Text, text_mdp.Text, text_prenom.Text, text_nom.Text);
        }

        private void button_afficher_Click(object sender, EventArgs e)
        {
            sda.SelectCommand = new SqlCommand("select matricule,mot_de_passe,prenom,nom from utilisateur where id_role = 2", con);
            ds.Clear();
            sda.Fill(ds);
            dataGrid_gestionHotel.DataSource = ds.Tables[0];
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            var admin_actions = new Model.Admin_class.Admin_actions();
            admin_actions.modifier_compte_receptionniste(text_matriculeG.Text, text_mdpG.Text);
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            var admin_actions = new Model.Admin_class.Admin_actions();
            admin_actions.supprimer_compte_receptionniste(text_matriculeG.Text);
        }

        private void button_chercher_Click(object sender, EventArgs e)
        {
            try
            {
                sda.SelectCommand = new SqlCommand("select matricule,mot_de_passe,prenom,nom from utilisateur where id_role = 2 AND matricule = '"+ text_matriculeG.Text +"'", con);
                ds.Clear();
                sda.Fill(ds);
                dataGrid_gestionHotel.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
