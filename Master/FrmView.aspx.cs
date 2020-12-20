using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoardProject.Master
{
    public partial class FrmView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) // 최초 실행, DB에서 데이터 가져오고 해당 글의 조회수 1 증가
            {
                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["BoardConnectionString"].ConnectionString);
                conn.Open();

                //                                                      Request !
                string selectSql = "select * from tblBrd where num=" + Request["No"];
                SqlCommand cmd = new SqlCommand(selectSql, conn);
                cmd.ExecuteNonQuery();

                // Data Read로 값을 가져옵니다
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtname.Text = dr["name"].ToString();
                    txtwritedate.Text = dr["writedate"].ToString();
                    lbl_title.Text = dr["title"].ToString();
                    txtcontents.Text = dr["contents"].ToString();

                    // 조회수 1 증가를 위한 코드문
                    int cnt = int.Parse(dr["readcnt"].ToString()) + 1;
                    dr.Close();
                    string updateSql = "update tblBrd set readcnt=" + cnt + "where num=" + Request["NO"];
                    cmd = new SqlCommand(updateSql, conn);
                    cmd.ExecuteNonQuery();

                    txtreadcnt.Text = cnt.ToString();
                }
                conn.Close();
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmLists.aspx");
        }

        // 수정버튼 눌렀을 때,
        protected void CmdEdit_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                /*
                // DB 커넥션으로 구현했다가 txtname.Text로 간단하게 처리가 가능한 것을 발견하여 주석처리 하였습니다
                 
                // Application == 해당 글 작성자
                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                conn.Open();

                string selectsql = "select * from tblBrd where num=" + Request["NO"];
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                */
                //if (Application["id"].ToString() == dr["name"].ToString())   // 해당 글 작성자

                if (Application["id"].ToString() == txtname.Text)
                    {
                    //dr.Close();
                    //conn.Close();
                    Edit((string)e.CommandArgument);
                }
                else
                {
                    //dr.Close();
                    //conn.Close();
                    lbl_error.Text = " * 접근 제한 : 이 글의 작성자가 아닙니다 !";
                }
            }
            else
                lbl_error.Text = "* Code Error Detected !";

        }
        private void Edit(string commandArgument)
        {
            if(commandArgument == "Insert")         // 수정
            {
                string querystring = "No=" + Request["NO"];
                Response.Redirect("FrmWrite.aspx?" + querystring);
            }
            else if(commandArgument == "Delete")    // 삭제
            {
                string querystring = "title=" + lbl_title.Text;
                querystring += "&No=" + Request["No"];
                Response.Redirect("FrmCheck.aspx?" + querystring);
            }
            else  // 그 외의 경우( 존재해서는 안 되는 Error )
            {
                lbl_error.Text = "* Code Error Detected ! ";
            }
        }
    }
 }
