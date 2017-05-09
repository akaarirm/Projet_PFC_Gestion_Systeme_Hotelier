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

namespace Projet_PFC_Gestion_Systeme_Hotelier.Model.Admin_class
{
    class Admin_actions
    {
        public string matricule;
        string mot_de_passe;
        string prenom;
        string nom;

        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source = sarah-laptop\sqlexpress; Initial Catalog = gestionHotel; Integrated Security = True");
        SqlDataAdapter sda = new SqlDataAdapter();

        public void ajouter_compte_receptionniste(string matricule, string mot_de_passe, string prenom, string nom)
        {
            try
            {
                this.matricule = matricule;
                this.mot_de_passe = mot_de_passe;
                this.prenom = prenom;
                this.nom = nom;
                sda.InsertCommand = new SqlCommand("INSERT INTO utilisateur VALUES('" + this.matricule + "','" + this.mot_de_passe + "','" + this.prenom + "','" + this.nom + "','" + 2 + "')", con);
                con.Open();
                sda.InsertCommand.ExecuteNonQuery();
                int var;
                var = 1;
                con.Close();
                if (var == 1)
                {
                    MessageBox.Show("Receptionniste ajoute");
                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* public void chercher_compte_receptionniste(string matricule, string prenom, string nom)
         {
             try
             {
                 this.matricule = matricule;
                 this.prenom = prenom;
                 this.nom = nom;
                 sda.InsertCommand = new SqlCommand("select matricule,mot_de_passe,prenom,nom from utilisateur where id_role = 2", con);
                 con.Open();
                 sda.InsertCommand.ExecuteNonQuery();
                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/

        public void modifier_compte_receptionniste(string matricule, string mot_de_passe)
        {
            try
            {
                this.matricule = matricule;
                this.mot_de_passe = mot_de_passe;
                sda.UpdateCommand = new SqlCommand("UPDATE utilisateur SET mot_de_passe = '" + this.mot_de_passe + "'WHERE matricule = '" + this.matricule + "'", con);
                con.Open();
                sda.UpdateCommand.ExecuteNonQuery();
                int var;
                var = 1;
                con.Close();
                if (var == 1)
                {
                    MessageBox.Show("mot de passe modifie");
                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void supprimer_compte_receptionniste(string matricule)
        {
            try
            {
                this.matricule = matricule;
                int var;
                sda.DeleteCommand = new SqlCommand("DELETE FROM utilisateur WHERE matricule = '" + this.matricule + "'", con);
                con.Open();
                sda.DeleteCommand.ExecuteNonQuery();
                var = 1;
                con.Close();
                if (var == 1)
                {
                    MessageBox.Show("Receptionniste supprime");
                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
