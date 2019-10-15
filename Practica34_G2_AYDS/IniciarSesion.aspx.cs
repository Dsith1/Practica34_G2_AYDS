using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica34_G2_AYDS
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        string cadena = "data source=HILBERTPC; database=BD_Banco; integrated security = true;";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void conectionString()
        {
            con.ConnectionString = cadena;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Login(TextBox1.Text, TextBox2.Text);
            
        }
        public string Login(string nombre, string contra)
        {
            if (nombre.Length <= 30 && contra.Length <= 10)
            {
                conectionString();
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from usuario where correo='" + nombre + "' and password='" + contra + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    //Response.Redirect("");
                    return "Correcto";

                }

                else
                {
                    con.Close();
                    Response.Redirect("");
                    return "Incorrecto";
                }
                
                
            }
            else
            {
                //Response.Write("<script language=javascript>alert('Tamaños muy Grandes');</script>");
                return "Incorrecto";
            }

        }
        protected void Registrarse(object sender, EventArgs e)
        {
            RegistrarUsuario();

        }

        public void RegistrarUsuario()
        {
            int consulta = 0;
            try
            {
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                SqlCommand cmd = new SqlCommand("CrearUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dpi_i", TextBox3.Text);
                cmd.Parameters.AddWithValue("@nombres_i", TextBox4.Text);
                cmd.Parameters.AddWithValue("@apellidos_i", TextBox5.Text);
                cmd.Parameters.AddWithValue("@correo_i", TextBox6.Text);
                cmd.Parameters.AddWithValue("@password_i", TextBox7.Text);
                consulta = cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script language=javascript>alert('Registrado Exitosamente');</script>");
            }
            catch (Exception ex)
            {
                //throw new Exception("Error al insertar el objeto: " + ex.Message);
                Console.WriteLine("Error al insertar el nuevo usuario: " + ex.Message);
            }
        }
    }
}