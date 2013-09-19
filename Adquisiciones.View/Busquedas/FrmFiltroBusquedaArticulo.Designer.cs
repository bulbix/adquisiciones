namespace Adquisiciones.View.Busquedas
{
    partial class FrmFiltroBusquedaArticulo
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpPartida = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEditPartida = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.txtAprox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsPartida = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAprox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Partida:";
            // 
            // searchLookUpPartida
            // 
            this.searchLookUpPartida.EditValue = "";
            this.searchLookUpPartida.Location = new System.Drawing.Point(57, 77);
            this.searchLookUpPartida.Name = "searchLookUpPartida";
            this.searchLookUpPartida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpPartida.Properties.DataSource = this.bsPartida;
            this.searchLookUpPartida.Properties.DisplayMember = "CatPartidaString";
            this.searchLookUpPartida.Properties.NullText = "";
            this.searchLookUpPartida.Properties.ValueMember = "Partida";
            this.searchLookUpPartida.Properties.View = this.searchLookUpEditPartida;
            this.searchLookUpPartida.Size = new System.Drawing.Size(329, 20);
            this.searchLookUpPartida.TabIndex = 19;
            // 
            // searchLookUpEditPartida
            // 
            this.searchLookUpEditPartida.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.searchLookUpEditPartida.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditPartida.Name = "searchLookUpEditPartida";
            this.searchLookUpEditPartida.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditPartida.OptionsView.ShowGroupPanel = false;
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.Location = new System.Drawing.Point(57, 204);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Size = new System.Drawing.Size(150, 23);
            this.cmdBusqueda.TabIndex = 21;
            this.cmdBusqueda.Text = "Generar Busqueda";
            this.cmdBusqueda.Click += new System.EventHandler(this.cmdBusqueda_Click);
            // 
            // txtAprox
            // 
            this.txtAprox.Location = new System.Drawing.Point(57, 151);
            this.txtAprox.Name = "txtAprox";
            this.txtAprox.Size = new System.Drawing.Size(329, 20);
            this.txtAprox.TabIndex = 22;
            this.txtAprox.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 132);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Descripcion Contenga:";
            this.labelControl1.Visible = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Partida";
            this.gridColumn17.FieldName = "Partida";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 107;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Descripcion";
            this.gridColumn18.FieldName = "DesPartida";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 925;
            // 
            // FrmFiltroBusquedaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 329);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAprox);
            this.Controls.Add(this.cmdBusqueda);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.searchLookUpPartida);
            this.Name = "FrmFiltroBusquedaArticulo";
            this.Text = "Filtro Busqueda Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAprox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpPartida;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditPartida;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.SimpleButton cmdBusqueda;
        private DevExpress.XtraEditors.TextEdit txtAprox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsPartida;
    }
}