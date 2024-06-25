namespace uniuapall
{
    partial class uniuapall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registrar = new Button();
            login = new Button();
            estudiante = new Label();
            SuspendLayout();
            // 
            // registrar
            // 
            registrar.Location = new Point(123, 82);
            registrar.Name = "registrar";
            registrar.Size = new Size(107, 23);
            registrar.TabIndex = 0;
            registrar.Text = "Registrar Carrera";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += Registrar_Click;
            // 
            // login
            // 
            login.Location = new Point(139, 124);
            login.Name = "login";
            login.Size = new Size(75, 23);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += Login_Click;
            // 
            // estudiante
            // 
            estudiante.AutoSize = true;
            estudiante.Location = new Point(12, 9);
            estudiante.Name = "estudiante";
            estudiante.Size = new Size(177, 30);
            estudiante.TabIndex = 2;
            estudiante.Text = "Nombre: Arileidy Gutierrez Rivas\r\nMatrícula: 100056608";
            // 
            // uniuapall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 213);
            Controls.Add(estudiante);
            Controls.Add(login);
            Controls.Add(registrar);
            Name = "uniuapall";
            Text = "uniuapall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrar;
        private Button login;
        private Label estudiante;
    }
}
