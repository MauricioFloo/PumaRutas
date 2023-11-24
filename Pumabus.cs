using System;

namespace Proyecto
{
    public class Pumabus
    {
        // Declaración de variables estáticas y sus propiedades
        private static int nopumabus1; //Número de pumabuses para la ruta 2
        private static int nopumabus2; //Número de pumabuses para la ruta 2

        public static int Nopumabus1
        {
            get => nopumabus1;
            private set => nopumabus1 = value;
        }
        public static int Nopumabus2
        {
            get => nopumabus2;
            private set => nopumabus2 = value;
        }

        static Pumabus()
        {
            // Generar un número aleatorio para nopumabus
            Random aleatorio = new Random();
            Nopumabus1 = aleatorio.Next(0, 25); // Genera un número aleatorio entre 1 y 25
            Nopumabus2 = aleatorio.Next(26, 50); // Genera un número aleatorio entre 26 y 50
        }
    }
}
