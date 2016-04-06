namespace PresentationLayer
{
    partial class Aulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aulas));
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAplicarFiltro = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbHoraI = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMinI = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbHoraF = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMinF = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscbDia = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbaddAula = new System.Windows.Forms.ToolStripButton();
            this.tsbrefrescar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbVerDetalles = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerarReporte = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.AllowUserToResizeColumns = false;
            this.dgvAulas.AllowUserToResizeRows = false;
            this.dgvAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aula});
            this.dgvAulas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAulas.Location = new System.Drawing.Point(0, 58);
            this.dgvAulas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.RowHeadersVisible = false;
            this.dgvAulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAulas.Size = new System.Drawing.Size(605, 392);
            this.dgvAulas.TabIndex = 0;
            this.dgvAulas.SelectionChanged += new System.EventHandler(this.dgvAulas_SelectionChanged);
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAplicarFiltro);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvAulas);
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 450);
            this.panel1.TabIndex = 1;
            // 
            // cbAplicarFiltro
            // 
            this.cbAplicarFiltro.AutoSize = true;
            this.cbAplicarFiltro.Enabled = false;
            this.cbAplicarFiltro.Location = new System.Drawing.Point(448, 28);
            this.cbAplicarFiltro.Name = "cbAplicarFiltro";
            this.cbAplicarFiltro.Size = new System.Drawing.Size(112, 25);
            this.cbAplicarFiltro.TabIndex = 4;
            this.cbAplicarFiltro.Text = "Aplicar Filro";
            this.cbAplicarFiltro.UseVisualStyleBackColor = true;
            this.cbAplicarFiltro.CheckedChanged += new System.EventHandler(this.rdAplicarFiltro_CheckedChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbHoraI,
            this.toolStripSeparator1,
            this.tbMinI,
            this.toolStripLabel1,
            this.tbHoraF,
            this.toolStripSeparator2,
            this.tbMinF,
            this.toolStripLabel2,
            this.tscbDia});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(605, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbHoraI
            // 
            this.tbHoraI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHoraI.Name = "tbHoraI";
            this.tbHoraI.Size = new System.Drawing.Size(36, 25);
            this.tbHoraI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoraI_KeyPress);
            this.tbHoraI.TextChanged += new System.EventHandler(this.tbHoraI_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbMinI
            // 
            this.tbMinI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMinI.Name = "tbMinI";
            this.tbMinI.Size = new System.Drawing.Size(36, 25);
            this.tbMinI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoraI_KeyPress);
            this.tbMinI.TextChanged += new System.EventHandler(this.tbHoraI_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "-";
            // 
            // tbHoraF
            // 
            this.tbHoraF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHoraF.Name = "tbHoraF";
            this.tbHoraF.Size = new System.Drawing.Size(36, 25);
            this.tbHoraF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoraI_KeyPress);
            this.tbHoraF.TextChanged += new System.EventHandler(this.tbHoraI_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbMinF
            // 
            this.tbMinF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMinF.Name = "tbMinF";
            this.tbMinF.Size = new System.Drawing.Size(36, 25);
            this.tbMinF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoraI_KeyPress);
            this.tbMinF.TextChanged += new System.EventHandler(this.tbHoraI_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Dia:";
            // 
            // tscbDia
            // 
            this.tscbDia.AutoCompleteCustomSource.AddRange(new string[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.tscbDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.tscbDia.Name = "tscbDia";
            this.tscbDia.Size = new System.Drawing.Size(121, 25);
            this.tscbDia.SelectedIndexChanged += new System.EventHandler(this.tbHoraI_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbaddAula,
            this.tsbrefrescar,
            this.tsbEditar,
            this.tsbVerDetalles,
            this.tsbEliminar,
            this.tsbGenerarReporte,
            this.btnAtras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(605, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbaddAula
            // 
            this.tsbaddAula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbaddAula.Image = ((System.Drawing.Image)(resources.GetObject("tsbaddAula.Image")));
            this.tsbaddAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbaddAula.Name = "tsbaddAula";
            this.tsbaddAula.Size = new System.Drawing.Size(70, 25);
            this.tsbaddAula.Text = "Agregar";
            this.tsbaddAula.Click += new System.EventHandler(this.addAula_Click);
            // 
            // tsbrefrescar
            // 
            this.tsbrefrescar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbrefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tsbrefrescar.Image")));
            this.tsbrefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbrefrescar.Name = "tsbrefrescar";
            this.tsbrefrescar.Size = new System.Drawing.Size(79, 25);
            this.tsbrefrescar.Text = "Refrescar";
            this.tsbrefrescar.Click += new System.EventHandler(this.tsbrefrescar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(54, 25);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbVerDetalles
            // 
            this.tsbVerDetalles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVerDetalles.Image = ((System.Drawing.Image)(resources.GetObject("tsbVerDetalles.Image")));
            this.tsbVerDetalles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVerDetalles.Name = "tsbVerDetalles";
            this.tsbVerDetalles.Size = new System.Drawing.Size(97, 25);
            this.tsbVerDetalles.Text = "Ver Detalles";
            this.tsbVerDetalles.Click += new System.EventHandler(this.tsbVerDetalles_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(71, 25);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 25);
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tsbGenerarReporte
            // 
            this.tsbGenerarReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerarReporte.Image")));
            this.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerarReporte.Name = "tsbGenerarReporte";
            this.tsbGenerarReporte.Size = new System.Drawing.Size(129, 25);
            this.tsbGenerarReporte.Text = "Generar Reporte";
            this.tsbGenerarReporte.Click += new System.EventHandler(this.tsbGenerarReporte_Click);
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 484);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Aulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbaddAula;
        private System.Windows.Forms.ToolStripButton tsbrefrescar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox tbHoraI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbMinI;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbHoraF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tbMinF;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbVerDetalles;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscbDia;
        private System.Windows.Forms.CheckBox cbAplicarFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton tsbGenerarReporte;
    }
}