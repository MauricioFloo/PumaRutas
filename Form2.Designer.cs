namespace Proyecto
{
    partial class Mapa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa));
            this.pictureBoxMapa = new System.Windows.Forms.PictureBox();
            this.pBHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMapa
            // 
            this.pictureBoxMapa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBoxMapa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMapa.Image")));
            this.pictureBoxMapa.Location = new System.Drawing.Point(-4, -22);
            this.pictureBoxMapa.Name = "pictureBoxMapa";
            this.pictureBoxMapa.Size = new System.Drawing.Size(360, 640);
            this.pictureBoxMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMapa.TabIndex = 0;
            this.pictureBoxMapa.TabStop = false;
            this.pictureBoxMapa.UseWaitCursor = true;
            this.pictureBoxMapa.WaitOnLoad = true;
            this.pictureBoxMapa.Click += new System.EventHandler(this.pictureBoxMapa_Click_1);
            this.pictureBoxMapa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMapa_MouseDown);
            this.pictureBoxMapa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMapa_MouseMove);
            this.pictureBoxMapa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMapa_MouseUp);
            // 
            // pBHome
            // 
            this.pBHome.BackColor = System.Drawing.Color.Transparent;
            this.pBHome.Image = ((System.Drawing.Image)(resources.GetObject("pBHome.Image")));
            this.pBHome.Location = new System.Drawing.Point(-4, 571);
            this.pBHome.Name = "pBHome";
            this.pBHome.Size = new System.Drawing.Size(56, 37);
            this.pBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHome.TabIndex = 1;
            this.pBHome.TabStop = false;
            this.pBHome.Click += new System.EventHandler(this.pBHome_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(354, 611);
            this.Controls.Add(this.pBHome);
            this.Controls.Add(this.pictureBoxMapa);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mapa";
            this.Text = "PUMARUTAS-MAPA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMapa;
        private System.Windows.Forms.PictureBox pBHome;
    }
}