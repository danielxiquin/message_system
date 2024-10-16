namespace message_system
{
    partial class cambiarFecha
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
            cambios = new Button();
            label1 = new Label();
            fecha = new DateTimePicker();
            SuspendLayout();
            // 
            // cambios
            // 
            cambios.Location = new Point(88, 178);
            cambios.Name = "cambios";
            cambios.Size = new Size(75, 23);
            cambios.TabIndex = 0;
            cambios.Text = "Modificar";
            cambios.UseVisualStyleBackColor = true;
            cambios.Click += cambios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 97);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "Cambiar fecha de nacimiento";
            // 
            // fecha
            // 
            fecha.Location = new Point(88, 135);
            fecha.Name = "fecha";
            fecha.Size = new Size(200, 23);
            fecha.TabIndex = 3;
            fecha.ValueChanged += fecha_ValueChanged;
            // 
            // cambiarFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fecha);
            Controls.Add(label1);
            Controls.Add(cambios);
            Name = "cambiarFecha";
            Text = "cambiarFecha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cambios;
        private Label label1;
        private DateTimePicker fecha;
    }
}