namespace FederacionFutbol2.View
{
    public class MenuPlantel
    {
        public MenuPlantel()
        {
        }

        public string MostrarPlantel()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n***** REGISTRO PLANTEL *****");
            Console.ResetColor();

            Console.WriteLine("1.1 Registro de la Liga");

            Console.WriteLine("1.2 Registro de Equipo");
            Console.WriteLine("1.3 Registro de Jugador");
            Console.WriteLine("1.4 Registro de Entrenador");
            Console.WriteLine("1.5 Registro de Masajista");
            Console.WriteLine("1.6 Venta de Jugador");
            Console.WriteLine("1.7 Salir");

            Console.Write("Elige una opción: ");
            string opcion = Convert.ToString(Console.ReadLine()) ?? "Invalid";
            return opcion;
            
        }
}
}