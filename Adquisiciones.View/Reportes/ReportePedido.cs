using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Adquisiciones.View.Reportes
{
    public class ReportePedido : PdfPageEventHelper
    {
        readonly Font fuente = FontFactory.GetFont("ARIAL", 7, Font.NORMAL);
        readonly Font fuenteBold = FontFactory.GetFont("ARIAL", 7, Font.BOLD);
        readonly Font fuenteTitulo = FontFactory.GetFont("ARIAL", 10, Font.NORMAL);
        readonly Font fuenteRojo = FontFactory.GetFont("ARIAL", 10, Font.NORMAL, BaseColor.RED);


        Assembly assembly = Assembly.GetExecutingAssembly();

        Pedido pedido;
        string fileAnverso = "";
        string fileReverso = "";




        public ReportePedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public ReportePedido()
        {
            
        }

        private PdfPTable Encabezado()
        {
            var encabezado = new PdfPTable(new float[]{10,50,10});
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
                                   "INSTITUTO NACIONAL DE REHABILITACIÓN", fuenteTitulo));
                titulo.AddCell(new Paragraph("DIRECCIÓN DE ADMINISTRACION", fuenteTitulo));
                titulo.AddCell(new Paragraph("SUBDIRECCIÓN DE COMPRAS Y SUMINISTROS", fuenteTitulo));
                encabezado.AddCell(titulo);

                var logoSalud = Image.GetInstance(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.logo_salud.jpg"));
                encabezado.AddCell(logoSalud);

                encabezado.DefaultCell.Colspan = 3;
                encabezado.AddCell(this.Proveedor());
            }
            catch(Exception ee){}

            return encabezado;
        }

        private PdfPTable Proveedor()
        {
            var result = new PdfPTable(1);
            result.DefaultCell.Border = 1;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            result.AddCell("PROVEEDOR: " + pedido.Proveedor);
            return result;

        }


        private PdfPTable CabeceraDetalle()
        {
            var result = new PdfPTable(new float[] { 3, 20, 5, 5, 6, 6 });
            //result.DefaultCell.Border = 1;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            result.AddCell(new Paragraph("PARTIDA", fuente));
            result.AddCell(new Paragraph("CODIGO / DESCRIPCION DE LOS BIENES", fuente));
            result.AddCell(new Paragraph("CANTIDAD", fuente));
            result.AddCell(new Paragraph("UNIDAD", fuente));
            result.AddCell(new Paragraph("PRECIO UNITARIO\nNETO M.N.", fuente));
            result.AddCell(new Paragraph("PRECIO TOTAL\nNETO M.N.", fuente));
            return result;

        }

        private PdfPTable Detalle()
        {
            var result = new PdfPTable(new float[]{3,20,5,5,6,6});
            //result.DefaultCell.Border = 1;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            result.DefaultCell.BorderWidthBottom = 0;
            result.DefaultCell.BorderWidthTop = 0;

            foreach (var pedidoDetalle in pedido.PedidoDetalle)
            {
                result.AddCell(new Paragraph("partida", fuente));
                var articulo = pedidoDetalle.Articulo.Id.CveArt + " / " + pedidoDetalle.Articulo.DesArticulo;
                result.AddCell(new Paragraph(articulo, fuente));
                result.AddCell(new Paragraph(pedidoDetalle.Cantidad.Value.ToString("N"), fuente));
                result.AddCell(new Paragraph(pedidoDetalle.Articulo.CatUnidad.Unidad, fuente));
                result.AddCell(new Paragraph(pedidoDetalle.PrecioUnitario.Value.ToString("C"), fuente));
                decimal total = pedidoDetalle.Cantidad.Value*pedidoDetalle.PrecioUnitario.Value;
                result.AddCell(new Paragraph(total.ToString("C"), fuente));
            }

            for (int renglon = 1; renglon <= 200; renglon++)
            {
                result.AddCell(new Paragraph("11111", fuente));
                result.AddCell(new Paragraph("11111/AAAAAA", fuente));
                result.AddCell(new Paragraph("100", fuente));
                result.AddCell(new Paragraph("PIEZA", fuente));
                result.AddCell(new Paragraph("$100.00", fuente));
                result.AddCell(new Paragraph("$100000.00", fuente));

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
            contrato.AddCell(new Paragraph("CONTRATO/PEDIDO DE ADQUISICION POR MONTO:", fuente));
            contrato.AddCell(new Paragraph("ART. 42 LA LEY DE ADQUISICIONES, ARRENDAMIENTOS Y SERVICIOS DEL SECTOR PUBLICO.", fuente));
            contrato.AddCell(new Paragraph("NUMERO: "  + pedido.NumeroPedido , fuenteBold));
            contrato.AddCell(new Paragraph("FECHA: " + String.Format("{0:MM/dd/yyyy}", pedido.FechaPedido), fuenteBold));
            contrato.AddCell(new Paragraph("REQUISICION: " + pedido.NumeroRequisicion, fuenteBold));
            //contrato.AddCell(new Paragraph("HOJA No. " , fuente));
            //contrato.AddCell(new Paragraph("DE", fuente));

            var etiqueta2 = new PdfPTable(1);
            etiqueta2.DefaultCell.Border = 0;
            etiqueta2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            etiqueta2.AddCell(new Paragraph("CONDICIONES DE ENTREGA:", fuente));
            etiqueta2.AddCell(new Paragraph("ALMACEN", fuente));
            etiqueta2.AddCell(new Paragraph("DE LUNES A VIERNES", fuente));
            etiqueta2.AddCell(new Paragraph("DE 8:00 A 14:00 HRS.", fuente));

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
            etiqueta4.AddCell(new Paragraph("Méx.. D.F., Tel. 59-99-10-00, Ext. 100023", fuente));

            var etiqueta5 = new PdfPTable(1);
            etiqueta5.DefaultCell.Border = 0;
            etiqueta5.AddCell(new Paragraph("LAS CONDICIONES DE ESTE CONTRATO / PEDIDO DE ADQUISIICON SE CONSIGNARAN AL REVERSO.", fuente));


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


        private PdfPTable Firmas()
        {
            var result = new PdfPTable(4);
            result.DefaultCell.Border = 0;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            var firma1 = new PdfPTable(1);
            firma1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            firma1.DefaultCell.Border = 0;
            //firma1.DefaultCell.BorderWidthBottom = 0;
            firma1.AddCell(new Paragraph("COMPRADOR", fuente));
            firma1.AddCell(Subrayado("          ", fuente));

            var firma2 = new PdfPTable(1);
            firma2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            firma2.DefaultCell.Border = 0;
            //firma2.DefaultCell.BorderWidthBottom = 0;
            firma2.AddCell(new Paragraph("DEPTO DE COMPRAS", fuente));
            firma2.AddCell(Subrayado("          ", fuente));

            var firma3 = new PdfPTable(1);
            firma3.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            firma3.DefaultCell.Border = 0;
            //firma3.DefaultCell.BorderWidthBottom = 0;
            firma3.AddCell(new Paragraph("SUBDIRECTOR DE COMPRAS Y SUMINISTROS", fuente));
            firma3.AddCell(Subrayado("          ", fuente));

            var etiqueta1 = new PdfPTable(1);
            etiqueta1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            etiqueta1.DefaultCell.Border = 0;
            //etiqueta1.DefaultCell.BorderWidthBottom = 0;
            etiqueta1.AddCell(new Paragraph("DIAS DE RECEPCION DE FACTURAS EN EL", fuente));
            etiqueta1.AddCell(new Paragraph("DEPTO. DE CONTROL PRESUPUESTAL", fuente));
            etiqueta1.AddCell(new Paragraph("", fuente));
            etiqueta1.AddCell(new Paragraph("MARTES Y JUEVES DE 10:00 A 14:00 HRS.", fuente));

            result.AddCell(firma1);
            result.AddCell(firma2);
            result.AddCell(firma3);
            result.AddCell(etiqueta1);

            result.DefaultCell.Colspan = 4;
            result.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            result.AddCell(new Paragraph("PAGO VER OBSERVACIONES AL REVERSO", fuenteRojo));

            return result;

        }


        private void GenerarCeldas(int numCeldas, PdfPTable tabla)
        {
            for (int i = 1; i <= numCeldas; i++)
            {
                tabla.AddCell("");
            }
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
            arriba.AddCell(new Paragraph("PEDIDO/CONTRATO POR MONTO DE ADQUISICIÓN DE BIENES QUE CELEBRAN POR UNA PARTE EL INSTITUTO NACIONAL DE REHABILITACIÓN, A QUIEN EN LO SUCESIVO Y PARA EFECTO DEL PRESENTE INSTRUMENTO SE LE", fuente));
            arriba.AddCell(new Paragraph(" DENOMINARÁ “EL INR” Y POR OTRA PARTE A QUIEN SE DESIGNARÁ COMO  “EL PROVEEDOR”, LOS NOMBRES Y LOS DOMICILIOS DE LAS PARTES SON LOS QUE SE SEÑALAN EN EL ANVERSO DE ESTE DOCUMENTO.", fuente));
            result.AddCell(arriba);
            result.DefaultCell.Colspan = 1;
            //result.DefaultCell.Border = 1;

// ReSharper disable AssignNullToNotNullAttribute
            var sr1 = new StreamReader(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.clausula1.txt"),Encoding.Default);
// ReSharper restore AssignNullToNotNullAttribute
// ReSharper disable AssignNullToNotNullAttribute
            var sr2 = new StreamReader(assembly.GetManifestResourceStream("Adquisiciones.View.Resources.clausula2.txt"),Encoding.Default);
// ReSharper restore AssignNullToNotNullAttribute
            string clausula1 = sr1.ReadToEnd();
            string clausula2 = sr2.ReadToEnd(); 
            sr2.Close();
            sr1.Close();
            result.AddCell(new Paragraph(clausula1, fuente));
            result.AddCell(new Paragraph(clausula2, fuente));

            var anotacion = new PdfPTable(1);
            anotacion.DefaultCell.Border = 0;
            anotacion.AddCell(new Paragraph("EL PROVEEDOR ACEPTA LAS CONDICIONES EN ESTE PEDIDO/CONTRATO POR MONTO DE ADQUISICIÓN.", fuente));
            GenerarCeldas(10,anotacion);
            
            anotacion.AddCell(new Paragraph("NOMBRE DEL REPRESENTANTE LEGAL", fuente));
            GenerarCeldas(10, anotacion);

            anotacion.AddCell(new Paragraph("CARGO:", fuente));
            GenerarCeldas(10, anotacion);

            var subTabla = new PdfPTable(2);
            subTabla.DefaultCell.Border = 0;

            var firma = new PdfPTable(1);
            firma.DefaultCell.Border = 0;
            firma.AddCell(new Paragraph("FIRMA DE CONFORMIDAD:", fuente));
            GenerarCeldas(10, anotacion);

            var telefono = new PdfPTable(4);
            telefono.DefaultCell.Colspan = 4;
            telefono.DefaultCell.Border = 0;
            telefono.AddCell(new Paragraph("TELÉFONO(S)",fuente));
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.DefaultCell.Colspan = 1;
            telefono.AddCell("");
            telefono.AddCell(new Paragraph("DIA",fuente));
            telefono.AddCell(new Paragraph("MES",fuente));
            telefono.AddCell(new Paragraph("AÑO",fuente));
            telefono.AddCell(new Paragraph("FECHA",fuente));
            telefono.AddCell("");
            telefono.AddCell("");
            telefono.AddCell("");

            subTabla.AddCell(firma);
            subTabla.AddCell(telefono);

            anotacion.AddCell(subTabla);

            anotacion.AddCell(new Paragraph("EL PROVEEDOR ACREDITA SU EXISTENCIA LEGAL Y FACULTADES DE SU REPRESENTANTE LEGAL MEDIANTE.", fuente));
            GenerarCeldas(10, anotacion);
            
            anotacion.AddCell(new Paragraph("OBSERVACIONES", fuente));
            GenerarCeldas(10, anotacion);

            result.AddCell(anotacion);return result;

        }


        public void GenerarAnverso()
        {
            var document = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 80);

            fileAnverso = System.IO.Path.GetTempFileName();

            var writer = PdfWriter.GetInstance(document, new FileStream(fileAnverso,
                FileMode.Create));
            writer.PageEvent = this;

            document.Open();

            var anverso = new PdfPTable(1);
            anverso.WidthPercentage = 100;
            //anverso.DefaultCell.Border = 1;

            anverso.HeaderRows = 1;

            var cabeza = new PdfPTable(new float[] { 60, 40 });
            cabeza.DefaultCell.Border = 0;
            cabeza.AddCell(this.Encabezado());
            cabeza.AddCell(this.Etiquetas());
            cabeza.DefaultCell.Colspan = 2;
            cabeza.AddCell(this.CabeceraDetalle());

            anverso.AddCell(cabeza);
            anverso.AddCell(this.Detalle());
            //anverso.AddCell(this.Firmas());

            //anverso.FooterRows = 1;

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

        public void GenerarReporte()
        {
            GenerarAnverso();
            GenerarReverso();

            var anversoReader = new PdfReader(fileAnverso);
            var reversoReader = new PdfReader(fileReverso);

            var document = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);

            var filePedido = System.IO.Path.GetTempFileName() + ".pdf";

            var copy = new PdfCopy(document, new FileStream(filePedido, FileMode.Create));

            document.Open();

            for (var page = 1; page <= anversoReader.NumberOfPages; page++)
            {
                copy.AddPage(copy.GetImportedPage(anversoReader, page));
                copy.AddPage(copy.GetImportedPage(reversoReader, 1));
            }

            copy.Close();
            anversoReader.Close();reversoReader.Close();

            Process.Start("cmd", "/c " + filePedido);

        }

        public static byte[] AddPageNumbers(byte[] pdf)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(pdf, 0, pdf.Length);
            // we create a reader for a certain document
            PdfReader reader = new PdfReader(pdf);
            // we retrieve the total number of pages
            int n = reader.NumberOfPages;
            // we retrieve the size of the first page
            Rectangle psize = reader.GetPageSize(1);

            // step 1: creation of a document-object
            Document document = new Document(psize, 50, 50, 50, 50);
            // step 2: we create a writer that listens to the document
            PdfWriter writer = PdfWriter.GetInstance(document, ms);
            // step 3: we open the document

            document.Open();
            // step 4: we add content
            PdfContentByte cb = writer.DirectContent;

            int p = 0;
            Console.WriteLine("There are " + n + " pages in the document.");
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                document.NewPage();
                p++;

                PdfImportedPage importedPage = writer.GetImportedPage(reader, page);
                cb.AddTemplate(importedPage, 0, 0);

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.BeginText();
                cb.SetFontAndSize(bf, 10);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, +p + "/" + n, 7, 44, 0);
                cb.EndText();
            }
            // step 5: we close the document
            document.Close();
            return ms.ToArray();
        }
       

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            var footerTbl = new PdfPTable(1);
            footerTbl.TotalWidth = 790;
            //footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
            var cell = new PdfPCell(this.Firmas());
            cell.Border = 0;
            cell.PaddingLeft = 10;
            footerTbl.AddCell(cell);
            footerTbl.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            footerTbl.DefaultCell.Border = 0;
            footerTbl.AddCell(writer.PageNumber+"");
            footerTbl.WriteSelectedRows(0, -1, -5, 80, writer.DirectContent);

        }
    }
}
