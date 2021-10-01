using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        //CONSTRUCTORES

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chasis">chasis del vehiculo</param>
        /// <param name="marca">marca del vehiculo</param>
        /// <param name="color">color del vehiculo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        //PROPIEDADES

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        {
            get;
        }

        //METODOS

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }


        //SOBRECARGAS

        /// <summary>
        /// Sobrecarga de conversion explicita de Vehiculo a string
        /// </summary>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}");
            sb.AppendLine($"MARCA : {p.marca}");
            sb.AppendLine($"COLOR : {p.color}");
            sb.AppendLine("---------------------");
            sb.AppendLine($"TAMANIO : {p.Tamanio}");
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">vehiculo 1</param>
        /// <param name="v2">vehiculo 2</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">vehiculo 1</param>
        /// <param name="v2">vehiculo 2</param>
        /// <returns>true si son diferentes, false si son iguales</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
