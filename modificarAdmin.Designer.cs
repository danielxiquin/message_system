namespace message_system
{
    partial class modificarAdmin
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            fechaNueva = new DateTimePicker();
            button1 = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 175);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Modificar telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 133);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 1;
            label2.Text = "Modificar fecha de nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 61);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Modificar Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 99);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Modificar apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(203, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(203, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // fechaNueva
            // 
            fechaNueva.Location = new Point(269, 133);
            fechaNueva.Name = "fechaNueva";
            fechaNueva.Size = new Size(200, 23);
            fechaNueva.TabIndex = 8;
            fechaNueva.ValueChanged += fechaNueva_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(173, 227);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(130, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar cambios";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(325, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // modificarAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(button1);
            Controls.Add(fechaNueva);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "modificarAdmin";
            Text = "modificarAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private DateTimePicker fechaNueva;
        private Button button1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}