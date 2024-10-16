namespace message_system
{
    partial class Login
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
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContrasena = new TextBox();
            iniciarsesion = new Button();
            registrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 45);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(82, 63);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 114);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(85, 143);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 3;
            // 
            // iniciarsesion
            // 
            iniciarsesion.Location = new Point(85, 192);
            iniciarsesion.Name = "iniciarsesion";
            iniciarsesion.Size = new Size(100, 23);
            iniciarsesion.TabIndex = 4;
            iniciarsesion.Text = "Iniciar Sesion";
            iniciarsesion.UseVisualStyleBackColor = true;
            iniciarsesion.Click += btnIniciarSesion_Click;
            // 
            // registrar
            // 
            registrar.Location = new Point(85, 221);
            registrar.Name = "registrar";
            registrar.Size = new Size(100, 23);
            registrar.TabIndex = 5;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrar);
            Controls.Add(iniciarsesion);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContrasena;
        private Button iniciarsesion;
        private Button registrar;
    }
}