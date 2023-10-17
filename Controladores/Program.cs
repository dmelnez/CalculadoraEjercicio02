using Calculadora.Servicios;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora;

/// <summary>
/// Clase que Implenta la Interfaz del Menu
/// 10/10/2023 - DMN
/// </summary>

class Program
{
    static void Main(String[] args)
    {
        MenuInterfaz menuinterfaz = new MenuImplementacion();
        menuinterfaz.BienvenidaUsuario();
        bool cerrarCal = false;
        int seleccionUsuario;

        double valor01, valor02;
        


        while (!cerrarCal)
        {

            seleccionUsuario = menuinterfaz.MostrarMenu();
            Console.WriteLine(seleccionUsuario);
            


            switch (seleccionUsuario)
            {

              /*  public int peticionNumero()
                 {
                Console.WriteLine("Dime un Numero");
                Console.WriteLine("Dime un Segundo Numero")
                  } Este metodo no tiene que estar aqui*/

                case 1:
                    Console.WriteLine("[INFO] - Seleccion de Salida");
                    cerrarCal=true;
                    break;

                case 2:
                    Console.WriteLine("[INFO] - Seleccion de Suma");

                    Console.WriteLine("Introduzca un Valor");
                  
                    valor01 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca un Segundo Valor");
                 
                    valor02 = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine(valor01 + valor02);
              
                    break;

                case 3:
                    Console.WriteLine("[INFO] - Seleccion de Resta");

                    Console.WriteLine("Introduzca un Valor");
                  
                    valor01 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca un Segundo Valor");
                   
                    valor02 = int.Parse(Console.ReadLine());
      
                    Console.WriteLine(valor01 - valor02);
                    break;

                case 4:

                    Console.WriteLine("[INFO] - Seleccion de Multiplicacion");

                    Console.WriteLine("Introduzca un Valor");

                    valor01 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca un Segundo Valor");

                    valor02 = int.Parse(Console.ReadLine());

                    Console.WriteLine(valor01 * valor02);

                    break;

                case 5:
                    Console.WriteLine("[INFO] - Seleccion de Division");

                    Console.WriteLine("Introduzca un Valor");

                    valor01 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca un Segundo Valor");

                    valor02 = int.Parse(Console.ReadLine());

                    Console.WriteLine(valor01 / valor02);
                    break;

                default:
                    Console.WriteLine("[INFO] - La opcion Seleecionada, no coincide con ninguna opcion disponible");
                    break;

            }

        }

    }
}
