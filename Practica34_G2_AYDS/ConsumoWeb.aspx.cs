using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Practica34_G2_AYDS.ServiceReference1;

namespace Practica34_G2_AYDS
{
    public partial class ConsumoWeb : System.Web.UI.Page
    {
        string dia;
        string cambio;
        TipoCambioSoapClient a = new TipoCambioSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Tipo_Cambio()
        {
         Console.WriteLine(a.TipoCambioDia().CambioDia.ToString());
         Console.WriteLine(a.TipoCambioDia().CambioDolar.ToString());
        }

        public void Tipo_cambio(string inicio)
        {
            DataVariable datos = a.TipoCambioFechaInicial(inicio);

            for (int x = 0; x < datos.TotalItems; x++)
            {
                Console.WriteLine(datos.Vars[x].compra);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            txtDia.Text = ("Cambio del dia" + a.TipoCambioDia().CambioDia.ToString() + " cambio dolar" + a.TipoCambioDia().CambioDolar.ToString());
        }
    }
}