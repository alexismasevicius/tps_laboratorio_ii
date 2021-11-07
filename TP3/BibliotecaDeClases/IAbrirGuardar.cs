using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    ///Implementacion de generics
    public interface IAbrirGuardar<T>
    {
        string RutaDeArchivo
        {
            get;set;
        }

        void Guardar(T lista);
        T Leer();

    }
}
