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
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        string cadena = "data source=diegoarmira; database=BD_Banco; integrated security = true;";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        void conectionString()
        {
            con.ConnectionString = cadena;
        }


        public string returnSaldo(string user)
        {
            string saldo = "";
            if (user.Length > 0)
            {
                conectionString();
                con.Open();
                com.Connection = con;
                com.CommandText = "select saldo from cuenta where usuario='" + user + "' ";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    //Response.Redirect("");
                    /*
                     * saldo= el valor de la consulta 
                     * 
                     */
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
                //ERROR 
            }
            return "";
        }
    }
}