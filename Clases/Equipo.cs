using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.Clases
{
    public class Equipo 
    {
        //Atributos 
        private string? nombre;
        private int edad;
        private string? ciudadOrigen;
        private string? propietario;

        private string? idLiga;

       //Cosntructor
       public Equipo()
       {

       }
       public Equipo(string Nombre, int Edad, string CiudadOrigen, string Propietario, string IdLiga)  
       {
            this.nombre = Nombre;
            this.edad = Edad;
            this.ciudadOrigen = CiudadOrigen;

            this.idLiga  = IdLiga;
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

        public string? CiudadOrigen
        {
            get{ return this.ciudadOrigen; }
            set{ this.ciudadOrigen = value; }
        }
        
        public string? Propietario
        {
            get{ return this.propietario; }
            set{ this.propietario = value; }
        }

        public string? IdLiga
        {
            get{ return this.idLiga; }
            set{ this.idLiga = value; }
        }

    

        public void RegistrarEquipo(Dictionary<string,Liga> DicLiga, Dictionary<string,Equipo> DicEquipo)
        {
            Console.WriteLine("Digite el ID de la liga al que va a pertenecer el equipo:");
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

        }

        public void MostrarEquipos(Dictionary<string,Equipo> DicEquipo){
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------ EQUIPOS -----");
            Console.ResetColor();
            Console.WriteLine("ID\tNombre");
            foreach(var equipo in DicEquipo)
            {
                Console.WriteLine(equipo.Key+"\t"+equipo.Value.Nombre);
            }
            Console.ReadKey();

        }
    }
}