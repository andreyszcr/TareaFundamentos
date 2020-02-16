using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocios;

namespace Tarea1_Bases
{
    public partial class Inventario : System.Web.UI.Page
    {
        ConexionArchivos objConArchivos = new ConexionArchivos();

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
            catch { }
            //desaparecen los botones al mostrarse en la pantalla 
            lblname.Visible = false;
            txtnombre.Visible = false;
            lblast7.Visible = false;

            //--------------------------------------
            lblnameproveedor.Visible = false;
            txtnombreproveedor.Visible = false;
            lblast.Visible = false;


            //---------------------------------------
            lblnamearticulo.Visible = false;
            txtnamearticulo.Visible = false;
            lblast2.Visible = false;

            //---------------------------------------
            lblcoantidad.Visible = false;
            txtcantidad.Visible = false;
            lblast3.Visible = false;

            //--------------------------------------
            lblcosto.Visible = false;
            txtcosto.Visible = false;
            Lblast4.Visible = false;

            //---------------------------------------
            lblventa.Visible = false;
            txtventa.Visible = false;
            lblast5.Visible = false;

            //--------------------------------------
            lblnumOrden.Visible = false;
            txtnumOrden.Visible = false;
            lblast6.Visible = false;

            lbtnEliminar.Enabled = false;
            lbtnGuardar.Enabled = false;
            lbtnModificar.Enabled = false;

        }

        protected void lbtnCrear_Click(object sender, EventArgs e)
        {

            lbtnEliminar.Enabled = true;
            lbtnGuardar.Enabled = true;
            lbtnModificar.Enabled = true;

            //se muestran los campos y los nombres para escribir los datos 
            lblname.Visible = true;
            txtnombre.Visible = true;
            lblast7.Visible = true;

            //--------------------------------------
            lblnameproveedor.Visible = true;
            txtnombreproveedor.Visible = true;
            lblast.Visible = true;


            //---------------------------------------
            lblnamearticulo.Visible = true;
            txtnamearticulo.Visible = true;
            lblast2.Visible = true;

            //---------------------------------------
            lblcoantidad.Visible = true;
            txtcantidad.Visible = true;
            lblast3.Visible = true;

            //--------------------------------------
            lblcosto.Visible = true;
            txtcosto.Visible = true;
            Lblast4.Visible = true;

            //---------------------------------------
            lblventa.Visible = true;
            txtventa.Visible = true;
            lblast5.Visible = true;

            //--------------------------------------
            lblnumOrden.Visible = true;
            txtnumOrden.Visible = true;
            lblast6.Visible = true;
        }

        protected void lbtnGuardar_Click(object sender, EventArgs e)

        {
            objConArchivos.NAME = txtnombre.Text;
            objConArchivos.NAME_EMPLOYEE = txtnombreproveedor.Text;
            objConArchivos.NAMEPRODUCT = txtnamearticulo.Text;
            objConArchivos.COUNT = int.Parse(txtcantidad.Text);
            objConArchivos.costo = int.Parse(txtcosto.Text);
            objConArchivos.numeroOrden = int.Parse(txtnumOrden.Text);

            objConArchivos.metodoGuardar();


            txtnombre.Text = "";
            txtnombreproveedor.Text = "";
            txtnamearticulo.Text = "";
        }

        protected void lbtnReportes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Almacen.aspx");
        }
    }
}