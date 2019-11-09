using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace Practica34_G2_AYDS
{
    public partial class consultaSaldo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlConnection con2 = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlCommand com2 = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader dr2;
        string cadena = "Data Source=bdpractica4.c2tdf5bqbyqf.us-east-1.rds.amazonaws.com;Initial Catalog=BD_Banco;User ID=admin;Password=analisis123";
        string user, dpi;
        protected void Page_Load(object sender, EventArgs e)
        {
            //CORREO ELECTRONICO COMO USUARIO
            user = Session["usuario"].ToString();
            Label1.Text = user;
        }

        void conectionString()
        {
            con.ConnectionString = cadena;
            con2.ConnectionString = cadena;
        }


        public string returnSaldo(string user)
        {
            string saldo = "";
            if (user.Length > 0)
            {

                conectionString();

                con.Open();
                con2.Open();

                com.Connection = con;
                com2.Connection = con2;

                
                com2.CommandText = "select dpi from usuario where correo='"+user+"'";
                dr2 = com2.ExecuteReader();

                if (dr2.Read())
                {
                    //Verificamos que se obtuvo el usuario y de ese usuario obtenemos el dpi 
                    dpi = dr2[0].ToString();
                    com.CommandText = "select saldo from cuenta where usuario='" + dpi + "' ";
                    con2.Close();
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {

                        /*
                         * CONSULTA PARA INGRESAR VALORES EN LA TABLA CUENTA;
                         * INSERT INTO cuenta VALUES (1234, 100.00, 1234);
                         */
                        saldo = dr[0].ToString();
                        return saldo;

                    }
                    else
                    {
                        con.Close();
                        Response.Redirect("");
                        return "Error en la consulta de saldo";
                    }
                }
                else
                {
                    con.Close();
                    
                    Response.Redirect("");
                    return "Error en la consulta de saldo";
                }
                
            }
            else
            {
                //ERROR 
            }
            return "";
        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = returnSaldo(user);

        }
    }
}