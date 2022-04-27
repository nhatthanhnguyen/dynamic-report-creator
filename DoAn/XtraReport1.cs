using DevExpress.DataAccess.Sql;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace DoAn
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public XtraReport1(object dataSource, string queryString, string nameReport, string pageSetup)
        {
            InitializeComponent();

            if (pageSetup == "Portail")
            {
                // portail
                this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            }
            else
            {
                // landscape
                this.PaperKind = System.Drawing.Printing.PaperKind.A4Rotated;
            }

            // Watermark text
            Watermark textWatermark = new Watermark();
            textWatermark.Text = "HỌC VIỆN CÔNG NGHỆ BƯU CHÍNH VIỄN THÔNG";
            textWatermark.TextDirection = DirectionMode.ForwardDiagonal;
            textWatermark.Font = new Font(textWatermark.Font.FontFamily, 30);
            textWatermark.ForeColor = Color.DodgerBlue;
            textWatermark.TextTransparency = 150;
            textWatermark.ShowBehind = false;
            textWatermark.PageRange = "All";
            this.Watermark.CopyFrom(textWatermark);

            SqlDataSource data = dataSource as SqlDataSource;
            if (data == null) return;

            // Create custom query
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = nameReport;
            query.Sql = queryString;

            // Add query to data source
            data.Queries.Add(query);
            data.RebuildResultSchema();
            data.Fill();

            // Bind the report to data source
            this.DataSource = data;
            this.DataMember = data.Queries[0].Name;

            // Init bands
            ReportHeaderBand reportHeader = new ReportHeaderBand();
            PageHeaderBand pageHeader = new PageHeaderBand();
            PageFooterBand pageFooter = new PageFooterBand();
            ReportFooterBand reportFooter = new ReportFooterBand();
            reportHeader.HeightF = 50;
            Detail.HeightF = 20;
            pageFooter.HeightF = 20;
            pageHeader.HeightF = 20;
            reportFooter.HeightF = 50;
            Bands.Add(reportHeader);
            Bands.Add(pageHeader);
            Bands.Add(pageFooter);
            Bands.Add(reportFooter);

            // Create report
            int colCount = ((IList)data.Result[nameReport].Columns).Count;
            if (colCount >= 7 && this.PaperKind == System.Drawing.Printing.PaperKind.A4)
            {
                this.PaperKind = System.Drawing.Printing.PaperKind.A4Rotated;
            }
            float colWidth = (this.PageWidth - (this.Margins.Left + this.Margins.Right)) / colCount;

            // title report
            XRLabel label = new XRLabel();
            label.Text = nameReport;
            label.Font = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            label.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
            label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            label.ForeColor = Color.Orange;

            // date and time 
            XRPageInfo dateAndTime = new XRPageInfo();
            dateAndTime.Font = new Font("Arial", 12, FontStyle.Underline, GraphicsUnit.Pixel);
            dateAndTime.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
            dateAndTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            dateAndTime.ForeColor = Color.Blue;
            dateAndTime.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            dateAndTime.StartPageNumber = 1;
            dateAndTime.TextFormatString = "Created at {0:h:mm tt dd MMMM yyyy}";

            
            // header table
            XRTable headerTable = new XRTable();
            headerTable.BeginInit();
            headerTable.Borders = DevExpress.XtraPrinting.BorderSide.All;
            var headerTableRow = new XRTableRow();
            foreach(var dc in data.Result[nameReport].Columns)
            {
                var cell = new XRTableCell()
                {
                    Text = dc.Name,
                    WidthF = colWidth,
                    HeightF = 40,
                    Font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel),
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    BackColor = Color.Gray,
                    ForeColor = Color.White,
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0F)
                };
                headerTableRow.Cells.Add(cell);
            }
            headerTable.Rows.Add(headerTableRow);
            headerTable.AdjustSize();
            headerTable.EndInit();

            // table bound to data
            XRTable detailTable = new XRTable();
            detailTable.BeginInit();
            detailTable.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            var detailTableRow = new XRTableRow();
            foreach(var dc in data.Result[nameReport].Columns)
            {
                var cell = new XRTableCell()
                {
                    Text = dc.Name,
                    WidthF = colWidth,
                    HeightF = 20,
                    Font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel),
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100.0F)
                };
                cell.ExpressionBindings.Add(new ExpressionBinding("Text", $"[{dc.Name}]"));
                detailTableRow.Cells.Add(cell);
            }
            detailTable.Rows.Add(detailTableRow);
            detailTable.AdjustSize();
            detailTable.EndInit();

            XRLabel labelFooter = new XRLabel();
            labelFooter.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            labelFooter.WidthF = this.PageWidth - this.Margins.Left - this.Margins.Right;
            labelFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            labelFooter.ForeColor = Color.Green;
            int rowCount = ((IList)data.Result[nameReport]).Count;
            labelFooter.Text = "The report has " + rowCount.ToString() + " record(s)";

            this.Bands[BandKind.ReportHeader].Controls.Add(label);
            this.Bands[BandKind.PageHeader].Controls.Add(headerTable);
            this.Bands[BandKind.Detail].Controls.Add(detailTable);
            this.Bands[BandKind.PageFooter].Controls.Add(dateAndTime);
            this.Bands[BandKind.ReportFooter].Controls.Add(labelFooter);
        }
    }
}
