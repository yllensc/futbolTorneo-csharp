internal class Program
{
    static void Main(string[] args)
    {
        bool blContinue = true;

        do
        {
            Console.Clear();
            Console.WriteLine(" LIGA BETPLAY \n\n");
            Console.WriteLine("1. Registrar plantel");
            Console.WriteLine("2. Consulta de datos");
            Console.WriteLine("3. Salir\n\n");
            Console.WriteLine("8. Terminar\n\n");
            Console.WriteLine("******************************");
            Console.Write("Elija una Opción: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        showSubMenuRegister();
                        break;
                    case 2:
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
    }

    int showSubMenuRegister(){
        bool blContinueSUbMenu1 = true;
        do{
        Console.Clear();
        Console.WriteLine(" REGISTRO PLANTEL \n\n");
        Console.WriteLine("1.1 Registrar equipo");
        Console.WriteLine("1.2 Registrar jugador");
        Console.WriteLine("1.3 Registrar entrenador");
        Console.WriteLine("1.4 Registrar terapista");
        Console.WriteLine("1.5 Vender jugador");
        Console.WriteLine("1.6 Terminar\n\n");
        Console.WriteLine("******************************");
        Console.Write("Elija una Opción: ");
        string option = Console.ReadLine();
        
                switch (option)
                {
                    case "1.1":
                        Console.WriteLine("holi 1.1");
                        break;
                    case "1.2":
                        break;
                    case "1.3":
                        Console.WriteLine("holi 1.2");
                        break;
                    case "1.4":
                        Console.WriteLine("holi 1.3");
                        break;
                    case "1.5":
                        Console.WriteLine("holi 1.4");
                        break;
                    case "1.6":
                        Console.WriteLine("holi 1.5");
                        blContinueSUbMenu1 = false;
                        break;
                    default:
                        Console.WriteLine("No tenemos esa opción, sorry");
                        Console.ReadKey();
                        break;
                }
        
        } while (blContinueSUbMenu1);


    }
    //int showSubMenuConsult(){}
}

