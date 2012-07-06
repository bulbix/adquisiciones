using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.View
{
    partial class FrmAnexo
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
            this.lbllicitacion = new System.Windows.Forms.Label();
            this.txtnumlicitacion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInstituto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lbltipolicitacion = new System.Windows.Forms.Label();
            this.lblTechopresupuestal = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.txtDesanexo = new System.Windows.Forms.TextBox();
            this.txtTechopresupuestal = new System.Windows.Forms.TextBox();
            this.gpbdatosgenerales = new System.Windows.Forms.GroupBox();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.dtpFechaanexo = new System.Windows.Forms.DateTimePicker();
            this.cbxTipolicitacion = new System.Windows.Forms.ComboBox();
            this.cbxInstituto = new System.Windows.Forms.ComboBox();
            this.dgvAnexo = new System.Windows.Forms.DataGridView();
            this.bsAnexoDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bsAnexo = new System.Windows.Forms.BindingSource(this.components);
            this.listaError = new System.Windows.Forms.ListBox();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.gpbdatosgenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllicitacion
            // 
            this.lbllicitacion.AutoSize = true;
            this.lbllicitacion.Location = new System.Drawing.Point(6, 25);
            this.lbllicitacion.Name = "lbllicitacion";
            this.lbllicitacion.Size = new System.Drawing.Size(52, 13);
            this.lbllicitacion.TabIndex = 0;
            this.lbllicitacion.Text = "Licitacion";
            // 
            // txtnumlicitacion
            // 
            this.txtnumlicitacion.Location = new System.Drawing.Point(105, 19);
            this.txtnumlicitacion.Name = "txtnumlicitacion";
            this.txtnumlicitacion.Size = new System.Drawing.Size(176, 20);
            this.txtnumlicitacion.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(336, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblInstituto
            // 
            this.lblInstituto.AutoSize = true;
            this.lblInstituto.Location = new System.Drawing.Point(551, 21);
            this.lblInstituto.Name = "lblInstituto";
            this.lblInstituto.Size = new System.Drawing.Size(44, 13);
            this.lblInstituto.TabIndex = 3;
            this.lblInstituto.Text = "Instituto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lbltipolicitacion
            // 
            this.lbltipolicitacion.AutoSize = true;
            this.lbltipolicitacion.Location = new System.Drawing.Point(6, 83);
            this.lbltipolicitacion.Name = "lbltipolicitacion";
            this.lbltipolicitacion.Size = new System.Drawing.Size(91, 13);
            this.lbltipolicitacion.TabIndex = 5;
            this.lbltipolicitacion.Text = "Tipo de Licitación";
            // 
            // lblTechopresupuestal
            // 
            this.lblTechopresupuestal.AutoSize = true;
            this.lblTechopresupuestal.Location = new System.Drawing.Point(336, 83);
            this.lblTechopresupuestal.Name = "lblTechopresupuestal";
            this.lblTechopresupuestal.Size = new System.Drawing.Size(102, 13);
            this.lblTechopresupuestal.TabIndex = 6;
            this.lblTechopresupuestal.Text = "Techo Presupuestal";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Location = new System.Drawing.Point(625, 83);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(35, 13);
            this.lbliva.TabIndex = 7;
            this.lbliva.Text = "% IVA";
            // 
            // txtDesanexo
            // 
            this.txtDesanexo.Location = new System.Drawing.Point(105, 50);
            this.txtDesanexo.Name = "txtDesanexo";
            this.txtDesanexo.Size = new System.Drawing.Size(613, 20);
            this.txtDesanexo.TabIndex = 8;
            // 
            // txtTechopresupuestal
            // 
            this.txtTechopresupuestal.Location = new System.Drawing.Point(444, 80);
            this.txtTechopresupuestal.Name = "txtTechopresupuestal";
            this.txtTechopresupuestal.Size = new System.Drawing.Size(116, 20);
            this.txtTechopresupuestal.TabIndex = 9;
            // 
            // gpbdatosgenerales
            // 
            this.gpbdatosgenerales.Controls.Add(this.cbxIva);
            this.gpbdatosgenerales.Controls.Add(this.dtpFechaanexo);
            this.gpbdatosgenerales.Controls.Add(this.cbxTipolicitacion);
            this.gpbdatosgenerales.Controls.Add(this.cbxInstituto);
            this.gpbdatosgenerales.Controls.Add(this.lblFecha);
            this.gpbdatosgenerales.Controls.Add(this.lbllicitacion);
            this.gpbdatosgenerales.Controls.Add(this.txtTechopresupuestal);
            this.gpbdatosgenerales.Controls.Add(this.txtnumlicitacion);
            this.gpbdatosgenerales.Controls.Add(this.txtDesanexo);
            this.gpbdatosgenerales.Controls.Add(this.lblInstituto);
            this.gpbdatosgenerales.Controls.Add(this.lbliva);
            this.gpbdatosgenerales.Controls.Add(this.lblDescripcion);
            this.gpbdatosgenerales.Controls.Add(this.lblTechopresupuestal);
            this.gpbdatosgenerales.Controls.Add(this.lbltipolicitacion);
            this.gpbdatosgenerales.Location = new System.Drawing.Point(12, 12);
            this.gpbdatosgenerales.Name = "gpbdatosgenerales";
            this.gpbdatosgenerales.Size = new System.Drawing.Size(733, 116);
            this.gpbdatosgenerales.TabIndex = 11;
            this.gpbdatosgenerales.TabStop = false;
            this.gpbdatosgenerales.Text = "Datos Generales Anexo";
            // 
            // cbxIva
            // 
            this.cbxIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(681, 80);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(37, 21);
            this.cbxIva.TabIndex = 18;
            // 
            // dtpFechaanexo
            // 
            this.dtpFechaanexo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaanexo.Location = new System.Drawing.Point(405, 19);
            this.dtpFechaanexo.Name = "dtpFechaanexo";
            this.dtpFechaanexo.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaanexo.TabIndex = 17;
            // 
            // cbxTipolicitacion
            // 
            this.cbxTipolicitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipolicitacion.FormattingEnabled = true;
            this.cbxTipolicitacion.Location = new System.Drawing.Point(105, 79);
            this.cbxTipolicitacion.Name = "cbxTipolicitacion";
            this.cbxTipolicitacion.Size = new System.Drawing.Size(114, 21);
            this.cbxTipolicitacion.TabIndex = 16;
            // 
            // cbxInstituto
            // 
            this.cbxInstituto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInstituto.FormattingEnabled = true;
            this.cbxInstituto.Location = new System.Drawing.Point(602, 16);
            this.cbxInstituto.Name = "cbxInstituto";
            this.cbxInstituto.Size = new System.Drawing.Size(116, 21);
            this.cbxInstituto.TabIndex = 15;
            // 
            // dgvAnexo
            // 
            this.dgvAnexo.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnexo.Location = new System.Drawing.Point(12, 134);
            this.dgvAnexo.Name = "dgvAnexo";
            this.dgvAnexo.Size = new System.Drawing.Size(733, 231);
            this.dgvAnexo.TabIndex = 12;
            this.dgvAnexo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnexoCellEndEdit);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(678, 388);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 56);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = global::Adquisiciones.View.Properties.Resources.search;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsulta.Location = new System.Drawing.Point(604, 386);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(69, 58);
            this.btnConsulta.TabIndex = 15;
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsultaClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::Adquisiciones.View.Properties.Resources.notes_edit;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(532, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(69, 58);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(460, 387);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 58);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.file_new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(387, 388);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 58);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // listaError
            // 
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(-1, 387);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(382, 68);
            this.listaError.TabIndex = 97;
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(-4, 371);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 98;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // FrmAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 452);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvAnexo);
            this.Controls.Add(this.gpbdatosgenerales);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 490);
            this.MinimumSize = new System.Drawing.Size(765, 490);
            this.Name = "FrmAnexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            this.gpbdatosgenerales.ResumeLayout(false);
            this.gpbdatosgenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllicitacion;
        private System.Windows.Forms.TextBox txtnumlicitacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblInstituto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lbltipolicitacion;
        private System.Windows.Forms.Label lblTechopresupuestal;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.TextBox txtDesanexo;
        private System.Windows.Forms.TextBox txtTechopresupuestal;
        private System.Windows.Forms.GroupBox gpbdatosgenerales;
        private System.Windows.Forms.DataGridView dgvAnexo;
        private System.Windows.Forms.ComboBox cbxInstituto;
        private System.Windows.Forms.ComboBox cbxTipolicitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaanexo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbxIva;
        private System.Windows.Forms.BindingSource bsAnexo;
        private System.Windows.Forms.BindingSource bsAnexoDetalle;
        private System.Windows.Forms.ListBox listaError;
        private System.Windows.Forms.Label lblNumErrors;

        private void BindearCampos()
        {

            // Initialize the DataGridView.
            bsAnexoDetalle.DataSource = new List<AnexoDetalle>();
            dgvAnexo.AutoGenerateColumns = false;
            dgvAnexo.AutoSize = true;
            dgvAnexo.DataSource = bsAnexoDetalle;

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn {DataPropertyName = "Renglon", Name = "Renglon"};
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn {DataPropertyName = "CveArt", Name = "Articulo"};
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
                         {
                             DataPropertyName = "DescripcionArt",
                             Width = 150,
                             Name = "Descripcion",
                             ReadOnly = true
                         };
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
                         {
                             DataPropertyName = "PresentacionArt",
                             Name = "Presentacion",
                             ReadOnly = true
                         };
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn {DataPropertyName = "Cantidad", Name = "Cantidad"};
            dgvAnexo.Columns.Add(column);

            ////Bindeamos el padre
            txtnumlicitacion.DataBindings.Add(new Binding("Text", bsAnexo, "NumeroAnexo"));
            this.dtpFechaanexo.DataBindings.Add(new Binding("Value", bsAnexo, "FechaAnexo",true));
            txtDesanexo.DataBindings.Add(new Binding("Text", bsAnexo, "DesAnexo"));
            cbxInstituto.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Instituto"));
            cbxTipolicitacion.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "TipoLicitacion", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsAnexo, "Iva", true));
            this.txtTechopresupuestal.DataBindings.Add(new Binding("Text", this.bsAnexo, "TechoPresupuestal", true));
            bsAnexo.DataSource = AnexoActual;
        }
    }
}