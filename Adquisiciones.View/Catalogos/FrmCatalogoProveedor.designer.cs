using System.Windows.Forms;

namespace Adquisiciones.View.Catalogos
{
    partial class FrmCatalogoProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.txtRnombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtRmaterno = new System.Windows.Forms.TextBox();
            this.txtRpaterno = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtDelegacion = new System.Windows.Forms.TextBox();
            this.txtNombreFiscal = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblMaterno2 = new System.Windows.Forms.Label();
            this.lblPaterno2 = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTel3 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDelegacion = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblComercial = new System.Windows.Forms.Label();
            this.lblFiscal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.NumericUpDown();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoP = new System.Windows.Forms.MaskedTextBox();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtRfc = new System.Windows.Forms.MaskedTextBox();
            this.listaError = new System.Windows.Forms.ListBox();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(643, 219);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(188, 20);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(249, 454);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(562, 69);
            this.txtObservaciones.TabIndex = 23;
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(249, 428);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(329, 20);
            this.txtGiro.TabIndex = 22;
            this.txtGiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtRnombre
            // 
            this.txtRnombre.Location = new System.Drawing.Point(296, 402);
            this.txtRnombre.Name = "txtRnombre";
            this.txtRnombre.Size = new System.Drawing.Size(209, 20);
            this.txtRnombre.TabIndex = 21;
            this.txtRnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(675, 328);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(156, 20);
            this.txtCorreo.TabIndex = 18;
            // 
            // txtRmaterno
            // 
            this.txtRmaterno.Location = new System.Drawing.Point(571, 375);
            this.txtRmaterno.Name = "txtRmaterno";
            this.txtRmaterno.Size = new System.Drawing.Size(209, 20);
            this.txtRmaterno.TabIndex = 20;
            this.txtRmaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtRpaterno
            // 
            this.txtRpaterno.Location = new System.Drawing.Point(296, 376);
            this.txtRpaterno.Name = "txtRpaterno";
            this.txtRpaterno.Size = new System.Drawing.Size(209, 20);
            this.txtRpaterno.TabIndex = 19;
            this.txtRpaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(249, 168);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(474, 20);
            this.txtCalle.TabIndex = 7;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(249, 194);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(474, 20);
            this.txtColonia.TabIndex = 8;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(249, 139);
            this.txtNombreComercial.MaxLength = 100;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(474, 20);
            this.txtNombreComercial.TabIndex = 6;
            this.txtNombreComercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(327, 83);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(617, 53);
            this.txtMaterno.MaxLength = 50;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(209, 20);
            this.txtMaterno.TabIndex = 3;
            this.txtMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(249, 258);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(141, 20);
            this.txtPais.TabIndex = 11;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtDelegacion
            // 
            this.txtDelegacion.Location = new System.Drawing.Point(249, 222);
            this.txtDelegacion.Name = "txtDelegacion";
            this.txtDelegacion.Size = new System.Drawing.Size(229, 20);
            this.txtDelegacion.TabIndex = 9;
            this.txtDelegacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtNombreFiscal
            // 
            this.txtNombreFiscal.Location = new System.Drawing.Point(249, 110);
            this.txtNombreFiscal.MaxLength = 100;
            this.txtNombreFiscal.Name = "txtNombreFiscal";
            this.txtNombreFiscal.Size = new System.Drawing.Size(474, 20);
            this.txtNombreFiscal.TabIndex = 5;
            this.txtNombreFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(327, 53);
            this.txtPaterno.MaxLength = 50;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(209, 20);
            this.txtPaterno.TabIndex = 2;
            this.txtPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(122, 457);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 71;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Giro o actividad";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(246, 403);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 69;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblMaterno2
            // 
            this.lblMaterno2.AutoSize = true;
            this.lblMaterno2.Location = new System.Drawing.Point(510, 379);
            this.lblMaterno2.Name = "lblMaterno2";
            this.lblMaterno2.Size = new System.Drawing.Size(46, 13);
            this.lblMaterno2.TabIndex = 68;
            this.lblMaterno2.Text = "Materno";
            // 
            // lblPaterno2
            // 
            this.lblPaterno2.AutoSize = true;
            this.lblPaterno2.Location = new System.Drawing.Point(246, 379);
            this.lblPaterno2.Name = "lblPaterno2";
            this.lblPaterno2.Size = new System.Drawing.Size(44, 13);
            this.lblPaterno2.TabIndex = 67;
            this.lblPaterno2.Text = "Paterno";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Location = new System.Drawing.Point(122, 379);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(103, 13);
            this.lblRepresentante.TabIndex = 66;
            this.lblRepresentante.Text = "Repesentante Legal";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(608, 331);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 65;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTel3
            // 
            this.lblTel3.AutoSize = true;
            this.lblTel3.Location = new System.Drawing.Point(122, 331);
            this.lblTel3.Name = "lblTel3";
            this.lblTel3.Size = new System.Drawing.Size(58, 13);
            this.lblTel3.TabIndex = 64;
            this.lblTel3.Text = "Teléfono 3";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(608, 296);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(58, 13);
            this.lblTel2.TabIndex = 63;
            this.lblTel2.Text = "Teléfono 2";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTel1.Location = new System.Drawing.Point(407, 296);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(58, 13);
            this.lblTel1.TabIndex = 62;
            this.lblTel1.Text = "Teléfono 1";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(447, 331);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 61;
            this.lblFax.Text = "Fax";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRfc.Location = new System.Drawing.Point(124, 296);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(28, 13);
            this.lblRfc.TabIndex = 60;
            this.lblRfc.Text = "RFC";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCodigo.Location = new System.Drawing.Point(541, 261);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(72, 13);
            this.lblCodigo.TabIndex = 59;
            this.lblCodigo.Text = "Código Postal";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPais.Location = new System.Drawing.Point(124, 261);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 58;
            this.lblPais.Text = "País";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEstado.Location = new System.Drawing.Point(541, 222);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 57;
            this.lblEstado.Text = "Estado";
            // 
            // lblDelegacion
            // 
            this.lblDelegacion.AutoSize = true;
            this.lblDelegacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDelegacion.Location = new System.Drawing.Point(124, 229);
            this.lblDelegacion.Name = "lblDelegacion";
            this.lblDelegacion.Size = new System.Drawing.Size(61, 13);
            this.lblDelegacion.TabIndex = 56;
            this.lblDelegacion.Text = "Delegación";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblColonia.Location = new System.Drawing.Point(124, 200);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(42, 13);
            this.lblColonia.TabIndex = 55;
            this.lblColonia.Text = "Colonia";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCalle.Location = new System.Drawing.Point(124, 171);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(66, 13);
            this.lblCalle.TabIndex = 54;
            this.lblCalle.Text = "Calle y Núm.";
            // 
            // lblComercial
            // 
            this.lblComercial.AutoSize = true;
            this.lblComercial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblComercial.Location = new System.Drawing.Point(124, 142);
            this.lblComercial.Name = "lblComercial";
            this.lblComercial.Size = new System.Drawing.Size(93, 13);
            this.lblComercial.TabIndex = 53;
            this.lblComercial.Text = "Nombre Comercial";
            // 
            // lblFiscal
            // 
            this.lblFiscal.AutoSize = true;
            this.lblFiscal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFiscal.Location = new System.Drawing.Point(124, 113);
            this.lblFiscal.Name = "lblFiscal";
            this.lblFiscal.Size = new System.Drawing.Size(74, 13);
            this.lblFiscal.TabIndex = 52;
            this.lblFiscal.Text = "Nombre Fiscal";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombre.Location = new System.Drawing.Point(277, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaterno.Location = new System.Drawing.Point(565, 56);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(46, 13);
            this.lblMaterno.TabIndex = 50;
            this.lblMaterno.Text = "Materno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPaterno.Location = new System.Drawing.Point(277, 56);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(44, 13);
            this.lblPaterno.TabIndex = 49;
            this.lblPaterno.Text = "Paterno";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProveedor.Location = new System.Drawing.Point(124, 56);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 48;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(186, 53);
            this.txtClave.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(70, 20);
            this.txtClave.TabIndex = 95;
            this.txtClave.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(477, 293);
            this.txtTel.Mask = "00000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 20);
            this.txtTel.TabIndex = 14;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(643, 253);
            this.txtCodigoP.Mask = "00000";
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(188, 20);
            this.txtCodigoP.TabIndex = 12;
            this.txtCodigoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(675, 293);
            this.txtTel2.Mask = "00000000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(156, 20);
            this.txtTel2.TabIndex = 15;
            this.txtTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtTel3
            // 
            this.txtTel3.Location = new System.Drawing.Point(249, 324);
            this.txtTel3.Mask = "00000000";
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Size = new System.Drawing.Size(141, 20);
            this.txtTel3.TabIndex = 16;
            this.txtTel3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(477, 324);
            this.txtFax.Mask = "00000000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(125, 20);
            this.txtFax.TabIndex = 17;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(249, 293);
            this.txtRfc.Mask = "LLLL000000LL0";
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(141, 20);
            this.txtRfc.TabIndex = 13;
            this.txtRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // listaError
            // 
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(128, 570);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(387, 100);
            this.listaError.TabIndex = 96;
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(132, 554);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 97;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(523, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "Los campos marcados en azul son obligatorios";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.reportes;
            this.btnNuevo.Location = new System.Drawing.Point(523, 572);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 95);
            this.btnNuevo.TabIndex = 99;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnGuardar.Location = new System.Drawing.Point(665, 572);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 95);
            this.btnGuardar.TabIndex = 100;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Adquisiciones.View.Properties.Resources.search;
            this.btnConsultar.Location = new System.Drawing.Point(798, 572);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 95);
            this.btnConsultar.TabIndex = 101;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
            // 
            // FrmCatalogoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(975, 727);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel3);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.txtRnombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRmaterno);
            this.Controls.Add(this.txtRpaterno);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtDelegacion);
            this.Controls.Add(this.txtNombreFiscal);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblMaterno2);
            this.Controls.Add(this.lblPaterno2);
            this.Controls.Add(this.lblRepresentante);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTel3);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblRfc);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDelegacion);
            this.Controls.Add(this.lblColonia);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblComercial);
            this.Controls.Add(this.lblFiscal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblProveedor);
            this.Name = "FrmCatalogoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.TextBox txtRnombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtRmaterno;
        private System.Windows.Forms.TextBox txtRpaterno;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtDelegacion;
        private System.Windows.Forms.TextBox txtNombreFiscal;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblMaterno2;
        private System.Windows.Forms.Label lblPaterno2;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTel3;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDelegacion;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblComercial;
        private System.Windows.Forms.Label lblFiscal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.NumericUpDown txtClave;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCodigoP;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel3;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtRfc;
        private System.Windows.Forms.ListBox listaError;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsProveedor;

        /// <summary>
        /// Enlaza las propiedades del POCO con los controles para ya no realizar operaciones
        /// setter's y getter's
        /// </summary>
        private void BindarCampos()
        {

            //txtClave.DataBindings.Add(new Binding("Value", bsProveedor, "CveProveedor",true));
            txtPaterno.DataBindings.Add(new Binding("Text", bsProveedor, "Paterno",true));
            txtMaterno.DataBindings.Add(new Binding("Text", bsProveedor, "Materno",true));
            txtNombre.DataBindings.Add(new Binding("Text", bsProveedor, "Nombre",true));
            txtNombreFiscal.DataBindings.Add(new Binding("Text", bsProveedor, "NombreFiscal",true));
            txtNombreComercial.DataBindings.Add(new Binding("Text", bsProveedor, "NombreComercial",true));
            txtCalle.DataBindings.Add(new Binding("Text", bsProveedor, "Calle",true));
            txtColonia.DataBindings.Add(new Binding("Text", bsProveedor, "Colonia",true));
            txtDelegacion.DataBindings.Add(new Binding("Text",ProveedorActual,"Delegacion",true));
            txtEstado.DataBindings.Add(new Binding("Text", bsProveedor, "Estado",true));
            txtPais.DataBindings.Add(new Binding("Text", bsProveedor, "Pais",true));
            txtCodigoP.DataBindings.Add(new Binding("Text", bsProveedor, "CodigoP",true));
            txtRfc.DataBindings.Add(new Binding("Text", bsProveedor, "Rfc",true));
            txtTel.DataBindings.Add(new Binding("Text", bsProveedor, "Tel",true));
            txtTel2.DataBindings.Add(new Binding("Text", bsProveedor, "Tel2",true));
            txtTel3.DataBindings.Add(new Binding("Text", bsProveedor, "Tel3",true));
            txtFax.DataBindings.Add(new Binding("Text", bsProveedor, "Fax",true));
            txtCorreo.DataBindings.Add(new Binding("Text", bsProveedor, "Correo",true));
            txtRnombre.DataBindings.Add(new Binding("Text", bsProveedor, "RNombre",true));
            txtRpaterno.DataBindings.Add(new Binding("Text", bsProveedor, "RPaterno",true));
            txtRmaterno.DataBindings.Add(new Binding("Text", bsProveedor, "RMaterno",true));
            txtGiro.DataBindings.Add(new Binding("Text", bsProveedor, "Giro",true));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsProveedor, "Observacion",true));

            bsProveedor.DataSource = ProveedorActual;

        }

        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
    }
}