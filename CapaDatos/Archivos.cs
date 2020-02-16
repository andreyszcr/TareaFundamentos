using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Security.Cryptography;
using System.IO;
using System.Data;
using System.Windows.Forms;


namespace CapaDatos
{
    public class Archivos
    {

        DataTable tabla;
        DataColumn column;

        StreamWriter Escritura;

        //StreamReader lectura;

        

        //ruta para registrarse 
        string RutaInventario = @"C:\Users\andre\source\repos\Front-End\inventario.txt";

        string RutaIniciarSesion = @"C:\Users\andre\source\repos\Front-End\IniciarSesion.txt";
        string RutaRegistarse = @"C:\Users\andre\source\repos\Front-End\Registrarse.txt";
        //**********************************************************************
       

       



        //metodos para escritura de guardar en archivos 
        #region Escritura de Archivos para registrarse 
        //metodo para registrarse 

        public void Registrarse(string nombre,string lastname, string email, string password, string password1)
        { 
            //validacion de datos 
            try 
            {

                //se da como nuevo colocando la ruta del archivo
                Escritura = new StreamWriter(RutaRegistarse,true);

                //una vex que se escribe en el archivo se guarda en el archivo txt
                Escritura.WriteLine(nombre+";"+lastname + ";" + email + ";" + password + ";" + password1);
                Escritura.WriteLine("\n");                                     
            }
            catch (Exception)
            {
                // en caso de error mostrarse un mensaje 
                MessageBox.Show("Error de resgistro", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cierre del archivo 
            Escritura.Close();
        }
        //*************************************************
        public void IniciarSesion(string username, string password)
        {
            //validacion de datos 
            try
              {

                Escritura = new StreamWriter(RutaIniciarSesion, true);

                Escritura.WriteLine(username+";"+password);
                Escritura.WriteLine("\n");
              }
              catch
                 { 
                    //en caso de error se muestra un mensaje
                     MessageBox.Show("no se pudo guardar la contraseña y el nombre de usuraio de la cuenta", "Error de guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }

        #endregion
        //*************************************************************************
        //region donde se da la lectura del inventario en archivo txt
        #region Escritura de Archivos en el Inventario
        public void AgregarArchivo(string name, string nameEmployee, string nameProduct, int count, int cost, int sell, int order)
        {
            //validacion de datos 
            try
            {
                //se establece como nuevo escritura de archivo 
                Escritura = new StreamWriter(RutaInventario, true);

                Escritura.WriteLine(name + ";" + nameEmployee + ";" + nameProduct + ";" + count + ";" + sell + ";" + order);
                Escritura.WriteLine("\n");

            }
            catch (Exception)
            {
                //en caso de error se muestra un mensaje 
                MessageBox.Show("Error para guardar", "Error en capa datos ");
            }
            Escritura.Close();
        }

        #endregion


    }

}
