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
    public partial class FrmRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // DB 열고 연결 확인
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectsql = "select * from member where id=@id";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();

            // 정상적인 경우,
            SqlDataReader dr = cmd.ExecuteReader();
            if(!dr.Read())
            {
                dr.Close();

                string insertsql = "insert into member values(@id, @pw, @que, @ans)";
                cmd = new SqlCommand(insertsql, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@pw", txtPW.Text);
                cmd.Parameters.AddWithValue("@que", txtQue.Text);
                cmd.Parameters.AddWithValue("@ans", txtAns.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("FrmLogin.aspx");
            }

            // id가 이미 있는 경우
            else
            {
                dr.Close();
                conn.Close();
                lbl_check.Text = "[ Error : ID 중복 ]";
                MultiView1.ActiveViewIndex = 1;
            }
        }
    }
}