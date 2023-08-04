using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.Clases
{
    public class Jugador
    {
        
        
        //Atributos 
        private string nombre;
        private int edad;
        private string dorsal;
        private string posicionJuego;
        private string ciudadOrigen;

        private string idEquipo;


        //Constructor
        public Jugador()
        {

        }
        public Jugador(string Nombre, int Edad, string Dorsal,string PosicionJuego, string CiudadOrigen, string IdEquipo)
        {
            this.nombre = Nombre;
            this.edad = Edad;
            this.dorsal = Dorsal;
            this.posicionJuego = PosicionJuego;
            this.ciudadOrigen = CiudadOrigen;
            this.idEquipo = IdEquipo;
        }


        //Propiedades
        public string Nombre
        {
            get{ return this.nombre; }
            set{ this.nombre = value; }
        }

        public int Edad
        {
            get{ return this.edad; }
            set{ this.edad = value; }
        }

        public string Dorsal
        {
            get{ return this.dorsal; }
            set{ this.dorsal = value; }
        }
        public string PosicionJuego
        {
            get{ return this.posicionJuego; }
            set{ this.posicionJuego = value; }
        }

        public string CiudadOrigen
        {
            get{ return this.ciudadOrigen; }
            set{ this.ciudadOrigen = value; }
        }

        public string IdEquipo
        {
            get{ return this.idEquipo; }
            set{ this.idEquipo = value; }
        }

       public void RegistrarJugador(Dictionary<string,Equipo> DicEquipo, Dictionary<string,Jugador> DicJugadores)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******* REGISTRAR JUGADOR *******");
            Console.ResetColor();
            Console.WriteLine("Digite el ID del equipo al que va a pertenecer el Jugador:");
            string idEquipo = Convert.ToString(Console.ReadLine()) ?? "";

            if(DicEquipo.ContainsKey(idEquipo))
            {
                Console.WriteLine("Digite número de identificación del jugador: ");
                string idJugador = Convert.ToString(Console.ReadLine()) ?? "";

                if(!DicJugadores.ContainsKey(idJugador)) 
                {
                    Console.WriteLine("Digite nombre del Jugador: ");
                    string nombreJugador = Convert.ToString(Console.ReadLine()) ?? "";

                    //Cambiar por fecha de nacimiento
                    Console.WriteLine("Digite edad del jugador: ");
                    if(int.TryParse(Console.ReadLine(), out int edadJugador )){
                        
                        Console.WriteLine("Digite dorsal del jugador: ");
                        string dorsalJugador = Convert.ToString(Console.ReadLine()) ?? "";
                        
                        Console.WriteLine("Digite posición de juego del jugador: ");
                        string posicionJugador = Convert.ToString(Console.ReadLine()) ?? "";

                        Console.WriteLine("Digite ciudad de origen del jugador: ");
                        string ciudadJugador = Convert.ToString(Console.ReadLine()) ?? "";

                        

                        Jugador newJugador= new (nombreJugador,edadJugador,dorsalJugador,posicionJugador,ciudadJugador,idEquipo);
                        DicJugadores.Add(idJugador,newJugador);

                        Console.WriteLine("¡Jugador registrado exitosamente!");
                        Console.ReadKey();


                    }else{
                        Console.WriteLine("Digite un valor númerico");
                        Console.ReadKey();
                    }
                    
                }else{
                    Console.WriteLine("El número de identificación ya  encuentra resgistrado");
                }
                
            }else
            {
                Console.WriteLine("El ID del equipo no se encuentra registrado. Por favor verifique.");
            }

        }
        

        public void MostrarJugadores(Dictionary<string,Equipo> DicEquipos,Dictionary<string,Jugador> DicJugadores)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------ JUGADORES -----");
            Console.ResetColor();

            Console.WriteLine("ID\tEquipo\tNombre\tEspecialidad");
            foreach(var jugador in DicJugadores)
            {
                string idEquipo = jugador.Value.IdEquipo;
                string equipo = DicEquipos[idEquipo].Nombre ?? "Equipo";


                Console.WriteLine(jugador.Key+"\t"+equipo+"\t"+jugador.Value.Nombre+"\t"+jugador.Value.posicionJuego);
            }
        }

        public void VenderJugador(Dictionary<string,Jugador> DicJugadores)
        {
            
        }
    }
}