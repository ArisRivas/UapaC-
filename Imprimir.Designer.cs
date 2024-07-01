namespace uniuapall
{
    partial class Imprimir
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
            Creador = new Label();
            Estudiante = new Label();
            DataGridSeleccion = new DataGridView();
            Titulo = new Label();
            Matricula = new Label();
            Materia = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridSeleccion).BeginInit();
            SuspendLayout();
            // 
            // Creador
            // 
            Creador.AutoSize = true;
            Creador.Location = new Point(21, 394);
            Creador.Name = "Creador";
            Creador.Size = new Size(292, 15);
            Creador.TabIndex = 0;
            Creador.Text = "Informe creado por: Arileidy Gutierrez Rivas 100056608";
            // 
            // Estudiante
            // 
            Estudiante.AutoSize = true;
            Estudiante.Location = new Point(12, 40);
            Estudiante.Name = "Estudiante";
            Estudiante.Size = new Size(68, 15);
            Estudiante.TabIndex = 1;
            Estudiante.Text = "Estudiante: ";
            // 
            // DataGridSeleccion
            // 
            DataGridSeleccion.AllowUserToAddRows = false;
            DataGridSeleccion.AllowUserToDeleteRows = false;
            DataGridSeleccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridSeleccion.Columns.AddRange(new DataGridViewColumn[] { Materia, Estado });
            DataGridSeleccion.Location = new Point(12, 91);
            DataGridSeleccion.Name = "DataGridSeleccion";
            DataGridSeleccion.ReadOnly = true;
            DataGridSeleccion.Size = new Size(344, 289);
            DataGridSeleccion.TabIndex = 2;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(92, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(134, 15);
            Titulo.TabIndex = 1;
            Titulo.Text = "Selección del estudiante";
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Location = new Point(12, 64);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(63, 15);
            Matricula.TabIndex = 1;
            Matricula.Text = "Matrícula: ";
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 180;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 120;
            // 
            // Imprimir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 418);
            Controls.Add(DataGridSeleccion);
            Controls.Add(Titulo);
            Controls.Add(Matricula);
            Controls.Add(Estudiante);
            Controls.Add(Creador);
            Name = "Imprimir";
            Text = "Imprimir";
            ((System.ComponentModel.ISupportInitialize)DataGridSeleccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Creador;
        private Label Titulo;
        public DataGridView DataGridSeleccion;
        public Label Estudiante;
        public Label Matricula;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Estado;
    }
}