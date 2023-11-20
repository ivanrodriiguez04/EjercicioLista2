using EjercicioLista2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista2.Servicios
{
    internal interface ModificacionesListaInterfaz
    {
        /// <summary>
        /// Metodo que da del alta a un nuevo cliente
        /// 20/11/2023 -> irm
        /// </summary>
        /// <param name=""></param>
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua);
        public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua);
    }
}
