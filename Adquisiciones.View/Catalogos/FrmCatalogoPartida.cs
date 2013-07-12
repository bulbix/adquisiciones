using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Catalogos
{
    public partial class FrmCatalogoPartida : FrmCatalogo
    {

        ///<summary>
        ///</summary>
        public IPartidaDao PartidaDao { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CatPartida PartidaActual = new CatPartida();

        public FrmCatalogoPartida(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            TypeEntity = typeof (CatPartida);

            var ctx = ContextRegistry.GetContext();
            PartidaDao = ctx["partidaDao"] as IPartidaDao;
            InicializarCatalogos();
            Nuevo();
            BindearCampos();
            base.ObtenerPerfil();
        }


        public FrmCatalogoPartida(CatPartida partida,FrmAdquisiciones padre):this(padre)
        {
            PartidaActual = partida;
            EntityActual = PartidaActual;

            txtClave.Text = partida.Partida;
            Consultar();
        }



        public override void InicializarCatalogos()
        {
            //Cargar lista
            var clases = new Dictionary<string, string>
                                 {
                                     {"CA", "CAPITULO"},
                                     {"CO", "CONCEPTO"},
                                     {"PA", "PARTIDA"}
                                 };
            Util.Dicc2Combo(clases, cbxClase);
        }

        public override void Nuevo()
        {
            LimpiarValidacion();
            PartidaActual = new CatPartida();
            bsSource.DataSource = PartidaActual;
            txtClave.Enabled = true;
            cmdGuardar.Enabled = true;
            txtClave.Text = String.Empty;
            cbxClase.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtClave.Focus();
        }

        public override void Guardar()
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
                    else
                    {
                        XtraMessageBox.Show(@"La partida ya existe, consultela y actualize",
                           @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion de la partida",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);

            }
        }

        public override void Consultar()
        {
            try
            {
                PartidaActual = PartidaDao.Get(txtClave.Text);
                if (PartidaActual != null)
                {
                    txtClave.Enabled = false;
                    bsSource.DataSource = PartidaActual;
                }
                else
                {
                    XtraMessageBox.Show(@"No existe la partida",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
            
        }

        public override void BindearCampos()
        {
            txtClave.DataBindings.Add(new Binding("Text", bsSource, "Partida"));
            txtDescripcion.DataBindings.Add(new Binding("Text", bsSource, "DesPartida"));
            cbxClase.DataBindings.Add(new Binding("SelectedValue", bsSource, "Clase"));
        }
    }
}