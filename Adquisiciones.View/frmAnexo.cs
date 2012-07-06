using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Spring.Context.Support;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmAnexo : Form
    {
        #region Variables Miembro

        ///<summary>
        ///</summary>
        public IAnexoService AnexoService;

        ///<summary>
        ///</summary>
        public Anexo AnexoActual;

        #endregion

        #region Contructores
        ///<summary>
        ///</summary>
        public FrmAnexo()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            AnexoService = ctx["anexoService"] as IAnexoService;
            this.Nuevo();
            this.BindearCampos();
            this.InicializarListas();
        }



        #endregion

        #region Eventos
        private void BtnConsultaClick(object sender, EventArgs e)
        {
            this.dgvAnexo.Rows.Clear();
            AnexoActual = AnexoService.ConsultarAnexo(txtnumlicitacion.Text,
                FrmModulo.AlmacenSelec.IdAlmacen);

            if (AnexoActual != null)
            {

                //Rebindeamos padre y detalle
                this.bsAnexo.DataSource = AnexoActual;
                this.bsAnexoDetalle.DataSource = AnexoActual.AnexoDetalle;

                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                txtnumlicitacion.Enabled = false;
                dtpFechaanexo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Folio no existe", "Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarClick(object sender, EventArgs e)
        {
            //No existe el numero de folio para ese anio
            if (!AnexoService.AnexoDao.ExisteAnexo(txtnumlicitacion.Text,
                                                   FrmModulo.AlmacenSelec.IdAlmacen))
            {
                if (MessageBox.Show(@"Esta seguro de guardar el anexo con ese #folio y fecha?",
                                    @"Adquisiciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                    GuardarAnexo();
            }
            else
                MessageBox.Show(@"El folio ya existe para este año",
                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnModificarClick(object sender, EventArgs e)
        {
            GuardarAnexo();
        }

        private void BtnCerrarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void DgvAnexoCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelect = dgvAnexo.CurrentRow;

            try
            {
                //Para realizar las validaciones
                AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

                //Posicionado en renglon
                if (e.ColumnIndex == 0 && TieneRepetidoRenglon(rowSelect))
                {
                    rowSelect.Cells[0].Value = null;

                    MessageBox.Show("Renglon repetido",
                "Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                if (e.ColumnIndex == 1)//posicionado en el articulo
                {
                    if (TieneRepetidoArticulo(rowSelect))
                    {
                        rowSelect.Cells[1].Value = null;
                        rowSelect.Cells[2].Value = null;
                        rowSelect.Cells[3].Value = null;

                        MessageBox.Show("Articulo repetido",
                    "Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var cveArt = (int)rowSelect.Cells[1].Value;

                    var almacen = FrmModulo.AlmacenSelec;
                    var articuloid = new ArticuloId(cveArt, almacen);
                    var articuloSelect = AnexoService.ArticuloDao.Get(articuloid);

                    //Ponemos la descripcion
                    rowSelect.Cells[2].Value = articuloSelect.DesArticulo;
                    //Ponemos la presentacion
                    rowSelect.Cells[3].Value = articuloSelect.Presentacion;
                }

            }
            catch (Exception ee)
            {
                rowSelect.Cells[1].Value = null;
                rowSelect.Cells[2].Value = null;
                rowSelect.Cells[3].Value = null;

                MessageBox.Show("Articulo No Encontrado, Verifique ... ", "Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        #endregion

        #region Metodos
        private void InicializarListas()
        {
            AnexoService.InstitutosCombo(cbxInstituto);
            AnexoService.TiposLicitacionesCombo(cbxTipolicitacion);
            AnexoService.IvasCombo(cbxIva);
        }

        private void Nuevo()
        {
            //Nueva consulta
            AnexoActual = new Anexo();
            bsAnexo.DataSource = AnexoActual;
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();

            this.dgvAnexo.Rows.Clear();

            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
            txtnumlicitacion.Enabled = true;
            dtpFechaanexo.Enabled = true;
            txtnumlicitacion.Focus();
            listaError.Items.Clear();
            lblNumErrors.Text = string.Empty;

        }

        /// <summary>
        /// Guarda un anexo valido 
        /// siempre no exista una cotizacion asociada
        /// </summary>
        private void GuardarAnexo()
        {
            AnexoActual = bsAnexo.DataSource as Anexo;
            //Seteamos el binding del detalle al padre
            AnexoActual.AnexoDetalle = bsAnexoDetalle.DataSource as List<AnexoDetalle>;

            try
            {
                if (Util.DatosValidos<Anexo>(AnexoActual, lblNumErrors, listaError))
                {

                    //if(AnexoService.AnexoDao.ExisteAnexoCotizacion(AnexoActual))
                    //{
                    //    MessageBox.Show(@"El anexo tiene asociadas cotizaciones",
                    //    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}

                    //los parametros basicos
                    AnexoActual.FechaModificacion = AnexoService.AnexoDao.FechaServidor();
                    AnexoActual.IpTerminal = Util.IpTerminal();
                    AnexoActual.Almacen = FrmModulo.AlmacenSelec;
                    AnexoActual.Usuario = FrmAcceso.UsuarioLog;
                    AnexoActual.FechaAnexo = dtpFechaanexo.Value;


                    AnexoService.GuardarAnexo(AnexoActual);

                    MessageBox.Show(@"Licitación Registrada o Actualizada Exitosamente",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btnModificar.Enabled = true;
                    btnAgregar.Enabled = false;

                    //Desactivamos las llaves principales
                    txtnumlicitacion.Enabled = false;
                    dtpFechaanexo.Enabled = false;
                    listaError.Items.Clear();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TieneRepetidoRenglon(DataGridViewRow row)
        {
            var numOcurrencia = AnexoActual.AnexoDetalle.Count
                (p => p.Renglon == (short?)row.Cells[0].Value);

            return numOcurrencia > 1;
        }

        private bool TieneRepetidoArticulo(DataGridViewRow row)
        {
            var numOcurrencia = AnexoActual.AnexoDetalle.Count
                (p => p.CveArt == (int?)row.Cells[1].Value);

            return numOcurrencia > 1;
        }

        #endregion

    }
}
