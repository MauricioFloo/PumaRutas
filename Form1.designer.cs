namespace Proyecto
{
    partial class Pumarutas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pumarutas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInicio = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.btnMapa = new System.Windows.Forms.Button();
            this.pBAtención = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBAtención)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stylus BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿En qué parada estas?";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Stylus BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(114, 505);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 41);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿A dónde quieres llegar?";
            // 
            // comboBoxInicio
            // 
            this.comboBoxInicio.Font = new System.Drawing.Font("Stylus BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInicio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxInicio.FormattingEnabled = true;
            this.comboBoxInicio.Items.AddRange(new object[] {
            "Anexo de Ingeniería",
            "FCA",
            "Trabajo Social",
            "Metrobús CU",
            "Metro CU"});
            this.comboBoxInicio.Location = new System.Drawing.Point(67, 233);
            this.comboBoxInicio.Name = "comboBoxInicio";
            this.comboBoxInicio.Size = new System.Drawing.Size(228, 34);
            this.comboBoxInicio.TabIndex = 7;
            this.comboBoxInicio.SelectedIndexChanged += new System.EventHandler(this.comboBoxInicio_SelectedIndexChanged_1);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.Font = new System.Drawing.Font("Stylus BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(67, 384);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(228, 34);
            this.comboBoxDestino.TabIndex = 7;
            // 
            // btnMapa
            // 
            this.btnMapa.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapa.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapa.ForeColor = System.Drawing.Color.Navy;
            this.btnMapa.Location = new System.Drawing.Point(118, 104);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(109, 31);
            this.btnMapa.TabIndex = 4;
            this.btnMapa.Text = "Mapa";
            this.btnMapa.UseVisualStyleBackColor = false;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // pBAtención
            // 
            this.pBAtención.BackColor = System.Drawing.Color.Transparent;
            this.pBAtención.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBAtención.BackgroundImage")));
            this.pBAtención.Image = ((System.Drawing.Image)(resources.GetObject("pBAtención.Image")));
            this.pBAtención.Location = new System.Drawing.Point(315, 575);
            this.pBAtención.Name = "pBAtención";
            this.pBAtención.Size = new System.Drawing.Size(33, 33);
            this.pBAtención.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAtención.TabIndex = 8;
            this.pBAtención.TabStop = false;
            this.pBAtención.Click += new System.EventHandler(this.pBAtención_Click);
            // 
            // Pumarutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(354, 611);
            this.Controls.Add(this.pBAtención);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Stylus BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pumarutas";
            this.Text = "PUMARUTAS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ((System.ComponentModel.ISupportInitialize)(this.pBAtención)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInicio;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.PictureBox pBAtención;
    }
}

