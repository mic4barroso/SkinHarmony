using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PantallaInformes : Form
    {
        private GerenteEntidad gerente;

        public PantallaInformes()
        {
            InitializeComponent();
            gerente = new GerenteEntidad(1, "NombreGerente", "ApellidoGerente", 12345678, "userGerente", "passwordGerente", "gerente", "activo");
        }

        private void PantallaInformes_Load(object sender, EventArgs e)
        {
            CargarListaDePDFs();

        }

        private void CargarListaDePDFs()
        {
            listBox1.Items.Clear();
            var pdfs = ObtenerListaDePDFs();
            foreach (var pdf in pdfs)
            {
                listBox1.Items.Add(Path.GetFileName(pdf));
            }
        }

        private List<string> ObtenerListaDePDFs()
        {
            string folderPath = "C:\\Users\\barro\\Downloads"; // Cambia esto a la ruta donde almacenas los PDF
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return Directory.GetFiles(folderPath, "*.pdf").ToList();
        }

        private DataTable ObtenerDatosVentas()
        {
            DataTable dt = new DataTable();

            // Asegúrate de agregar columnas y filas
            dt.Columns.Add("NroVenta", typeof(int));
            dt.Columns.Add("FechaVenta", typeof(DateTime));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));
            dt.Columns.Add("MetodoPago", typeof(string));

            // Aquí debes agregar los datos reales desde tu base de datos
            // Ejemplo de agregar una fila:
            dt.Rows.Add(1, DateTime.Now, "Cliente 1", "Producto 1", 2, 100.00m, 200.00m, "Tarjeta");

            return dt;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedPDF = listBox1.SelectedItem.ToString();
                string folderPath = "C:\\Users\\barro\\Downloads"; // Cambia esto a la ruta donde almacenas los PDF
                string filePath = Path.Combine(folderPath, selectedPDF);
                //webBrowser1.Navigate(filePath);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable ventasData = ObtenerDatosVentas(); // Implementa este método para obtener los datos
            string folderPath = "C:\\Users\\barro\\Downloads"; // Cambia esto a la ruta donde almacenas los PDF
            string filePath = Path.Combine(folderPath, "InformeVentas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf");

            try
            {
                gerente.CrearInforme(ventasData, filePath);
                MessageBox.Show("Informe generado exitosamente.");
                CargarListaDePDFs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe: " + ex.Message);
            }
        }
    }
}

