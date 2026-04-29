using CapaEntidades;
using CapaNegocio;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;


namespace CapaPresentación
{
    public partial class FormReporte : Form
    {
        RequisicionServicio servicio = new RequisicionServicio();


        public FormReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos
                var requisiciones = servicio.ObtenerRequisicionesAprobadas();

                if (requisiciones.Count == 0)
                {
                    MessageBox.Show("No hay requisiciones aprobadas para generar el reporte.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear documento
                var document = new RequisicionesDocument(requisiciones);

                // Guardar archivo
                var saveDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = $"Requisiciones_Aprobadas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf",
                    DefaultExt = "pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    document.GeneratePdf(saveDialog.FileName);

                    var result = MessageBox.Show(
                        "Reporte generado exitosamente. ¿Desea abrir el archivo?",
                        "Éxito",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer1);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\User\Desktop\Practicas Arquitectura Soft\RequisicionesAprobadas\RequisicionesAprobadas\bin\Debug\RequisicionesAprobadas.exe");

        }
    }
}

