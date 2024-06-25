namespace uniuapall
{
    partial class SeleccionarCarreras
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
            DataGridCarreras = new DataGridView();
            nombre = new Label();
            matricula = new Label();
            Agregar = new Button();
            DataGridCarrerasAgregadas = new DataGridView();
            clCarrera = new DataGridViewTextBoxColumn();
            clTrimestre = new DataGridViewTextBoxColumn();
            clDuracion = new DataGridViewTextBoxColumn();
            clEscuela = new DataGridViewTextBoxColumn();
            Borrar = new Button();
            Guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridCarrerasAgregadas).BeginInit();
            SuspendLayout();
            // 
            // DataGridCarreras
            // 
            DataGridCarreras.AllowUserToAddRows = false;
            DataGridCarreras.AllowUserToDeleteRows = false;
            DataGridCarreras.AllowUserToResizeColumns = false;
            DataGridCarreras.AllowUserToResizeRows = false;
            DataGridCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCarreras.Location = new Point(12, 106);
            DataGridCarreras.MultiSelect = false;
            DataGridCarreras.Name = "DataGridCarreras";
            DataGridCarreras.Size = new Size(443, 332);
            DataGridCarreras.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(12, 18);
            nombre.Name = "nombre";
            nombre.Size = new Size(49, 15);
            nombre.TabIndex = 1;
            nombre.Text = "nombre";
            // 
            // matricula
            // 
            matricula.AutoSize = true;
            matricula.Location = new Point(12, 44);
            matricula.Name = "matricula";
            matricula.Size = new Size(57, 15);
            matricula.TabIndex = 1;
            matricula.Text = "matricula";
            // 
            // Agregar
            // 
            Agregar.Location = new Point(380, 77);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(75, 23);
            Agregar.TabIndex = 2;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // DataGridCarrerasAgregadas
            // 
            DataGridCarrerasAgregadas.AllowUserToAddRows = false;
            DataGridCarrerasAgregadas.AllowUserToOrderColumns = true;
            DataGridCarrerasAgregadas.AllowUserToResizeColumns = false;
            DataGridCarrerasAgregadas.AllowUserToResizeRows = false;
            DataGridCarrerasAgregadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCarrerasAgregadas.Columns.AddRange(new DataGridViewColumn[] { clCarrera, clTrimestre, clDuracion, clEscuela });
            DataGridCarrerasAgregadas.Location = new Point(498, 106);
            DataGridCarrerasAgregadas.MultiSelect = false;
            DataGridCarrerasAgregadas.Name = "DataGridCarrerasAgregadas";
            DataGridCarrerasAgregadas.Size = new Size(443, 332);
            DataGridCarrerasAgregadas.TabIndex = 0;
            // 
            // clCarrera
            // 
            clCarrera.HeaderText = "Carrera";
            clCarrera.Name = "clCarrera";
            // 
            // clTrimestre
            // 
            clTrimestre.HeaderText = "Cantidad de trimestre";
            clTrimestre.Name = "clTrimestre";
            // 
            // clDuracion
            // 
            clDuracion.HeaderText = "Duracion";
            clDuracion.Name = "clDuracion";
            // 
            // clEscuela
            // 
            clEscuela.HeaderText = "Escuela";
            clEscuela.Name = "clEscuela";
            // 
            // Borrar
            // 
            Borrar.Location = new Point(498, 77);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 23);
            Borrar.TabIndex = 2;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(596, 77);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 23);
            Guardar.TabIndex = 2;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // SeleccionarCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(Guardar);
            Controls.Add(Borrar);
            Controls.Add(Agregar);
            Controls.Add(matricula);
            Controls.Add(nombre);
            Controls.Add(DataGridCarrerasAgregadas);
            Controls.Add(DataGridCarreras);
            Name = "SeleccionarCarreras";
            Text = "Seleccionar Carreras";
            ((System.ComponentModel.ISupportInitialize)DataGridCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridCarrerasAgregadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView DataGridCarreras;
        private Button Agregar;
        public DataGridView DataGridCarrerasAgregadas;
        private Button Borrar;
        public Label nombre;
        public Label matricula;
        private DataGridViewTextBoxColumn clCarrera;
        private DataGridViewTextBoxColumn clTrimestre;
        private DataGridViewTextBoxColumn clDuracion;
        private DataGridViewTextBoxColumn clEscuela;
        private Button Guardar;
    }
}