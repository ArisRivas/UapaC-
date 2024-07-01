namespace uniuapall
{
    partial class HomePage
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
            Bienvenido = new Label();
            Seleccionar = new Button();
            ImprimirSelecc = new Button();
            SuspendLayout();
            // 
            // Bienvenido
            // 
            Bienvenido.AutoSize = true;
            Bienvenido.Location = new Point(174, 23);
            Bienvenido.Name = "Bienvenido";
            Bienvenido.Size = new Size(118, 15);
            Bienvenido.TabIndex = 0;
            Bienvenido.Text = "BIENVENIDO A UAPA";
            // 
            // Seleccionar
            // 
            Seleccionar.Location = new Point(77, 135);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(153, 23);
            Seleccionar.TabIndex = 1;
            Seleccionar.Text = "Seleccionar Asignaturas";
            Seleccionar.UseVisualStyleBackColor = true;
            Seleccionar.Click += Seleccionar_Click;
            // 
            // ImprimirSelecc
            // 
            ImprimirSelecc.Location = new Point(246, 135);
            ImprimirSelecc.Name = "ImprimirSelecc";
            ImprimirSelecc.Size = new Size(153, 23);
            ImprimirSelecc.TabIndex = 1;
            ImprimirSelecc.Text = "Imprimir Selección";
            ImprimirSelecc.UseVisualStyleBackColor = true;
            ImprimirSelecc.Click += ImprimirSelecc_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 281);
            Controls.Add(ImprimirSelecc);
            Controls.Add(Seleccionar);
            Controls.Add(Bienvenido);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Bienvenido;
        private Button Seleccionar;
        private Button ImprimirSelecc;
    }
}