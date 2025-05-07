using System;
using System.Configuration;
using System.Data.SqlClient;

namespace mywebapp {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }



        protected void Button2_Click(object sender, EventArgs e) {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select* from customer", conn);
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }
    }
}
