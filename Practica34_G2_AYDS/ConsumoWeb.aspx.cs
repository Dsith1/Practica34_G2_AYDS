using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
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
            string respuesta = "";
            txtDia.Text=a.TipoCambioDiaString();
            XmlDocument lector = new XmlDocument();
            lector.LoadXml(a.TipoCambioDiaString());
            XmlNodeList parentNode = lector.GetElementsByTagName("referencia");
            respuesta +="Referencia:"+ parentNode[0].InnerText;
            parentNode = lector.GetElementsByTagName("fecha");
            respuesta += " al dia " + parentNode[0].InnerText;


            txtDia.Text = respuesta;

        }

        public void Tipo_cambio(string inicio)
        {
            DataVariable datos = a.TipoCambioFechaInicial(inicio);

            for (int x = 0; x < datos.TotalItems; x++)
            {
                txtTipoDesde.Text +="fecha:"+ datos.Vars[x].fecha.ToString();
                txtTipoDesde.Text +=" compra:"+datos.Vars[x].compra.ToString();
                txtTipoDesde.Text += " venta:" + datos.Vars[x].venta.ToString()+"\n";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            txtDIa.Text=("Cambio del dia"+a.TipoCambioDia().CambioDia.ToString()+" cambio dolar"+ a.TipoCambioDia().CambioDolar.ToString())

            Tipo_Cambio();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Tipo_cambio(txtDiaInicio.Text);

        }
    }
}