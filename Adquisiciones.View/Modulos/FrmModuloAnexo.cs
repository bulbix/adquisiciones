using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Spring.Context.Support;
using System.Linq;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloAnexo : FrmModulo
    {

        #region Variables
        public IAnexoService AnexoService { get; set; }
        public IFalloService FalloService { get; set; }
        public Anexo AnexoActual;
        #endregion

        #region Constructores
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
        }
        #endregion

        #region Metodos
        public override void BindearCampos()
        {
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();
            txtnumlicitacion.DataBindings.Add(new Binding("Text", bsAnexo, "NumeroAnexo",false));
            txtDesanexo.DataBindings.Add(new Binding("Text", bsAnexo, "DesAnexo",true));
            //cbxTipolicitacion.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "TipoLicitacion", true));
            //cbxIva.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Iva", true));
            txtTechopresupuestal.DataBindings.Add(new Binding("Text", bsAnexo, "TechoPresupuestal", true));
            bsAnexo.DataSource = AnexoActual;
           
        }

        public override void InicializarCatalogos()
        {
            AnexoService.TiposLicitacionesCombo(cbxTipolicitacion);
            AnexoService.IvasCombo(cbxIva);
        }

        public override void Nuevo()
        {
            AnexoActual = new Anexo();
            bsAnexo.DataSource = AnexoActual;
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();

            AnexoActual.FechaAnexo = AnexoService.AnexoDao.FechaServidor();
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", AnexoActual.FechaAnexo);

            Text = @"Anexo::" + AnexoActual;

            txtnumlicitacion.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdMaximos.Enabled = false;

            txtnumlicitacion.Focus();
            LimpiarErrores();
            cbxAlmacen.Enabled = true;
        }
        public override void Guardar()
        {
            gcAnexoDetalle.Focus();//Para rebindeeen los campos
            AnexoActual = bsAnexo.DataSource as Anexo;
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            try
            {
                AnexoActual.Almacen = AlmacenActual;
                AnexoActual.Usuario = FrmModuloAcceso.UsuarioLog;

                //Combos
                AnexoActual.TipoLicitacion = cbxTipolicitacion.SelectedValue as TipoLicitacion;
                AnexoActual.Iva = cbxIva.SelectedValue as Iva;


                if (!Util.DatosValidos(AnexoActual, lblNumErrors, listaError))
                    return;

              
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

                    //Combos que no vincula
                    if(AnexoActual.TipoLicitacion != null)
                        cbxTipolicitacion.SelectedIndex = cbxTipolicitacion.
                            FindStringExact(AnexoActual.TipoLicitacion.DesTipolicitacion);

                    if(AnexoActual.Iva != null)
                        cbxIva.SelectedIndex = cbxIva.FindStringExact(AnexoActual.Iva.Id.Porcentaje.ToString());

                    lblFecha.Text = String.Format("{0:dd/MM/yyyy}", AnexoActual.FechaAnexo);

                    LimpiarErrores();

                    base.EntityActual = AnexoActual;
                    base.Consultar();
                    if (AnexoService.AnexoDao.ExisteAnexoCotizacion(AnexoActual) ||
                    AnexoService.AnexoDao.ExisteAnexoPedido(AnexoActual))
                    {
                        XtraMessageBox.Show(@"El anexo tiene asociadas cotizaciones o pedidos",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdGuardar.Enabled = false;
                        
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
           Text = @"Anexo::" + AnexoActual.NumeroAnexo;

        }

        private bool TieneRepetidoArticulo(int? articulo)
        {
            var numOcurrencia = AnexoActual.AnexoDetalle.Count(p => p.CveArt == articulo);
            return numOcurrencia > 1;
        }
        #endregion

        #region Eventos
        protected override void CmdConsultarClick(object sender, ItemClickEventArgs e)
        {
            Consultar();
            HayErrores();
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
                        var almacen = cbxAlmacen.SelectedValue as Almacen;
                        var articuloid = new ArticuloId(cveArt, almacen);

                        var articuloSelect = AnexoService.ArticuloDao.Get(articuloid);

                        if (articuloSelect == null)
                        {
                            XtraMessageBox.Show(@"No existe la clave", @"Adquisiciones",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                            gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                            gvAnexoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");

                            return;
                        }

                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "Articulo", articuloSelect);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", articuloSelect.Unidad);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMinimo", 0);
                        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CantidadMaximo", 0);

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

        private void CbxAlmacenSelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnexoActual == null || AnexoActual.IdAnexo == 0)
                bsAnexoDetalle.DataSource = new List<AnexoDetalle>();
        }

        #endregion

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = @"txt files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Podria no leer el archivo");
                }
            }

        }
    }
}