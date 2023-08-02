using System.Collections;
using System.Globalization;
internal class Program
{
    static void Main(string[] args)
    {
        bool blContinue = true;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLIGA BETPLAY \n\n");
            Console.WriteLine("1. Registrar plantel");
            Console.WriteLine("2. Consulta de datos");
            Console.WriteLine("3. Salir\n\n");
            Console.WriteLine("******************************");
            Console.Write("Elija una Opción: ");
            Console.ResetColor();

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        showSubMenuRegister();
                        break;
                    case 2:
                        showSubMenuConsult();
                        break;
                    case 3:
                        Console.WriteLine("Bye, bye");
                        blContinue = false;
                        break;
                    default:
                        Console.WriteLine("No tenemos esa opción, sorry");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Hey, ojito, ingresa números.");
                Console.ReadKey();
            }
        } while (blContinue);

        static void showSubMenuRegister()
        {
            bool blContinueSubMenu = true;
            do
            {
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

                switch (option)
                {
                    case "1.1":
                        Console.WriteLine("holi 1.1");
                        break;
                    case "1.2":
                        Console.WriteLine("holi 1.2");
                        break;
                    case "1.3":
                        Console.WriteLine("holi 1.3");
                        break;
                    case "1.4":
                        Console.WriteLine("holi 1.4");
                        break;
                    case "1.5":
                        Console.WriteLine("holi 1.5");
                        break;
                    case "1.6":
                        Console.WriteLine("holi 1.6");
                        blContinueSubMenu = false;
                        break;
                    default:
                        Console.WriteLine("No tenemos esa opción, sorry");
                        Console.ReadKey();
                        break;
                }
            } while (blContinueSubMenu);

        }

        static void showSubMenuConsult()
        {
            bool blContinueSubMenu = true;
            do
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

                switch (option)
                {
                    case "2.1":
                        Console.WriteLine("holi 1.1");
                        break;
                    case "2.2":
                        Console.WriteLine("holi 1.2");
                        break;
                    case "2.3":
                        Console.WriteLine("holi 1.3");
                        break;
                    case "2.4":
                        blContinueSubMenu = false;
                        break;
                    default:
                        Console.WriteLine("No tenemos esa opción, sorry");
                        Console.ReadKey();
                        break;
                }
            } while (blContinueSubMenu);

        }
    }

}

