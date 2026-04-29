using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class RequisicionesDocument : IDocument
    {
        private readonly List<RequisicionAprobada> _requisiciones;

        public RequisicionesDocument(List<RequisicionAprobada> requisiciones)
        {
            _requisiciones = requisiciones;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(40);
                page.Size(PageSizes.Letter.Landscape());
                page.DefaultTextStyle(x => x.FontSize(9));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().BorderBottom(2).BorderColor(Colors.Blue.Darken2)
                    .PaddingBottom(10).Column(col =>
                    {
                        col.Item().Text("Reporte de Requisiciones Aprobadas")
                            .FontSize(18)
                            .Bold()
                            .FontColor(Color.FromRGB(0, 167, 62));

                        col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}")
                            .FontSize(9);

                        col.Item().Text($"Total: {_requisiciones.Count} requisiciones")
                            .FontSize(10)
                            .Bold();
                    });
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(15).Table(table =>
            {
                // Definir columnas
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(40);   // ID
                    columns.ConstantColumn(80);   // Referencia
                    columns.RelativeColumn(1.5f); // Remitente
                    columns.RelativeColumn(1.5f); // Aprobador
                    columns.RelativeColumn(1.2f); // Departamento
                    columns.ConstantColumn(70);   // Código Evento
                    columns.RelativeColumn(2);    // Nombre Evento
                    columns.ConstantColumn(75);   // Fecha Creación
                    columns.ConstantColumn(75);   // Fecha Caducidad
                });

                // Header
                table.Header(header =>
                {
                    header.Cell().Element(HeaderStyle).Text("ID");
                    header.Cell().Element(HeaderStyle).Text("Referencia");
                    header.Cell().Element(HeaderStyle).Text("Remitente");
                    header.Cell().Element(HeaderStyle).Text("Aprobador");
                    header.Cell().Element(HeaderStyle).Text("Departamento");
                    header.Cell().Element(HeaderStyle).Text("Cód. Evento");
                    header.Cell().Element(HeaderStyle).Text("Nombre Evento");
                    header.Cell().Element(HeaderStyle).Text("F. Creación");
                    header.Cell().Element(HeaderStyle).Text("F. Caducidad");
                });

                // Filas
                foreach (var req in _requisiciones)
                {
                    table.Cell().Element(CellStyle).Text(req.RequisicionID.ToString());
                    table.Cell().Element(CellStyle).Text(req.Referencia ?? "");
                    table.Cell().Element(CellStyle).Text(req.Remitente ?? "");
                    table.Cell().Element(CellStyle).Text(req.Aprobador ?? "");
                    table.Cell().Element(CellStyle).Text(req.DepartamentoDestino ?? "");
                    table.Cell().Element(CellStyle).Text(req.CodigoEvento ?? "");
                    table.Cell().Element(CellStyle).Text(req.NombreEvento ?? "");
                    table.Cell().Element(CellStyle).Text(req.FechaCreacion.ToString("dd/MM/yyyy"));
                    table.Cell().Element(CellStyle).Text(req.FechaCaducidad.ToString("dd/MM/yyyy"));
                }
            });

            static IContainer HeaderStyle(IContainer container)
            {
                return container
                    .Background(Colors.Grey.Lighten2)
                    .Padding(5)
                    .BorderBottom(1)
                    .BorderColor(Colors.Black)
                    .AlignCenter();
            }

            static IContainer CellStyle(IContainer container)
            {
                return container
                    .Padding(4)
                    .BorderBottom(1)
                    .BorderColor(Colors.Grey.Lighten3);
            }
        }

        private void ComposeFooter(IContainer container)
        {
            container.AlignCenter().Text(text =>
            {
                text.Span("Página ");
                text.CurrentPageNumber();
                text.Span(" de ");
                text.TotalPages();
            });
        }
    }
}
