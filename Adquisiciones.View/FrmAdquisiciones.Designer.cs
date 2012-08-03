namespace Adquisiciones.View
{
    partial class FrmAdquisiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdquisiciones));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonAnexo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCotizacion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonFallo = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPedidoAuto = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPedidoMayor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPedidoMenor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPedidoDonacion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPedidoExtra = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.txtFechaStatus = new DevExpress.XtraBars.BarStaticItem();
            this.txtUsuarioStatus = new DevExpress.XtraBars.BarStaticItem();
            this.txtAlmacenStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btnCambiarAlma = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.xafBarManager1 = new DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.ApplicationIcon = global::Adquisiciones.View.Properties.Resources.INR;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonAnexo,
            this.barButtonCotizacion,
            this.barButtonFallo,
            this.barMdiChildrenListItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonPedidoAuto,
            this.barButtonPedidoMayor,
            this.barButtonPedidoMenor,
            this.barButtonPedidoDonacion,
            this.barButtonPedidoExtra,
            this.barButtonItem6,
            this.barButtonItem7,
            this.txtFechaStatus,
            this.txtUsuarioStatus,
            this.txtAlmacenStatus,
            this.btnCambiarAlma,
            this.barButtonItem8});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1,
            this.ribbonPageCategory2});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(1123, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonAnexo
            // 
            this.barButtonAnexo.Caption = "Anexo\r\n";
            this.barButtonAnexo.Id = 1;
            this.barButtonAnexo.LargeGlyph = global::Adquisiciones.View.Properties.Resources.licitaciones;
            this.barButtonAnexo.LargeWidth = 75;
            this.barButtonAnexo.Name = "barButtonAnexo";
            this.barButtonAnexo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonAnexo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAnexoItemClick);
            // 
            // barButtonCotizacion
            // 
            this.barButtonCotizacion.Caption = "Cotizacion";
            this.barButtonCotizacion.Id = 2;
            this.barButtonCotizacion.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Cotizaciones;
            this.barButtonCotizacion.LargeWidth = 75;
            this.barButtonCotizacion.Name = "barButtonCotizacion";
            this.barButtonCotizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonCotizacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonCotizacionItemClick);
            // 
            // barButtonFallo
            // 
            this.barButtonFallo.Caption = "Fallo";
            this.barButtonFallo.Id = 3;
            this.barButtonFallo.LargeGlyph = global::Adquisiciones.View.Properties.Resources.order;
            this.barButtonFallo.LargeWidth = 75;
            this.barButtonFallo.Name = "barButtonFallo";
            this.barButtonFallo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonFallo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonFalloItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Ventanas";
            this.barMdiChildrenListItem1.Id = 4;
            this.barMdiChildrenListItem1.LargeGlyph = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Proveedores";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Precios;
            this.barButtonItem1.LargeWidth = 75;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Anexo";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.LargeGlyph = global::Adquisiciones.View.Properties.Resources.search;
            this.barButtonItem2.LargeWidth = 75;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cotizacion";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.LargeGlyph = global::Adquisiciones.View.Properties.Resources.search;
            this.barButtonItem3.LargeWidth = 75;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem3ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Proveedor";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.LargeGlyph = global::Adquisiciones.View.Properties.Resources.search;
            this.barButtonItem4.LargeWidth = 75;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem4ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Partidas";
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Pedido;
            this.barButtonItem5.LargeWidth = 75;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonPedidoAuto
            // 
            this.barButtonPedidoAuto.Caption = "Pedido Automatico";
            this.barButtonPedidoAuto.Id = 11;
            this.barButtonPedidoAuto.LargeGlyph = global::Adquisiciones.View.Properties.Resources.pedi2;
            this.barButtonPedidoAuto.Name = "barButtonPedidoAuto";
            this.barButtonPedidoAuto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonPedidoAuto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonPedidoItemClick);
            // 
            // barButtonPedidoMayor
            // 
            this.barButtonPedidoMayor.Caption = "Mayor";
            this.barButtonPedidoMayor.Id = 12;
            this.barButtonPedidoMayor.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Pedido3;
            this.barButtonPedidoMayor.LargeWidth = 75;
            this.barButtonPedidoMayor.Name = "barButtonPedidoMayor";
            this.barButtonPedidoMayor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonPedidoMayor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonPedidoMayorItemClick);
            // 
            // barButtonPedidoMenor
            // 
            this.barButtonPedidoMenor.Caption = "Menor";
            this.barButtonPedidoMenor.Id = 13;
            this.barButtonPedidoMenor.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Pedido3;
            this.barButtonPedidoMenor.LargeWidth = 75;
            this.barButtonPedidoMenor.Name = "barButtonPedidoMenor";
            this.barButtonPedidoMenor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonPedidoMenor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonPedidoMenorItemClick);
            // 
            // barButtonPedidoDonacion
            // 
            this.barButtonPedidoDonacion.Caption = "Donacion";
            this.barButtonPedidoDonacion.Id = 14;
            this.barButtonPedidoDonacion.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Pedido3;
            this.barButtonPedidoDonacion.LargeWidth = 75;
            this.barButtonPedidoDonacion.Name = "barButtonPedidoDonacion";
            this.barButtonPedidoDonacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonPedidoDonacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonPedidoDonacionItemClick);
            // 
            // barButtonPedidoExtra
            // 
            this.barButtonPedidoExtra.Caption = "ExtraMuro";
            this.barButtonPedidoExtra.Id = 15;
            this.barButtonPedidoExtra.LargeGlyph = global::Adquisiciones.View.Properties.Resources.Pedido3;
            this.barButtonPedidoExtra.LargeWidth = 75;
            this.barButtonPedidoExtra.Name = "barButtonPedidoExtra";
            this.barButtonPedidoExtra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonPedidoExtra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonPedidoExtraItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Fallo";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.LargeGlyph = global::Adquisiciones.View.Properties.Resources.search;
            this.barButtonItem6.LargeWidth = 75;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Pedido";
            this.barButtonItem7.Id = 17;
            this.barButtonItem7.LargeGlyph = global::Adquisiciones.View.Properties.Resources.search;
            this.barButtonItem7.LargeWidth = 75;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem7ItemClick);
            // 
            // txtFechaStatus
            // 
            this.txtFechaStatus.Caption = "barStaticItem1";
            this.txtFechaStatus.Id = 18;
            this.txtFechaStatus.Name = "txtFechaStatus";
            this.txtFechaStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtUsuarioStatus
            // 
            this.txtUsuarioStatus.Caption = "barStaticItem2";
            this.txtUsuarioStatus.Id = 20;
            this.txtUsuarioStatus.Name = "txtUsuarioStatus";
            this.txtUsuarioStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtAlmacenStatus
            // 
            this.txtAlmacenStatus.Caption = "barStaticItem1";
            this.txtAlmacenStatus.Id = 21;
            this.txtAlmacenStatus.Name = "txtAlmacenStatus";
            this.txtAlmacenStatus.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnCambiarAlma
            // 
            this.btnCambiarAlma.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCambiarAlma.Caption = "Cambiar Almacen";
            this.btnCambiarAlma.Glyph = global::Adquisiciones.View.Properties.Resources.almacen;
            this.btnCambiarAlma.Id = 22;
            this.btnCambiarAlma.Name = "btnCambiarAlma";
            this.btnCambiarAlma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCambiarAlmaItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Fundamentos";
            this.barButtonItem8.Id = 23;
            this.barButtonItem8.LargeGlyph = global::Adquisiciones.View.Properties.Resources.cata3;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Color = System.Drawing.Color.Empty;
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Color = System.Drawing.Color.Empty;
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Text = "ribbonPageCategory2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Adquisiciones";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ventanas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAnexo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCotizacion);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonFallo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPedidoAuto);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Modulos";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonPedidoMayor);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonPedidoMenor);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonPedidoDonacion);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonPedidoExtra);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Pedidos";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Catalogos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Busquedas";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Ventanas";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Modulos";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Catalogos";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtFechaStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.txtUsuarioStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.txtAlmacenStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.btnCambiarAlma);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1123, 23);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // xafBarManager1
            // 
            this.xafBarManager1.DockControls.Add(this.barDockControlTop);
            this.xafBarManager1.DockControls.Add(this.barDockControlBottom);
            this.xafBarManager1.DockControls.Add(this.barDockControlLeft);
            this.xafBarManager1.DockControls.Add(this.barDockControlRight);
            this.xafBarManager1.Form = this;
            this.xafBarManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1123, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 449);
            this.barDockControlBottom.Size = new System.Drawing.Size(1123, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 449);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1123, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 449);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // FrmAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Adquisiciones.View.Properties.Resources.fondo_gris;
            this.ClientSize = new System.Drawing.Size(1123, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmAdquisiciones";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Adquisiciones V 1.0 @ Instituto Nacional Rehabilitación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdquisicionesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonAnexo;
        private DevExpress.XtraBars.BarButtonItem barButtonCotizacion;
        private DevExpress.XtraBars.BarButtonItem barButtonFallo;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonPedidoAuto;
        private DevExpress.XtraBars.BarButtonItem barButtonPedidoMayor;
        private DevExpress.XtraBars.BarButtonItem barButtonPedidoMenor;
        private DevExpress.XtraBars.BarButtonItem barButtonPedidoDonacion;
        private DevExpress.XtraBars.BarButtonItem barButtonPedidoExtra;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager xafBarManager1;
        private DevExpress.XtraBars.BarStaticItem txtFechaStatus;
        private DevExpress.XtraBars.BarStaticItem txtUsuarioStatus;
        private DevExpress.XtraBars.BarStaticItem txtAlmacenStatus;
        private DevExpress.XtraBars.BarButtonItem btnCambiarAlma;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}