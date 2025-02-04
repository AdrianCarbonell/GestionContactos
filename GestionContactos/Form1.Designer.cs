namespace GestionContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAñadirContacto = new Button();
            btnEliminarContacto = new Button();
            btnModificarTelefono = new Button();
            btnMostrarContactos = new Button();
            SuspendLayout();
            // 
            // btnAñadirContacto
            // 
            btnAñadirContacto.Location = new Point(241, 145);
            btnAñadirContacto.Name = "btnAñadirContacto";
            btnAñadirContacto.Size = new Size(75, 23);
            btnAñadirContacto.TabIndex = 0;
            btnAñadirContacto.Text = "Añadir Contacto";
            btnAñadirContacto.UseVisualStyleBackColor = true;
            btnAñadirContacto.Click += btnAñadirContacto_Click;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Location = new Point(435, 145);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(75, 23);
            btnEliminarContacto.TabIndex = 1;
            btnEliminarContacto.Text = "Eliminar Contacto";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // btnModificarTelefono
            // 
            btnModificarTelefono.Location = new Point(241, 242);
            btnModificarTelefono.Name = "btnModificarTelefono";
            btnModificarTelefono.Size = new Size(75, 23);
            btnModificarTelefono.TabIndex = 2;
            btnModificarTelefono.Text = "Modificar Telefono";
            btnModificarTelefono.UseVisualStyleBackColor = true;
            // 
            // btnMostrarContactos
            // 
            btnMostrarContactos.Location = new Point(435, 242);
            btnMostrarContactos.Name = "btnMostrarContactos";
            btnMostrarContactos.Size = new Size(75, 23);
            btnMostrarContactos.TabIndex = 3;
            btnMostrarContactos.Text = "Mostrar Contactos";
            btnMostrarContactos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarContactos);
            Controls.Add(btnModificarTelefono);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnAñadirContacto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadirContacto;
        private Button btnEliminarContacto;
        private Button btnModificarTelefono;
        private Button btnMostrarContactos;
    }
}
