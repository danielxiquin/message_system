namespace message_system
{
    partial class modificarContacto
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
            btnRehabilitar = new Button();
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            txtContacto = new TextBox();
            txtTransacción = new TextBox();
            fechaT = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 63);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Contacto ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 145);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de transacción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 185);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 3;
            label4.Text = "Usuario de transacción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 224);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Rehabilitar";
            // 
            // btnRehabilitar
            // 
            btnRehabilitar.Location = new Point(181, 224);
            btnRehabilitar.Name = "btnRehabilitar";
            btnRehabilitar.Size = new Size(75, 23);
            btnRehabilitar.TabIndex = 5;
            btnRehabilitar.Text = "Rehabilitar";
            btnRehabilitar.UseVisualStyleBackColor = true;
            btnRehabilitar.Click += btnRehabilitar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(93, 267);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar cambios";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(181, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(181, 101);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 8;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // txtTransacción
            // 
            txtTransacción.Location = new Point(181, 182);
            txtTransacción.Name = "txtTransacción";
            txtTransacción.Size = new Size(100, 23);
            txtTransacción.TabIndex = 10;
            txtTransacción.TextChanged += txtTransacción_TextChanged;
            // 
            // fechaT
            // 
            fechaT.Location = new Point(181, 145);
            fechaT.Name = "fechaT";
            fechaT.Size = new Size(200, 23);
            fechaT.TabIndex = 11;
            fechaT.ValueChanged += fechaT_ValueChanged;
            // 
            // modificarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaT);
            Controls.Add(txtTransacción);
            Controls.Add(txtContacto);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnRehabilitar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "modificarContacto";
            Text = "modificarContacto";
            Load += modificarContacto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRehabilitar;
        private Button btnAceptar;
        private TextBox txtUsuario;
        private TextBox txtContacto;
        private TextBox txtTransacción;
        private DateTimePicker fechaT;
    }
}