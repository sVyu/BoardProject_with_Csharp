using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace BoardProject.Master
{
    public partial class FrmCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // text set
            if(!IsPostBack)
            {
                lbl_ID.Text = Application["id"].ToString();
                lbl_title.Text = Request["title"];
            }
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            // 취소를 누른 경우, 해당 View 페이지로 넘어가게 합니다
            string queryString ="No="+ Request["No"];
            Response.Redirect("FrmView.aspx?" + queryString);
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectsql = "select * from member where id=@id";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            cmd.Parameters.AddWithValue("@id", Application["id"].ToString());
            cmd.ExecuteNonQuery();

            string password = "";   // 비밀번호를 load 하기 위한 password string
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                password = dr["pw"].ToString();
            }
            dr.Close();
            
            if(txtPW.Text == password)  // 비밀번호가 일치하는 경우
            {
                string deletesql = "delete from tblBrd where num=@num";
                cmd = new SqlCommand(deletesql, conn);
                cmd.Parameters.AddWithValue("@num", Request["NO"]);
                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("FrmLists.aspx");
            }
            else                        // 일치하지 않는 경우
            {
                if (txtPW.Text == "")
                    lbl_error.Text = "* 비밀번호를 입력하세요";
                else
                    lbl_error.Text = "* 비밀번호가 일치하지 않습니다";
                conn.Close();
            }
        }
    }
}