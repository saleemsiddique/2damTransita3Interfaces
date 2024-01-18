using AxAcroPDFLib;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
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
using System.IO;

namespace Pantalla_Cliente
{
    public partial class VentanaPDFPunto : Form
    {
        public VentanaPDFPunto()
        {
            InitializeComponent();

            cmbFiltroPunto.Items.Add("id");
            cmbFiltroPunto.Items.Add("accesibilidad");
            cmbFiltroPunto.Items.Add("descripcion");
            cmbFiltroPunto.Items.Add("latitud");
            cmbFiltroPunto.Items.Add("longitud");
            cmbFiltroPunto.Items.Add("tipo");
            cmbFiltroPunto.Items.Add("visibilidad");
        }

        private void btnGenerarListaPunto_Click(object sender, EventArgs e)
        {
            crearPDF();
            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);

            //Console.WriteLine(rutaCompleta);
            axAcroPDFPunto.src = rutaCompleta;

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
            string[] columnas = { "id", "accesibilidad", "descripcion", "latitud", "longitud", "tipo","visibilidad" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2,2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            string sql = "SELECT id, accesibilidad, descripcion, latitud, longitud, tipo, visibilidad FROM punto ";//WHERE nombre = '"+filtro+"'";


            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();

            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["accesibilidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["latitud"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["longitud"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["tipo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["visibilidad"].ToString()).SetFont(fontContenido)));




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

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();

            documento.Close();
            pdfWriter.Close();
        }

        //Filtro
        private void btnFiltrarPunto_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltroPunto.SelectedItem as string;
            string filtroValor = txtFiltroPunto.Text;

            // Validar que se haya seleccionado un filtro y que se haya proporcionado un valor
            if (string.IsNullOrEmpty(filtroSeleccionado) || (txtFiltroPunto.Visible && string.IsNullOrEmpty(filtroValor)))
            {
                MessageBox.Show("Por favor, seleccione un filtro y proporcione un valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = $"SELECT id, accesibilidad, descripcion, latitud, longitud, tipo, visibilidad FROM punto WHERE {filtroSeleccionado} = '{filtroValor}'";


            crearPDFFiltro(sql);
            string rutaRelativa = @"ReporteProducto.pdf";
            string rutaCompleta = System.IO.Path.GetFullPath(rutaRelativa);

            //Console.WriteLine(rutaCompleta);
            axAcroPDFPunto.src = rutaCompleta;
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
            string[] columnas = { "id", "accesibilidad", "descripcion", "latitud", "longitud", "tipo", "visibilidad" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2,2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }
            string sql = filtro;


            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();

            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["accesibilidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["descripcion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["latitud"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["longitud"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["tipo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["visibilidad"].ToString()).SetFont(fontContenido)));



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

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteProducto.pdf"));
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

        private void cmbFiltroPunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltroPunto.SelectedItem as string;

            // Configurar el TextBox según tus necesidades para diferentes opciones
            txtFiltroPunto.Visible = (filtroSeleccionado == "id" || filtroSeleccionado == "accesibilidad" || filtroSeleccionado == "descripcion" || filtroSeleccionado == "latitud" || filtroSeleccionado == "longitud" || filtroSeleccionado == "visibilidad" || filtroSeleccionado == "tipo");

            // Puedes establecer un valor predeterminado si es necesario
            if (txtFiltroPunto.Visible)
            {
                txtFiltroPunto.Text = "";
            }
        }
    }
}
