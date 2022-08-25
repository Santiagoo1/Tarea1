namespace Tarea1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_dni = new System.Windows.Forms.TextBox();
            this.Boton_cargar_persona = new System.Windows.Forms.Button();
            this.Boton_Mostrar_Edad = new System.Windows.Forms.Button();
            this.Mostrar_edad = new System.Windows.Forms.Label();
            this.Txt_FechaNac = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha De Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(166, 92);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // Txt_dni
            // 
            this.Txt_dni.Location = new System.Drawing.Point(166, 140);
            this.Txt_dni.Name = "Txt_dni";
            this.Txt_dni.Size = new System.Drawing.Size(100, 20);
            this.Txt_dni.TabIndex = 6;
            this.Txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dni_KeyPress);
            // 
            // Boton_cargar_persona
            // 
            this.Boton_cargar_persona.Location = new System.Drawing.Point(503, 107);
            this.Boton_cargar_persona.Name = "Boton_cargar_persona";
            this.Boton_cargar_persona.Size = new System.Drawing.Size(75, 23);
            this.Boton_cargar_persona.TabIndex = 7;
            this.Boton_cargar_persona.Text = "Persona";
            this.Boton_cargar_persona.UseVisualStyleBackColor = true;
            this.Boton_cargar_persona.Click += new System.EventHandler(this.Boton_cargar_persona_Click);
            // 
            // Boton_Mostrar_Edad
            // 
            this.Boton_Mostrar_Edad.Location = new System.Drawing.Point(503, 189);
            this.Boton_Mostrar_Edad.Name = "Boton_Mostrar_Edad";
            this.Boton_Mostrar_Edad.Size = new System.Drawing.Size(75, 23);
            this.Boton_Mostrar_Edad.TabIndex = 8;
            this.Boton_Mostrar_Edad.Text = "Edad";
            this.Boton_Mostrar_Edad.UseVisualStyleBackColor = true;
            this.Boton_Mostrar_Edad.Click += new System.EventHandler(this.Boton_Mostrar_Edad_Click);
            // 
            // Mostrar_edad
            // 
            this.Mostrar_edad.AutoSize = true;
            this.Mostrar_edad.Location = new System.Drawing.Point(166, 269);
            this.Mostrar_edad.Name = "Mostrar_edad";
            this.Mostrar_edad.Size = new System.Drawing.Size(0, 13);
            this.Mostrar_edad.TabIndex = 9;
            // 
            // Txt_FechaNac
            // 
            this.Txt_FechaNac.Location = new System.Drawing.Point(192, 192);
            this.Txt_FechaNac.Mask = "00/00/0000";
            this.Txt_FechaNac.Name = "Txt_FechaNac";
            this.Txt_FechaNac.Size = new System.Drawing.Size(100, 20);
            this.Txt_FechaNac.TabIndex = 10;
            this.Txt_FechaNac.ValidatingType = typeof(System.DateTime);
            this.Txt_FechaNac.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_FechaNac_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_FechaNac);
            this.Controls.Add(this.Mostrar_edad);
            this.Controls.Add(this.Boton_Mostrar_Edad);
            this.Controls.Add(this.Boton_cargar_persona);
            this.Controls.Add(this.Txt_dni);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_dni;
        private System.Windows.Forms.Button Boton_cargar_persona;
        private System.Windows.Forms.Button Boton_Mostrar_Edad;
        private System.Windows.Forms.Label Mostrar_edad;
        private System.Windows.Forms.MaskedTextBox Txt_FechaNac;
    }
}

