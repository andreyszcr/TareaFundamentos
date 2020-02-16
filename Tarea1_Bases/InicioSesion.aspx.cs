using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//uso de datos para habilitar las herrmientas de windwos form
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace Tarea1_Bases
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//evalua si presionamos un boton para enviar informacion
            {
                Session["InicioSesion"] = false;
                if (Request.Cookies["InicioSesion"] != null)
                {
                    if (Request.Cookies["InicioSesion"]["usuario"] != null)
                    {
                        txtUser.Text = Request.Cookies["InicioSesion"]["Nombre Usuario"];
                        string clv = Request.Cookies["InicioSesion"]["Contraseña"];
                        txtpassword.Attributes.Add("value", clv);
                    }
                }
                txtUser.Focus();
            }
        }

     
        protected void btnEnter_Click1(object sender, EventArgs e)
        {
            //validacion de datos 
            try
            {
                //variables de tipo string 
                string user, password;

                user = txtUser.Text;
                password = txtpassword.Text;

                //cookies de inicio de session
                HttpCookie coologin = new HttpCookie("login");
                Session["login"] = true;
                if (checksession.Checked)
                {
                    coologin["Nombre Usuario"] = txtUser.Text;
                    coologin["Contraseña"] = txtpassword.Text;
                    coologin.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(coologin);
                }
                else
                {
                    coologin["Nombre Usuario"] = "";
                    coologin["Contraseña"] = "";
                    coologin.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(coologin);
                }

                if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    //en caso de error cuando no ingresan la contraseña
                    MessageBox.Show("Error al ingresar la contraseña ", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = "";
                }
                //en caso de que sea mayor a 50 entonces 
                else if (txtUser.Text.Length >= 50)
                {
                    //en caso de que sea mayor a 50 
                    MessageBox.Show("Cantidad Inexacta de datos para ingresar", "Cantidad Inexacta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = " ";
                }
                //----------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
                {
                    //mensaje de error al ingresar la contraseña
                    MessageBox.Show("Error al ingresar la contraseña", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassword.Text = "";

                }
                else if (txtpassword.Text.Length >= 50)
                {
                    //en caso de que se pase mas de 50
                    MessageBox.Show("Cantidad Inexacta de datos para ingresar", "Cantidad Inexacta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = " ";
                }
            }
            catch (Exception)
            {
                //en caso de error,se muestra un mensaje 
                MessageBox.Show("Error al ingresar en los datos", "Error de Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                string username = "andreyszcr";
                string pass = "12";


            //si el campo es igual al nombre que esta guardado y es igual 
            
            
            if (txtUser.Text == "andreyszcr" && txtpassword.Text == "1234")
            {
                Response.Redirect("Main.aspx");
            }
        }

        protected void LbtnForget_Click(object sender, EventArgs e)
        {
            //try catch 
            try
            {
              

            }
            catch(Exception) 
            {
                //en caso de error se muestra un mensaje de error 
                MessageBox.Show("Error al entrar para recuperar la contraseña","Error en la recuperacion de contraseña",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }



        protected void lbtnRegister_Click(object sender, EventArgs e)
        {
         
                // se muestra la pantalla de registrarse
                Response.Redirect("Registrarse.aspx");
        }

        protected void checksession_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}