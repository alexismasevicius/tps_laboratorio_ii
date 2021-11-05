using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IAbrirGuardar<T> where T: class
    {
        string RutaDeArchivo
        {
            get;set;
        }

        void Guardar(T lista);
        T Leer();

    }
}
