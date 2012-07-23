using System;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Catalogos
{
    ///<summary>
    ///</summary>
    /// 
    /// 
    public partial class FrmCatalogoFundamento : Form
    {
        ///<summary>
        ///</summary>
        public IFundamentoDao FundamentoDao { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Fundamento FundamentoActual = new Fundamento();

        /// <summary>
        /// 
        /// </summary>
        public FrmCatalogoFundamento()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            FundamentoDao = ctx["fundamentoDao"] as IFundamentoDao;

            Nuevo();

            //bindear campos
            txtClave.DataBindings.Add(new Binding("Text", bsFundamento, "CveFundamento",true));
            txtArticulo.DataBindings.Add(new Binding("Text", bsFundamento, "ArtiFundamento",true));
            txtInciso.DataBindings.Add(new Binding("Text", bsFundamento, "IncisoFundamento",true));
            txtFraccion.DataBindings.Add(new Binding("Text", bsFundamento, "FraccFundamento",true));
            txtDescripcion.DataBindings.Add(new Binding("Text", bsFundamento, "DesFundamento",true));

            txtClave.Text = FundamentoDao.SiguienteCveFundamento().ToString();}

        /// <summary>
        /// 
        /// </summary>
        private void Nuevo()
        {
            listaError.Items.Clear();
            lblNumErrors.Text = @"0 Errores";
            FundamentoActual = new Fundamento();
            bsFundamento.DataSource = FundamentoActual;
            txtClave.Enabled = true;
            btnGuardar.Enabled = true;
            txtClave.Text = String.Empty;
            txtArticulo.Text = String.Empty;
            txtInciso.Text = String.Empty;
            txtFraccion.Text = String.Empty;
            txtDescripcion.Text = String.Empty;

            txtClave.Text = FundamentoDao.SiguienteCveFundamento().ToString();

            txtClave.Focus();
        }

        private void BtnGuardarClick(object sender, EventArgs e)
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
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion del fundamento " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnConsultarClick(object sender, EventArgs e)
        {
            try
            {
                FundamentoActual = FundamentoDao.Get(short.Parse(txtClave.Text));
                if (FundamentoActual != null)
                {
                    txtClave.Enabled = false;
                    bsFundamento.DataSource = FundamentoActual;
                }
                else
                {
                    XtraMessageBox.Show(@"No existe el fundamento",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta" + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            Nuevo();
        }


    }
}
