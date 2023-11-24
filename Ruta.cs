using System.Collections.Generic;

namespace Proyecto
{
    public class Ruta
    {
        // Declaración de dos listas y sus propiedades
        public List<Parada> Paradas { get; set; }  //Lista de las paradas
        public List<int> Tiempos { get; set; } //Lista con los tiempos entre paradas

        // Constructor para la Ruta 2
        public Ruta()
        {
            Paradas = Parada.ObtenerParadas(); //Se manda a llamar a la lista con las paradas por medio de ObtenerParadas ubicado en la clase Parada
            Tiempos = new List<int> { 2, 3, 2, 10, 10 }; //Es la lista con enteros, donde se muestran los tiempos entre paradas medios con google maps
        }

        // Constructor para la Ruta 4
        public Ruta(string ruta) //Se hace una sobrecarga ya que se tiene ya el constructor de Ruta pero este es para la ruta 4 
        {
            Paradas = Parada.ObtenerParadas();
            if (ruta == "Ruta4")
            {
                Tiempos = new List<int> { 4, 3, 2, 19, 14 };
            }
            else
            {
                Tiempos = new List<int>(); 
            }
        }
    }
}

/*Solo como referencia
                new Ruta("Ruta2", new List<Parada> { paradas[0], paradas[1] }, 2), // Anexo de Ingenieria a FCA (Ruta2)
                new Ruta("Ruta2", new List<Parada> { paradas[1], paradas[2] }, 3), // FCA a Trabajo Social (Ruta2)
                new Ruta("Ruta2", new List<Parada> { paradas[2], paradas[3] }, 2), // Trabajo Social a Metrobús CU (Ruta2)
                new Ruta("Ruta2", new List<Parada> { paradas[3], paradas[4] }, 10), // Metrobús CU al Metro CU (Ruta2)
                new Ruta("Ruta2", new List<Parada> { paradas[4], paradas[0] }, 10), // Metro CU al Anexo de Ingenieria (Ruta2)
           
                new Ruta("Ruta4", new List<Parada> { paradas[0], paradas[1] }, 4), // Anexo de Ingenieria a FCA (Ruta4)
                new Ruta("Ruta4", new List<Parada> { paradas[1], paradas[2] }, 3), // FCA a Trabajo Social (Ruta4)
                new Ruta("Ruta4", new List<Parada> { paradas[2], paradas[3] }, 2), // Trabajo Social a Metrobús CU (Ruta4)
                new Ruta("Ruta4", new List<Parada> { paradas[3], paradas[4] }, 19), // Metrobús CU al Metro CU (Ruta4)
                new Ruta("Ruta4", new List<Parada> { paradas[4], paradas[0] }, 14), // Metro CU al Anexo de Ingenieria (Ruta4)
*/




