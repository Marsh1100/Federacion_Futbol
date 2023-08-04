using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FederacionFutbol2.View
{
    public class MenuBusqueda
    {
        public MenuBusqueda()
        {
        }

        public string MostrarBusqueda()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n***** CONSULTA DE DATOS *****");
            Console.ResetColor();

            Console.WriteLine("2.1 Listar Equipos");
            Console.WriteLine("2.2 Listar Jugadores");
            Console.WriteLine("2.3 Buscar los delanteros de cada equipo");
            Console.WriteLine("2.4 Buscar cuerpo de entrenadores por equipo");
            Console.WriteLine("2.5 Regresar al menu principal");

            Console.Write("Elige una opción: ");
            string opcion = Convert.ToString(Console.ReadLine()) ?? "Invalid";
            return opcion;
            
        }
    }
}