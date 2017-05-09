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


namespace Projet_PFC_Gestion_Systeme_Hotelier.Model.Authentification
{   
    class Authentification
    {
        public string matricule;
        public string mdp;
        SqlConnection con = new SqlConnection(@"Data Source = sarah-laptop\sqlexpress; Initial Catalog = gestionHotel; Integrated Security = True");
        public void auth(string matricule,string mdp) {
            try
            {
                this.matricule = matricule;
                this.mdp = mdp;
                SqlCommand sc = new SqlCommand("select * from utilisateur where matricule ='" + this.matricule + "' and mot_de_passe = '" + this.mdp + "' and id_role = '1'", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Authentification reussite !");
                    Views.Authentification.Authentification.ActiveForm.Hide();
                    Views.Admin.Admin_page admin_page = new Views.Admin.Admin_page();
                    admin_page.Show();
                    //Views.Receptionniste.Receptionniste_page receptionniste_page = new Views.Receptionniste.Receptionniste_page();
                    //receptionniste_page.Show();
                }
                else
                {
                    SqlCommand scR = new SqlCommand("select * from utilisateur where matricule ='" + this.matricule + "' and mot_de_passe = '" + this.mdp + "' and id_role = '2'", con);
                    con.Open();
                    SqlDataAdapter sdaR = new SqlDataAdapter(scR);
                    DataSet dsR = new DataSet();
                    sda.Fill(dsR);
                    con.Close();
                    int countR = dsR.Tables[0].Rows.Count;
                    if (countR == 1)
                    {
                        MessageBox.Show("Authentification reussite !");
                        Views.Authentification.Authentification.ActiveForm.Hide();
                        Views.Receptionniste.Receptionniste_page receptionniste_page = new Views.Receptionniste.Receptionniste_page();
                        receptionniste_page.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
