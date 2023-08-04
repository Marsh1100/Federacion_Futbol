using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.Clases
{
    public class Jugador
    {
        
        
        //Atributos 
        private string? nombre;
        private int edad;
        private string? dorsal;
        private string? posicionJuego;
        private string? ciudadOrigen;

        private string? idEquipo;


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
        public string? Nombre
        {
            get{ return this.nombre; }
            set{ this.nombre = value; }
        }

        public int Edad
        {
            get{ return this.edad; }
            set{ this.edad = value; }
        }

        public string? Dorsal
        {
            get{ return this.dorsal; }
            set{ this.dorsal = value; }
        }
        public string? PosicionJuego
        {
            get{ return this.posicionJuego; }
            set{ this.posicionJuego = value; }
        }

        public string? CiudadOrigen
        {
            get{ return this.ciudadOrigen; }
            set{ this.ciudadOrigen = value; }
        }

        public string? IdEquipo
        {
            get{ return this.idEquipo; }
            set{ this.idEquipo = value; }
        }

       /* public void RegistrarJugador(Dictionary<string,Equipo> DicEquipo, Dictionary<string,Jugador> DicJugadores)
        {

            Console.WriteLine("Digite el ID del equipo al que va a pertenecer el Jugador:");
            string idLiga = Convert.ToString(Console.ReadLine()) ?? "Liga";

            if(DicLiga.ContainsKey(idLiga))
            {
                Console.WriteLine("Digite Id del Equipo: ");
                string idEquipo = Convert.ToString(Console.ReadLine()) ?? "Liga";

                if(!DicEquipo.ContainsKey(idEquipo)) 
                {
                    Console.WriteLine("Digite nombre del equipo: ");
                    string nombreEquipo = Convert.ToString(Console.ReadLine()) ?? "Equipo";

                    Console.WriteLine("Digite el años que tiene el quipo: ");
                    if(int.TryParse(Console.ReadLine(), out int edadEquipo )){
                        
                        Console.WriteLine("Digite ciudad de origen del equipo: ");
                        string ciudadEquipo = Convert.ToString(Console.ReadLine()) ?? "ciudad";

                        Console.WriteLine("Digite propietario del equipo: ");
                        string propietarioEquipo = Convert.ToString(Console.ReadLine()) ?? "propietario";

                        Equipo newEquipo= new Equipo(nombreEquipo,edadEquipo,ciudadEquipo, propietarioEquipo, idLiga);
                        DicEquipo.Add(idEquipo,newEquipo);

                        Console.WriteLine("¡Equipo registrado exitosamente!");
                        Console.ReadKey();


                    }else{
                        Console.WriteLine("Digite un valor númerico");
                        Console.ReadKey();
                    }
                    
                }else{
                    Console.WriteLine("El número de ID del equipo ya se encuentra resgistrado");
                }
                
            }else
            {
                Console.WriteLine("El ID de la liga no se encuentra registrado. Por favor verifique");
            }

        }*/
        
    }
}