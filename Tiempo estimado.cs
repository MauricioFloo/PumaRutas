
namespace Proyecto
{
    public class TiempoEsperado
    {
        private Ruta ruta2;
        private Ruta ruta4;

        public TiempoEsperado()
        {
            // Inicializar las rutas 2 y 4 usando sus respectivos constructores
            ruta2 = new Ruta();
            ruta4 = new Ruta("Ruta4");
        }

        // Método para calcular el tiempo entre dos paradas en la ruta 2
        public int CalcularTiempoRuta2(string inicio, string destino)
        {
            
            int indiceInicio = ruta2.Paradas.FindIndex(p => p.Nombre == inicio);// Encuentra el índice de la parada de inicio en la lista de paradas de la ruta
            int indiceDestino = ruta2.Paradas.FindIndex(p => p.Nombre == destino);// Encuentra el índice de la parada de destino en la lista de paradas de la ruta

            int tiempoTotal = 0; // Variable para almacenar el tiempo total

            
            if (indiceInicio < indiceDestino) // Comprueba si el índice de inicio es menor que el índice de destino
            {
                for (int i = indiceInicio; i < indiceDestino; i++) // Recorre las paradas desde el inicio hasta el destino sumando los tiempos entre cada parada
                {
                    tiempoTotal += ruta2.Tiempos[i]; // Agrega el tiempo del tramo actual al tiempo total
                }
            }
            else if (indiceInicio > indiceDestino) // Si el índice de inicio es mayor que el índice de destino
            { 
                for (int i = indiceInicio; i < ruta2.Tiempos.Count; i++)  // Recorre desde el índice de inicio hasta el final de la lista de tiempos sumando los tiempos
                {
                    tiempoTotal += ruta2.Tiempos[i]; // Agrega el tiempo del tramo actual al tiempo total
                }
                for (int i = 0; i < indiceDestino; i++) // Recorre desde el principio hasta el índice de destino sumando los tiempos
                {
                    tiempoTotal += ruta2.Tiempos[i]; // Agrega el tiempo del tramo actual al tiempo total
                }
            }
            return tiempoTotal; // Devuelve el tiempo total calculado entre las dos paradas
        }


        //Se hace lo mismo pero para la ruta 4
        public int CalcularTiempoRuta4(string inicio, string destino)
        {
            int indiceInicio = ruta4.Paradas.FindIndex(p => p.Nombre == inicio);
            int indiceDestino = ruta4.Paradas.FindIndex(p => p.Nombre == destino);

            int tiempoTotal = 0;

            if (indiceInicio < indiceDestino)
            {
                for (int i = indiceInicio; i < indiceDestino; i++)
                {
                    tiempoTotal += ruta4.Tiempos[i];
                }
            }
            else if (indiceInicio > indiceDestino)
            {
                for (int i = indiceInicio; i < ruta4.Tiempos.Count; i++)
                {
                    tiempoTotal += ruta4.Tiempos[i];
                }

                for (int i = 0; i < indiceDestino; i++)
                {
                    tiempoTotal += ruta4.Tiempos[i];
                }
            }

            return tiempoTotal;
        }
    }
}
