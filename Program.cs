using FederacionFutbol2.View;

using FederacionFutbol2.Clases;
internal class Program
{
     //Diccionario de Ligas
    static Dictionary<string,Liga> DicLigas = new ();

    //Diccionario de Equipos
    static Dictionary<string,Equipo> DicEquipos = new ();
    //Diccionario de Jugador
    static Dictionary<string,Jugador> DicJugadores = new ();
    //Diccionario de Entrenador
    static Dictionary<string,Entrenador> DicEntrenadores = new ();
    //Diccionario de Entrenador
    static Dictionary<string,Masajista> DicMasajistas = new ();

    public static void Main()
    {
        string opcion;

        do
        {
            MainMenu mainmenu = new ();

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
        Liga metodosLiga = new ();
        Equipo metodosEquipo = new ();
        Jugador metodosJugador = new ();
        Entrenador metodosEntrenador = new ();
        Masajista metodosMasajista = new();

        do
        {
            MenuPlantel menuplantel = new ();
            opcion = menuplantel.MostrarPlantel();

            switch (opcion)
            {
            case "1.1":
                    Liga.RegistrarLiga(DicLigas);
                break;
            case "1.2":
                metodosLiga.MostrarLigas(DicLigas);
                metodosEquipo.RegistrarEquipo(DicLigas,DicEquipos);

                foreach(var equipo in DicEquipos)
                {
                    string idliga = equipo.Value.IdLiga;
                    string liga = DicLigas[idliga].Nombre ?? "Liga";
                    Console.WriteLine("ID Equipo {0}\tLiga{1}\tNombre {2}\tEdad {3}",equipo.Key,liga,equipo.Value.Nombre,equipo.Value.Edad);
                }
                break;
            case "1.3":
                metodosEquipo.MostrarEquipos(DicEquipos);
                metodosJugador.RegistrarJugador(DicEquipos,DicJugadores);
                foreach(var jugador in DicJugadores)
                {
                    string idEquipo = jugador.Value.IdEquipo;
                    string equipo = DicEquipos[idEquipo].Nombre ?? "Equipo";


                    Console.WriteLine("ID Jugador:{0} \tEquipo:{1} \tNombre {2}\tEdad {3}",jugador.Key,equipo,jugador.Value.Nombre,jugador.Value.Edad);
                }
                break;
            case "1.4":
                metodosEquipo.MostrarEquipos(DicEquipos);
                metodosEntrenador.RegistrarEntrenador(DicEquipos,DicEntrenadores);
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
            MenuBusqueda menuBusqueda = new ();
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