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

namespace Projet_PFC_Gestion_Systeme_Hotelier.Model.Receptionniste
{
    class receptionniste_actions
    {
       /* DateTime date_debut;
        DateTime date_fin;
        int nmbr_personne;
        float net_a_payer;
        string cin;
        string matricule;
        int id_promotion;
        int id_chambre;
        Authentification.Authentification Auth;

        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source = sarah-laptop\sqlexpress; Initial Catalog = gestionHotel; Integrated Security = True");
        SqlDataAdapter sda = new SqlDataAdapter();


        public void ajouter_reservation(string cin,DateTime date_debut,DateTime date_fin,int id_chambre,int id_promotion,float net_a_payer,int nmbr_personne)
        {
            try
            {
                this.matricule = Auth.matricule;
                this.date_debut = date_debut;
                this.date_fin = date_fin;
                this.id_chambre = id_chambre;
                this.id_promotion = id_promotion;
                this.net_a_payer = net_a_payer;
                sda.InsertCommand = new SqlCommand("INSERT INTO reservation VALUES('" + this.date_debut + "','" + this.date_fin + "','" + this.nmbr_personne + "','" + this.net_a_payer + "','" + this.cin + "','" + this.matricule + "','" + this.c +  "')", con);
                con.Open();
                sda.InsertCommand.ExecuteNonQuery();
                int var;
                var = 1;
                con.Close();
                if (var == 1)
                {
                    MessageBox.Show("Reservation enregistre");
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
        */
    }
}
