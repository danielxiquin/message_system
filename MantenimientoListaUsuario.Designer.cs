namespace message_system
{
    partial class MantenimientoListaUsuario
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
            btnIngresar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(65, 90);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(237, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar a una lista de difusión";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(65, 133);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(229, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir de mantenimiento";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccion una opcion del mantenimineto ";
            // 
            // MantenimientoListaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Name = "MantenimientoListaUsuario";
            Text = "Ingresar a lista de difución";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private Label label1;
    }
}