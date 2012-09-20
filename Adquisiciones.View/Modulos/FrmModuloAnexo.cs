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

        public FrmModuloAnexo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            

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

        public FrmModuloAnexo(Anexo anexo,FrmAdquisiciones padre)
            : this(padre)
        {
            AnexoActual = anexo;
            Consultar();
            Text = @"Anexo::" + anexo.NumeroAnexo;
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

            repositoryItemSearchLookUpEdit2.DataSource = AnexoService.ArticuloDao.
               ArticulosByAlmacen(AlmacenActual);
            repositoryItemSearchLookUpEdit2.DisplayMember = "CveArt";
            repositoryItemSearchLookUpEdit2.ValueMember = "CveArt";
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
            listaError.Strings.Clear();
            lblNumErrors.Caption = string.Empty;
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
                    //txtnumlicitacion.Enabled = false;
                    //dtpFechaanexo.Enabled = false;
                    listaError.Strings.Clear();
                    lblNumErrors.Caption = string.Empty;

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

        private void DgvAnexoCellValueChanged(object sender,
          DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowSelectValue = e.Value;

            //Para realizar las validaciones
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            if (e.Column.AbsoluteIndex == 0) //posicionado en el articulo
            {
                if (TieneRepetidoArticulo((int?) (rowSelectValue)))
                {
                    XtraMessageBox.Show(@"Articulo repetido clave " + rowSelectValue,
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");
                    //gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CveArt", "");
                    return;
                }

                try
                {
                    var cveArt = (int) rowSelectValue;

                    var almacen = AlmacenActual;
                    var articuloid = new ArticuloId(cveArt, almacen);
                    var articuloSelect = AnexoService.ArticuloDao.Get(articuloid);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", articuloSelect.Presentacion);
                }
                catch (Exception ee)
                {
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");

                }
            }
        }

        private void CmdMaximosClick(object sender, EventArgs e)
        {
            FalloService.ActualizarFallo(AnexoActual);
            XtraMessageBox.Show(@"Se actualizaron los maximos del fallo asociado",
                       @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtnumlicitacion_Leave(object sender, EventArgs e)
        {
            //if (AnexoActual.IdAnexo == 0){
                //No existe el numero de folio para ese anio
            if((AnexoActual.NumeroAnexo != txtnumlicitacion.Text && AnexoActual.IdAnexo != 0)
                || AnexoActual.IdAnexo == 0 ){if (AnexoService.AnexoDao.ExisteAnexo(txtnumlicitacion.Text, AlmacenActual))
                {
                    
                    //dxErrorProvider1.SetError(txtnumlicitacion,"El folio ya existe para este año NO SIGA CAPTURANDO!!");
                    //txtnumlicitacion.SelectAll();
                    //txtnumlicitacion.ErrorText ="Huevos" ;
                    XtraMessageBox.Show(@"El folio ya existe para este año NO SIGA CAPTURANDO!!",
                                  @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnumlicitacion.Select();
                }
            }
        }

        private void gcDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}