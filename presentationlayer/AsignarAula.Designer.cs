namespace PresentationLayer
{
    partial class AsignarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarAula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAsignar = new System.Windows.Forms.ToolStripButton();
            this.tsbVerDetalles = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.lHorario = new System.Windows.Forms.Label();
            this.lGrupo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lHorario);
            this.panel1.Controls.Add(this.lGrupo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 404);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAulas);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 330);
            this.panel2.TabIndex = 1;
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
            this.aula});
            this.dgvAulas.Location = new System.Drawing.Point(0, 28);
            this.dgvAulas.MultiSelect = false;
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.ReadOnly = true;
            this.dgvAulas.RowHeadersVisible = false;
            this.dgvAulas.Size = new System.Drawing.Size(290, 302);
            this.dgvAulas.TabIndex = 1;
            this.dgvAulas.SelectionChanged += new System.EventHandler(this.dgvAulas_SelectionChanged);
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.Name = "aula";
            this.aula.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAsignar,
            this.tsbVerDetalles,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(290, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAsignar
            // 
            this.tsbAsignar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAsignar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsignar.Image")));
            this.tsbAsignar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAsignar.Name = "tsbAsignar";
            this.tsbAsignar.Size = new System.Drawing.Size(67, 25);
            this.tsbAsignar.Text = "Asignar";
            this.tsbAsignar.Click += new System.EventHandler(this.tsbAsignar_Click);
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
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(74, 25);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // lHorario
            // 
            this.lHorario.AutoSize = true;
            this.lHorario.Location = new System.Drawing.Point(3, 47);
            this.lHorario.Name = "lHorario";
            this.lHorario.Size = new System.Drawing.Size(70, 21);
            this.lHorario.TabIndex = 0;
            this.lHorario.Text = "Horario: ";
            // 
            // lGrupo
            // 
            this.lGrupo.AutoSize = true;
            this.lGrupo.Location = new System.Drawing.Point(3, 12);
            this.lGrupo.Name = "lGrupo";
            this.lGrupo.Size = new System.Drawing.Size(61, 21);
            this.lGrupo.TabIndex = 0;
            this.lGrupo.Text = "Grupo: ";
            // 
            // AsignarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 428);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AsignarAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarAula";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAsignar;
        private System.Windows.Forms.ToolStripButton tsbVerDetalles;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Label lHorario;
        private System.Windows.Forms.Label lGrupo;
    }
}