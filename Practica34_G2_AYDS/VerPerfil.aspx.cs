using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica34_G2_AYDS
{
    public partial class VerPerfil : System.Web.UI.Page
    {
        string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            //CORREO ELECTRONICO COMO USUARIO
            user = Session["usuario"].ToString();
            Label1.Text = user;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}