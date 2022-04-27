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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConnectButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WindowsForm\Website\DoAn\DoAn\App_Data\LoginInformation.mdf;Integrated Security=True");
            string usernameText = UsernameTextBox.Text;
            string passwordText = PasswordTextBox.Text;
            SqlDataAdapter loginDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE Username='" + usernameText + "' and Password='" + passwordText + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            loginDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Session["serverName"] = ServerNameDropDownList.SelectedValue;
                Session["username"] = usernameText;
                Session["password"] = passwordText;
                Response.Redirect("Database.aspx");
            } 
            else
            {
                List<string> errorField = new List<string>();
                if (string.IsNullOrEmpty(usernameText))
                {
                    errorField.Add("Username");
                }
                if (string.IsNullOrEmpty(passwordText))
                {
                    errorField.Add("Password");
                }
                if (errorField.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Wrong login detail!')", true);
                }
                else if (errorField.Count == 1)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Missing '" + errorField[0] + "')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Missing username and password!')", true);
                }
            }
        }
    }
}