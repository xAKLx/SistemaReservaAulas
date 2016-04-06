namespace PresentationLayer
{
    partial class AdministradorMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManejarAulas = new System.Windows.Forms.Button();
            this.btnAsignarAulas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnManejarAulas);
            this.flowLayoutPanel1.Controls.Add(this.btnAsignarAulas);
            this.flowLayoutPanel1.Controls.Add(this.btnGenerarReporte);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnCambiarPass);
            this.flowLayoutPanel1.Controls.Add(this.btnLogOut);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(609, 275);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnManejarAulas
            // 
            this.btnManejarAulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManejarAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManejarAulas.Location = new System.Drawing.Point(4, 5);
            this.btnManejarAulas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManejarAulas.Name = "btnManejarAulas";
            this.btnManejarAulas.Size = new System.Drawing.Size(142, 123);
            this.btnManejarAulas.TabIndex = 0;
            this.btnManejarAulas.Text = "Manejar Aulas";
            this.btnManejarAulas.UseVisualStyleBackColor = true;
            this.btnManejarAulas.Click += new System.EventHandler(this.btnManejarAulas_Click);
            // 
            // btnAsignarAulas
            // 
            this.btnAsignarAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarAulas.Location = new System.Drawing.Point(154, 5);
            this.btnAsignarAulas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignarAulas.Name = "btnAsignarAulas";
            this.btnAsignarAulas.Size = new System.Drawing.Size(142, 123);
            this.btnAsignarAulas.TabIndex = 0;
            this.btnAsignarAulas.Text = "Asignar Aulas";
            this.btnAsignarAulas.UseVisualStyleBackColor = true;
            this.btnAsignarAulas.Click += new System.EventHandler(this.btnAsignarAulas_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(454, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 123);
            this.button1.TabIndex = 2;
            this.button1.Text = "Manejar Administradores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(154, 138);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 123);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 275);
            this.panel1.TabIndex = 1;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPass.Location = new System.Drawing.Point(4, 138);
            this.btnCambiarPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(142, 123);
            this.btnCambiarPass.TabIndex = 3;
            this.btnCambiarPass.Text = "Cambiar Contraseña";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Location = new System.Drawing.Point(304, 5);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(142, 123);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "GenerarReporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // AdministradorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 275);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdministradorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorMain";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnManejarAulas;
        private System.Windows.Forms.Button btnAsignarAulas;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Button btnGenerarReporte;

    }
}