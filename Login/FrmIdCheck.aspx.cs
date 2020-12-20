using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoardProject.Login
{
    public partial class FrmIdCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // DB 커넥션
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from member where id=@id";
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);

            // 아이디가 있는지 없는지 체크합니다
            SqlDataReader dr = cmd.ExecuteReader();
            if(!dr.Read())
            {
                dr.Close();
                conn.Close();
                lbl_error.Text = "* 없는 ID 입니다 *";
            }
            else
            {
                dr.Close();
                conn.Close();
                string queryString = "id=" + txtID.Text;
                Response.Redirect("FrmQueCheck.aspx?" + queryString);
            }
        }
    }
}