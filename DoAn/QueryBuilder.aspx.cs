using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoAn
{
    public partial class QueryBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsSqlConnectionParameters connectionParameters = Session["connectionParameters"] as MsSqlConnectionParameters;
            ASPxQueryBuilder1.OpenConnection(connectionParameters);
        }

        protected void ASPxQueryBuilder1_SaveQuery(object sender, DevExpress.XtraReports.Web.SaveQueryEventArgs e)
        {
            string nameReport = NameReportTextbox.Text;
            string pageSetup = PageSetupRadioList.SelectedValue;
            if (string.IsNullOrEmpty(nameReport))
            {
                NameInEnglish.Text = "Error";
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Type in field 'Name of report'')", true);
            }
            else
            {
                string queryString = e.SelectStatement;
                Session["nameReport"] = nameReport;
                Session["pageSetup"] = pageSetup;
                Session["queryString"] = queryString;
                ASPxEdit.RedirectOnCallback("ViewReport.aspx");
            }
        }
    }
}