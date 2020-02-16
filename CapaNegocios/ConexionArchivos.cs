using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;


namespace CapaNegocios
{

    public class ConexionArchivos
    {

        //llamado a traves de lka capa de datos 
        Archivos objArchivo = new Archivos();


        //variables del inventario 
        //**********************************************
        #region variables del inventario

        string name;
        string nameEmployee;
        string nameProduct;
        int count;
        int cost;
        int sell;
        int numOrder;
        #endregion
        //*******************************************************
        #region Registrarse y login

        string email;
        string lastname;
        string password;
        string password1;
        string llave = "";
        #endregion
        //************************************************
        //properties 
        #region  property del inventario

        public string NAME
        {
            get
            {
                //se le devuelve un valor 
                return name;
            }
            set
            {
                //se le da un valor 
                name = value;
            }
        }
        //*************************************************
        public string NAME_EMPLOYEE
        {
            get
            {
                //se le devuelve un valor 
                return nameEmployee;

            }
            set
            {
                //se le da un valor 
                nameEmployee = value;
            }
        }
        //***************************************************
        public string NAMEPRODUCT
        {

            get
            {
                //se le devuelve un producto
                return nameProduct;
            }
            set
            {
                //se le devuelve un  valor 
                nameProduct = value;
            }
        }
        //*****************************************
        public int COUNT
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        //*********************************************
        public int venta
        {
            get
            {
                return sell;
            }
            set
            {
                sell = value;
            }

        }
        //************************************************
        public int costo
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }

        }
        //*****************************************************
        public int numeroOrden
        {
            get
            {
                return numOrder;

            }
            set
            {
                numOrder = value;
            }
        }
        #endregion
        //*****************************************************************************************
        #region property del register

        public string Password
        {
            get
            {
                //se le devuelve un valor 
                return password;

            }
            set
            {
                //se le da un valor 
                password = value;

            }
        }
        //*********************************************
        public string key
        {
            get
            {
                //se le devuelve un valor 
                return llave;
            }
            set
            {
                //se le da un valor 
                llave = value;
            }
        }
        //*********************************************
        public string Password1
        {
            get
            {
                //se le devuelve un valor
                return password1;
            }
            set
            {
                //se les da un valor 
                password1 = value;
            }
        }
        //***************************************************
        public string Lastname
        {
            get
            {
                //se le devuelve un valor 
                return lastname;
            }
            set
            {
                //se le da un valor 
                lastname = value;
            }
        }

        //**************************************************
        public string Email
        {
            get
            {
                //se le devuelve un valor 
                return email;
            }
            set
            {
                //se le da un valor 
                email = value;
            }
        }
        #endregion
        //*************************************************************
        public void metodoGuardar()
        {
            objArchivo.AgregarArchivo(name, nameEmployee, nameProduct, count, cost, sell, numOrder);


        }
        //*************************************************************
        public void metodoGuardarRegistrarse()
        {
            objArchivo.Registrarse(name, lastname, email, password, password1);
            objArchivo.IniciarSesion(name, password);
        }
    }
}
