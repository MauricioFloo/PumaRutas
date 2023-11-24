using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Pumarutas1 : Form
    {
        //Se mandan a traer las paradas elegidas por el usuario desde el forms 1 y se declaran 
        private string inicio;
        private string destino;
        private Pumarutas pumarutasForm;

        public Pumarutas1(Pumarutas pumarutasForm, string inicio, string destino)
        {
            InitializeComponent();
            this.pumarutasForm = pumarutasForm;
            this.inicio = inicio;
            this.destino = destino;

            // Llama a ImprimirResultados al cargar el formulario
            ImprimirResultados();
        }

        private void ImprimirResultados()
        {
            //Se manda allamar los constructores creados para realizar los cálculos de los tiempo para cada ruta
            TiempoEsperado tiempoEsperado = new TiempoEsperado();
            int tiempoRuta2 = tiempoEsperado.CalcularTiempoRuta2(inicio, destino);
            int tiempoRuta4 = tiempoEsperado.CalcularTiempoRuta4(inicio, destino);

            if (tiempoRuta2 != -1)
            {
                lbRuta1.Text = "2"; //Para la ruta 2
                lbEspera1.Text = tiempoRuta2.ToString()+ " [min]";
                lbLlegada1.Text = "2 [min]"; //Tiempo promedio de llegada del pumabus con el uso de google maps
                lbPumabus1.Text = Pumabus.Nopumabus1.ToString(); //Se manda a llamar a la clase Pumabus y el número de pumabus para la ruta 2
            }
            else
            {
                // Manejar caso donde la parada de inicio o destino no se encuentran en la lista
                lbRuta1.Text = "Ruta no disponible";
                lbEspera1.Text = "...";
                lbLlegada1.Text = "...";
                lbPumabus1.Text = "...";
            }

            if (tiempoRuta4 != -1)
            {
                lbRuta2.Text = "4"; //Para la ruta 4
                lbEspera2.Text = tiempoRuta4.ToString() + " [min]";
                lbLlegada2.Text = "5 [min]"; //Tiempo promedio de llegada del pumabus
                lbPumabus2.Text = Pumabus.Nopumabus2.ToString(); //Se manda a llamar a la clase Pumabus y el número de pumabus para la ruta 4
            }
            else
            {
                // Manejar caso donde la parada de inicio o destino no se encuentran en la lista
                lbRuta2.Text = "Ruta no disponible";
                lbEspera2.Text = "...";
                lbLlegada2.Text = "...";
                lbPumabus2.Text = "...";
            }
        }

        private void pBAtencion_Click(object sender, EventArgs e) //Para que el usuario si requiere de aopoyo o sugerencias pueda comunicarse con el equipo
        {
            MessageBox.Show("pumarutas@ingenieria.unam.edu");
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
