using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum Genero {masculino, femenino, noBinario};
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private Genero genero;
        private int edad;

        public Cliente(int dni, string nombre, string apellido, Genero genero, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.edad = edad;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Genero Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }


    }
}
