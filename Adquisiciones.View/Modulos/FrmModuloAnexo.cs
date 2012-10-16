using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Spring.Context.Support;
using System.Linq;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloAnexo : FrmModulo
    {
       ///<summary></summary>
        public IAnexoService AnexoService { get; set; }
        public IFalloService FalloService { get; set; }

        ///<summary>
        ///</summary>
        public Anexo AnexoActual;

        public Almacen AlmacenArticulo;

        public FrmModuloAnexo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            
            AlmacenesCombo(cbxAlmacen,AlmacenActual);
            base.TypeEntity = typeof(Anexo);
            base.NombreReporte = "reporteAnexo";
            base.NombreService = "anexoService";
            base.GetServicio();
            
            AnexoService = base.Servicio as IAnexoService;
            
            var ctx = ContextRegistry.GetContext();
            FalloService = ctx["falloService"] as IFalloService;

            Nuevo();
            BindearCampos();
            InicializarCatalogos();
            base.ObtenerPerfil();
        }

        public FrmModuloAnexo(Anexo anexo,FrmAdquisiciones padre): this(padre)
        {
            AnexoActual = anexo;
            Consultar();

            //Cargar los articulos del almacen con centinela seleccionado
            var almacenSelect = AnexoActual.AnexoDetalle[0].Articulo.Id.Almacen;
            CargarArticulos(almacenSelect);
        }
        
        public override void BindearCampos()
        {
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();
            txtnumlicitacion.DataBindings.Add(new Binding("Text", bsAnexo, "NumeroAnexo",false));
            dtpFechaanexo.DataBindings.Add(new Binding("DateTime", bsAnexo, "FechaAnexo", true));
            txtDesanexo.DataBindings.Add(new Binding("Text", bsAnexo, "DesAnexo",true));
            cbxInstituto.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Instituto",true));
            cbxTipolicitacion.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "TipoLicitacion", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Iva", true));
            txtTechopresupuestal.DataBindings.Add(new Binding("Text", bsAnexo, "TechoPresupuestal", true));
            bsAnexo.DataSource = AnexoActual;
           
        }

        public override void InicializarCatalogos()
        {
            AnexoService.InstitutosCombo(cbxInstituto);
            AnexoService.TiposLicitacionesCombo(cbxTipolicitacion);
            AnexoService.IvasCombo(cbxIva);
        }

        public override void Nuevo()
        {
            AnexoActual = new Anexo();
            bsAnexo.DataSource = AnexoActual;
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();

            txtnumlicitacion.Enabled = true;
            dtpFechaanexo.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdEliminar.Enabled = true;
            cmdMaximos.Enabled = false;

            txtnumlicitacion.Focus();
            LimpiarErrores();
            cbxAlmacen.Enabled = true;
            lblAlmacenDesc.Text = string.Empty;
            cmdCargarArt.Enabled = true;
        }

        public override void Guardar()
        {
            AnexoActual = bsAnexo.DataSource as Anexo;
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            try
            {
                if (!Util.DatosValidos(AnexoActual, lblNumErrors, listaError))
                {
                    return;
                }

                AnexoActual.Almacen = AlmacenActual;
                AnexoActual.Usuario = FrmModuloAcceso.UsuarioLog;
                AnexoActual.FechaAnexo = dtpFechaanexo.DateTime;
                AnexoService.GuardarAnexo(ref AnexoActual);

                Consultar();

                XtraMessageBox.Show(@"Licitación Registrada o Actualizada Exitosamente",
               @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en el guardado",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        protected override void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
            HayErrores();

            //Cargar los articulos del almacen con centinela seleccionado
            var almacenSelect = AnexoActual.AnexoDetalle[0].Articulo.Id.Almacen;
            CargarArticulos(almacenSelect);
        }

        public override void Consultar()
        {
           try
            {
               if(AnexoActual.NumeroAnexo == null)
                   AnexoActual.NumeroAnexo = txtnumlicitacion.Text;

                AnexoActual = AnexoService.ConsultarAnexo(AnexoActual.NumeroAnexo,
                                                          AlmacenActual);
                if (AnexoActual != null)
                {
                    bsAnexo.DataSource = AnexoActual;
                    bsAnexoDetalle.DataSource = AnexoActual.AnexoDetalle;

                    LimpiarErrores();

                    base.EntityActual = AnexoActual;
                    base.Consultar();
                    if (AnexoService.AnexoDao.ExisteAnexoCotizacion(AnexoActual) ||
                    AnexoService.AnexoDao.ExisteAnexoPedido(AnexoActual))
                    {
                        XtraMessageBox.Show(@"El anexo tiene asociadas cotizaciones o pedidos",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdGuardar.Enabled = false;
                        cmdEliminar.Enabled = false;
                    }

                    if (FalloService.CotizacionDao.ExisteAnexoFallo(AnexoActual))
                        cmdMaximos.Enabled = true;

                }
                else
                {
                    XtraMessageBox.Show(@"Folio no existe", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumlicitacion.Select();
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }

            cbxAlmacen.Enabled = false;
            cmdCargarArt.Enabled = false;

           Text = @"Anexo::" + AnexoActual.NumeroAnexo;

        }

        private bool TieneRepetidoArticulo(int? articulo)
        {
            var numOcurrencia = AnexoActual.AnexoDetalle.Count(p => p.CveArt == articulo);
            return numOcurrencia > 1;
        }

        private void GvAnexoDetalleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvAnexoDetalle.DeleteRow(gvAnexoDetalle.FocusedRowHandle);
            }
        }

        private void DgvAnexoCellValueChanged(object sender,CellValueChangedEventArgs e)
        {
            var rowSelectValue = e.Value;

            //Para realizar las validaciones
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            switch(e.Column.AbsoluteIndex)
            {
                case 0: //Articulo
                    if (TieneRepetidoArticulo((int?) (rowSelectValue)))
                    {
                        XtraMessageBox.Show(@"Articulo repetido clave " + rowSelectValue,
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");
                        return;
                    }

                    try
                    {
                        var cveArt = (int) rowSelectValue;
                        var articuloid = new ArticuloId(cveArt, AlmacenArticulo);
                        var articuloSelect = AnexoService.ArticuloDao.Get(articuloid);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "Articulo", articuloSelect);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", articuloSelect.CatUnidad.Unidad);
                    }catch (Exception ee)
                    {
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");

                    }
                    break;
                case 4: //Cantidad Maxima

                    try
                    {
                        var cantidadMinimo = (decimal) gvAnexoDetalle.GetRowCellValue(e.RowHandle, "CantidadMinimo");

                        if (cantidadMinimo > (decimal) rowSelectValue)
                        {
                            XtraMessageBox.Show(@"Cantidad Minimo > Cantidad Maximo",
                                          @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMinimo", 0);
                            gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMaximo", 0);

                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMinimo", 0);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMaximo", 0);
                        
                    }

                    break;

            }
        }

        private void CmdMaximosClick(object sender, EventArgs e)
        {
            FalloService.ActualizarFallo(AnexoActual);
            XtraMessageBox.Show(@"Se actualizaron los maximos del fallo asociado",
                       @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtnumlicitacionLeave(object sender, EventArgs e)
        {
            
            if((AnexoActual.NumeroAnexo != txtnumlicitacion.Text && AnexoActual.IdAnexo != 0)
                || AnexoActual.IdAnexo == 0 ){
                if (AnexoService.AnexoDao.ExisteAnexo(txtnumlicitacion.Text, AlmacenActual))
                {
                    XtraMessageBox.Show(@"El folio ya existe para este año NO SIGA CAPTURANDO!!",
                                  @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnumlicitacion.Select();
                }
            }
        }

        /// <summary>
        /// Carga claves con almacen donde se registran claves
        /// </summary>
        /// <param name="almacen"></param>
        private void CargarArticulos(Almacen almacen)
        {
            repositoryItemSearchLookUpEdit2.DataSource =
                AnexoService.ArticuloDao.ArticulosByAlmacen(almacen);
            repositoryItemSearchLookUpEdit2.DisplayMember = "CveArt";
            repositoryItemSearchLookUpEdit2.ValueMember = "CveArt";

            lblAlmacenDesc.Text = almacen.ToString();
            cbxAlmacen.SelectedIndex = -1;

            AlmacenArticulo = almacen;

            XtraMessageBox.Show(@"Articulos cargados satisfactoriamente",
            @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CmdCargarArtClick(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(@"Esta seguro de cambiar el almacen? Se borrara el detralle", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bsAnexoDetalle.DataSource = new List<AnexoDetalle>();
                CargarArticulos(cbxAlmacen.SelectedValue as Almacen);
            }

        }
    }
}