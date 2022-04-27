using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoAn
{
    public partial class CustomQuery : System.Web.UI.Page
    {

        private MsSqlConnectionParameters connectionParameters;
        protected void Page_Load(object sender, EventArgs e)
        {
            connectionParameters = Session["connectionParameters"] as MsSqlConnectionParameters;
            ASPxQueryBuilder1.OpenConnection(connectionParameters);
        }

        protected void PrintReportButton_Click(object sender, EventArgs e)
        {
            string queryString = SqlTextBox.Text;
            string nameReport = NameReportTextbox.Text;
            string pageSetup = PageSetupRadioList.SelectedValue;
            List<string> error = new List<string>();
            if (string.IsNullOrEmpty(queryString))
            {
                error.Add("SQL command");
            }
            if (string.IsNullOrEmpty(nameReport))
            {
                error.Add("name of report");
            }
            if (error.Count == 2)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Missing " + error[0] + " and " + error[1] + "')", true);
            } 
            else if (error.Count == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Missing " + error[0] + "')", true);
            }
            else
            {
                string connectionString = @"Data Source=" + connectionParameters.ServerName +
                    ";Initial Catalog=" + connectionParameters.DatabaseName +
                    ";User ID=" + connectionParameters.UserName +
                    ";Password=" + connectionParameters.Password;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, conn);
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Your SQL command is incorrect, check it again!')", true);
                        return;
                    }
                }
                Session["nameReport"] = nameReport;
                Session["pageSetup"] = pageSetup;
                Session["queryString"] = queryString;
                Response.Redirect("ViewReport.aspx");
            }
        }
    }
}