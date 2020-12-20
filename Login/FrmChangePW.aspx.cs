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
    public partial class FrmChangePW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_id.Text = Request["id"];
        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            // (정상) 비밀번호가 비어있는게 아니면서 확인 비밀번호랑도 일치하는 경우,
            if((txt_pw.Text != "") && (txt_pw.Text == txt_pw_check.Text))
            {
                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                conn.Open();

                string updateSql = "update member set pw=@pw where id=@id";
                SqlCommand cmd = new SqlCommand(updateSql, conn);
                cmd.Parameters.AddWithValue("@pw", txt_pw.Text);
                cmd.Parameters.AddWithValue("@id", Request["id"]);
                cmd.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("FrmLogin.aspx");
            }
            else
            {
                if(txt_pw.Text == "")
                {
                    lbl_error.Text = "* 새로운 비밀번호를 입력하세요 *";
                }
                else
                {
                    lbl_error.Text = "* 비밀번호가 서로 일치하지 않습니다 *";
                }
            }
        }
    }
}