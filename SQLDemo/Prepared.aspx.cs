using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLDemo
{
    public partial class Prepared : System.Web.UI.Page
    {
        protected void Submit(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseConnection.ConnectionString))
                    {
                        conn.Open();
                        string query = "SELECT [email], [phone] FROM Users WHERE [name] = @name";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.Add("@name", SqlDbType.NVarChar, NameField.Text.Length).Value = NameField.Text;
                        command.Prepare();
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            Results.DataSource = table;
                            Results.DataBind();
                        } else
                        {
                            ErrorText.Text = "No Results Found";
                            ErrorMessage.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorText.Text = ex.ToString();
                    ErrorMessage.Visible = true;
                }
            }
        }
    }
}
