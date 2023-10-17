using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{

    /// <summary>
    /// Interfaz que contiene la relacion de metodos con el menu
    /// 10/10/2023 - DMN
    /// </summary>

    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que lanza el mensaje de bienvenidaUsuario al usuario
        /// 10/10/2023 - DMN
        /// </summary>


        void BienvenidaUsuario();



        /// <summary>
        /// Metodo que Muestra el menu de seleccion y recoger el valor introducido por el usuario
        /// 10/10/2023
        /// </summary>
        /// <returns>Entero con la Opcion Seleecionada</returns>

        public int MostrarMenu();
    }
}
