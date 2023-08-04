using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.Clases
{
    public class Masajista
    {
         //Atributos 
        private string nombre;
        private int edad;
        private string titulacion;
        private int experiencia;
        private string ciudadOrigen;

        private string idEquipo;


        //Constructor
        public Masajista()
        {

        }
        public Masajista(string Nombre, int Edad, string Titulacion,int Experiencia, string CiudadOrigen, string IdEquipo)
        {
            this.nombre = Nombre;
            this.edad = Edad;
            this.experiencia = Experiencia;
            this.titulacion = Titulacion;
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

        public string Titulacion
        {
            get{ return this.titulacion; }
            set{ this.titulacion = value; }
        }
        public int Experencia
        {
            get{ return this.experiencia; }
            set{ this.experiencia = value; }
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

        public void RegistrarMasajista(Dictionary<string,Equipo> DicEquipos, Dictionary<string,Masajista> DicMasajistas)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******* REGISTRAR MASAJISTA *******");
            Console.ResetColor();
            Console.WriteLine("Digite el ID del equipo al que va a pertenecer el masajista:");
            string idEquipo = Convert.ToString(Console.ReadLine()) ?? "";

            if(DicEquipos.ContainsKey(idEquipo))
            {
                Console.WriteLine("Digite número de identificación del masajista: ");
                string idMasajista= Convert.ToString(Console.ReadLine()) ?? "";

                if(!DicMasajistas.ContainsKey(idMasajista)) 
                {
                    Console.WriteLine("Digite nombre del masajista: ");
                    string nombre = Convert.ToString(Console.ReadLine()) ?? "";

                    //Cambiar por fecha de nacimiento
                    Console.WriteLine("Digite edad del masajista: ");
                    if(int.TryParse(Console.ReadLine(), out int edad )){
                        
                        Console.WriteLine("Digite años de experiencia del masajista: ");
                        int experiencia = Int32.Parse(Console.ReadLine()) ;
                        
                        Console.WriteLine("Digite título del masajista: ");
                        string titulo = Convert.ToString(Console.ReadLine()) ?? "";

                        Console.WriteLine("Digite ciudad de origen del masajista: ");
                        string ciudad = Convert.ToString(Console.ReadLine()) ?? "";

                        

                        Masajista newMasajista= new (nombre,edad,titulo,experiencia,ciudad,idEquipo);

                        DicMasajistas.Add(idMasajista,newMasajista);

                        Console.WriteLine("Masajista registrado exitosamente!");
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
                Console.WriteLine("El ID del masajista no se encuentra registrado. Por favor verifique.");
            }

        }
    }
}