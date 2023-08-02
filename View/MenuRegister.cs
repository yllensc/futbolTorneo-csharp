using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbolTorneo.View
{
    public class MenuRegister
    {
        public MenuRegister(){

        }

        public string ShowMenuRegister(){
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nREGISTRO PLANTEL \n\n");
                Console.WriteLine("1.1 Registrar equipo");
                Console.WriteLine("1.2 Registrar jugador");
                Console.WriteLine("1.3 Registrar entrenador");
                Console.WriteLine("1.4 Registrar terapista");
                Console.WriteLine("1.5 Vender jugador");
                Console.WriteLine("1.6 Regresar al menú principal\n\n");
                Console.WriteLine("******************************");
                Console.Write("Elija una Opción: ");
                Console.ResetColor();
                string? option = Console.ReadLine();
                return option;
        }
    }
}