using futbolTorneo.View;

class Program
{
    static void Main(string[] args)
    {
        bool blContinue = true;
        int optionMain;
        do
        {
            MainMenu MainMenu = new MainMenu();
            optionMain = MainMenu.MostrarMenu();
            switch (optionMain)
            {
                case 0:
                    Console.WriteLine("Hey, ojito, ingresa números.");
                    Console.ReadKey();
                    break;
                case 1:
                    chooseOptionRegister();
                    break;
                case 2:
                    chooseOptionCOnsult();
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
        } while (blContinue);

        static void chooseOptionRegister()
        {
            bool blContinueSubMenu = true;
            string optionRegister;
            do
            {
                MenuRegister RegisterMenu = new MenuRegister();
                optionRegister = RegisterMenu.ShowMenuRegister();
                switch (optionRegister)
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

        static void chooseOptionCOnsult()
        {
            bool blContinueSubMenu = true;
            string optionConsult;
            do
            {
                MenuConsult ConsultMenu = new MenuConsult();
                optionConsult = ConsultMenu.showMenuConsult();

                switch (optionConsult)
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

