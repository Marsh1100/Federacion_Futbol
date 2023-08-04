using FederacionFutbol2.View;

using FederacionFutbol2.Clases;
internal class Program
{
     //Diccionario de Ligas
    static Dictionary<string,Liga> DicLigas = new Dictionary<string,Liga>();

    //Diccionario de Equipos
    static Dictionary<string,Equipo> DicEquipos = new Dictionary<string,Equipo>();
    //Diccionario de Jugador
    static Dictionary<string,Jugador> DicJugadores = new Dictionary<string,Jugador>();

    public static void Main(string[] args)
    {
        string opcion;

        do
        {
            MainMenu mainmenu = new MainMenu();

            opcion = mainmenu.MostrarMenu();

            switch (opcion) {
                case "1":
                    OpcionesPlantel();
                    break;

                case "2":
                    OpcionesBusqueda();
                    break;
                case "3":
                    Console.WriteLine("Fin del programa!");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }


        }while(opcion != "3");
    }

    static void OpcionesPlantel()
    {
        string opcion;
        Liga metodosLiga = new Liga();
        Equipo metodosEquipo = new Equipo();

        do{
            MenuPlantel menuplantel = new MenuPlantel();
            opcion = menuplantel.MostrarPlantel();

            switch (opcion)
            {
            case "1.1":
                metodosLiga.RegistrarLiga(DicLigas);
                break;
            case "1.2":
                metodosLiga.MostrarLigas(DicLigas);
                metodosEquipo.RegistrarEquipo(DicLigas,DicEquipos);

                foreach(var equipo in DicEquipos)
                {
                    Console.WriteLine("ID Equipo {0}\t Nombre {1}\t Edad {2}",equipo.Key,equipo.Value.Nombre,equipo.Value.Edad);
                }
                break;
            case "1.3":
                break;
            case "1.4":
                break;
            case "1.5":
                break;
            case "1.6":
                break;
            case "1.7":
                break;
            default:
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                break;
            
            }
        }while(opcion != "1.7");
        
    }

    static void OpcionesBusqueda()
    {
        string opcion;

        do
        {
            MenuBusqueda menuBusqueda = new MenuBusqueda();
            opcion = menuBusqueda.MostrarBusqueda();
            switch (opcion)
            {
            case "2.1":
                Console.WriteLine("Holuu");

                Console.ReadKey();

                break;
            case "2.2":
                break;
            case "2.3":
                break;
            case "2.4":
                break;
            default:
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                Console.ReadKey();
                break;
        }

        }while(opcion!="2.4");
        

    }
}