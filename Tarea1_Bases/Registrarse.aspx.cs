using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaNegocios;

namespace Tarea1_Bases
{
    public partial class Registrarse : System.Web.UI.Page

    {
        ConexionArchivos objarchivo = new ConexionArchivos();

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnregiter_Click(object sender, EventArgs e)
        {
            //validacion de datos
            try
            {
                //validacion del nombre 
                if (string.IsNullOrEmpty(txtname.Text.Trim())) 
                {
                    //en caso de camppos vacios se envia un mensaje
                    MessageBox.Show("no puede dejar campos vacios","Error de campos vacios");
                    
                }
                //si es mayor a 50
                else if (txtname.Text.Length>50)
                    {
                       // en caso de que se pase de la longitud 
                       MessageBox.Show("Cantidad Inexacta en el nombre","cantidad Inezacta");
                    }
                //***********************************************************************************
                // validacion del apellido

                if (string.IsNullOrEmpty(txtLastname.Text.Trim()))
                {
                    //en caso de camppos vacios se envia un mensaje
                    MessageBox.Show("no puede dejar campos vacios en el nombre", "Error de campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else if (txtLastname.Text.Length>50 ) 

                {
                    // en caso de que se pase de la longitud 
                    MessageBox.Show("Cantidad Inexacta en el apellido", "cantidad Inezacta",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //****************************************************************************************    
                if (string.IsNullOrEmpty(txtemail.Text.Trim()))
                {
                    //en caso de que vacio 
                    MessageBox.Show("no puede quedar vacio el email", "campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtemail.Text.Length >50)
                {
                    //mayor a a alalongitud
                    MessageBox.Show("Cantidad Inexacta en el email", "cantidad Inexacta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
                if ((!txtemail.Text.Contains("@")) && (!txtemail.Text.Contains("hotmail")) && (!txtemail.Text.Contains("gmail.com"))) 
                {
                    //en caso de que no sea un correo 
                    MessageBox.Show("no es un correo electronico", "dato erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //********************************************************************************************************************************
                if (string.IsNullOrEmpty(txtpassword.Text.Trim())) 
                {
                    //en caso de que este vacio 
                    MessageBox.Show("error de correo electronico", "dato erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpassword.Text.Length >50)
                {
                    //mayor a a alalongitud
                    MessageBox.Show("Cantidad Inexacta en la contraseña", "cantidad Inexacta en la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //********************************************************************************************************************************
                if (string.IsNullOrEmpty(txtpassword1.Text.Trim()))
                {
                    //en caso de que este vacio 
                    MessageBox.Show("error de correo electronico", "dato erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpassword1.Text.Length > 50)
                {
                    //mayor a a alalongitud
                    MessageBox.Show("Cantidad Inexacta en la contraseña", "cantidad Inexacta en la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //********************************************************************************************************************************
                if (txtpassword.Text!=txtpassword1.Text)
                {
                    //en caso de que las contraseñas no coincidan 
                    MessageBox.Show("no son iguales las contraseñas","contraseñas no semejantes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }


                    objarchivo.NAME = txtname.Text;
                    objarchivo.Lastname = txtLastname.Text;
                    objarchivo.Email = txtemail.Text;
                    objarchivo.Password = txtpassword.Text;
                    objarchivo.Password1 = txtpassword1.Text;


                    //se muestra datos en los arhivos en el cual ya se da la contrasena ya encriptada 
                    objarchivo.Password = encriptar(this.txtpassword.Text);
                    objarchivo.Password1 = encriptar1(this.txtpassword1.Text);

                    //un mensaje que muestra la contraseña encriptada 

                    MessageBox.Show("contraseña 1: " + encriptar(this.txtpassword1.Text));
                    MessageBox.Show("contraseña: " + encriptar(this.txtpassword.Text));


                    objarchivo.metodoGuardarRegistrarse();

                    
            }
            catch
            {
                //en caso de error se muestra un mensaje 
                MessageBox.Show("Error al registrarse en los datos","Error en el registro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //metodo con parametros para encriptar 
        string encriptar(string contrasena)
        {
            string resultado = string.Empty;

            //el byte el cual se encripta atraves de la variable 
            byte[] encript = System.Text.Encoding.Unicode.GetBytes(contrasena);


            //convieryte la variable de tipo byre
            resultado = Convert.ToBase64String(encript);

            //se retorna la variable  
            return resultado;
        }
        //********************************************************************************
        string encriptar1(string contrasena1)
        {
            //variable de tipo string 
            string resultado1 = string.Empty;
            
            //se encripta a traves de la variable
            byte[] encript1 = System.Text.Encoding.Unicode.GetBytes(contrasena1);

            //se convierte la variable de tipo byte
            resultado1 = Convert.ToBase64String(encript1);

            //se le devuelve un valor 
            return resultado1;
        }
    }

}