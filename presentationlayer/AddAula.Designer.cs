namespace PresentationLayer
{
    partial class AddAula
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbCaracteristicas = new System.Windows.Forms.TextBox();
            this.caracteristicas = new System.Windows.Forms.Label();
            this.identificador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbIdentificador);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tbCaracteristicas);
            this.panel1.Controls.Add(this.caracteristicas);
            this.panel1.Controls.Add(this.identificador);
            this.panel1.Location = new System.Drawing.Point(20, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 318);
            this.panel1.TabIndex = 1;
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(133, 9);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(160, 29);
            this.tbIdentificador.TabIndex = 3;
            this.tbIdentificador.TextChanged += new System.EventHandler(this.tbIdentificador_TextChanged);
            this.tbIdentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(4, 261);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 50);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(4, 201);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 50);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbCaracteristicas
            // 
            this.tbCaracteristicas.Location = new System.Drawing.Point(133, 48);
            this.tbCaracteristicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCaracteristicas.Multiline = true;
            this.tbCaracteristicas.Name = "tbCaracteristicas";
            this.tbCaracteristicas.Size = new System.Drawing.Size(386, 262);
            this.tbCaracteristicas.TabIndex = 1;
            // 
            // caracteristicas
            // 
            this.caracteristicas.AutoSize = true;
            this.caracteristicas.Location = new System.Drawing.Point(6, 51);
            this.caracteristicas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.caracteristicas.Name = "caracteristicas";
            this.caracteristicas.Size = new System.Drawing.Size(117, 21);
            this.caracteristicas.TabIndex = 0;
            this.caracteristicas.Text = "Caracteristicas: ";
            // 
            // identificador
            // 
            this.identificador.AutoSize = true;
            this.identificador.BackColor = System.Drawing.SystemColors.Control;
            this.identificador.Location = new System.Drawing.Point(6, 12);
            this.identificador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(104, 21);
            this.identificador.TabIndex = 0;
            this.identificador.Text = "Identificador: ";
            // 
            // AddAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 359);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Aula";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbCaracteristicas;
        private System.Windows.Forms.Label caracteristicas;
        private System.Windows.Forms.Label identificador;
        private System.Windows.Forms.TextBox tbIdentificador;
    }
}