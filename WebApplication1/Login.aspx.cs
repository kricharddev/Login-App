using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["FIRST_NAME"] = null;
                Session["LAST_NAME"] = null;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUserName.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "UsernameMissing", "alert('Username is Required');", true);
                return;
            }
            else if (string.IsNullOrWhiteSpace(this.txtUserName.Text.Trim()))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "UsernameMissing", "alert('Username is Required');", true);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "PasswordMissing", "alert('Password is Required');", true);
                return;
            }
            else if (string.IsNullOrWhiteSpace(this.txtPassword.Text.Trim()))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "PasswordMissing", "alert('Password is Required');", true);
                return;
            }
            string user = this.txtUserName.Text.Trim().ToLower();
            string password = this.txtPassword.Text.Trim();

            this.login(user,password);
        }

        private void login(string user, string password)
        {
            var connectionString = string.Format(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source={0}App_Data\DB.mdb;Persist Security Info=False;",
                HttpRuntime.AppDomainAppPath);
            using (var cn = new OleDbConnection(connectionString))
            {
                cn.Open();
                string sql = string.Format("select * from USERS where user_name='{0}' and password='{1}'", user, password);
                using (var cm = new OleDbCommand(sql, cn))
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["FIRST_NAME"].ToString();
                            string lastName = reader["LAST_NAME"].ToString();
                            //string msgSuccess = string.Format("Welcome {0} {1}, you are now logged in.", firstName, lastName);
                            //ScriptManager.RegisterStartupScript(this, this.GetType(), "LoginMessage",
                            //    string.Format("alert('{0}');", msgSuccess), true);
                            Session["FIRST_NAME"] = firstName;
                            Session["LAST_NAME"] = lastName;
                            Response.Redirect(this.ResolveUrl("~/ValidationPage.aspx"));
                            return;
                        }
                    }
                }

                cn.Close();

                string msg = "Login Failed, Please Try Again";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "LoginMessage",
                    string.Format("alert('{0}');", msg), true);
            }
        }
    }
}