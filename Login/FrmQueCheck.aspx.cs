using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoardProject.Login
{
    public partial class FrmQueCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // QueryString으로 넘겨준 id를 받아서 lbl_id.Text로 set 합니다
                lbl_id.Text = Request["id"];

                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                conn.Open();

                //string selectSql = "select * from member where id=" + Request["id"].ToString();
                string selectSql = "select * from member where id=@id";
                SqlCommand cmd = new SqlCommand(selectSql, conn);
                cmd.Parameters.AddWithValue("@id", Request["id"]);

                // 해당 ID의 que(question, 질문) 항목을 가져와서 lbl_que.Text에 저장합니다
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    lbl_que.Text = dr["que"].ToString();
                }
                
                dr.Close();
                conn.Close();
            }
        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            //string selectSql = "select * from member where id=@" + Request["id"];
            string selectSql = "select * from member where id=@id";
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            cmd.Parameters.AddWithValue("@id", Request["id"]);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string answer = dr["ans"].ToString();
            dr.Close();
            conn.Close();

            // 해당 id의 설정된 ans(answer,답)와 txtAns.Text가 일치하는 경우,
            if(txtAns.Text == answer)
            {
                string querystring = "id=" + Request["id"];
                Response.Redirect("FrmChangePW.aspx?" + querystring);
            }
            // 그렇지 않은 경우,
            else
            {
                lbl_error.Text = "* 설정된 답이 아닙니다 *";
            }
        }
    }
}