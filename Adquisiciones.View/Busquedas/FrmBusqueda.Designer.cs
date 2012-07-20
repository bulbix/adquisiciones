namespace Adquisiciones.View{
    partial class FrmBusqueda
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
            this.cmdReporte = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cmdConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bsSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdReporte
            // 
            this.cmdReporte.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdReporte.Location = new System.Drawing.Point(474, 22);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(145, 57);
            this.cmdReporte.TabIndex = 4;
            this.cmdReporte.Text = "Generar Reporte";
            this.cmdReporte.Click += new System.EventHandler(this.CmdReporteClick);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.cmdEliminar.Location = new System.Drawing.Point(635, 22);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(133, 57);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.cmdEliminar);
            this.splitContainerControl2.Panel1.Controls.Add(this.cmdReporte);
            this.splitContainerControl2.Panel1.Controls.Add(this.cmdConsultar);
            this.splitContainerControl2.Panel1.Controls.Add(this.cmdImprimir);
            this.splitContainerControl2.Panel1.Controls.Add(this.cmdBuscar);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(824, 500);
            this.splitContainerControl2.SplitterPosition = 95;
            this.splitContainerControl2.TabIndex = 3;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdConsultar.Location = new System.Drawing.Point(164, 22);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(133, 57);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.Click += new System.EventHandler(this.CmdConsultarClick);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdImprimir.Location = new System.Drawing.Point(313, 22);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(145, 57);
            this.cmdImprimir.TabIndex = 1;
            this.cmdImprimir.Text = "Imprimir Listado";
            this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdBuscar.Location = new System.Drawing.Point(12, 21);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(133, 57);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscarClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(217, 359);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 500);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBusqueda";
            this.Text = "FrmBusquedaGeneral";
            this.Load += new System.EventHandler(this.FrmBusquedaGeneralLoad);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton cmdReporte;
        protected DevExpress.XtraEditors.SimpleButton cmdEliminar;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        protected DevExpress.XtraEditors.SimpleButton cmdConsultar;
        protected DevExpress.XtraEditors.SimpleButton cmdImprimir;
        protected DevExpress.XtraEditors.SimpleButton cmdBuscar;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        protected System.Windows.Forms.BindingSource bsSource;

    }
}