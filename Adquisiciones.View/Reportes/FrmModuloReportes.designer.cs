﻿namespace Adquisiciones.View
{
    partial class FrmModuloReportes
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReporteCotizacion1 = new Adquisiciones.View.Reportes.ReporteCotizacion();
            this.ReporteAnexo1 = new Adquisiciones.View.Reportes.ReporteAnexo();
            this.ReporteFallo1 = new Adquisiciones.View.Reportes.ReporteFallo();
            this.ReporteSubFallo1 = new Adquisiciones.View.Reportes.ReporteSubFallo();
            this.ReportePedido1 = new Adquisiciones.View.Reportes.ReportePedidoAnverso();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(710, 362);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 58);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.EnableDrillDown = false;
            this.crystalReportViewer.EnableToolTips = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.ReporteCotizacion1;
            this.crystalReportViewer.Size = new System.Drawing.Size(787, 634);
            this.crystalReportViewer.TabIndex = 8;
            // 
            // FrmModuloReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 634);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "FrmModuloReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportesLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private Reportes.ReporteCotizacion ReporteCotizacion1;
        private Reportes.ReporteAnexo ReporteAnexo1;
        private Reportes.ReporteFallo ReporteFallo1;
        private Reportes.ReporteSubFallo ReporteSubFallo1;
        private Reportes.ReportePedidoAnverso ReportePedido1;
    }
}