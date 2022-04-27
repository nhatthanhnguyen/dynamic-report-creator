using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DoAn
{
    public partial class ViewReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsSqlConnectionParameters connectionParameters = Session["connectionParameters"] as MsSqlConnectionParameters;
            SqlDataSource dataSource = new SqlDataSource(connectionParameters);
            string queryString = Session["queryString"] as string;
            string nameReport = Session["nameReport"] as string;
            string pageSetup = Session["pageSetup"] as string;
            var cachedReportSource = new CachedReportSourceWeb(new XtraReport1(dataSource, queryString, nameReport, pageSetup));
            ASPxWebDocumentViewer1.OpenReport(cachedReportSource);
        }
    }
}