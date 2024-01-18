using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pantalla_Cliente
{
    public partial class VentanaPDF : Form
    {
        public VentanaPDF()
        {
            InitializeComponent();
            this.Size = new Size(1250, 750);
            //cargarPDF();
            cmbFiltro.Items.Add("id");
            cmbFiltro.Items.Add("apellidos");
            cmbFiltro.Items.Add("contrasenya");
            cmbFiltro.Items.Add("estado");
            cmbFiltro.Items.Add("nombre");
            cmbFiltro.Items.Add("nombre_usuario");


        }
        /*
        private void VentanaPDF_Load(object sender, EventArgs e)
        {
            cargarPDF();
        }
        private void cargarPDF()
        {
            axAcroPDF.src = "C:/Users/hamon/Documents/GitHub/2damTransita3Interfaces/2damTransita3Interfaces/Pantalla_Cliente/bin/Debug/ReporteProducto.pdf";
        }*/

        private void btnGenerarLista_Click_1(object sender, EventArgs e)
        {
            crearPDF();
            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);

            //Console.WriteLine(rutaCompleta);
            axAcroPDF.src = rutaCompleta;
        }

        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "apellidos", "contrasenya", "estado", "nombre", "nombre_usuario" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            string sql = "SELECT id, apellidos, contrasenya, estado, nombre, nombre_usuario FROM cliente ";//WHERE nombre = '"+filtro+"'";


            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();

            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["apellidos"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["contrasenya"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["estado"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre_usuario"].ToString()).SetFont(fontContenido)));

                

            }
            documento.Add(tabla);

            documento.Close();


            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/hamon/Pictures/12.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var titulo = new Paragraph("Reporte de productos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();

            documento.Close();
            pdfWriter.Close();
        }



        //Filtros
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem as string;
            string filtroValor = txtFiltro.Text;

            // Validar que se haya seleccionado un filtro y que se haya proporcionado un valor
            if (string.IsNullOrEmpty(filtroSeleccionado) || (txtFiltro.Visible && string.IsNullOrEmpty(filtroValor)))
            {
                MessageBox.Show("Por favor, seleccione un filtro y proporcione un valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = $"SELECT id, apellidos, contrasenya, estado, nombre, nombre_usuario FROM cliente WHERE {filtroSeleccionado} = '{filtroValor}'";


            crearPDFFiltro(sql);

            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);

            //Console.WriteLine(rutaCompleta);
            axAcroPDF.src = rutaCompleta;
        }

        private void crearPDFFiltro(string filtro)
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "apellidos", "contrasenya", "estado", "nombre", "nombre_usuario" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            string sql =filtro;


            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();

            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
               
                tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["apellidos"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["contrasenya"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["estado"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre_usuario"].ToString()).SetFont(fontContenido)));

                

            }
            documento.Add(tabla);

            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/hamon/Pictures/12.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var titulo = new Paragraph("Reporte de productos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i < numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();
        }

       

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirPdf("Reporte.pdf");
        }
        private void ImprimirPdf(string ruta)
        {
            try
            {
                using (PrintDocument printDocument = new PrintDocument())
                {
                    printDocument.PrintPage += (s, ev) =>
                    {
                        using (System.Drawing.Image image = System.Drawing.Image.FromFile(ruta))
                        {
                            ev.Graphics.DrawImage(image, ev.Graphics.VisibleClipBounds);
                        }
                    };

                    using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
                    {
                        printPreviewDialog.Document = printDocument;
                        printPreviewDialog.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerRutaCompleta(string rutaRelativa)
        {
            return System.IO.Path.GetFullPath(rutaRelativa);
        }

       

        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem as string;

            // Configurar el TextBox según tus necesidades para diferentes opciones
            txtFiltro.Visible = (filtroSeleccionado == "nombre" || filtroSeleccionado == "apellidos" || filtroSeleccionado == "contrasenya" || filtroSeleccionado == "estado" || filtroSeleccionado == "nombre_usuario" || filtroSeleccionado == "id");

            // Puedes establecer un valor predeterminado si es necesario
            if (txtFiltro.Visible)
            {
                txtFiltro.Text = "";
            }
        }
    }
}

