using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace futbolTorneo.View
{
    public class MenuConsult
    {
        public MenuConsult(){}
        public string showMenuConsult()
        {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCONSULTAS \n\n");
                Console.WriteLine("2.1 Listar judadores por equipo");
                Console.WriteLine("2.2 Buscar delanteros de cada equipo");
                Console.WriteLine("2.3 Buscar cuerpo de entrenadores por equipo");
                Console.WriteLine("2.4 Regresar al menú principal\n\n");
                Console.WriteLine("******************************");
                Console.Write("Elija una Opción: ");
                Console.ResetColor();
                string? option = Console.ReadLine();
                return option;

        }
    }
}