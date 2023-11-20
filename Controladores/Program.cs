﻿using EjercicioLista2.Dtos;
using EjercicioLista2.Servicios;

namespace EjercicioLista2 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 20/11/2023 -> irm
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo principal de la apliacion
        /// 20/11/2023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Creamos los objetos necesarios
            ClienteDto nuevoCLiente = new ClienteDto();
            MenuInterfaz mi = new MenuImplementacion();
            ModificacionesListaInterfaz mL = new ModificacionesListaImplementacion();
            //variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;
            //lista donde se va a guardar la informacion introducida por el usuario
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            List<CuentaDto> listaCuenta = new List<CuentaDto>();
            //desde la primera iteración debe cumplirse la condición
            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se va ha cerrar la aplicacion");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado insertar un nuevo cliente");
                        mL.darAltaCliente(listaCliente);
                        /*foreach (ClienteDto cliente in listaCliente) 
                        {
                            Console.WriteLine(cliente.ToString());
                        }*/
                        break;
                    case 2:
                        mL.darAltaCuenta(listaCuenta);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }

            }
        }

    }
}