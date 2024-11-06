namespace message_system
{
    partial class agregarContacto
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
            txtBuscarUsuario = new TextBox();
            btnBuscar = new Button();
            dgvUsuario = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminacion = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar usuario";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(48, 78);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(100, 23);
            txtBuscarUsuario.TabIndex = 1;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(48, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.Location = new Point(48, 136);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(423, 150);
            dgvUsuario.TabIndex = 0;
            dgvUsuario.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(525, 136);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(525, 177);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificación";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminacion
            // 
            btnEliminacion.Location = new Point(525, 222);
            btnEliminacion.Name = "btnEliminacion";
            btnEliminacion.Size = new Size(89, 23);
            btnEliminacion.TabIndex = 5;
            btnEliminacion.Text = "Eliminar";
            btnEliminacion.UseVisualStyleBackColor = true;
            btnEliminacion.Click += btnEliminacion_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(525, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // agregarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminacion);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvUsuario);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Name = "agregarContacto";
            Text = " ";
            Load += agregarContacto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarUsuario;
        private Button btnBuscar;
        private DataGridView dgvUsuario;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminacion;
        private Button btnSalir;
    }
}