using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace mywebapp {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }


        protected void Insert_Click(object sender, EventArgs e) {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            try {
                using (SqlConnection conn = new SqlConnection(cs)) {

                    SqlCommand cmd = new SqlCommand("sp_addEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@EmpName", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Designetion", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@City", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Salary", TextBox5.Text);
                    conn.Open();
                    var rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0) {
                        Response.Write($"<script> alert('Recod insert successfully');</script>");
                    }
                    else {
                        Response.Write("<script>alert('No record found with the provided ID.');</script>");
                    }
                }
            } catch (SqlException ex) {

                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }

        }


        protected void Button1_Click(object sender, EventArgs e) {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            try {
                using (SqlConnection conn = new SqlConnection(cs)) {

                    SqlCommand cmd1 = new SqlCommand("sp_UpdateEmployee", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd1.Parameters.AddWithValue("@EmpName", TextBox2.Text);
                    cmd1.Parameters.AddWithValue("@Designetion", TextBox3.Text);
                    cmd1.Parameters.AddWithValue("@City", TextBox4.Text);
                    cmd1.Parameters.AddWithValue("@Salary", TextBox5.Text);
                    conn.Open();
                    var rowsAffected = cmd1.ExecuteNonQuery();

                    if (rowsAffected > 0) {
                        Response.Write("<script>alert('Record Update Successfully');</script>");
                    }
                    else {
                        Response.Write("<script>alert('No record found with the provided ID.');</script>");
                    }
                }
            } catch (SqlException ex) {

                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }
        }

        protected void Delete_Click(object sender, EventArgs e) {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            if (string.IsNullOrWhiteSpace(TextBox1.Text)) {
                Response.Write("<script>alert('Please provide a valid ID.');</script>");
                return;
            }

            try {
                using (SqlConnection conn = new SqlConnection(cs)) {
                    SqlCommand cmd2 = new SqlCommand("sp_DeletedEmployee", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd2.Parameters.AddWithValue("@EmpName", TextBox2.Text);
                    cmd2.Parameters.AddWithValue("@Designetion", TextBox3.Text);
                    cmd2.Parameters.AddWithValue("@City", TextBox4.Text);
                    cmd2.Parameters.AddWithValue("@Salary", TextBox5.Text);

                    conn.Open();
                    var rowsAffected = cmd2.ExecuteNonQuery();

                    if (rowsAffected > 0) {
                        Response.Write("<script>alert('Record Deleted Successfully');</script>");
                    }
                    else {
                        Response.Write("<script>alert('No record found with the provided ID.');</script>");
                    }
                }
            } catch (SqlException ex) {

                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }
        }

        protected void Show_Click(object sender, EventArgs e) {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            try {
                using (SqlConnection conn = new SqlConnection(cs)) {

                    SqlDataAdapter da = new SqlDataAdapter("select * from Employee", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Response.Write($"<script> alert('Records Retrieved Successfully');</script>");
                }
            } catch (SqlException ex) {
                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e) {

        }
    }
}
