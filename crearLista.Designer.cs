namespace message_system
{
    partial class crearLista
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
            btnCrear = new Button();
            btnCancelar = new Button();
            txtDescripcion = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 31);
            label1.Name = "label1";
            label1.Size = new Size(255, 15);
            label1.TabIndex = 0;
            label1.Text = "Rellene los siguientes campos para crear la lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 68);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la lista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 103);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion de la lista ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 139);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(92, 172);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(173, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(186, 100);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(235, 60);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.Text = "";
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // crearLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "crearLista";
            Text = "crearLista";
            Load += crearLista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private Button btnCrear;
        private Button btnCancelar;
        private RichTextBox txtDescripcion;
    }
}