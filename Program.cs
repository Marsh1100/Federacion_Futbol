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


    static Liga metodosLiga = new ();
    static Equipo metodosEquipo = new ();
    static Jugador metodosJugador = new ();
    static Entrenador metodosEntrenador = new ();
    static Masajista metodosMasajista = new();

    public static void Main()
    {
        string opcion;
        Liga newLiga = new("aaaa",1899,"cali");
        DicLigas.Add("123",newLiga);
        DicLigas.Add("456",newLiga);
        DicLigas.Add("789",newLiga);

        Equipo newEquipo = new ("eeee",23,"Tunja","Federico","123");
        Equipo newEquipo2 = new ("Bucaros",23,"Tunja","Federico","123");
        Equipo newEquipo3 = new ("Millos",23,"Tunja","Federico","456");

        DicEquipos.Add("111",newEquipo);
        DicEquipos.Add("222",newEquipo2);
        DicEquipos.Add("333",newEquipo3);

        Jugador newJugador = new("Cesar",17,"18","Lateral","Valledupar","111");
        Jugador newJugador2 = new("Luis",17,"18","Delantero","Valledupar","222");
        Jugador newJugador3 = new("Alejo",17,"18","Delantero","Valledupar","333");

        DicJugadores.Add("999",newJugador);
        DicJugadores.Add("888",newJugador);
        DicJugadores.Add("666",newJugador2);
        DicJugadores.Add("555",newJugador3);


        DicJugadores.Add("777",newJugador2);



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
                
                break;
            case "1.4":
                metodosEquipo.MostrarEquipos(DicEquipos);
                metodosEntrenador.RegistrarEntrenador(DicEquipos,DicEntrenadores);

                foreach(var entrenador in DicEntrenadores)
                {
                    string idEquipo = entrenador.Value.IdEquipo;
                    string equipo = DicEquipos[idEquipo].Nombre ?? "Equipo";


                    Console.WriteLine("ID entrenador:{0} \tEquipo:{1} \tNombre {2}\tEdad {3}",entrenador.Key,
                    equipo,entrenador.Value.Nombre,entrenador.Value.Edad);
                }
                break;
            case "1.5":
                metodosEquipo.MostrarEquipos(DicEquipos);
                metodosMasajista.RegistrarMasajista(DicEquipos,DicMasajistas);
                
                foreach(var masajista in DicMasajistas)
                {
                    string idEquipo = masajista.Value.IdEquipo;
                    string equipo = DicEquipos[idEquipo].Nombre ?? "Equipo";


                    Console.WriteLine("ID masajista:{0} \tEquipo:{1} \tNombre {2}\tEdad {3}",masajista.Key,
                    equipo,masajista.Value.Nombre,masajista.Value.Edad);
                }
                break;
            case "1.6":
                    metodosJugador.MostrarJugadores(DicEquipos,DicJugadores);
                    metodosJugador.VenderJugador(DicEquipos,DicJugadores);
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
                metodosEquipo.MostrarEquipos(DicEquipos);
                Console.ReadKey();
                break;
            case "2.2":
                metodosJugador.MostrarJugadores(DicEquipos,DicJugadores);
                Console.ReadKey();
                break;
            case "2.3":
                metodosJugador.FiltroPosicionJugador(DicEquipos,DicJugadores);
                Console.ReadKey();
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