using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;

using iTextSharp.text;
using iTextSharp.text.pdf;
using Spring.Context.Support;
using Document = iTextSharp.text.Document;
using Element = iTextSharp.text.Element;
using Font = iTextSharp.text.Font;
using FontFactory = iTextSharp.text.FontFactory;
using Image = iTextSharp.text.Image;
using PageSize = iTextSharp.text.PageSize;
using Paragraph = iTextSharp.text.Paragraph;
using Rectangle = iTextSharp.text.Rectangle;

namespace Adquisiciones.View.Reportes
{
    public class ReportePedido : PdfPageEventHelper
    {
        readonly Font fuente = FontFactory.GetFont("ARIAL", 7, Font.NORMAL);
        readonly Font fuenteBold = FontFactory.GetFont("ARIAL", 7, Font.BOLD);
        readonly Font fuenteTitulo = FontFactory.GetFont("ARIAL", 10, Font.NORMAL);
        readonly Font fuenteTitulo2 = FontFactory.GetFont("ARIAL", 12, Font.NORMAL);
        readonly Font fuenteRojo = FontFactory.GetFont("ARIAL", 10, Font.NORMAL, BaseColor.RED);

        CatPartida partida = null;
        Assembly assembly = Assembly.GetExecutingAssembly();

        Pedido pedido;
        string fileAnverso = "";
        string fileReverso = "";
        private string piePagina = "PAGO";

        //private decimal subtotal = (decimal)0.0;

        public ReportePedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public ReportePedido() {}

