namespace FederacionFutbol2.View
{
    public class MainMenu
    {
        public MainMenu()
        {
        }

        public string MostrarMenu() {
        //Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Menú de opciones:");
        Console.ResetColor();

        Console.WriteLine("1. Registro Plantel");
        Console.WriteLine("2. Consulta de datos");
        Console.WriteLine("3. Salir");

        Console.Write("Elige una opción: ");
        string opcion = Convert.ToString(Console.ReadLine()) ?? "Invalid";
        return opcion;
    
        }

    
    }

    }

   

   
