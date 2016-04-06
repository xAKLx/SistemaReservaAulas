namespace PresentationLayer
{
    partial class ReporteHorariosGruposConAula
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaReservasDataSet = new PresentationLayer.SistemaReservasDataSet();
            this.HorarioGruposConAulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HorarioGruposConAulasTableAdapter = new PresentationLayer.SistemaReservasDataSetTableAdapters.HorarioGruposConAulasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaReservasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioGruposConAulasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.HorarioGruposConAulasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentationLayer.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(611, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaReservasDataSet
            // 
            this.SistemaReservasDataSet.DataSetName = "SistemaReservasDataSet";
            this.SistemaReservasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HorarioGruposConAulasBindingSource
            // 
            this.HorarioGruposConAulasBindingSource.DataMember = "HorarioGruposConAulas";
            this.HorarioGruposConAulasBindingSource.DataSource = this.SistemaReservasDataSet;
            // 
            // HorarioGruposConAulasTableAdapter
            // 
            this.HorarioGruposConAulasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteHorariosGruposConAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 428);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReporteHorariosGruposConAula";
            this.Text = "ReporteHorariosGruposConAula";
            this.Load += new System.EventHandler(this.ReporteHorariosGruposConAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaReservasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorarioGruposConAulasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HorarioGruposConAulasBindingSource;
        private SistemaReservasDataSet SistemaReservasDataSet;
        private SistemaReservasDataSetTableAdapters.HorarioGruposConAulasTableAdapter HorarioGruposConAulasTableAdapter;

    }
}