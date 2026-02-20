using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Clase que contiene métodos estáticos para realizar conversiones de tiempo.
    /// </summary>
    internal class HadaP1
    {
        /// <summary>
        /// Convierte una cantidad de segundos a su equivalente en minutos.
        /// </summary>
        /// <param name="s">La cantidad de segundos a convertir (double).</param>
        /// <returns>La cantidad de minutos resultante (double). Si la entrada es 0, devuelve 0.</returns>
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
            {
                return 0;
            }
            return s / 60;
        }

        /// <summary>
        /// Convierte una cantidad de minutos a su equivalente en segundos.
        /// </summary>
        /// <param name="m">La cantidad de minutos a convertir (double).</param>
        /// <returns>La cantidad de segundos resultante (double).</returns>
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }

        /// <summary>
        /// Convierte una cantidad de horas a su equivalente en minutos.
        /// </summary>
        /// <param name="h">La cantidad de horas a convertir (double).</param>
        /// <returns>La cantidad de minutos resultante (double).</returns>
        public static double Hours2Minutes(double h)
        {
            return h * 60;
        }
    }
}