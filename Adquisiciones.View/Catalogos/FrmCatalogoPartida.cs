using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using Adquisiciones.Business;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Catalogos
{
    ///<summary>
    ///</summary>
    public partial class FrmCatalogoPartida : Form
    {


        ///<summary>
        ///</summary>
        public IPartidaDao PartidaDao { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CatPartida PartidaActual = new CatPartida();

        /// <summary>
        /// 
        /// </summary>
        public FrmCatalogoPartida()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            PartidaDao = ctx["partidaDao"] as IPartidaDao;

            //Cargar lista
            var clases = new Dictionary<string, string>
                                 {
                                     {"CA", "CAPITULO"},
                                     {"CO", "CONCEPTO"},
                                     {"PA", "PARTIDA"}
                                 };
            Util.Dicc2Combo(clases, cbxClase);

            Nuevo();

            //bindear campos
            txtClave.DataBindings.Add(new Binding("Text", bsPartida, "Partida"));
            txtDescripcion.DataBindings.Add(new Binding("Text", bsPartida, "DesPartida"));
            cbxClase.DataBindings.Add(new Binding("SelectedValue", bsPartida, "Clase"));
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            try
            {
                if (Util.DatosValidos(PartidaActual, lblNumErrors, listaError))
                {   

                    PartidaActual.FechaAlta = PartidaDao.FechaServidor();
                    PartidaActual.Estatus = "A";
                    PartidaActual.IpTerminal = Util.IpTerminal();

                    var partidaExiste = PartidaDao.Get(txtClave.Text);

                    if (partidaExiste == null)
                    {
                        PartidaDao.Update(PartidaActual);
                        XtraMessageBox.Show(@"Partida Registrado o Actualizado Exitosamente",
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else{
                       XtraMessageBox.Show(@"La partida ya existe, consultela y actualize",
                          @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion de la partida" + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {   
            Nuevo();
        }

        private void Nuevo()
        {
            listaError.Items.Clear();
            lblNumErrors.Text = @"0 Errores";
            PartidaActual = new CatPartida();
            bsPartida.DataSource = PartidaActual;
            txtClave.Enabled = true;
            btnGuardar.Enabled = true;
            txtClave.Text = String.Empty;
            cbxClase.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtClave.Focus();
        }

        private void BtnConsultarClick(object sender, EventArgs e)
        {
            try
            {
                PartidaActual = PartidaDao.Get(txtClave.Text);
                if (PartidaActual != null)
                {   
                    txtClave.Enabled = false;
                    bsPartida.DataSource = PartidaActual;
                }
                else
                {
                    XtraMessageBox.Show(@"No existe la partida",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta" + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
    }
}
