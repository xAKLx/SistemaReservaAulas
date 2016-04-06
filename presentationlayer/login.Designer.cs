namespace PresentationLayer
{
    partial class login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.contra = new System.Windows.Forms.Label();
            this.identificador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ContraTB = new System.Windows.Forms.TextBox();
            this.identificadorTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.contra);
            this.panel1.Controls.Add(this.identificador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ContraTB);
            this.panel1.Controls.Add(this.identificadorTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 185);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 48);
            this.panel3.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(290, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 48);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.Location = new System.Drawing.Point(10, 97);
            this.contra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(89, 21);
            this.contra.TabIndex = 3;
            this.contra.Text = "Contraseña";
            // 
            // identificador
            // 
            this.identificador.AutoSize = true;
            this.identificador.Location = new System.Drawing.Point(10, 58);
            this.identificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.identificador.Name = "identificador";
            this.identificador.Size = new System.Drawing.Size(126, 21);
            this.identificador.TabIndex = 3;
            this.identificador.Text = "Nombre Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContraTB
            // 
            this.ContraTB.Location = new System.Drawing.Point(144, 94);
            this.ContraTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContraTB.Name = "ContraTB";
            this.ContraTB.Size = new System.Drawing.Size(148, 29);
            this.ContraTB.TabIndex = 1;
            this.ContraTB.UseSystemPasswordChar = true;
            // 
            // identificadorTB
            // 
            this.identificadorTB.Location = new System.Drawing.Point(144, 55);
            this.identificadorTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.identificadorTB.Name = "identificadorTB";
            this.identificadorTB.Size = new System.Drawing.Size(148, 29);
            this.identificadorTB.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Next);
            this.panel2.Controls.Add(this.Tipo);
            this.panel2.Controls.Add(this.Previous);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 130);
            this.panel2.TabIndex = 3;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Next.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(346, 0);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(42, 130);
            this.Next.TabIndex = 1;
            this.Next.Text = "|>";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Tipo
            // 
            this.Tipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(50, 52);
            this.Tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Size = new System.Drawing.Size(288, 26);
            this.Tipo.TabIndex = 2;
            this.Tipo.Text = "Tipo";
            this.Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Previous.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Previous.Dock = System.Windows.Forms.DockStyle.Left;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.Location = new System.Drawing.Point(0, 0);
            this.Previous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(42, 130);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "<|";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 332);
            this.panel4.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(417, 356);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.Label identificador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ContraTB;
        private System.Windows.Forms.TextBox identificadorTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Tipo;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Panel panel4;

    }
}