namespace message_system
{
    partial class ListaDifusion
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
            btnCrearLista = new Button();
            btnMantenimiento = new Button();
            btnUsuarioLista = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "MENU LISTA DE DIFUSIÓN";
            // 
            // btnCrearLista
            // 
            btnCrearLista.Location = new Point(51, 73);
            btnCrearLista.Name = "btnCrearLista";
            btnCrearLista.Size = new Size(172, 23);
            btnCrearLista.TabIndex = 1;
            btnCrearLista.Text = "Crear Lista de difusión";
            btnCrearLista.UseVisualStyleBackColor = true;
            btnCrearLista.Click += btnCrearLista_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.Location = new Point(51, 113);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(172, 23);
            btnMantenimiento.TabIndex = 0;
            btnMantenimiento.Text = "Mantenimiento de lista";
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // btnUsuarioLista
            // 
            btnUsuarioLista.Location = new Point(51, 154);
            btnUsuarioLista.Name = "btnUsuarioLista";
            btnUsuarioLista.Size = new Size(172, 23);
            btnUsuarioLista.TabIndex = 2;
            btnUsuarioLista.Text = "Mantenimiento lista-usuario";
            btnUsuarioLista.UseVisualStyleBackColor = true;
            btnUsuarioLista.Click += btnUsuarioLista_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(98, 194);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // ListaDifusion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnUsuarioLista);
            Controls.Add(btnMantenimiento);
            Controls.Add(btnCrearLista);
            Controls.Add(label1);
            Name = "ListaDifusion";
            Text = "ListaDifusion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearLista;
        private Button btnMantenimiento;
        private Button btnUsuarioLista;
        private Button btnCerrar;
    }
}