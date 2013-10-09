namespace Adquisiciones.View.Busquedas
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusqueda));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.cmdBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdReporte = new DevExpress.XtraBars.BarButtonItem();
            this.cmdEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bsSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cmdBuscar,
            this.cmdConsultar,
            this.cmdReporte,
            this.cmdEliminar,
            this.cmdCancelar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdBuscar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdConsultar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdReporte, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Appearance.Options.UseFont = true;
            this.cmdBuscar.Caption = "Buscar";
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Glyph")));
            this.cmdBuscar.Id = 0;
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdBuscarItemClick);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Appearance.Options.UseFont = true;
            this.cmdConsultar.Caption = "Consultar";
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdConsultar.Glyph")));
            this.cmdConsultar.Id = 1;
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdConsultarItemClick);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Appearance.Options.UseFont = true;
            this.cmdCancelar.Caption = "Cancelar";
            this.cmdCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Glyph")));
            this.cmdCancelar.Id = 5;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.cmdCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdCancelarItemClick);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Appearance.Options.UseFont = true;
            this.cmdReporte.Caption = "Generar Reporte";
            this.cmdReporte.Enabled = false;
            this.cmdReporte.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdReporte.Glyph")));
            this.cmdReporte.Id = 3;
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdReporteItemClick);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Appearance.Options.UseFont = true;
            this.cmdEliminar.Caption = "Eliminar";
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Glyph")));
            this.cmdEliminar.Id = 4;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdEliminarItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(708, 67);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 375);
            this.barDockControlBottom.Size = new System.Drawing.Size(708, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 308);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(708, 67);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 308);
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBusqueda";
            this.Text = "FrmBusqueda2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBusqueda_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraBars.BarManager barManager1;
        protected DevExpress.XtraBars.Bar bar1;
        protected DevExpress.XtraBars.Bar bar2;
        protected DevExpress.XtraBars.BarButtonItem cmdBuscar;
        protected DevExpress.XtraBars.BarButtonItem cmdConsultar;
        protected DevExpress.XtraBars.BarButtonItem cmdReporte;
        protected DevExpress.XtraBars.BarButtonItem cmdEliminar;
        protected DevExpress.XtraBars.Bar bar3;
        protected DevExpress.XtraBars.BarDockControl barDockControlTop;
        protected DevExpress.XtraBars.BarDockControl barDockControlBottom;
        protected DevExpress.XtraBars.BarDockControl barDockControlLeft;
        protected DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected System.Windows.Forms.BindingSource bsSource;
        protected DevExpress.XtraBars.BarButtonItem cmdCancelar;
    }
}