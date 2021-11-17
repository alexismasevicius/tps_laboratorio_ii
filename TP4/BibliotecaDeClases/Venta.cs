using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{

    public class Venta
    {
        private Guid codigo;
        private float monto;
        private DateTime fecha;
        private Cliente cliente;

        public Venta(float monto, Cliente cliente)
        {
            this.codigo = Guid.NewGuid();
            this.fecha = DateTime.Now;
            this.cliente = cliente;            
            this.monto = monto;
        }

        public Guid Codigo { get => codigo; set => codigo = value; }
        public float Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
