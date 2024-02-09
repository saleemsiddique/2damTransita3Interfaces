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
using System.Web.Mvc;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class VentanaPDF : Form
    {
        private List<Cliente> clienteList;
        private ClienteService clienteService = new ClienteService();

        public VentanaPDF()
        {
            InitializeComponent();
            cmbFiltro.Items.Add("id");
            cmbFiltro.Items.Add("apellidos");
            cmbFiltro.Items.Add("estado");
            cmbFiltro.Items.Add("nombre");
            cmbFiltro.Items.Add("nombre_usuario");
        }

        private void btnGenerarLista_Click_1(object sender, EventArgs e)
        {
            crearPDF();
        }

        private async Task ObtenerClientes()
        {
            clienteList = await clienteService.GetAllCliente();
        }

        private async Task ObtenerClientesFiltrados()
        {
            clienteList = await clienteService.GetClientesFiltrado(cmbFiltro.Text, txtFiltro.Text);
        }

        private async Task crearPDF()
        {
            await ObtenerClientes();
            string nombreArchivo = "Reporte_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "nombre", "apellidos", "nombre_usuario", "estado" };

            float[] tamanios = { 2, 2, 2, 2, 2};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            foreach (Cliente c in clienteList)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(c.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.nombre.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.apellidos.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.nombreUsuario.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.estadoCuenta.ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();
            var rutaCompleta = System.IO.Path.GetFullPath(nombreArchivo);
            axAcroPDF.src = rutaCompleta;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem as string;
            string filtroValor = txtFiltro.Text;

            if (string.IsNullOrEmpty(filtroSeleccionado) || (txtFiltro.Visible && string.IsNullOrEmpty(filtroValor)))
            {
                MessageBox.Show("Por favor, seleccione un filtro y proporcione un valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            crearPDFFiltro();
        }

        private async void crearPDFFiltro()
        {
            await ObtenerClientesFiltrados();
            string nombreArchivo = "Reporte_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            PdfWriter pdfWriter = new PdfWriter(nombreArchivo);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "nombre", "apellidos", "nombre_usuario", "estado" };

            float[] tamanios = { 2, 2, 2, 2, 2};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            foreach (Cliente c in clienteList)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(c.id.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.nombre.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.apellidos.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.nombreUsuario.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.contrasenya.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(c.estadoCuenta.ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();
            var rutaCompleta = System.IO.Path.GetFullPath(nombreArchivo);
            axAcroPDF.src = rutaCompleta;
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

        private void cmbFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem as string;
            txtFiltro.Visible = (filtroSeleccionado == "nombre" || filtroSeleccionado == "apellidos" || filtroSeleccionado == "contrasenya" || filtroSeleccionado == "estado" || filtroSeleccionado == "nombre_usuario" || filtroSeleccionado == "id");
            if (txtFiltro.Visible)
            {
                txtFiltro.Text = "";
            }
        }
    }
}
