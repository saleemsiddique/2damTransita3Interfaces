using AxAcroPDFLib;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class VentanaPDFIncidencia : Form
    {
        private List<Incidencia> incidenciasList;
        private IncidenciaService incidenciaService = new IncidenciaService();

        public VentanaPDFIncidencia()
        {
            InitializeComponent();
            cmbFiltroInciden.Items.Add("id");
            cmbFiltroInciden.Items.Add("estado");
            cmbFiltroInciden.Items.Add("fecha_hora");
        }

        private async void btnGenerarListaInci_Click(object sender, EventArgs e)
        {
            await crearPDF();
            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);
            axAcroPDFIncidencia.src = rutaCompleta;
        }

        private async Task ObtenerIncidencias()
        {
            incidenciasList = await incidenciaService.GetAllIncidencia();
        }

        private async Task ObtenerIncidenciasFiltradas()
        {
            incidenciasList = await incidenciaService.GetIncidenciasFiltradas(cmbFiltroInciden.Text, txtFiltroIncid.Text);
        }

        private async Task crearPDF()
        {
            await ObtenerIncidencias();
            string nombreArchivo = $"Reporte_{DateTime.Now:yyyyMMddHHmmss}.pdf"; // Generar nombre de archivo único
            PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "duracion", "estado", "fecha_hora", "cliente_id", "punto_id" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            foreach (Incidencia i in incidenciasList)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(i.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.duracion.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.estado.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.fechaHora.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.cliente.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.punto.id.ToString()).SetFont(fontContenido)));
            }
            documento.Add(tabla);

            documento.Close();

            var titulo = new Paragraph("Reporte de productos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(nombreArchivo), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i < numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();
        }

        private async void btnFiltrarInci_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltroInciden.SelectedItem as string;
            string filtroValor = txtFiltroIncid.Text;

            if (string.IsNullOrEmpty(filtroSeleccionado) || (txtFiltroIncid.Visible && string.IsNullOrEmpty(filtroValor)))
            {
                MessageBox.Show("Por favor, seleccione un filtro y proporcione un valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await crearPDFFiltro();
            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);
            axAcroPDFIncidencia.src = rutaCompleta;
        }

        private async Task crearPDFFiltro()
        {
            await ObtenerIncidenciasFiltradas();
            string nombreArchivo = $"Reporte_{DateTime.Now:yyyyMMddHHmmss}.pdf"; // Generar nombre de archivo único
            PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "duracion", "estado", "fecha_hora", "cliente_id", "punto_id" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            foreach (Incidencia i in incidenciasList)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(i.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.duracion.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.estado.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.fechaHora.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.cliente.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(i.punto.id.ToString()).SetFont(fontContenido)));
            }
            documento.Add(tabla);

            documento.Close();

            var titulo = new Paragraph("Reporte de productos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(nombreArchivo), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i < numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();
        }

        private void cmbFiltroInciden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltroInciden.SelectedItem as string;

            txtFiltroIncid.Visible = (filtroSeleccionado == "id" || filtroSeleccionado == "descripcion" || filtroSeleccionado == "duracion" || filtroSeleccionado == "estado" || filtroSeleccionado == "fecha_hora" || filtroSeleccionado == "cliente_id" || filtroSeleccionado == "punto_id");

            if (txtFiltroIncid.Visible)
            {
                txtFiltroIncid.Text = "";
            }
        }
    }
}