        private PdfPTable Encabezado()
        {
            var encabezado = new PdfPTable(new float[] { 10, 50, 10 });
            encabezado.DefaultCell.Border = 0;
            encabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            try
            {
                //var assembly = typeof (ReportePedido).Assembly;
                var logoINR = Image.GetInstance(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.logotipo.jpg"));
                logoINR.ScaleAbsolute(10f, 10f);
                encabezado.AddCell(logoINR);

                var titulo = new PdfPTable(1);
                titulo.DefaultCell.Border = 0;
                titulo.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                titulo.AddCell(new Paragraph(
                                   "INSTITUTO NACIONAL DE REHABILITACIÓN", fuenteTitulo2));

                var linea = Image.GetInstance(assembly.
                    GetManifestResourceStream("Adquisiciones.View.Resources.linea_abajo.jpg"));
                titulo.AddCell(linea);


                titulo.AddCell(new Paragraph("DIRECCIÓN DE ADMINISTRACIÓN", fuenteTitulo));
                titulo.AddCell(new Paragraph("SUBDIRECCIÓN DE COMPRAS Y SUMINISTROS", fuenteTitulo));
                encabezado.AddCell(titulo);

                var logoSalud = Image.GetInstance(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.logoINR2013.png"));
                encabezado.AddCell(logoSalud);

                encabezado.DefaultCell.Colspan = 3;
                encabezado.AddCell(this.Proveedor());
            }
            catch (Exception ee) { }

            return encabezado;
        }

        private PdfPTable Proveedor()
        {

            var result = new PdfPTable(1);
            result.DefaultCell.Border = 0;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            result.AddCell(new Paragraph("PROVEEDOR:", fuente));
            result.AddCell(new Paragraph("                      " + pedido.Proveedor.NombreFiscal, fuente));
            result.AddCell(new Paragraph("                      " + pedido.Proveedor.Calle, fuente));
            result.AddCell(new Paragraph("                      COL. " + pedido.Proveedor.Colonia, fuente));
            result.AddCell(new Paragraph("                      DEL. " + pedido.Proveedor.Delegacion, fuente));
            result.AddCell(new Paragraph("                      C.P. " + pedido.Proveedor.CodigoP, fuente));
            result.AddCell(new Paragraph("                      TEL. " + pedido.Proveedor.Tel, fuente));
            result.AddCell(new Paragraph("                      TEL 2. " + pedido.Proveedor.Tel2, fuente));
            result.AddCell(new Paragraph("                      TEL 3. " +  pedido.Proveedor.Tel3, fuente));
            result.AddCell(new Paragraph("                      R.F.C. " + pedido.Proveedor.Rfc, fuente));
            result.AddCell(new Paragraph("                      EMAIL. " + pedido.Proveedor.Correo, fuente));

            return result;

        }

        private PdfPTable CabeceraDetalle()
        {
            var result = new PdfPTable(new float[] { 3, 20, 5, 5, 6, 6 });
            //result.DefaultCell.Border = 1;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            result.AddCell(new Paragraph("CLAVE", fuente));
            result.AddCell(new Paragraph("DESCRIPCION DE LOS BIENES", fuente));
            result.AddCell(new Paragraph("CANTIDAD", fuente));
            result.AddCell(new Paragraph("UNIDAD", fuente));
            result.AddCell(new Paragraph("PRECIO UNITARIO\nNETO M.N.", fuente));
            result.AddCell(new Paragraph("PRECIO TOTAL\nNETO M.N.", fuente));
            return result;

        }

        private PdfPTable Detalle()
        {
            var result = new PdfPTable(new float[] { 3, 20, 5, 5, 6, 6 });
            
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            result.DefaultCell.BorderWidthBottom = 0;
            result.DefaultCell.BorderWidthTop = 0;

            var ctx = ContextRegistry.GetContext();
            var articuloDao = ctx["articuloDao"] as IArticuloDao;

            var index = 0;

            //subtotal = (decimal)0.0;

            foreach (var pedidoDetalle in pedido.PedidoDetalle)
            {
                ++index;
                if (index == 1){//Consulta una sola vez
                    partida = articuloDao.GetPartida(pedidoDetalle.Articulo);
                }

                result.AddCell(new Paragraph(pedidoDetalle.Articulo.Id.CveArt + "", fuente));

                var articulo = pedidoDetalle.Articulo.DesArticulo;

                var entregaTotal = "";

                foreach(var pedidoEntrega in pedidoDetalle.PedidoEntrega)
                {
                    var entrega = "ENTREGAR: " + pedidoEntrega.Cantidad + " DEL " + String.Format("{0:dd/MM/yyyy}", pedidoEntrega.FechaInicial) + " AL " +
                              String.Format("{0:dd/MM/yyyy}", pedidoEntrega.FechaFinal) + "\n";

                    entregaTotal += entrega;
                }

                articulo += "\n" + entregaTotal;

                result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                result.AddCell(new Paragraph(articulo, fuente));
                result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                result.AddCell(new Paragraph(pedidoDetalle.Cantidad.Value.ToString("N"), fuente));
                result.AddCell(new Paragraph(pedidoDetalle.Articulo.Unidad, fuente));
                result.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                result.AddCell(new Paragraph(pedidoDetalle.PrecioUnitario.Value.ToString("C4"), fuente));
                decimal total = pedidoDetalle.Importe.Value;

                //subtotal += total;

                result.AddCell(new Paragraph(total.ToString("C"), fuente));
                result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            }

            return result;
        }

        private PdfPTable Etiquetas()
        {
            var result = new PdfPTable(2);
            result.DefaultCell.Border = 1;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            var etiqueta1 = new PdfPTable(1);
            etiqueta1.DefaultCell.Border = 0;
            etiqueta1.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            etiqueta1.AddCell(new Paragraph("FAVOR DE CITAR", fuente));
            etiqueta1.AddCell(new Paragraph("ESTE NUMERO EN", fuente));
            etiqueta1.AddCell(new Paragraph("TODA SU", fuente));
            etiqueta1.AddCell(new Paragraph("CORRESPONDENCIA,", fuente));
            etiqueta1.AddCell(new Paragraph("DOCUMENTOS Y", fuente));
            etiqueta1.AddCell(new Paragraph("EMPAQUES", fuente));

            var contrato = new PdfPTable(1);
            contrato.DefaultCell.Border = 0;
            

            switch(pedido.CatTipopedido.IdTipoped)
            {
                case 1: //MAYOR
                    contrato.AddCell(new Paragraph("CONTRATO/ PEDIDO DE ADQUISICION", fuente));
                    contrato.AddCell(new Paragraph("NUMERO: INR/" + pedido.FechaPedido.Value.Year + "/" 
                        + pedido.NumeroPedido, fuenteBold));

                    break;
                case 2: //MENOR
                    contrato.AddCell(new Paragraph("CONTRATO/ PEDIDO DE ADQUISICION POR MONTO:", fuente));
                    contrato.AddCell(new Paragraph("ART. 42 LA LEY DE ADQUISICIONES, ARRENDAMIENTOS Y SERVICIOS DEL SECTOR PUBLICO.", fuente));
                    contrato.AddCell(new Paragraph("NUMERO: " + pedido.NumeroPedido, fuenteBold));
                    break;
                case 3: //DONACION
                    contrato.AddCell(new Paragraph("CONTRATO/ PEDIDO DE DONACION", fuente));
                    contrato.AddCell(new Paragraph("NUMERO: " + pedido.NumeroPedido, fuenteBold));
                    break;
                case 4: //EXTRAMUROS
                    contrato.AddCell(new Paragraph("CONTRATO/ PEDIDO DE EXTRAMUROS", fuente));
                    contrato.AddCell(new Paragraph("NUMERO: " + pedido.NumeroPedido, fuenteBold));
                    break;

            }
            
            //contrato.AddCell(new Paragraph("NUMERO: " + pedido.NumeroPedido, fuenteBold));
            contrato.AddCell(new Paragraph("FECHA: " + String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido), fuenteBold));

            var requisicion = pedido.NumeroRequisicion ?? pedido.Requisicion.ToString();

            contrato.AddCell(new Paragraph("REQUISICION: " + requisicion, fuenteBold));
            //contrato.AddCell(new Paragraph("HOJA No. " , fuente));
            //contrato.AddCell(new Paragraph("DE", fuente));

            var etiqueta2 = new PdfPTable(1);
            etiqueta2.DefaultCell.Border = 0;
            etiqueta2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            etiqueta2.AddCell(new Paragraph("CONDICIONES DE ENTREGA:", fuente));
            etiqueta2.AddCell(new Paragraph("ALMACEN", fuente));
            etiqueta2.AddCell(new Paragraph("DE LUNES A VIERNES", fuente));
            etiqueta2.AddCell(new Paragraph("DE 9:00 A 14:00 HRS.", fuente));

            var etiqueta3 = new PdfPTable(1);
            etiqueta3.DefaultCell.Border = 0;
            etiqueta3.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            etiqueta3.AddCell(new Paragraph("CONDICIONES DE PAGO A PARTIR", fuente));
            etiqueta3.AddCell(new Paragraph("DE LA ENTREGA:", fuente));
            etiqueta3.AddCell(new Paragraph("20 DIAS NATURALES, CONTADOS A", fuente));
            etiqueta3.AddCell(new Paragraph("PARTIR DE LA RECEPCION OFICIAL", fuente));
            etiqueta3.AddCell(new Paragraph("DE LA FACTURA", fuente));

            var etiqueta4 = new PdfPTable(1);
            etiqueta4.DefaultCell.Border = 0;
            etiqueta4.AddCell(new Paragraph("FACTURAR A: INSTITUTO NACIONAL DE REHABILITACION RFC. INR0506235L1", fuente));
            etiqueta4.AddCell(new Paragraph("Av. México Xochimilco, No.289, Col.Arenal de Guadalupe, Del. Tlalpan, C.P, 14389,", fuente));
            etiqueta4.AddCell(new Paragraph("Méx.. D.F., Tel. 59-99-10-00, Ext. 10023", fuente));

            var etiqueta5 = new PdfPTable(1);
            etiqueta5.DefaultCell.Border = 0;
            etiqueta5.AddCell(new Paragraph("LAS CONDICIONES DE ESTE CONTRATO / PEDIDO DE ADQUISICION SE CONSIGNARAN AL REVERSO.", fuente));


            result.AddCell(etiqueta1);
            result.AddCell(contrato);
            result.AddCell(etiqueta2);
            result.AddCell(etiqueta3);
            result.DefaultCell.Colspan = 2;
            result.AddCell(etiqueta4);
            result.AddCell(etiqueta5);


            return result;

        }

        public PdfPTable Subrayado(String txt, Font fuente)
        {

            var tabla = new PdfPTable(1);
            tabla.DefaultCell.BorderWidthTop = 0;
            tabla.DefaultCell.BorderWidthLeft = 0;
            tabla.DefaultCell.BorderWidthRight = 0;
            tabla.DefaultCell.BorderWidthBottom = 1;
            tabla.AddCell(new Paragraph("" + txt, fuente));
            return tabla;
        }

        private PdfPTable Firmas(string piePagina)
        {
            var nombresMayor = new string[][]
            {new [] {"SUBDIRECTOR DE COMPRAS Y SUMINISTROS","LIC. JOSE RAUL SANCHEZ ARREDONDO"},
             new [] {"SUBDIRECTOR DE RECURSOS FINANCIEROS","C.P. ANTONIO URIBE ANDRADE"},
             new [] {"DIRECTOR DE ADMINISTRACION","DRA. MARICELA VERDEJO SILVA"},
             new [] {"DIRECTOR GENERAL DEL INSTITUTO","DR. LUIS GUILLERMO IBARRA"}
            };

            var nombresMenor = new string[][]
            {
                new [] {"COMPRADOR",pedido.Usuario.Nombre.ToUpper()}, 
                new [] {"DEPTO. DE COMPRAS","CP. MARCO ANTONIO ALVARADO CURIEL"},
                new [] {"SUBDIRECTOR DE COMPRAS Y SUMINISTROS","LIC. JOSE RAUL SANCHEZ ARREDONDO"}
            };

            var result = new PdfPTable(4);
            result.DefaultCell.Border = 0;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            if (pedido.CatTipopedido.IdTipoped == 1)//MAYOR
            {
                for (int index = 0; index < nombresMayor.Length; index++)
                {
                    var etiqueta = nombresMayor[index][0];
                    var nombre = nombresMayor[index][1];
                    var firma = new PdfPTable(1);
                    firma.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    firma.DefaultCell.Border = 0;

                    
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell(Subrayado("          ", fuente));
                    firma.AddCell(new Paragraph(nombre, fuente));
                    firma.AddCell(new Paragraph(etiqueta, fuenteBold));

                    result.AddCell(firma);
                }
            }
            else //MENOR U OTROS
            {
                for (int index = 0; index < nombresMenor.Length; index++)
                {
                    var etiqueta = nombresMenor[index][0];
                    var nombre = nombresMenor[index][1];
                    var firma = new PdfPTable(1);
                    firma.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    firma.DefaultCell.Border = 0;
                    
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    firma.AddCell("");
                    //firma.AddCell("");
                    //firma.AddCell("");
                    firma.AddCell(Subrayado("          ", fuente));
                    firma.AddCell(new Paragraph(nombre, fuente));
                     firma.AddCell(new Paragraph(etiqueta, fuenteBold));
                    result.AddCell(firma);
                }

                var etiqueta1 = new PdfPTable(1);
                etiqueta1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                etiqueta1.DefaultCell.Border = 0;
                //etiqueta1.DefaultCell.BorderWidthBottom = 0;
                etiqueta1.AddCell(new Paragraph("DIAS DE RECEPCION DE FACTURAS EN EL", fuente));
                etiqueta1.AddCell(new Paragraph("DEPTO. DE CONTROL PRESUPUESTAL", fuente));
                etiqueta1.AddCell(new Paragraph("", fuente));
                etiqueta1.AddCell(new Paragraph("MARTES Y JUEVES DE 10:00 A 14:00 HRS.", fuente));
                result.AddCell(etiqueta1);
            }

            result.DefaultCell.Colspan = 2;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            result.AddCell(new Paragraph(piePagina, fuenteRojo));
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            result.AddCell(new Paragraph("PAGO VER OBSERVACIONES AL REVERSO", fuenteRojo));

            return result;

        }

        private void GenerarCeldas(int numCeldas, PdfPTable tabla)
        {
            tabla.DefaultCell.Border = 0;
            for (int i = 1; i <= numCeldas; i++)
            {
                tabla.AddCell("");
            }

            tabla.DefaultCell.Border = 1;

        }

        private PdfPTable Reverso()
        {
            var result = new PdfPTable(3);
            result.WidthPercentage = 100;
            //result.DefaultCell.Border = 0;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            result.DefaultCell.Colspan = 3;
            var arriba = new PdfPTable(1);
            arriba.DefaultCell.Border = 0;
            arriba.AddCell(new Paragraph("PEDIDO/CONTRATO POR MONTO DE ADQUISICIÓN DE BIENES QUE CELEBRAN POR UNA PARTE EL INSTITUTO NACIONAL DE REHABILITACIÓN, A QUIEN EN LO SUCESIVO Y PARA EFECTO DEL PRESENTE INSTRUMENTO SE ", fuente));
            arriba.AddCell(new Paragraph("LE DENOMINARÁ “EL INR” Y POR OTRA PARTE A QUIEN SE DESIGNARÁ COMO  “EL PROVEEDOR”, LOS NOMBRES Y LOS DOMICILIOS DE LAS PARTES SON LOS QUE SE SEÑALAN EN EL ANVERSO DE ESTE DOCUMENTO.", fuente));
            result.AddCell(arriba);
            result.DefaultCell.Colspan = 1;
            //result.DefaultCell.Border = 1;

            // ReSharper disable AssignNullToNotNullAttribute
            var sr1 = new StreamReader(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.clausula1.txt"), Encoding.Default);
            // ReSharper restore AssignNullToNotNullAttribute
            // ReSharper disable AssignNullToNotNullAttribute
            var sr2 = new StreamReader(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.clausula2.txt"), Encoding.Default);
            // ReSharper restore AssignNullToNotNullAttribute
            string clausula1 = sr1.ReadToEnd();
            string clausula2 = sr2.ReadToEnd();
            sr2.Close();
            sr1.Close();
            result.AddCell(new Paragraph(clausula1, fuente));
            result.AddCell(new Paragraph(clausula2, fuente));

            var anotacion = new PdfPTable(1);
            anotacion.DefaultCell.Border = 1;
            //anotacion.DefaultCell.Border = 0;
            anotacion.AddCell(new Paragraph("EL PROVEEDOR ACEPTA LAS CONDICIONES EN ESTE PEDIDO/CONTRATO POR MONTO DE ADQUISICIÓN.", fuente));
            GenerarCeldas(15, anotacion);

            //var prov = pedido.Proveedor;

            //var representanteLegal = prov.Rnombre + " " + prov.Rpaterno + " " + prov.Rmaterno;

            anotacion.AddCell(new Paragraph("NOMBRE DEL REPRESENTANTE LEGAL", fuente));
            //anotacion.AddCell(new Paragraph(representanteLegal, fuenteBold));
            GenerarCeldas(15, anotacion);

            anotacion.AddCell(new Paragraph("CARGO:", fuente));
            //anotacion.AddCell(new Paragraph(prov.Giro, fuenteBold));

            GenerarCeldas(10, anotacion);

            var subTabla = new PdfPTable(2);
            subTabla.DefaultCell.Border = 0;

            var firma = new PdfPTable(1);
            firma.DefaultCell.Border = 0;
            firma.AddCell(new Paragraph("FIRMA DE CONFORMIDAD:", fuente));
            GenerarCeldas(10, anotacion);

            var telefono = new PdfPTable(4);
            telefono.DefaultCell.Colspan = 4;
            telefono.DefaultCell.Border = 1;
            telefono.AddCell(new Paragraph("TELÉFONO(S)", fuente));
            telefono.DefaultCell.Border = 0;
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.DefaultCell.Colspan = 1;
            telefono.DefaultCell.Border = 1;
            telefono.AddCell("");
            telefono.AddCell(new Paragraph("DIA", fuente));
            telefono.AddCell(new Paragraph("MES", fuente));
            telefono.AddCell(new Paragraph("AÑO", fuente));
            telefono.AddCell(new Paragraph("FECHA", fuente));
            //telefono.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            telefono.AddCell(""/*new Paragraph(DateTime.Now.Day.ToString(), fuenteBold)*/);
            telefono.AddCell(""/*new Paragraph(DateTime.Now.Month.ToString(), fuenteBold)*/);
            telefono.AddCell(""/*new Paragraph(DateTime.Now.Year.ToString(), fuenteBold)*/);
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            subTabla.AddCell(firma);
            subTabla.AddCell(telefono);

            anotacion.AddCell(subTabla);

            anotacion.AddCell(new Paragraph("EL PROVEEDOR ACREDITA SU EXISTENCIA LEGAL Y FACULTADES DE SU REPRESENTANTE LEGAL MEDIANTE.", fuente));
            GenerarCeldas(15, anotacion);

            anotacion.AddCell(new Paragraph("OBSERVACIONES", fuente));
            anotacion.AddCell("");

            GenerarCeldas(10, anotacion);

            result.AddCell(anotacion); return result;

        }

        private void WaterMark(Document document)
        {
            try
            {
                var fs1 = Image.
                GetInstance(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.marcaagua.jpg"));
                var jpg = Image.GetInstance(fs1);

                //Scale image
                jpg.ScalePercent(50f);
                //Set position
                jpg.SetAbsolutePosition(0f, 70f);
                document.Add(jpg);
            }
            catch (Exception e)
            {}
        }

        public void GenerarAnverso()
        {
            var document = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 120);

            fileAnverso = System.IO.Path.GetTempFileName();

            var writer = PdfWriter.GetInstance(document, new FileStream(fileAnverso,
                FileMode.Create));
            writer.PageEvent = this;

            document.Open();

            //WaterMark(document);

            var anverso = new PdfPTable(1);
            anverso.WidthPercentage = 100;
            //anverso.DefaultCell.Border = 1;

            anverso.HeaderRows = 1;

            var cabeza = new PdfPTable(new float[] { 60, 40 });
            cabeza.DefaultCell.Border = 0;
            cabeza.AddCell(this.Encabezado());
            cabeza.AddCell(this.Etiquetas());
            cabeza.DefaultCell.Colspan = 2;cabeza.AddCell(this.CabeceraDetalle());
            anverso.AddCell(cabeza);
            anverso.AddCell(this.Detalle());

            
            var let = new  Aletras();

            var totales = new PdfPTable(3);
            totales.DefaultCell.Border = 0;
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            totales.AddCell("");
            totales.AddCell("");
            totales.AddCell(new Paragraph("SUBTOTAL  " + pedido.ImporteTotal.Value.ToString("C"), fuente));
            
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            totales.DefaultCell.Colspan = 2;
            
            if(pedido.Fundamento != null)
                totales.AddCell(new Paragraph("FUNDAMENTO LEGAL: " + pedido.Fundamento.DesFundamento, fuente));
            else if(pedido.TipoProcedimiento != null)
                totales.AddCell(new Paragraph("PROCEDIMIENTO: " + pedido.TipoProcedimiento, fuente));
            else
                totales.AddCell("");

            
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            totales.DefaultCell.Colspan = 1;
            totales.AddCell(new Paragraph("DESCUENTO  " + pedido.ImporteDescuento.Value.ToString("C") , fuente));
            
            decimal subTotalDesc = pedido.SubTotalDesc;
            
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            totales.DefaultCell.Colspan = 2;
            totales.AddCell(new Paragraph("PARTIDA PRESUPUESTAL: " + partida.Partida, fuente));
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            totales.DefaultCell.Colspan = 1;
            totales.AddCell(new Paragraph("SUBT-DESC.  " + subTotalDesc.ToString("C"), fuente));
            

            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            totales.DefaultCell.Colspan = 2;
            //totales.AddCell(new Paragraph("ACTIVIDAD INST.: " + pedido.CatActividad.IdActividad, fuente));
            totales.AddCell("");
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            totales.DefaultCell.Colspan = 1;

            decimal cantidadIva = pedido.IvaCantidad;

            totales.AddCell(new Paragraph("I.V.A.  " + cantidadIva.ToString("C"), fuente));

            decimal total = pedido.Total;
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            totales.DefaultCell.Colspan = 2;
            totales.AddCell(new Paragraph("CARGO A: "+pedido.CatPresupuesto.DesPresupuesto+
                "( " + let.Letras(Math.Round(total,2).ToString()).ToUpper() + " )",fuente));
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            
            totales.DefaultCell.Colspan = 1;
            totales.AddCell(new Paragraph("TOTAL  " + total.ToString("C"), fuente));


            //Observaciones
            totales.DefaultCell.Colspan = 3;
            totales.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            totales.AddCell("");
            totales.AddCell("");
            totales.AddCell(new Paragraph(pedido.Observaciones, fuente));

            anverso.AddCell(totales);
            document.Add(anverso);
            document.Close();
        }

        public void GenerarReverso()
        {

            var document = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);

            fileReverso = System.IO.Path.GetTempFileName();

            var writer = PdfWriter.GetInstance(document, new FileStream(fileReverso,
               FileMode.Create));

            var reverso = new PdfPTable(1);
            reverso.WidthPercentage = 100;
            reverso.DefaultCell.Border = 0;

            reverso.AddCell(this.Reverso());

            document.Open();
            document.Add(reverso);
            document.Close();
        }

        public void GenerarReporteCompleto()
        {
            string[] piesPagina = {
                                      "PAGO", "CONSECUTIVO DE PEDIDOS",
                                      "PROVEEDOR", "ACUSE DE RECIBO", "EXPEDIENTE","COMPRADOR"
                                  };

            var filePedidoCompleto = Path.GetTempFileName() + ".pdf";
            var concatenate = new PdfConcatenate(new FileStream(filePedidoCompleto, FileMode.Create));

            for (var numReporte = 0; numReporte < piesPagina.Count(); numReporte++)
            {
                this.piePagina = piesPagina[numReporte];
                var fileReporte = GenerarReporte();
                var reporte = new PdfReader(fileReporte);
                concatenate.AddPages(reporte);
                File.Delete(fileReporte);
            }

            concatenate.Close();

            Process.Start("cmd", "/c " + filePedidoCompleto);
        }

        private string GenerarReporte()
        {
            GenerarAnverso();
            GenerarReverso();
            var fileAnversoMarca = fileAnverso;
            var fileReversoMarca = fileReverso;

            if(pedido.EstadoPedido == "C")
            {
                fileAnversoMarca = MarcaCancelado(fileAnverso);
            }


            var anversoReader = new PdfReader(fileAnversoMarca);
            var reversoReader = new PdfReader(fileReversoMarca);

            var document = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);

            var filePedido = Path.GetTempFileName() + ".pdf";

            var copy = new PdfCopy(document, new FileStream(filePedido, FileMode.Create));

            document.Open();

            for (var page = 1; page <= anversoReader.NumberOfPages; page++)
            {
                copy.AddPage(copy.GetImportedPage(anversoReader, page));
                copy.AddPage(copy.GetImportedPage(reversoReader, 1));
            }

            copy.Close();
            anversoReader.Close();
            reversoReader.Close();

            File.Delete(fileReversoMarca);
            File.Delete(fileAnversoMarca);
            File.Delete(fileAnverso);
            File.Delete(fileReverso);

            return filePedido;
        }

        private String MarcaCancelado(String path)
        {
            PdfReader reader = new PdfReader(path);
            FileStream fs = null;
            PdfStamper stamp = null;

            var fileOutput = Path.GetTempFileName() + ".pdf";

            string outputPdf = String.Format(fileOutput, Guid.NewGuid().ToString());
            fs = new FileStream(outputPdf, FileMode.CreateNew, FileAccess.Write);
            stamp = new PdfStamper(reader, fs);

            BaseFont bf = BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf", BaseFont.CP1252, true);
            PdfGState gs = new PdfGState();

            gs.FillOpacity = 0.35F;

            gs.StrokeOpacity = 0.35F;
            for (int nPag = 1; nPag <= reader.NumberOfPages; nPag++)
            {

                Rectangle tamPagina = reader.GetPageSizeWithRotation(nPag);
                PdfContentByte over = stamp.GetOverContent(nPag);
                over.BeginText();
                WriteTextToDocument(bf, tamPagina, over, gs, "CANCELADO");
                over.EndText();

            }

            reader.Close();
            if (stamp != null) stamp.Close();
            if (fs != null) fs.Close();

            return fileOutput;

        }

        private static void WriteTextToDocument(BaseFont bf,Rectangle tamPagina,
            PdfContentByte over,PdfGState gs,string texto)
        {

            over.SetGState(gs);

            over.SetRGBColorFill(220, 220, 220);

            over.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_STROKE);

            over.SetFontAndSize(bf, 46);

            Single anchoDiag =

                (Single)Math.Sqrt(Math.Pow((tamPagina.Height - 120), 2)

                + Math.Pow((tamPagina.Width - 60), 2));

            Single porc = (Single)100

                * (anchoDiag / bf.GetWidthPoint(texto, 46));

            over.SetHorizontalScaling(porc);

            double angPage = (-1)

            * Math.Atan((tamPagina.Height - 60) / (tamPagina.Width - 60));

            over.SetTextMatrix((float)Math.Cos(angPage),

                       (float)Math.Sin(angPage),

                       (float)((-1F) * Math.Sin(angPage)),

                       (float)Math.Cos(angPage),

                       30F,

                       (float)tamPagina.Height - 60);

            over.ShowText(texto);


        }


