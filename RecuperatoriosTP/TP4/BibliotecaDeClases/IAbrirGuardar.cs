using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    ///Implementacion de generics
    public interface IAbrirGuardar
    {
        string RutaDeArchivo
        {
            get;set;
        }

        public void Guardar<T>(List<T> miLista);
        public List<T> Leer<T>();

    }
}
