namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaPartida
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
            this.gcPartida = new DevExpress.XtraGrid.GridControl();
            this.gvPartida = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPartida
            // 
            this.gcPartida.DataSource = this.bsSource;
            this.gcPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPartida.Location = new System.Drawing.Point(0, 67);
            this.gcPartida.MainView = this.gvPartida;
            this.gcPartida.Name = "gcPartida";
            this.gcPartida.Size = new System.Drawing.Size(665, 451);
            this.gcPartida.TabIndex = 5;
            this.gcPartida.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartida});
            // 
            // gvPartida
            // 
            this.gvPartida.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.gvPartida.GridControl = this.gcPartida;
            this.gvPartida.Name = "gvPartida";
            this.gvPartida.OptionsBehavior.Editable = false;
            this.gvPartida.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPartida.OptionsView.ShowAutoFilterRow = true;
            this.gvPartida.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clave";
            this.gridColumn2.FieldName = "Partida";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 104;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descripcion";
            this.gridColumn1.FieldName = "DesPartida";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 680;
            // 
            // FrmBusquedaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 540);
            this.Controls.Add(this.gcPartida);
            this.Name = "FrmBusquedaPartida";
            this.Text = "Partida::Busqueda";
            this.Controls.SetChildIndex(this.gcPartida, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPartida;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPartida;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}