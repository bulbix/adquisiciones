using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using ComboBox = System.Windows.Forms.ComboBox;


namespace ctlTipoProcedimiento
{
    public partial class ctlTipoProcedimiento: UserControl
    {
        public string[] Fracciones =
        {
            "I","II","III","IV","V","VI","VII","VIII","IX","X","XI","XII","XIII",
            "XIV","XV","XVI","XVII","XVIII","XIX","XX"
        };

        public string[] Numeros =
        {
            "1ra", "2da", "3ra", "4ta", "5ta", "6ta", "7ma", "8va", "9na", "10ma",
            "11ra", "12da", "13ra", "14ta", "15ta", "16ta", "17ma", "18va", "19na", "20ma"
        };



        private IPedidoService service;

        private TipoProcedimiento _tipoProcedimiento = new TipoProcedimiento();

        private CatTipopedido _tipoPedido  = new CatTipopedido();


        public ctlTipoProcedimiento()
        {
            InitializeComponent();
            try
            {
                var ctx = ContextRegistry.GetContext();
                service = ctx["pedidoService"] as IPedidoService;
            }
            catch (Exception e)
            {
            }
        }

        private void ClearCombos(int numeroCombo)
        {
            for(var index=numeroCombo+1;index<=9;index++)
            {
                foreach(var control in this.Controls)
                {
                    if (control is ComboBox)
                    {
                        var combo = control as ComboBox;
                        if (combo.Name == "cb" + index)
                        {
                            combo.DataSource = null;
                        }
                    }
                    
                }
                
            }

        }

        private void DisplayControles(int numeroCombo, int numeroTexto, bool visible)
        {
           foreach (var control in this.Controls){
               if (control is ComboBox)
               {
                   var combo = control as ComboBox;

                   for (var index = numeroCombo + 1; index <= 9; index++)
                   {
                       if (combo.Name == "cb" + index)
                       {
                           combo.Visible = visible;
                       }
                   }

                   for (var index = numeroTexto; index <= 5; index++)
                   {
                       if (numeroTexto == 1)//Num de Licitacion
                           txt1.Visible = false;

                       if (combo.Name == "txt" + index)
                       {
                           combo.Visible = false;
                       }
                   }
               }

            }
            
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(1);
            if (cb1.SelectedValue != null)
            {
                DisplayControles(0,1,true);
                service.
                CatalogoTipoProcedimiento(cb2, "Bloque2", TipoPedido, condicionColumn: "Bloque1", condicionValor: cb1.SelectedValue.ToString());
                
            }
           
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(2);
            if (cb2.SelectedValue != null)
            {
                DisplayControles(0, 1, true);

                if (!cb2.SelectedValue.ToString().StartsWith("Art.")){
                    txt1.Visible = true;
                }

                service.CatalogoTipoProcedimiento(cb3, "Bloque3", TipoPedido, condicionColumn: "Bloque2", condicionValor: cb2.SelectedValue.ToString());
            }

        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(3);
            if (cb3.SelectedValue != null)
            {
                if (cb3.SelectedValue.ToString().Equals("Ninguno") || cb3.SelectedValue.ToString().Equals("Renglon Desierto") || cb3.SelectedValue.ToString().Equals("por monto de la actuacion"))
                {
                    DisplayControles(3,2,false);
                }
                else
                {
                    DisplayControles(0, 2, true);

                    if (cb3.SelectedValue.ToString().Equals("Fracc.")){
                        txt2.Visible = true;
                        txt2.Items.Clear();
                        txt2.Items.AddRange(Fracciones);
                    }

                    service.CatalogoTipoProcedimiento(cb4, "Bloque4", TipoPedido, condicionColumn: "Bloque3", condicionValor: cb3.SelectedValue.ToString());
                }

            }
            

        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(4);
            if (cb4.SelectedValue != null)
            {
                DisplayControles(0, 3, true);

                if (cb4.SelectedValue.ToString().Equals("Numero")){
                    txt3.Visible = true;
                    txt3.Items.Clear();
                    txt3.Items.AddRange(Numeros);
                }

                service.CatalogoTipoProcedimiento(cb5, "Bloque5", TipoPedido, condicionColumn: "Bloque4", condicionValor: cb4.SelectedValue.ToString());
                
            }
            

        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(5);
            if (cb5.SelectedValue != null)
            {
                if (cb5.SelectedValue.ToString().Equals("entrega."))
                {
                    DisplayControles(5,4, false);
                }
                else
                {
                    DisplayControles(0, 4, true);

                    if (cb5.SelectedValue.ToString().Equals("Numero") || cb5.SelectedValue.ToString().Equals("Fracc.")){
                        txt4.Visible = true;
                        txt4.Items.Clear();
                        if (cb5.SelectedValue.ToString().Equals("Numero"))
                            txt4.Items.AddRange(Numeros);
                        else
                            txt4.Items.AddRange(Fracciones);
                    }

                    service.CatalogoTipoProcedimiento(cb6, "Bloque6", TipoPedido, condicionColumn: "Bloque5", condicionValor: cb5.SelectedValue.ToString());
                }


            }
            
        }

