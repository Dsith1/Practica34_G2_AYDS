using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica34_G2_AYDS
{
    public partial class VerPerfil : System.Web.UI.Page
    {
        string user;
        string cadena = "data source=SERGIO\\SERGIO; database=BD_Banco; integrated security = true;";
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;



        protected void Page_Load(object sender, EventArgs e)
        {
            //CORREO ELECTRONICO COMO USUARIO
            user = Session["usuario"].ToString();
            Label1.Text = user;
            obtenerPerfil(user);
        }

        void conectionString()
        {
            con.ConnectionString = cadena;
        }

        public Boolean obtenerPerfil(String usuario) {
            
            conectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from usuario where correo='" + usuario + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                LabelDPI.Text = dr[0].ToString();
                LabelNombre.Text = dr[1].ToString();
                LabelApellido.Text = dr[2].ToString();
                LabelCorreo.Text = dr[3].ToString();
                LabelPassword.Text = dr[4].ToString();
                con.Close();

                return true;

            }

            else
            {
                con.Close();
                Response.Redirect("IniciarSesion.aspx");
                return false;
            }
        
        
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}