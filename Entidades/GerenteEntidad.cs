using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;

namespace Entidades
{
    public class GerenteEntidad : UsuarioEntidad
    { 
        public GerenteEntidad(int id, string nombre, string apellido, long dni, string user, string contrasenia, string rol, string estado)
        : base(id, nombre, apellido, dni, user, contrasenia, rol, estado) { 
        //Rol = rol;
        }

        public void CrearInforme(DataTable ventasData, string filePath)
        {
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("Informe de Ventas"));
                doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
                doc.Add(new Paragraph(" ")); 

                PdfPTable table = new PdfPTable(ventasData.Columns.Count);

                foreach (DataColumn column in ventasData.Columns)
                {
                    table.AddCell(new Phrase(column.ColumnName));
                }

                foreach (DataRow row in ventasData.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        table.AddCell(new Phrase(cell.ToString()));
                    }
                }

                doc.Add(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el informe: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

    }
}
