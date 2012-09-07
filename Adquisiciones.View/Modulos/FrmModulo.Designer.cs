namespace Adquisiciones.View.Modulos
{
    partial class FrmModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModulo));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.cmdNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.cmdGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.cmdReporte = new DevExpress.XtraBars.BarButtonItem();
            this.listaError = new DevExpress.XtraBars.BarListItem();
            this.lblNumErrors = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 92);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(628, 309);
            this.splitContainerControl1.SplitterPosition = 92;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barManager1
            // 
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
            this.cmdNuevo,
            this.cmdGuardar,
            this.cmdConsultar,
            this.listaError,
            this.lblNumErrors,
            this.cmdEliminar,
            this.cmdReporte});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdConsultar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmdReporte, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.listaError),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblNumErrors)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Appearance.Options.UseFont = true;
            this.cmdNuevo.Caption = "Nuevo";
            this.cmdNuevo.Enabled = false;
            this.cmdNuevo.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Glyph")));
            this.cmdNuevo.Id = 0;
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdNuevoClick);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.Caption = "Guardar";
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Glyph")));
            this.cmdGuardar.Id = 1;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdGuardarClick);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Appearance.Options.UseFont = true;
            this.cmdConsultar.Caption = "Consultar";
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdConsultar.Glyph")));
            this.cmdConsultar.Id = 2;
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdConsultarClick);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Appearance.Options.UseFont = true;
            this.cmdEliminar.Caption = "Eliminar";
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Glyph")));
            this.cmdEliminar.Id = 6;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdEliminarItemClick);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Appearance.Options.UseFont = true;
            this.cmdReporte.Caption = "Reporte";
            this.cmdReporte.Enabled = false;
            this.cmdReporte.Glyph = ((System.Drawing.Image)(resources.GetObject("cmdReporte.Glyph")));
            this.cmdReporte.Id = 7;
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CmdReporteItemClick);
            // 
            // listaError
            // 
            this.listaError.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.Appearance.ForeColor = System.Drawing.Color.White;
            this.listaError.Appearance.Options.UseFont = true;
            this.listaError.Appearance.Options.UseForeColor = true;
            this.listaError.Caption = "Errores";
            this.listaError.Enabled = false;
            this.listaError.Id = 3;
            this.listaError.Name = "listaError";
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNumErrors.Appearance.Options.UseFont = true;
            this.lblNumErrors.Appearance.Options.UseForeColor = true;
            this.lblNumErrors.Caption = "0 Errores";
            this.lblNumErrors.Enabled = false;
            this.lblNumErrors.Id = 4;
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.TextAlignment = System.Drawing.StringAlignment.Near;
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
            this.barDockControlTop.Size = new System.Drawing.Size(628, 92);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(628, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 92);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 309);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(628, 92);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 309);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.Appearance.Options.UseFont = true;
            this.barButtonItem1.Caption = "Consultar";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.Appearance.Options.UseFont = true;
            this.barButtonItem2.Caption = "Consultar";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 423);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmModulo";
            this.Text = "FrmModulo2";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        protected DevExpress.XtraBars.BarManager barManager1;
        protected DevExpress.XtraBars.Bar bar1;
        protected DevExpress.XtraBars.Bar bar2;
        protected DevExpress.XtraBars.BarButtonItem cmdNuevo;
        protected DevExpress.XtraBars.Bar bar3;
        protected DevExpress.XtraBars.BarDockControl barDockControlTop;
        protected DevExpress.XtraBars.BarDockControl barDockControlBottom;
        protected DevExpress.XtraBars.BarDockControl barDockControlLeft;
        protected DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarButtonItem cmdGuardar;
        protected DevExpress.XtraBars.BarButtonItem cmdConsultar;
        protected DevExpress.XtraBars.BarListItem listaError;
        protected DevExpress.XtraBars.BarStaticItem lblNumErrors;
        protected DevExpress.XtraBars.BarButtonItem cmdEliminar;
        protected DevExpress.XtraBars.BarButtonItem cmdReporte;
        protected DevExpress.XtraBars.BarButtonItem barButtonItem1;
        protected DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}