using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practica34_G2_AYDS
{
    public class Coneccion
    {
        string cadena;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Coneccion(string cadena)
        {
            this.cadena = cadena;
        }

        public void Operar(string procedimiento,string datos)
        {
            con = new SqlConnection(cadena);
            con.Open();
            cmd = new SqlCommand(procedimiento, con);
            cmd.CommandType = CommandType.StoredProcedure;
            string[] dato = datos.Split(';');

            for (int x = 0; x < dato.Length; x++)
            {
                string[] valor = dato[x].Split(',');
                cmd.Parameters.AddWithValue(valor[0], valor[1]);

            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public string Operar_D(string procedimiento, string datos)
        {
            string respuesta = null;
            try
            {
                
                con = new SqlConnection(cadena);
                con.Open();
                cmd = new SqlCommand(procedimiento, con);
                cmd.CommandType = CommandType.StoredProcedure;
                string[] dato = datos.Split(';');

                for (int x = 0; x < dato.Length; x++)
                {
                    string[] valor = dato[x].Split(',');
                    cmd.Parameters.AddWithValue(valor[0], valor[1]);

                }

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    respuesta = dr.GetString(0);

                }
            }catch(Exception ex)
            {
                respuesta = "Error";
            }

            return respuesta;

        }
    }
}