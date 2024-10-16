namespace message_system
{
    partial class Signup
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsuario = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtTelefono = new TextBox();
            CrearUsuario = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 94);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 125);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 155);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 4;
            label5.Text = "Confirmar Contraseña";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 186);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 216);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "Teléfono";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(137, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 88);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(137, 127);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 10;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(193, 155);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(100, 23);
            txtConfirmarContrasena.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(69, 241);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 13;
            // 
            // CrearUsuario
            // 
            CrearUsuario.Location = new Point(193, 241);
            CrearUsuario.Name = "CrearUsuario";
            CrearUsuario.Size = new Size(100, 23);
            CrearUsuario.TabIndex = 14;
            CrearUsuario.Text = "Crear usuario";
            CrearUsuario.UseVisualStyleBackColor = true;
            CrearUsuario.Click += CrearUsuario_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 241);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancelar_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(CrearUsuario);
            Controls.Add(txtTelefono);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtContrasena;
        private TextBox txtConfirmarContrasena;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTelefono;
        private Button CrearUsuario;
        private Button button2;
    }
}