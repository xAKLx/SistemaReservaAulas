namespace PresentationLayer
{
    partial class HorarioGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGrupoHorario = new System.Windows.Forms.DataGridView();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAsignarAula = new System.Windows.Forms.ToolStripButton();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.tsbRevocarAula = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoHorario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGrupoHorario);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 404);
            this.panel1.TabIndex = 0;
            // 
            // dgvGrupoHorario
            // 
            this.dgvGrupoHorario.AllowUserToAddRows = false;
            this.dgvGrupoHorario.AllowUserToDeleteRows = false;
            this.dgvGrupoHorario.AllowUserToResizeColumns = false;
            this.dgvGrupoHorario.AllowUserToResizeRows = false;
            this.dgvGrupoHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupoHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupo,
            this.horario,
            this.No,
            this.aula});
            this.dgvGrupoHorario.Location = new System.Drawing.Point(3, 28);
            this.dgvGrupoHorario.MultiSelect = false;
            this.dgvGrupoHorario.Name = "dgvGrupoHorario";
            this.dgvGrupoHorario.ReadOnly = true;
            this.dgvGrupoHorario.RowHeadersVisible = false;
            this.dgvGrupoHorario.Size = new System.Drawing.Size(641, 373);
            this.dgvGrupoHorario.TabIndex = 1;
            this.dgvGrupoHorario.SelectionChanged += new System.EventHandler(this.dgvGrupoHorario_SelectionChanged);
            // 
            // grupo
            // 
            this.grupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            this.grupo.Width = 79;
            // 
            // horario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.horario.DefaultCellStyle = dataGridViewCellStyle1;
            this.horario.HeaderText = "Horario";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            // 
            // aula
            // 
            this.aula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aula.HeaderText = "Aula";
            this.aula.Name = "aula";
            this.aula.ReadOnly = true;
            this.aula.Width = 66;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAsignarAula,
            this.tsbRevocarAula,
            this.tsbRefrescar,
            this.btnAtras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(647, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAsignarAula
            // 
            this.tsbAsignarAula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAsignarAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAsignarAula.Name = "tsbAsignarAula";
            this.tsbAsignarAula.Size = new System.Drawing.Size(102, 25);
            this.tsbAsignarAula.Text = "Asignar Aula";
            this.tsbAsignarAula.Click += new System.EventHandler(this.tsbAsignarAula_Click);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(79, 25);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 25);
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tsbRevocarAula
            // 
            this.tsbRevocarAula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRevocarAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRevocarAula.Name = "tsbRevocarAula";
            this.tsbRevocarAula.Size = new System.Drawing.Size(105, 25);
            this.tsbRevocarAula.Text = "Revocar Aula";
            this.tsbRevocarAula.Click += new System.EventHandler(this.tsbRevocarAula_Click);
            // 
            // HorarioGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 428);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HorarioGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoHorario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGrupoHorario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAsignarAula;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton tsbRevocarAula;
    }
}