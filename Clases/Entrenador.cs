using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.Clases
{
    public class Entrenador
    {
         
        //Atributos 
        private string nombre;
        private int edad;
        private string codigoFederacion;
        private string especialidad;
        private string ciudadOrigen;

        private string idEquipo;


        //Constructor
        public Entrenador()
        {

        }
        public Entrenador(string Nombre, int Edad, string CodigoFederacion,string Especialidad, string CiudadOrigen, string IdEquipo)
        {
            this.nombre = Nombre;
            this.edad = Edad;
            this.codigoFederacion = CodigoFederacion;
            this.especialidad = Especialidad;
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

        public string CodigoFederacion
        {
            get{ return this.codigoFederacion; }
            set{ this.codigoFederacion = value; }
        }
        public string Especialidad
        {
            get{ return this.especialidad; }
            set{ this.especialidad = value; }
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


        public void RegistrarEntrenador(Dictionary<string,Equipo> DicEquipo, Dictionary<string,Entrenador> DicEntrenadores)
        {


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******* REGISTRAR ENTRENADOR *******");
            Console.ResetColor();

            Console.WriteLine("Digite el ID del equipo al que va a pertenecer el Entrenador:");
            string idEquipo = Convert.ToString(Console.ReadLine()) ?? "";

            if(DicEquipo.ContainsKey(idEquipo))
            {
                Console.WriteLine("Digite número de identificación del Entrenador: ");
                string idEntrenador= Convert.ToString(Console.ReadLine()) ?? "";

                if(!DicEntrenadores.ContainsKey(idEntrenador)) 
                {
                    Console.WriteLine("Digite nombre del Entrenador: ");
                    string nombreEntrenador = Convert.ToString(Console.ReadLine()) ?? "";

                    //Cambiar por fecha de nacimiento
                    Console.WriteLine("Digite edad del Entrenador: ");
                    if(int.TryParse(Console.ReadLine(), out int edadEntrenador )){
                        
                        Console.WriteLine("Digite código de federación del Entrenador: ");
                        string codeEntrenador = Convert.ToString(Console.ReadLine()) ?? "";
                        
                        Console.WriteLine("Digite especialidad del Entrenador: ");
                        string especEntrenador = Convert.ToString(Console.ReadLine()) ?? "";

                        Console.WriteLine("Digite ciudad de origen del Entrenador: ");
                        string ciudadEntrenador = Convert.ToString(Console.ReadLine()) ?? "";

                        

                        Entrenador newEntrenador= new (nombreEntrenador,edadEntrenador,codeEntrenador,especEntrenador,ciudadEntrenador,idEquipo);
                        DicEntrenadores.Add(idEntrenador,newEntrenador);

                        Console.WriteLine("Entrenador registrado exitosamente!");
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
                Console.WriteLine("El ID del entrenador no se encuentra registrado. Por favor verifique.");
            }

        }
    }
}