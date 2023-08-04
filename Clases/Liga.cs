namespace FederacionFutbol2.Clases
{

    public class Liga
    {
         //Atributos 
        private string nombre;
        private int fundacion;
        private string ciudadOrigen;

        //Constructor
        public Liga()
        {

        }
        public Liga(string Nombre, int Fundacion, string CiudadOrigen)
        {
            this.nombre = Nombre;
            this.fundacion = Fundacion;
            this.ciudadOrigen = CiudadOrigen;
        }


        //Propiedades
        public string Nombre
        {
            get{ return this.nombre; }
            set{ this.nombre = value; }
        }

        public int Fundacion
        {
            get{ return this.fundacion; }
            set{ this.fundacion = value; }
        }

        public string CiudadOrigen
        {
            get{ return this.ciudadOrigen; }
            set{ this.ciudadOrigen = value; }
        }
        

        //MÉTODOS
        //Agregar Liga

        public static void RegistrarLiga(Dictionary<string,Liga> DicLiga)
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****** REGISTRAR NUEVA LIGA ********\n");
            Console.ResetColor();
            
            Console.WriteLine("Digite Id de la liga: ");
            string idLiga = Convert.ToString(Console.ReadLine()) ?? "Liga";

            if(!DicLiga.ContainsKey(idLiga)) 
            {
                Console.WriteLine("Digite nombre de la liga: ");
                string nombreLiga = Convert.ToString(Console.ReadLine()) ?? "Liga";

                Console.WriteLine("Digite el año de fundación de la liga: ");
                if(int.TryParse(Console.ReadLine(), out int fundacionLiga )){
                    
                    Console.WriteLine("Digite ciudad de origen del equipo: ");
                    string ciudadLiga = Convert.ToString(Console.ReadLine()) ?? "Propietario";

                    Liga newLiga = new (nombreLiga,fundacionLiga,ciudadLiga);
                    DicLiga.Add(idLiga,newLiga);

                    Console.WriteLine("¡Liga registrada exitosamente!");
                    Console.ReadKey();


                }else{
                    Console.WriteLine("Digite un valor númerico");
                    Console.ReadKey();
                }
                
                }
            else{
                 Console.WriteLine("El número de ID de la liga ya se encuentra resgistrado");
                    Console.ReadKey();

                
            }

        }

        public void MostrarLigas(Dictionary<string,Liga> DicLiga){
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------ LIGAS -----");
            Console.ResetColor();
            Console.WriteLine("ID\tNombre");
            foreach(var liga in DicLiga)
            {
                Console.WriteLine(liga.Key+"\t"+liga.Value.Nombre);
            }

        }
    
    }
    
}