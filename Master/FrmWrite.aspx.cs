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
    public partial class FrmWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request["NO"] != null)  // 수정으로 들어온 경우
                {                           // (단순 글쓰기의 경우는 QueryString 이 없습니다)
                    lbl_title.Text = " 수정";

                    SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                    conn.Open();

                    string selectSql = "select * from tblBrd where num=@num";
                    SqlCommand cmd = new SqlCommand(selectSql, conn);
                    cmd.Parameters.AddWithValue("@num", Request["NO"]);
                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    // 제목과 내용을 DB에서 불러올 수 있도록 했습니다
                    txttitle.Text = dr["title"].ToString();
                    txtcontents.Text = dr["contents"].ToString();

                    dr.Close();
                    conn.Close();

                    btnWrite.Text = "게시물 수정";
                }
                if (Application["id"] != null)
                {
                    lbl_name.Text = Application["id"].ToString();
                }
            }
           
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            // name 은 Application에 저장한 id 에서 가져옵니다
            string name = Application["id"].ToString();
            int check = 0;      // 글쓰기 : 0, 수정 : 1

            // 수정일 경우
            if(Request["NO"] != null)
            {
                check = 1;
            }

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["BoardConnectionString"].ConnectionString);
            conn.Open();

            // 비밀번호 확인용 
            string selectSql = "select * from member where id=@id";
            SqlCommand cmd = new SqlCommand(selectSql, conn);
            cmd.Parameters.AddWithValue("@id", lbl_name.Text);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            string checkpass = "";
            if (dr.Read())
            {
                checkpass = dr["pw"].ToString();
            }
            dr.Close();

            if (checkpass == txtpass.Text)   // 비밀번호 확인 완료
            {
                if (check == 0)              // 글쓰기
                {
                    if (txttitle.Text != "")     // 제목도 이상 없을 때,
                    {                            // 추가!
                        string insertSql = "insert into tblBrd(name, title, contents, writedate, readcnt)  values (@name, @title, @contents, @writedate, @readcnt)";
                        cmd = new SqlCommand(insertSql, conn);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@title", txttitle.Text);
                        cmd.Parameters.AddWithValue("@contents", txtcontents.Text);
                        cmd.Parameters.AddWithValue("@writedate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@readcnt", "0");
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Response.Redirect("FrmLists.aspx");
                    }

                    else                         // 글쓰기인데, 제목이 없는 경우
                    {
                        lbl_valpass.Text = "* 확인 완료";
                        lbl_valtitle.Text = "* 제목을 입력하세요!";
                        conn.Close();
                    }
                }

                else  //check == 1, 즉, 수정으로 들어온 경우
                {
                    if (txttitle.Text != "") // 이상 없는 경우 update
                    {
                        string updateSql = "update tblBrd set title=@title, contents=@contents, writedate=@writedate where num=@num";
                        cmd = new SqlCommand(updateSql, conn);
                        cmd.Parameters.AddWithValue("@title", txttitle.Text);
                        cmd.Parameters.AddWithValue("@contents", txtcontents.Text);
                        cmd.Parameters.AddWithValue("@writedate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@num", Request["NO"]);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        Response.Redirect("FrmLists.aspx");
                        //Label1.Text = updateSql;
                    }
                    else                    // 이상 있는경우 error
                    {
                        lbl_valpass.Text = "* 확인 완료";
                        lbl_valtitle.Text = "* 제목을 입력하세요!";
                        conn.Close();
                    }
                }
            }

            else     // 비밀번호 불일치
            {
                if (txtpass.Text == "")
                    lbl_valpass.Text = "* 비밀번호를 입력하세요!";
                else
                {
                    lbl_valpass.Text = "* 비밀번호가 일치하지 않습니다";
                }

                if (txttitle.Text == "")
                    lbl_valtitle.Text = "* 제목을 입력하세요!";
                else
                    lbl_valtitle.Text = "";

                conn.Close();
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmLists.aspx");
        }
    }
}