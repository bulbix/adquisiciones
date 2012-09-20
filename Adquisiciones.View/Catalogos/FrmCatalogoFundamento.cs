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
    public partial class FrmCatalogoFundamento : FrmCatalogo
    {

        ///<summary>
        ///</summary>
        public IFundamentoDao FundamentoDao { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Fundamento FundamentoActual = new Fundamento();

        public FrmCatalogoFundamento(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            var ctx = ContextRegistry.GetContext();
            FundamentoDao = ctx["fundamentoDao"] as IFundamentoDao;
            Nuevo();
            BindearCampos();
            base.ObtenerPerfil();
        }

        public FrmCatalogoFundamento(Fundamento fundamento,FrmAdquisiciones padre):this(padre)
        {
            FundamentoActual = fundamento;
            txtClave.Text = fundamento.CveFundamento.ToString();
            Consultar();
        }
        
        public override void BindearCampos()
        {
            txtClave.DataBindings.Add(new Binding("Text", bsSource, "CveFundamento", true));
            txtArticulo.DataBindings.Add(new Binding("Text", bsSource, "ArtiFundamento", true));
            txtInciso.DataBindings.Add(new Binding("Text", bsSource, "IncisoFundamento", true));
            txtFraccion.DataBindings.Add(new Binding("Text", bsSource, "FraccFundamento", true));
            txtDescripcion.DataBindings.Add(new Binding("Text", bsSource, "DesFundamento", true));

            txtClave.Text = FundamentoDao.SiguienteCveFundamento().ToString();
        }

        public override void Nuevo()
        {
            LimpiarValidacion();
            FundamentoActual = new Fundamento();
            bsSource.DataSource = FundamentoActual;
            txtClave.Enabled = true;
            cmdGuardar.Enabled = true;
            txtClave.Text = String.Empty;
            txtArticulo.Text = String.Empty;
            txtInciso.Text = String.Empty;
            txtFraccion.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtClave.Text = FundamentoDao.SiguienteCveFundamento().ToString();
            txtClave.Focus();
        }

        public override void Guardar()
        {
            try
            {
                if (Util.DatosValidos(FundamentoActual, lblNumErrors, listaError))
                {
                    FundamentoActual.FechaAlta = FundamentoDao.FechaServidor();
                    FundamentoActual.Estatus = "A";
                    FundamentoActual.IpTerminal = Util.IpTerminal();

                    var fundamentoExiste = FundamentoDao.Get(short.Parse(txtClave.Text));

                    if (fundamentoExiste == null)
                    {
                        FundamentoDao.Update(FundamentoActual);
                        XtraMessageBox.Show(@"Fundamento Registrado o Actualizado Exitosamente",
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(@"El fundamento ya existe, consultelo y actualize",
                         @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion del fundamento ",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Consultar()
        {
            try
            {
                FundamentoActual = FundamentoDao.Get(short.Parse(txtClave.Text));
                if (FundamentoActual != null)
                {
                    txtClave.Enabled = false;
                    bsSource.DataSource = FundamentoActual;
                }
                else
                {
                    XtraMessageBox.Show(@"No existe el fundamento",
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
    }
}