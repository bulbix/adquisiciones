namespace Adquisiciones.View
{
    partial class FrmPerfil
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
            this.lstUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lstOrigen = new DevExpress.XtraEditors.ListBoxControl();
            this.lstDestino = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDerecha = new DevExpress.XtraEditors.SimpleButton();
            this.cmdIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bsOrigen = new System.Windows.Forms.BindingSource(this.components);
            this.bsDestino = new System.Windows.Forms.BindingSource(this.components);
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdOmitir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsuario
            // 
            this.lstUsuario.Location = new System.Drawing.Point(123, 12);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstUsuario.Properties.DataSource = this.bsUsuario;
            this.lstUsuario.Properties.View = this.searchLookUpEdit1View;
            this.lstUsuario.Size = new System.Drawing.Size(314, 20);
            this.lstUsuario.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lstOrigen
            // 
            this.lstOrigen.DataSource = this.bsOrigen;
            this.lstOrigen.Location = new System.Drawing.Point(12, 57);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(186, 402);
            this.lstOrigen.TabIndex = 1;
            // 
            // lstDestino
            // 
            this.lstDestino.DataSource = this.bsDestino;
            this.lstDestino.Location = new System.Drawing.Point(349, 57);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.Size = new System.Drawing.Size(194, 402);
            this.lstDestino.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuarios activos";
            // 
            // cmdDerecha
            // 
            this.cmdDerecha.Location = new System.Drawing.Point(240, 150);
            this.cmdDerecha.Name = "cmdDerecha";
            this.cmdDerecha.Size = new System.Drawing.Size(75, 23);
            this.cmdDerecha.TabIndex = 4;
            this.cmdDerecha.Text = ">";
            this.cmdDerecha.Click += new System.EventHandler(this.cmdDerecha_Click);
            // 
            // cmdIzquierda
            // 
            this.cmdIzquierda.Location = new System.Drawing.Point(240, 192);
            this.cmdIzquierda.Name = "cmdIzquierda";
            this.cmdIzquierda.Size = new System.Drawing.Size(75, 23);
            this.cmdIzquierda.TabIndex = 5;
            this.cmdIzquierda.Text = "<";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Perfiles sin asignar";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(349, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Perfiles asignados";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(240, 262);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            // 
            // cmdOmitir
            // 
            this.cmdOmitir.Location = new System.Drawing.Point(240, 317);
            this.cmdOmitir.Name = "cmdOmitir";
            this.cmdOmitir.Size = new System.Drawing.Size(75, 23);
            this.cmdOmitir.TabIndex = 10;
            this.cmdOmitir.Text = "Omitir";
            this.cmdOmitir.Click += new System.EventHandler(this.cmdOmitir_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 535);
            this.Controls.Add(this.cmdOmitir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdIzquierda);
            this.Controls.Add(this.cmdDerecha);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstDestino);
            this.Controls.Add(this.lstOrigen);
            this.Controls.Add(this.lstUsuario);
            this.Name = "FrmPerfil";
            this.Text = "Asociacion Usuario Perfil";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lstUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.ListBoxControl lstOrigen;
        private DevExpress.XtraEditors.ListBoxControl lstDestino;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdDerecha;
        private DevExpress.XtraEditors.SimpleButton cmdIzquierda;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bsOrigen;
        private System.Windows.Forms.BindingSource bsDestino;
        private System.Windows.Forms.BindingSource bsUsuario;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdOmitir;
    }
}