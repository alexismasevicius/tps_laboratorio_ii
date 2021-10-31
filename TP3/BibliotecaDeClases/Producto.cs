using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Producto
    {
        private string codigo;
        private string titulo;
        private string autor;
        private int anio;
        private int stock;
        private int ventas;
        private float precio;


        protected Producto(string titulo, string autor, int anio, int stock, int ventas, float precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.stock = stock;
            this.ventas = ventas;
            this.precio = precio;

        }

        //PROPIEDADes
        public string Codigo
        {
            get
            {
                return this.codigo;
            }

            set
            {
                codigo = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }
        public int Anio
        {
            get
            {
                return anio;
            }

            set
            {
                anio = value;
            }
        }

        public int Stock
        {
            get => stock; set
            {
                stock = value;
            }
        }

        public int Ventas
        {
            get
            {
                return ventas;
            }

            set
            {
                ventas = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }

            set
            {
                this.precio = value;
            }
        }



        //METODOS

        /// <summary>
        /// Muestra el titulo, autor y anio en formato string
        /// </summary>
        /// <returns>string con los datos</returns>
        public override string ToString()
        {
            return String.Format($"{this.Titulo},{this.Autor},{this.Anio}");
        }


        public abstract override bool Equals(object obj);


    }
}
