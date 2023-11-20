using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista2.Servicios
{
    /// <summary>
    /// Metodo que implementa la interfaz del metodo
    /// 20/11/23 -> irm
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int respuesta;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Insertar nuevo cliente");
            Console.WriteLine("2. Insertar nueva cuenta");
            Console.WriteLine("¿Que opcion desea utilizar?");
            respuesta = Convert.ToInt32(Console.ReadLine());

            return respuesta;
        }
    }
}
