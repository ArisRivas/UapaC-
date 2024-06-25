namespace uniuapall
{
    partial class RegistrarCarrera
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
            tbCarrera = new TextBox();
            NombreCarrera = new Label();
            CantidadTrimestres = new Label();
            tbTrimestres = new TextBox();
            Duracion = new Label();
            Escuela = new Label();
            tbDuracion = new TextBox();
            tbEscuela = new TextBox();
            Registrar = new Button();
            SuspendLayout();
            // 
            // tbCarrera
            // 
            tbCarrera.Location = new Point(160, 55);
            tbCarrera.Name = "tbCarrera";
            tbCarrera.Size = new Size(179, 23);
            tbCarrera.TabIndex = 0;
            // 
            // NombreCarrera
            // 
            NombreCarrera.AutoSize = true;
            NombreCarrera.Location = new Point(12, 58);
            NombreCarrera.Name = "NombreCarrera";
            NombreCarrera.Size = new Size(120, 15);
            NombreCarrera.TabIndex = 1;
            NombreCarrera.Text = "Nombre de la Carrera";
            // 
            // CantidadTrimestres
            // 
            CantidadTrimestres.AutoSize = true;
            CantidadTrimestres.Location = new Point(12, 101);
            CantidadTrimestres.Name = "CantidadTrimestres";
            CantidadTrimestres.Size = new Size(126, 15);
            CantidadTrimestres.TabIndex = 1;
            CantidadTrimestres.Text = "Cantidad de trimestres";
            // 
            // tbTrimestres
            // 
            tbTrimestres.Location = new Point(160, 98);
            tbTrimestres.Name = "tbTrimestres";
            tbTrimestres.Size = new Size(179, 23);
            tbTrimestres.TabIndex = 0;
            // 
            // Duracion
            // 
            Duracion.AutoSize = true;
            Duracion.Location = new Point(12, 148);
            Duracion.Name = "Duracion";
            Duracion.Size = new Size(55, 15);
            Duracion.TabIndex = 1;
            Duracion.Text = "Duración";
            // 
            // Escuela
            // 
            Escuela.AutoSize = true;
            Escuela.Location = new Point(12, 194);
            Escuela.Name = "Escuela";
            Escuela.Size = new Size(145, 15);
            Escuela.TabIndex = 1;
            Escuela.Text = "Escuela a la que pertenece";
            // 
            // tbDuracion
            // 
            tbDuracion.Location = new Point(160, 145);
            tbDuracion.Name = "tbDuracion";
            tbDuracion.Size = new Size(179, 23);
            tbDuracion.TabIndex = 0;
            // 
            // tbEscuela
            // 
            tbEscuela.Location = new Point(160, 191);
            tbEscuela.Name = "tbEscuela";
            tbEscuela.Size = new Size(179, 23);
            tbEscuela.TabIndex = 0;
            // 
            // Registrar
            // 
            Registrar.Location = new Point(139, 255);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(75, 23);
            Registrar.TabIndex = 2;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // RegistrarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 311);
            Controls.Add(Registrar);
            Controls.Add(Escuela);
            Controls.Add(Duracion);
            Controls.Add(CantidadTrimestres);
            Controls.Add(NombreCarrera);
            Controls.Add(tbEscuela);
            Controls.Add(tbDuracion);
            Controls.Add(tbTrimestres);
            Controls.Add(tbCarrera);
            Name = "RegistrarCarrera";
            Text = "Registrar Carrera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCarrera;
        private Label NombreCarrera;
        private Label CantidadTrimestres;
        private TextBox tbTrimestres;
        private Label Duracion;
        private Label Escuela;
        private TextBox tbDuracion;
        private TextBox tbEscuela;
        private Button Registrar;
    }
}