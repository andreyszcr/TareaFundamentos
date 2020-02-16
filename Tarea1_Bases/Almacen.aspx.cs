using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea1_Bases
{
    public partial class Almacen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar si la session se escuentra abierta o cerrada
            try
            {
                if ((bool)(Session["Nombre Usuario"]) == false)
                {
                    Response.Redirect("InicioSesion.aspx");
                }

            }
            catch { Response.Redirect("InicioSesion.aspx"); }
        }
    }
}