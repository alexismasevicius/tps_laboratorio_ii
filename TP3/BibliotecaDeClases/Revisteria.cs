using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Revisteria
    {
        private List<Revista> listaRevistas;
        private List<Comic> listaComics;

        public Revisteria()
        {
            this.listaRevistas = new List<Revista>();
            this.listaComics = new List<Comic>();
        }

        public List<Revista> ListaRevistas
        {
            get
            {
                return listaRevistas;
            }
        }
        public List<Comic> ListaComics
        {
            get
            {
                return listaComics;
            }
        }





    }
}
