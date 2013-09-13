namespace Adquisiciones.View.Reportes
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
            this.ReportePedidoDetallado1 = new Adquisiciones.View.Reportes.Pedidos.ReportePedidoDetallado();
            this.ReportePedidoConcentrado1 = new Adquisiciones.View.Reportes.Pedidos.ReportePedidoConcentrado();
            this.ReportePedidoEntrada1 = new Adquisiciones.View.Reportes.Pedidos.ReportePedidoEntrada();
            this.ReporteProveedor1 = new Adquisiciones.View.Reportes.Catalogos.ReporteProveedor();
            this.ReporteFundamento1 = new Adquisiciones.View.Reportes.Catalogos.ReporteFundamento();
            this.ReportePedidoCompleto1 = new Adquisiciones.View.Reportes.Pedidos.ReportePedidoCompleto();
            this.ReporteListaPedido1 = new Adquisiciones.View.Reportes.Pedidos.ReporteListaPedido();
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
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.EnableDrillDown = false;
            this.crystalReportViewer.EnableToolTips = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(787, 634);
            this.crystalReportViewer.TabIndex = 8;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private Reportes.ReporteCotizacion ReporteCotizacion1;
        private Reportes.ReporteAnexo ReporteAnexo1;
        private Reportes.ReporteFallo ReporteFallo1;
        private Reportes.ReporteSubFallo ReporteSubFallo1;
        private Reportes.Pedidos.ReportePedidoDetallado ReportePedidoDetallado1;
        private Reportes.Pedidos.ReportePedidoConcentrado ReportePedidoConcentrado1;
        private Reportes.Pedidos.ReportePedidoEntrada ReportePedidoEntrada1;
        private Reportes.Catalogos.ReporteProveedor ReporteProveedor1;
        private Reportes.Catalogos.ReporteFundamento ReporteFundamento1;
        private Reportes.Pedidos.ReportePedidoCompleto ReportePedidoCompleto1;
        private Pedidos.ReporteListaPedido ReporteListaPedido1;
    }
}