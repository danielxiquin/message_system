namespace message_system
{
    partial class Form1
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
            lblBienvenida = new Label();
            Mantenimiento = new Button();
            cambiarContraseña = new Button();
            DarsedeBaja = new Button();
            Respaldar = new Button();
            CerrarSesion = new Button();
            lblRol = new Label();
            lblTelefono = new Label();
            lblEstatus = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(123, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(38, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label3";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // Mantenimiento
            // 
            Mantenimiento.Location = new Point(123, 113);
            Mantenimiento.Name = "Mantenimiento";
            Mantenimiento.Size = new Size(160, 27);
            Mantenimiento.TabIndex = 1;
            Mantenimiento.Text = "Mantenimiento de usuarios";
            Mantenimiento.UseVisualStyleBackColor = true;
            Mantenimiento.Click += Mantenimiento_Click;
            // 
            // cambiarContraseña
            // 
            cambiarContraseña.Location = new Point(123, 146);
            cambiarContraseña.Name = "cambiarContraseña";
            cambiarContraseña.Size = new Size(160, 23);
            cambiarContraseña.TabIndex = 2;
            cambiarContraseña.Text = "Cambiar contraseña";
            cambiarContraseña.UseVisualStyleBackColor = true;
            cambiarContraseña.Click += cambiarContraseña_Click;
            // 
            // DarsedeBaja
            // 
            DarsedeBaja.Location = new Point(123, 233);
            DarsedeBaja.Name = "DarsedeBaja";
            DarsedeBaja.Size = new Size(160, 23);
            DarsedeBaja.TabIndex = 3;
            DarsedeBaja.Text = "Darse de baja";
            DarsedeBaja.UseVisualStyleBackColor = true;
            DarsedeBaja.Click += DarsedeBaja_Click;
            // 
            // Respaldar
            // 
            Respaldar.Location = new Point(123, 262);
            Respaldar.Name = "Respaldar";
            Respaldar.Size = new Size(160, 23);
            Respaldar.TabIndex = 4;
            Respaldar.Text = "Respaladar información";
            Respaldar.UseVisualStyleBackColor = true;
            Respaldar.Click += Respaldar_Click;
            // 
            // CerrarSesion
            // 
            CerrarSesion.Location = new Point(123, 291);
            CerrarSesion.Name = "CerrarSesion";
            CerrarSesion.Size = new Size(160, 23);
            CerrarSesion.TabIndex = 5;
            CerrarSesion.Text = "Cerrar Sesión";
            CerrarSesion.UseVisualStyleBackColor = true;
            CerrarSesion.Click += CerrarSesion_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(123, 33);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 15);
            lblRol.TabIndex = 6;
            lblRol.Text = "label1";
            lblRol.Click += lblRol_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(123, 57);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(38, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "label2";
            lblTelefono.Click += lblTelefono_Click;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(123, 82);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(38, 15);
            lblEstatus.TabIndex = 8;
            lblEstatus.Text = "label1";
            lblEstatus.Click += lblEstatus_Click;
            // 
            // button1
            // 
            button1.Location = new Point(123, 175);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 9;
            button1.Text = "Cambiar telefono";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(123, 204);
            button2.Name = "button2";
            button2.Size = new Size(191, 23);
            button2.TabIndex = 10;
            button2.Text = "Cambiar fecha de nacimiento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblEstatus);
            Controls.Add(lblTelefono);
            Controls.Add(lblRol);
            Controls.Add(CerrarSesion);
            Controls.Add(Respaldar);
            Controls.Add(DarsedeBaja);
            Controls.Add(cambiarContraseña);
            Controls.Add(Mantenimiento);
            Controls.Add(lblBienvenida);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button Mantenimiento;
        private Button cambiarContraseña;
        private Button DarsedeBaja;
        private Button Respaldar;
        private Button CerrarSesion;
        private Label lblRol;
        private Label lblTelefono;
        private Label lblEstatus;
        private Button button1;
        private Button button2;
    }
}