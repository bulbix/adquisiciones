using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using log4net;
using Spring.Context.Support;
using System.Linq;
using Spring.Objects.Factory;
using Form = Spring.Windows.Forms.Form;

namespace Adquisiciones.View
{
    public partial class FrmModuloAnexo : XtraForm
    {
        ///<summary>
        ///</summary>
        public IAnexoService AnexoService { get; set; }

        ///<summary>
        ///</summary>
        public Anexo AnexoActual;

        /// <summary>
        /// La bitacora
        /// </summary>
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// 
        /// </summary> <param name="anexo"></param>
        public FrmModuloAnexo(Anexo anexo)
            : this()
        {
            ConsultarAnexo(anexo.NumeroAnexo);
            Text = @"Anexo::" + anexo.NumeroAnexo;

            if (AnexoService.AnexoDao.ExisteAnexoCotizacion(AnexoActual))
            {
                MessageBox.Show(@"El anexo tiene asociadas cotizaciones",
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
            }
        }

        /// <summary> 
        /// </summary>
        public FrmModuloAnexo()
        {
            var ctx = ContextRegistry.GetContext();
            AnexoService = ctx["anexoService"] as IAnexoService;
            InitializeComponent();
            NuevoAnexo();
            BindearCampos();
            InicializarCatalogos();
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {

            if (AnexoActual.IdAnexo == 0)
            {
                //No existe el numero de folio para ese anio
                if (!AnexoService.AnexoDao.ExisteAnexo(txtnumlicitacion.Text,
                                                       FrmModuloModulo.AlmacenSelec))
                {
                    GuardarAnexo();
                }
                else
                    MessageBox.Show(@"El folio ya existe para este año",
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GuardarAnexo();
            }
        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            NuevoAnexo();
            Log.Info("Probando Nuevo en anexo");
        }



        private void BindearCampos()
        {
            // Initialize the DataGridView.
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();

            ////Bindeamos el padre
            txtnumlicitacion.DataBindings.Add(new Binding("Text", bsAnexo, "NumeroAnexo"));
            dtpFechaanexo.DataBindings.Add(new Binding("DateTime", bsAnexo, "FechaAnexo", true));
            txtDesanexo.DataBindings.Add(new Binding("Text", bsAnexo, "DesAnexo"));
            cbxInstituto.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Instituto"));
            cbxTipolicitacion.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "TipoLicitacion", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Iva", true));
            txtTechopresupuestal.DataBindings.Add(new Binding("Text", bsAnexo, "TechoPresupuestal", true));
            bsAnexo.DataSource = AnexoActual;
        }

        private void InicializarCatalogos()
        {
            AnexoService.InstitutosCombo(cbxInstituto);
            AnexoService.TiposLicitacionesCombo(cbxTipolicitacion);
            AnexoService.IvasCombo(cbxIva);

            repositoryItemSearchLookUpEdit2.DataSource = AnexoService.ArticuloDao.
               ArticulosByAlmacen(FrmModuloModulo.AlmacenSelec);
            repositoryItemSearchLookUpEdit2.DisplayMember = "CveArt";
            repositoryItemSearchLookUpEdit2.ValueMember = "CveArt";
        }

        private void NuevoAnexo()
        {
            AnexoActual = new Anexo();
            bsAnexo.DataSource = AnexoActual;
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();

            txtnumlicitacion.Enabled = true;
            dtpFechaanexo.Enabled = true;
            btnGuardar.Enabled = true;
            txtnumlicitacion.Focus();
            listaError.Items.Clear();
            lblNumErrors.Text = string.Empty;

        }

        private void ConsultarAnexo(string numAnexo)
        {
            try
            {
                AnexoActual = AnexoService.ConsultarAnexo(numAnexo,
                                                          FrmModuloModulo.AlmacenSelec);

                if (AnexoActual != null)
                {
                    bsAnexo.DataSource = AnexoActual;
                    bsAnexoDetalle.DataSource = AnexoActual.AnexoDetalle;
                    txtnumlicitacion.Enabled = false;
                    dtpFechaanexo.Enabled = false;
                    listaError.Items.Clear();
                    lblNumErrors.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(@"Folio no existe", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumlicitacion.Select();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la consulta Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        /// <summary>
        /// Guarda un anexo valido 
        /// siempre no exista una cotizacion asociada
        /// </summary>
        private void GuardarAnexo()
        {
            AnexoActual = bsAnexo.DataSource as Anexo;
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            try
            {
                if (!Util.DatosValidos(AnexoActual, lblNumErrors, listaError))
                {
                    return;
                }


                //los parametros basicos
                    AnexoActual.FechaModificacion = AnexoService.AnexoDao.FechaServidor();
                    AnexoActual.IpTerminal = Util.IpTerminal();
                    AnexoActual.Almacen = FrmModuloModulo.AlmacenSelec;
                    AnexoActual.Usuario = FrmModuloAcceso.UsuarioLog;
                    AnexoActual.FechaAnexo = dtpFechaanexo.DateTime;
                    AnexoService.GuardarAnexo(ref AnexoActual);

                    ConsultarAnexo(AnexoActual.NumeroAnexo);

                    MessageBox.Show(@"Licitación Registrada o Actualizada Exitosamente",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception ee){
                MessageBox.Show(@"Ocurrio un error en la persistencia Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        //private bool TieneRepetidoRenglon(short? renglon)
        //{
        //    var numOcurrencia = AnexoActual.AnexoDetalle.Count
        //        (p => p.Renglon == renglon);

        //    return numOcurrencia > 1;
        //}

        private bool TieneRepetidoArticulo(int? articulo)
        {
            var numOcurrencia = AnexoActual.AnexoDetalle.Count
                (p => p.CveArt == articulo);

            return numOcurrencia > 1;
        }



      
        private void FrmAnexoDevLoad(object sender, EventArgs e)
        {
           
         }

        private void GvAnexoDetalleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvAnexoDetalle.DeleteRow(gvAnexoDetalle.FocusedRowHandle);
            }
        }

        private void BtnRefrescarClick(object sender, EventArgs e)
        {
            if (AnexoActual != null)
            {
                ConsultarAnexo(AnexoActual.NumeroAnexo);
            }
        }

        private void DgvAnexoCellValueChanged(object sender,
           DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowSelectValue = e.Value;

            //Para realizar las validaciones
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;
            ////Posicionado en renglon
            //if (e.Column.AbsoluteIndex == 0)
            //{
            //    if (TieneRepetidoRenglon((short?)(rowSelectValue)))
            //    {

            //        MessageBox.Show(@"Renglon repetido numero " + rowSelectValue,
            //                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        gvAnexoDetalle.SetRowCellValue(e.RowHandle, "Renglon", "");
            //        return;
            //    }
            //}


            if (e.Column.AbsoluteIndex == 0)//posicionado en el articulo
            {


                if (TieneRepetidoArticulo((int?)(rowSelectValue)))
                {
                    MessageBox.Show(@"Articulo repetido clave " + rowSelectValue,
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");
                    //gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CveArt", "");
                    return;
                }

                try
                {
                    var cveArt = (int) rowSelectValue;

                    var almacen = FrmModuloModulo.AlmacenSelec;
                    var articuloid = new ArticuloId(cveArt, almacen);
                    var articuloSelect = AnexoService.ArticuloDao.Get(articuloid);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", articuloSelect.Presentacion);
                }
                catch(Exception ee)
                {
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    gvAnexoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");
                    
                }
            }



        }

        

    }
}