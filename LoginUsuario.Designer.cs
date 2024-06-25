namespace uniuapall
{
    partial class LoginUsuario
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
            Entrar = new Button();
            tbUsuario = new TextBox();
            usuario = new Label();
            clave = new Label();
            tbClave = new TextBox();
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.Location = new Point(124, 137);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 0;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(124, 52);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(156, 23);
            tbUsuario.TabIndex = 1;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Location = new Point(40, 52);
            usuario.Name = "usuario";
            usuario.Size = new Size(47, 15);
            usuario.TabIndex = 2;
            usuario.Text = "Usuario";
            // 
            // clave
            // 
            clave.AutoSize = true;
            clave.Location = new Point(40, 86);
            clave.Name = "clave";
            clave.Size = new Size(67, 15);
            clave.TabIndex = 2;
            clave.Text = "Contraseña";
            // 
            // tbClave
            // 
            tbClave.Location = new Point(124, 86);
            tbClave.Name = "tbClave";
            tbClave.Size = new Size(156, 23);
            tbClave.TabIndex = 1;
            // 
            // LoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 216);
            Controls.Add(clave);
            Controls.Add(usuario);
            Controls.Add(tbClave);
            Controls.Add(tbUsuario);
            Controls.Add(Entrar);
            Name = "LoginUsuario";
            Text = "Login Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Entrar;
        private TextBox tbUsuario;
        private Label usuario;
        private Label clave;
        private TextBox tbClave;
    }
}