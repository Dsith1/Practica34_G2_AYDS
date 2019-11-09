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
        string cadena = "Data Source=bdpractica4.c2tdf5bqbyqf.us-east-1.rds.amazonaws.com;Initial Catalog=BD_Banco;User ID=admin;Password=analisis123";
        //bdpractica4.c2tdf5bqbyqf.us-east-1.rds.amazonaws.com
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
                    Session["usuario"] = nombre;
                    Response.Redirect("VerPerfil.aspx");
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
                Response.Write("<script language=javascript>alert('Tamaños muy Grandes');</script>");
                return "Incorrecto";
            }

        }
        protected void Registrarse(object sender, EventArgs e)
        {
            RegistrarUsuario(TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);

        }

        public int RegistrarUsuario(string dpi, string name, string ape, string correo, string pass)
        {

            int consulta = 0;
            if (dpi.Length == 13 && name.Length <= 30 && ape.Length <= 30 && correo.Length <= 20 && pass.Length <= 20)
            {
                try
                {
                    SqlConnection con = new SqlConnection(cadena);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CrearUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dpi_i", dpi);
                    cmd.Parameters.AddWithValue("@nombres_i", name);
                    cmd.Parameters.AddWithValue("@apellidos_i", ape);
                    cmd.Parameters.AddWithValue("@correo_i", correo);
                    cmd.Parameters.AddWithValue("@password_i", pass);
                    consulta = cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script language=javascript>alert('Registrado Exitosamente En la Calificacion');</script>");
                    //return "Correcto";
                }
                catch (Exception ex)
                {
                    //throw new Exception("Error al insertar el objeto: " + ex.Message);
                    Console.WriteLine("Error al insertar el nuevo usuario: " + ex.Message);
                    //return "Incorrecto";
                }
            }
                
            return consulta;
        }
    }
}