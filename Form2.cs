using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Mapa : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        private float factorDeZoom = 1f;// Ajusta este valor para cambiar el nivel de zoom
        private Image imagenOriginal;
        private Point posicionOriginal;
        private Size tamañoOriginalVentana;

        public Mapa()
        {
            InitializeComponent();
            // Guardar la imagen, posición original y tamaño original de la ventana
            imagenOriginal = pictureBoxMapa.Image;
            posicionOriginal = new Point(pictureBoxMapa.Left, pictureBoxMapa.Top);
            tamañoOriginalVentana = new Size(this.Width, this.Height);
        }

        private void AplicarZoomIn()
        {
            int originalWidth = pictureBoxMapa.Image.Width;
            int originalHeight = pictureBoxMapa.Image.Height;

            int newWidth = (int)(originalWidth * factorDeZoom);
            int newHeight = (int)(originalHeight * factorDeZoom);

            pictureBoxMapa.Image = new Bitmap(imagenOriginal, newWidth, newHeight);

            // Ajustar la posición para centrar la imagen en el PictureBox
            AjustarPosicionDespuesDeZoom();

            pictureBoxMapa.SizeMode = PictureBoxSizeMode.AutoSize;

            // Acciones adicionales cuando se hace zoom
        }

        private void AplicarZoomOut()
        {
            pictureBoxMapa.Image = new Bitmap(imagenOriginal);

            // Ajustar la posición para centrar la imagen en el PictureBox
            AjustarPosicionDespuesDeZoom();

            pictureBoxMapa.SizeMode = PictureBoxSizeMode.Zoom;

            // Ajustar el tamaño de la ventana al tamaño original
            this.ClientSize = tamañoOriginalVentana;

            // Acciones adicionales cuando se hace zoom out
            //MessageBox.Show($"Zoom Out realizado.");
        }

        private void AjustarPosicionDespuesDeZoom()
        {
            int nuevaX = posicionOriginal.X;
            int nuevaY = posicionOriginal.Y;

            if (pictureBoxMapa.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                // Calcular nuevas coordenadas para centrar la imagen
                nuevaX -= (pictureBoxMapa.Width - pictureBoxMapa.Image.Width) / 2;
                nuevaY -= (pictureBoxMapa.Height - pictureBoxMapa.Image.Height) / 2;
            }

            // Asignar nuevas coordenadas
            pictureBoxMapa.Left = nuevaX;
            pictureBoxMapa.Top = nuevaY;
        }

        private void pictureBoxMapa_Click_1(object sender, EventArgs e)
        {
            // Si no se está arrastrando, realizar zoom in o zoom out al hacer clic
            if (!isDragging)
            {
                if (pictureBoxMapa.SizeMode == PictureBoxSizeMode.AutoSize)
                {
                    // Zoom in
                    AplicarZoomIn();
                }
                else
                {
                    // Zoom out
                    AplicarZoomOut();
                }
            }
            


        }

        private void pictureBoxMapa_MouseDown(object sender, MouseEventArgs e)
        {
            // Desactivar AutoSizeMode para evitar la minimización al arrastrar
            pictureBoxMapa.SizeMode = PictureBoxSizeMode.Normal;

            // Iniciar el arrastre al mantener presionado el botón del mouse
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
            }
        }

        private void pictureBoxMapa_MouseMove(object sender, MouseEventArgs e)
        {
            // Arrastrar la imagen si se está arrastrando actualmente
            if (isDragging)
            {
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;

                // Mover la imagen en consecuencia
                pictureBoxMapa.Left += deltaX;
                pictureBoxMapa.Top += deltaY;
            }
        }

        private void pictureBoxMapa_MouseUp(object sender, MouseEventArgs e)
        {
            // Detener el arrastre al soltar el botón del mouse
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;

                // Volver a activar AutoSizeMode después de soltar el mouse
                pictureBoxMapa.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
