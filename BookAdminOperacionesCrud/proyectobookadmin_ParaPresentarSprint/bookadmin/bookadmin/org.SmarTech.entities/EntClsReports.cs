using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsReports
    {
        #region Attributes

        private string codigo;
        private string isbn;
        private string titulo;
        private string publicacion;
        private string editorial;
        private string categoria;
        private string estado;
        private int stock;
        private string nombre;
        private string apellido;

        private string cedula;
        private string nombreCliente;
        private string apellidoCliente;
        private string telefono;
        private string celular;
        private string direccion;
        private string email;

        #endregion

        #region Setters and Getters

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }


        public string ApellidoCliente
        {
            get { return apellidoCliente; }
            set { apellidoCliente = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        #endregion

        public EntClsReports(string codigo, string isbn, string titulo, string publicacion, string editorial,
            string nombre, string apellido, string categoria, string estado, int stock)
        {
            this.codigo = codigo;
            this.isbn = isbn;
            this.titulo = titulo;
            this.publicacion = publicacion;
            this.editorial = editorial;
            this.nombre = nombre;
            this.apellido = apellido;
            this.categoria = categoria;
            this.estado = estado;
            this.stock = stock;
        }

        public EntClsReports(string cedula, string nombreCliente, string apellidoCliente, string telefono, string celular,
            string direccion, string email)
        {
            this.cedula = cedula;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.telefono = telefono;
            this.celular = celular;
            this.direccion = direccion;
            this.email = email;
        }

        public EntClsReports()
        {
        }
    }
}