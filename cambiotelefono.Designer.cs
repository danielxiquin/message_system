namespace message_system
{
    partial class cambiotelefono
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
            Modificar = new Button();
            label1 = new Label();
            textTelefono = new TextBox();
            SuspendLayout();
            // 
            // Modificar
            // 
            Modificar.Location = new Point(100, 146);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(75, 23);
            Modificar.TabIndex = 0;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 70);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el nuevo numero de telefono";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(100, 102);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(199, 23);
            textTelefono.TabIndex = 2;
            textTelefono.TextChanged += textTelefono_TextChanged;
            // 
            // cambiotelefono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textTelefono);
            Controls.Add(label1);
            Controls.Add(Modificar);
            Name = "cambiotelefono";
            Text = "cambiotelefono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Modificar;
        private Label label1;
        private TextBox textTelefono;
    }
}