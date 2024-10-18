namespace message_system
{
    partial class Usermanager
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
            dgvUsuarios = new DataGridView();
            btnModificar = new Button();
            btnDarDeBaja = new Button();
            btnAgregarNuevo = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar usuario";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(22, 47);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(100, 23);
            txtBuscarUsuario.TabIndex = 1;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(22, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(22, 122);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(516, 150);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(577, 122);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnDarDeBaja
            // 
            btnDarDeBaja.Location = new Point(577, 151);
            btnDarDeBaja.Name = "btnDarDeBaja";
            btnDarDeBaja.Size = new Size(132, 23);
            btnDarDeBaja.TabIndex = 5;
            btnDarDeBaja.Text = "Dar de baja";
            btnDarDeBaja.UseVisualStyleBackColor = true;
            btnDarDeBaja.Click += btnDarDeBaja_Click;
            // 
            // btnAgregarNuevo
            // 
            btnAgregarNuevo.Location = new Point(577, 180);
            btnAgregarNuevo.Name = "btnAgregarNuevo";
            btnAgregarNuevo.Size = new Size(132, 23);
            btnAgregarNuevo.TabIndex = 6;
            btnAgregarNuevo.Text = "Agregar nuevo user";
            btnAgregarNuevo.UseVisualStyleBackColor = true;
            btnAgregarNuevo.Click += btnAgregarNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(577, 209);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(132, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Usermanager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregarNuevo);
            Controls.Add(btnDarDeBaja);
            Controls.Add(btnModificar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Name = "Usermanager";
            Text = "Usermanager";
            Load += Usermanager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarUsuario;
        private Button btnBuscar;
        private DataGridView dgvUsuarios;
        private Button btnModificar;
        private Button btnDarDeBaja;
        private Button btnAgregarNuevo;
        private Button btnCerrar;
    }
}