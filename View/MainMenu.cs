namespace futbolTorneo.View;

    public class MainMenu
    {
        public MainMenu(){

        }

        public int  MostrarMenu(){
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
                return option;
            }
            else{
                option = 0;
                return option;
            }
        }
        
    }
