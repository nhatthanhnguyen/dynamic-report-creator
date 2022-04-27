using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoAn
{
    public partial class Database : System.Web.UI.Page
    {
        private string serverName;
        private string username;
        private string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            serverName = Session["serverName"] as string;
            username = Session["username"] as string;
            password = Session["password"] as string;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=" + serverName + ";Initial Catalog=master;User ID=" + username + ";Password=" + password);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT name FROM master.dbo.sysdatabases WHERE dbid > 7", sqlConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                DatabaseDropDownList.Items.Insert(0, new ListItem(dataTable.Rows[i][0] as string));
            }
        }

        protected void ToQueryBuilder_Click(object sender, EventArgs e)
        {
            string database = DatabaseDropDownList.SelectedValue;
            Session["connectionParameters"] = new MsSqlConnectionParameters()
            {
                ServerName = serverName,
                DatabaseName = database,
                UserName = username,
                Password = password,
                AuthorizationType = MsSqlAuthorizationType.SqlServer
            };
            Response.Redirect("QueryBuilder.aspx");
        }

        protected void ToCustomQuery_Click(object sender, EventArgs e)
        {
            string database = DatabaseDropDownList.SelectedValue;
            Session["connectionParameters"] = new MsSqlConnectionParameters()
            {
                ServerName = serverName,
                DatabaseName = database,
                UserName = username,
                Password = password,
                AuthorizationType = MsSqlAuthorizationType.SqlServer
            };
            Response.Redirect("CustomQuery.aspx");
        }
    }
}