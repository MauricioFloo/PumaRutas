using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Pumarutas : Form
    {

        public Pumarutas()
        {
            InitializeComponent();
        }
        private void comboBoxInicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxDestino.Text = ""; // Limpia el texto del comboBox de destino, si se vuelve a seleccionar una parada nueva.

            string selectedItem = comboBoxInicio.SelectedItem.ToString(); // Obtiene el ítem seleccionado en el comboBox

            switch (selectedItem)//De acuerdo a la parada que se seleccione va ahacer las paradas de destino que se muestren.
            {
                case "Anexo de Ingeniería":
                    comboBoxDestino.Items.Clear();
                    comboBoxDestino.Items.Add("FCA");
                    comboBoxDestino.Items.Add("Trabajo Social");
                    comboBoxDestino.Items.Add("Metrobús CU");
                    comboBoxDestino.Items.Add("Metro CU");
                    break;
                case "FCA":
                    comboBoxDestino.Items.Clear();
                    comboBoxDestino.Items.Add("Trabajo Social");
                    comboBoxDestino.Items.Add("Metrobús CU");
                    comboBoxDestino.Items.Add("Metro CU");
                    break;
                case "Trabajo Social":
                    comboBoxDestino.Items.Add("Metrobús CU");
                    comboBoxDestino.Items.Add("Metro CU");
                    break;
                case "Metrobús CU":
                    comboBoxDestino.Items.Clear();
                    comboBoxDestino.Items.Add("Metro CU");
                    break;
                case "Metro CU":
                    comboBoxDestino.Items.Clear();
                    comboBoxDestino.Items.Add("Anexo de Ingeniería");
                    comboBoxDestino.Items.Add("FCA");
                    comboBoxDestino.Items.Add("Metrobús CU");
                    comboBoxDestino.Items.Add("Trabajo social");
                    break;

                default:
                    comboBoxDestino.Items.Clear();
                    
                    break;

            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e) //Configuración del boton confirmar
        {
            //Se les asigana a los selectedItem la opci{on elegida por el usuario en los comboBox
            string selectedItem = comboBoxDestino.SelectedItem?.ToString(); 
            string selectedItem1 = comboBoxInicio.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedItem1)) //Se crea una excepción por si el usuario no ha incresado una parada de inicio y le da al boton de confirmar
            {
                MessageBox.Show("Por favor, selecciona donde te encuentras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(selectedItem)) //Se crea una excepción por si el usuario no ha incresado una parada de destino y le da al boton de confirmar
            {
                MessageBox.Show("Selecciona un destino antes de confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Ambos campos están seleccionados, por lo que se procede a abrir el formulario Pumarutas1
                Pumarutas1 miform3 = new Pumarutas1(this, selectedItem1, selectedItem);
                miform3.ShowDialog();

            }

        }
        

        private void btnMapa_Click(object sender, EventArgs e)// Se crea una instancia del formulario Mapa y se muestra como diálogo
        {
            Mapa miform2 = new Mapa();
            miform2.ShowDialog();
        }

        private void pBAtención_Click(object sender, EventArgs e) //Para que el usuario si requiere de aopoyo o sugerencias pueda comunicarse con el equipo
        {
            MessageBox.Show("pumarutas@ingenieria.unam.edu");
        }

    }
}
