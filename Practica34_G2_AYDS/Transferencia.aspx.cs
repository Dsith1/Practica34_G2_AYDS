using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica34_G2_AYDS
{
    public partial class Transferencia : System.Web.UI.Page
    {
        Coneccion Coneccion;
        protected void Page_Load(object sender, EventArgs e)
        {
            Coneccion = new Coneccion("Data Source=bdpractica4.c2tdf5bqbyqf.us-east-1.rds.amazonaws.com;Initial Catalog=BD_Banco;User ID=admin;Password=analisis123");
        }

        public int getSaldo(string cuenta)
        {
          
                string saldo = Coneccion.Operar_D("Get_Saldo", "@cuenta, cuenta;");
                return int.Parse(saldo);

         
        }

        public string transferir(string cuentaSale, string cuentaentra,int monto,int saldo1, int saldo2)
        {

            try
            {
                saldo1 = saldo1 + monto;
                Coneccion.Operar("Tranferencia", "@cuenta ," + cuentaentra + ";@monto," + saldo1);

                saldo2 = saldo2 - monto;
                Coneccion.Operar("Tranferencia", "@cuenta ," + cuentaSale + ";@monto," + saldo2);

                return "Transferencia Realizada";
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuenta1.Text = "";
            txtCuenta2.Text = "";
        }

        protected void btnTransferencia_Click(object sender, EventArgs e)
        {
            string cuentas = txtCuenta1.Text;
            string cuentae = txtCuenta2.Text;
            string montoc = txtmonto.Text;

            int monto = Int16.Parse(montoc);

            int saldo = getSaldo(cuentas);
            int saldo2 = getSaldo(cuentae);

            if (saldo < monto)
            {
                lblRespuestaT.Text = "Saldo Insuficiente";
            }
            else
            {
                lblRespuestaT.Text = transferir(cuentas, cuentae, monto, saldo2, saldo);
            }

        }
    }
}