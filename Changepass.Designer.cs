namespace message_system
{
    partial class Changepass
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
            contraseñaActual = new TextBox();
            label2 = new Label();
            contraseñaNueva = new TextBox();
            label3 = new Label();
            confirmarContraseña = new TextBox();
            Guardar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña actual";
            label1.Click += label1_Click;
            // 
            // contraseñaActual
            // 
            contraseñaActual.Location = new Point(27, 71);
            contraseñaActual.Name = "contraseñaActual";
            contraseñaActual.Size = new Size(100, 23);
            contraseñaActual.TabIndex = 1;
            contraseñaActual.TextChanged += contraseñaActual_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 114);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Nueva contraseña";
            label2.Click += label2_Click;
            // 
            // contraseñaNueva
            // 
            contraseñaNueva.Location = new Point(29, 149);
            contraseñaNueva.Name = "contraseñaNueva";
            contraseñaNueva.Size = new Size(100, 23);
            contraseñaNueva.TabIndex = 3;
            contraseñaNueva.TextChanged += contraseñaNueva_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 186);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 4;
            label3.Text = "Confirmar nueva contraseña";
            label3.Click += label3_Click;
            // 
            // confirmarContraseña
            // 
            confirmarContraseña.Location = new Point(29, 217);
            confirmarContraseña.Name = "confirmarContraseña";
            confirmarContraseña.Size = new Size(100, 23);
            confirmarContraseña.TabIndex = 5;
            confirmarContraseña.TextChanged += confirmarContraseña_TextChanged;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(29, 268);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 23);
            Guardar.TabIndex = 6;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(124, 268);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Changepass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelar);
            Controls.Add(Guardar);
            Controls.Add(confirmarContraseña);
            Controls.Add(label3);
            Controls.Add(contraseñaNueva);
            Controls.Add(label2);
            Controls.Add(contraseñaActual);
            Controls.Add(label1);
            Name = "Changepass";
            Text = "Changepass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox contraseñaActual;
        private Label label2;
        private TextBox contraseñaNueva;
        private Label label3;
        private TextBox confirmarContraseña;
        private Button Guardar;
        private Button Cancelar;
    }
}