﻿namespace message_system
{
    partial class AccionListas
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
            btnCerrar = new Button();
            btnIngresarLista = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            dgvLista = new DataGridView();
            btnBuscar = new Button();
            txtBuscarUsuario = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(593, 239);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(132, 23);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnIngresarLista
            // 
            btnIngresarLista.Location = new Point(593, 152);
            btnIngresarLista.Name = "btnIngresarLista";
            btnIngresarLista.Size = new Size(132, 23);
            btnIngresarLista.TabIndex = 14;
            btnIngresarLista.Text = "Ingresar a lista";
            btnIngresarLista.UseVisualStyleBackColor = true;
            btnIngresarLista.Click += btnIngresarLista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(593, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(593, 181);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(38, 152);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(516, 150);
            dgvLista.TabIndex = 11;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(38, 106);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(38, 77);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(100, 23);
            txtBuscarUsuario.TabIndex = 9;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "Buscar usuario";
            // 
            // AccionListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnIngresarLista);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvLista);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(label1);
            Name = "AccionListas";
            Text = "AccionListas";
            Load += AccionListas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnIngresarLista;
        private Button btnEliminar;
        private Button btnModificar;
        private DataGridView dgvLista;
        private Button btnBuscar;
        private TextBox txtBuscarUsuario;
        private Label label1;
    }
}