using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{

    public class Venta
    {
        private Guid codigo;
        private Libro libro;
        private DateTime fecha;
        private Cliente cliente;

        public Venta()
        {
        }

        public Venta(Libro libro, Cliente cliente)
        {
            this.codigo = Guid.NewGuid();
            this.fecha = DateTime.Now;
            this.cliente = cliente;            
            this.Libro = libro;
        }

        public Guid Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Libro Libro { get => libro; set => libro = value; }
        public string RutaDeArchivo
        {
            get
            {
                StringBuilder str = new StringBuilder();
                str.Append(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString());
                str.Append(@$"\Factura {DateTime.Now.ToString()}");
                return str.ToString();
            }
        }

        public void Guardar()
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    string json = JsonSerializer.Serialize(this);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar el recibo de venta", "Venta", "Guardar", e);
            }

        }

    }
}