        private void cb6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(6);
            if (cb6.SelectedValue != null)
            {
                if (cb6.SelectedValue.ToString().Equals("sesion del Comite de Adquisiciones"))
                {
                    DisplayControles(6,5,false);
                }
                else
                {
                    DisplayControles(0, 5, true);
                    service.CatalogoTipoProcedimiento(cb7, "Bloque7", TipoPedido, condicionColumn: "Bloque6", condicionValor: cb6.SelectedValue.ToString());
                }

            }
            

        }

        private void cb7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(7);
            if (cb7.SelectedValue != null)
            {
                DisplayControles(0, 5, true);
                service.CatalogoTipoProcedimiento(cb8, "Bloque8", TipoPedido, condicionColumn: "Bloque7", condicionValor: cb7.SelectedValue.ToString());
            }
        }

        private void cb8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCombos(8);
            if (cb8.SelectedValue != null)
            {
                DisplayControles(0, 5, true);
                txt5.Visible = true;
                txt5.Items.Clear();
                txt5.Items.AddRange(Numeros);
                service.CatalogoTipoProcedimiento(cb9, "Bloque9", TipoPedido, condicionColumn: "Bloque8", condicionValor: cb8.SelectedValue.ToString());
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public TipoProcedimiento Tipoprocedimiento {
            get
            {
                return _tipoProcedimiento;
            }
            set
            {
                _tipoProcedimiento = value;
                CargarSeleccion(_tipoProcedimiento);
            }
        }

        public CatTipopedido TipoPedido
        {
            get
            {
                return _tipoPedido;
            }
            set
            {
                try
                {
                    _tipoPedido = value;

                    if (_tipoPedido != null)
                    {
                        service.CatalogoTipoProcedimiento(cb1, "Bloque1", _tipoPedido);
                        service.CatalogoTipoProcedimiento(cb2, "Bloque2", _tipoPedido,
                            "Bloque1", cb1.SelectedValue.ToString());
                        cb1.SelectedIndex = cb1.FindStringExact("Licitación Publica Nacional");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            var bloquesNombre = new string[] {"Bloque1","Bloque2","Bloque3","Bloque4","Bloque5",
                "Bloque6","Bloque7","Bloque8","Bloque9"};

            var bloquesValor = new object[]
            {
                cb1.SelectedValue, cb2.SelectedValue, cb3.SelectedValue, cb4.SelectedValue, cb5.SelectedValue,
                cb6.SelectedValue, cb7.SelectedValue, cb8.SelectedValue, cb9.SelectedValue
            };

            var catalogo =
            service.PedidoDao.CatTipoprocedimientoByBloques(bloquesNombre, bloquesValor);

            string fraccion = null, numero = null, num_licitacion=null;

            bool error = false;

            if ((catalogo.Id >= 1 && catalogo.Id <= 6) || (catalogo.Id >= 11 && catalogo.Id <= 13))
            {
                string pattern = "\\d{3}-\\d{4}";
                if (!Regex.IsMatch(txt1.Text, pattern))
                    error = true;

                num_licitacion = txt1.Text;
            }

            switch (catalogo.Id)
            {
                case 2:
                case 4:
                    if (txt4.Text.Length == 0 || txt5.Text.Length == 0)
                        error = true;
                    fraccion = txt4.Text;
                    numero = txt5.Text;
                    break;
                case 5:
                case 6:
                    if (txt3.Text.Length == 0)
                        error = true;
                    numero = txt3.Text;
                    break;
                case 7:

                    if (txt2.Text.Length == 0 || txt4.Text.Length == 0)
                        error = true;

                    fraccion = txt2.Text;
                    numero = txt4.Text;
                    break;
            }

            if (!error)
            {
                var tipoProcedimiento = new TipoProcedimiento()
                {
                    Catalogo = catalogo,
                    Fraccion = fraccion,
                    NumLicitacion = num_licitacion,
                    NumOrdinal = numero
                };

                _tipoProcedimiento = tipoProcedimiento;
                this.Visible = false;
            }
            else
            {
                _tipoProcedimiento = new TipoProcedimiento();
                XtraMessageBox.Show(@"Faltan completar campos",
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarSeleccion(TipoProcedimiento tipoProcedimiento)
        {
            if (tipoProcedimiento == null || tipoProcedimiento.Catalogo == null)
                return;

            var catalogo = tipoProcedimiento.Catalogo;

            try
            {
                service.CatalogoTipoProcedimiento(cb1, "Bloque1", TipoPedido);
                service.CatalogoTipoProcedimiento(cb2, "Bloque2", TipoPedido, condicionColumn: "Bloque1", condicionValor: catalogo.Bloque1);
                service.CatalogoTipoProcedimiento(cb3, "Bloque3", TipoPedido, condicionColumn: "Bloque2", condicionValor: catalogo.Bloque2);
                service.CatalogoTipoProcedimiento(cb4, "Bloque4", TipoPedido, condicionColumn: "Bloque3", condicionValor: catalogo.Bloque3);
                service.CatalogoTipoProcedimiento(cb5, "Bloque5", TipoPedido, condicionColumn: "Bloque4", condicionValor: catalogo.Bloque4);
                service.CatalogoTipoProcedimiento(cb6, "Bloque6", TipoPedido, condicionColumn: "Bloque5", condicionValor: catalogo.Bloque5);
                service.CatalogoTipoProcedimiento(cb7, "Bloque7", TipoPedido, condicionColumn: "Bloque6", condicionValor: catalogo.Bloque6);
                service.CatalogoTipoProcedimiento(cb8, "Bloque8", TipoPedido, condicionColumn: "Bloque7", condicionValor: catalogo.Bloque7);
                service.CatalogoTipoProcedimiento(cb9, "Bloque9", TipoPedido, condicionColumn: "Bloque8", condicionValor: catalogo.Bloque8);

                cb1.SelectedIndex = cb1.FindStringExact(catalogo.Bloque1);
                cb2.SelectedIndex = cb2.FindStringExact(catalogo.Bloque2);
                cb3.SelectedIndex = cb3.FindStringExact(catalogo.Bloque3);
                cb4.SelectedIndex = cb4.FindStringExact(catalogo.Bloque4);
                cb5.SelectedIndex = cb5.FindStringExact(catalogo.Bloque5);
                cb6.SelectedIndex = cb6.FindStringExact(catalogo.Bloque6);
                cb7.SelectedIndex = cb7.FindStringExact(catalogo.Bloque7);
                cb8.SelectedIndex = cb8.FindStringExact(catalogo.Bloque8);
                cb9.SelectedIndex = cb9.FindStringExact(catalogo.Bloque9);
            }
            catch(Exception e){}

            txt1.Text = tipoProcedimiento.NumLicitacion;

            switch (catalogo.Id)
            {
                case 2:
                case 4:
                    txt4.Text = tipoProcedimiento.Fraccion;
                    txt5.Text = tipoProcedimiento.NumOrdinal;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    break;
                case 5:
                case 6:
                    txt3.Text = tipoProcedimiento.NumOrdinal;
                    txt3.Visible = true;
                    break;
                case 7:
                    txt2.Text = tipoProcedimiento.Fraccion;
                    txt4.Text = tipoProcedimiento.NumOrdinal;
                    txt4.Visible = true;
                    txt2.Visible = true;
                    break;
            }

        }

        private void ctlTipoProcedimiento_Load(object sender, EventArgs e)
        {
           

        }
    }
}
