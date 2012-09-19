namespace Adquisiciones.View
{
    partial class FrmPanelControl
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
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.bsOrigen = new System.Windows.Forms.BindingSource(this.components);
            this.bsDestino = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckButton();
            this.txtConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDerecha = new DevExpress.XtraEditors.SimpleButton();
            this.lstDestino = new DevExpress.XtraEditors.ListBoxControl();
            this.lstOrigen = new DevExpress.XtraEditors.ListBoxControl();
            this.cmdOmitir = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaError = new System.Windows.Forms.ListBox();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtRfc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrentPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpUsuarioView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lstAlmacen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuarioView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(295, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuarios";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(441, 20);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(107, 23);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Usuario Activo";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(82, 149);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Properties.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmPass.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Confirmar:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(82, 115);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(152, 20);
            this.txtNewPass.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nueva:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.cmdIzquierda);
            this.groupBox1.Controls.Add(this.cmdDerecha);
            this.groupBox1.Controls.Add(this.lstDestino);
            this.groupBox1.Controls.Add(this.lstOrigen);
            this.groupBox1.Location = new System.Drawing.Point(13, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 492);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfiles";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(354, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Perfiles asignados";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Perfiles sin asignar";
            // 
            // cmdIzquierda
            // 
            this.cmdIzquierda.Location = new System.Drawing.Point(245, 190);
            this.cmdIzquierda.Name = "cmdIzquierda";
            this.cmdIzquierda.Size = new System.Drawing.Size(75, 23);
            this.cmdIzquierda.TabIndex = 14;
            this.cmdIzquierda.Text = "<";
            this.cmdIzquierda.Click += new System.EventHandler(this.CmdIzquierdaClick);
            // 
            // cmdDerecha
            // 
            this.cmdDerecha.Location = new System.Drawing.Point(245, 148);
            this.cmdDerecha.Name = "cmdDerecha";
            this.cmdDerecha.Size = new System.Drawing.Size(75, 23);
            this.cmdDerecha.TabIndex = 13;
            this.cmdDerecha.Text = ">";
            this.cmdDerecha.Click += new System.EventHandler(this.CmdDerechaClick);
            // 
            // lstDestino
            // 
            this.lstDestino.DataSource = this.bsDestino;
            this.lstDestino.Location = new System.Drawing.Point(354, 55);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.Size = new System.Drawing.Size(194, 402);
            this.lstDestino.TabIndex = 12;
            // 
            // lstOrigen
            // 
            this.lstOrigen.DataSource = this.bsOrigen;
            this.lstOrigen.Location = new System.Drawing.Point(17, 55);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(186, 402);
            this.lstOrigen.TabIndex = 6;
            // 
            // cmdOmitir
            // 
            this.cmdOmitir.Location = new System.Drawing.Point(205, 4);
            this.cmdOmitir.Name = "cmdOmitir";
            this.cmdOmitir.Size = new System.Drawing.Size(75, 23);
            this.cmdOmitir.TabIndex = 18;
            this.cmdOmitir.Text = "Omitir";
            this.cmdOmitir.Click += new System.EventHandler(this.CmdOmitirClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaError);
            this.groupBox2.Controls.Add(this.lblNumErrors);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.txtRfc);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.txtCurrentPass);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.cmdGuardarUsuario);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Controls.Add(this.chkActivo);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtConfirmPass);
            this.groupBox2.Location = new System.Drawing.Point(13, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contraseña";
            // 
            // listaError
            // 
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.Location = new System.Drawing.Point(245, 99);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(294, 69);
            this.listaError.TabIndex = 27;
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Location = new System.Drawing.Point(249, 84);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(0, 13);
            this.lblNumErrors.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Nombre:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(82, 17);
            this.txtRfc.Mask = "LLLL000000";
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(72, 21);
            this.txtRfc.TabIndex = 1;
            this.txtRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "RFC:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(82, 81);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Properties.PasswordChar = '*';
            this.txtCurrentPass.Size = new System.Drawing.Size(152, 20);
            this.txtCurrentPass.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Actual:";
            // 
            // cmdGuardarUsuario
            // 
            this.cmdGuardarUsuario.Location = new System.Drawing.Point(441, 49);
            this.cmdGuardarUsuario.Name = "cmdGuardarUsuario";
            this.cmdGuardarUsuario.Size = new System.Drawing.Size(107, 37);
            this.cmdGuardarUsuario.TabIndex = 18;
            this.cmdGuardarUsuario.Text = "Guardar Usuario";
            this.cmdGuardarUsuario.Click += new System.EventHandler(this.CmdGuardarUsuarioClick);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(286, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 19;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
            // 
            // searchLookUpUsuario
            // 
            this.searchLookUpUsuario.EditValue = "<Null>";
            this.searchLookUpUsuario.Location = new System.Drawing.Point(342, 31);
            this.searchLookUpUsuario.Name = "searchLookUpUsuario";
            this.searchLookUpUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpUsuario.Properties.DataSource = this.bsUsuarios;
            this.searchLookUpUsuario.Properties.DisplayMember = "Nombre";
            this.searchLookUpUsuario.Properties.ValueMember = "IdUsuario";
            this.searchLookUpUsuario.Properties.View = this.searchLookUpUsuarioView;
            this.searchLookUpUsuario.Size = new System.Drawing.Size(281, 20);
            this.searchLookUpUsuario.TabIndex = 20;
            this.searchLookUpUsuario.EditValueChanged += new System.EventHandler(this.LstUsuarioEditValueChanged);
            // 
            // searchLookUpUsuarioView
            // 
            this.searchLookUpUsuarioView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.searchLookUpUsuarioView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpUsuarioView.Name = "searchLookUpUsuarioView";
            this.searchLookUpUsuarioView.OptionsBehavior.Editable = false;
            this.searchLookUpUsuarioView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpUsuarioView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "RFC";
            this.gridColumn1.FieldName = "Rfc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 384;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 368;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estatus";
            this.gridColumn3.FieldName = "Estatus";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(367, 4);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 21;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Click += new System.EventHandler(this.SimpleButton1Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(97, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Seleccionar Almacen";
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.Items.AddRange(new object[] {
            "",
            "C2",
            "C5",
            "P2",
            "P5"});
            this.lstAlmacen.Location = new System.Drawing.Point(115, 33);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(165, 21);
            this.lstAlmacen.TabIndex = 28;
            this.lstAlmacen.SelectedIndexChanged += new System.EventHandler(this.LstAlmacenSelectedIndexChanged);
            // 
            // FrmPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 705);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.searchLookUpUsuario);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdOmitir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmPanelControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPanelControlFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuarioView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsOrigen;
        private System.Windows.Forms.BindingSource bsDestino;
        private System.Windows.Forms.BindingSource bsUsuarios;
        private DevExpress.XtraEditors.CheckButton chkActivo;
        private DevExpress.XtraEditors.TextEdit txtConfirmPass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton cmdOmitir;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdIzquierda;
        private DevExpress.XtraEditors.SimpleButton cmdDerecha;
        private DevExpress.XtraEditors.ListBoxControl lstDestino;
        private DevExpress.XtraEditors.ListBoxControl lstOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarUsuario;
        private DevExpress.XtraEditors.TextEdit txtCurrentPass;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox txtRfc;
        private System.Windows.Forms.ListBox listaError;
        private System.Windows.Forms.Label lblNumErrors;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpUsuarioView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton cmdEliminar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox lstAlmacen;
    }
}