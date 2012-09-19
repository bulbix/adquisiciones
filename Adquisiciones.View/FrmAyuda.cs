using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Adquisiciones.View
{
    public partial class FrmAyuda : DevExpress.XtraEditors.XtraForm
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void SimpleButton2Click(object sender, EventArgs e)
        {
            try
            {
                var directorio = new
                    DirectoryInfo(@"\\192.168.16.65\users\Public\Documents\ManualAdquisiciones");
                string video = "";

                switch (lstModulo.SelectedItem.ToString())
                {case "Anexo":
                        video = directorio.GetFiles("Anexo.mp4")[0].FullName;
                        break;
                    case "Cotizacion":
                        video = directorio.GetFiles("Cotizacion.mp4")[0].FullName;
                        break;
                    case "Fallo":
                        video = directorio.GetFiles("Fallo.mp4")[0].FullName;
                        break;
                    case "Pedido":
                        video = directorio.GetFiles("Pedido.mp4")[0].FullName;
                        break;
                    default:
                        break;
                }

                windowsMedia.URL = video;
                windowsMedia.Ctlcontrols.play();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Ocurrio un error en la visualizacion");
                
            }
        }
    }
}