        public int getNumberOfPdfPages(string fileName)
        {
            using (StreamReader sr = new StreamReader(File.OpenRead(fileName)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }
        
      

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            WaterMark(document);
        }

        // This is the contentbyte object of the writer
        PdfContentByte cb;

        // we will put the final number of pages in a template
        PdfTemplate template;

        // this is the BaseFont we are going to use for the header / footer
        BaseFont bf = null;

        // This keeps track of the creation time
        DateTime PrintTime = DateTime.Now;

        // we override the onOpenDocument method
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            try
            {
                PrintTime = DateTime.Now;
                bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb = writer.DirectContent;
                template = cb.CreateTemplate(50, 50);
            }
            catch (DocumentException de)
            {
            }
            catch (System.IO.IOException ioe)
            {
            }
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);

            template.BeginText();
            template.SetFontAndSize(bf, 8);
            template.SetTextMatrix(0, 0);
            template.ShowText("" + (writer.PageNumber - 1));
            template.EndText();
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            int pageN = writer.PageNumber;
            String text = "Pagina " + pageN + " de ";
            float len = bf.GetWidthPoint(text, 8);

            Rectangle pageSize = document.PageSize;

            cb.SetRGBColorFill(100, 100, 100);

            cb.BeginText();
            cb.SetFontAndSize(bf, 8);
            cb.SetTextMatrix(pageSize.GetLeft(40), pageSize.GetBottom(30));
            cb.ShowText(text);
            cb.EndText();

            cb.AddTemplate(template, pageSize.GetLeft(40) + len, pageSize.GetBottom(30));

            cb.BeginText();
            cb.SetFontAndSize(bf, 8);
            cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT,
                "Creado " + PrintTime.ToString(),
                pageSize.GetRight(40),
                pageSize.GetBottom(30), 0);
            cb.EndText();


            //Firmas
            var footerTbl = new PdfPTable(1);
            footerTbl.TotalWidth = 790;
            var cell = new PdfPCell(this.Firmas(this.piePagina));
            cell.Border = 0;
            cell.PaddingLeft = 10;
            footerTbl.AddCell(cell);
            footerTbl.WriteSelectedRows(0, -1, -5, 120, writer.DirectContent);
        }


    }
}
