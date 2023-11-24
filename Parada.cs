using System.Collections.Generic;

namespace Proyecto
{
    public class Parada
    {
        //Declaración de variable y propiedades
        private string nombre;

        public Parada(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public static List<Parada> ObtenerParadas() //Lista de las paradas con las que se van a trabajar a lo largo del proyecto 
        {
            return new List<Parada>
            {
                new Parada("Anexo de Ingeniería"),
                new Parada("FCA"),
                new Parada("Trabajo Social"),
                new Parada("Metrobús CU"),
                new Parada("Metro CU"),
            };
        }

    }
}
