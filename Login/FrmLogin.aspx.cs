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
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hlink.NavigateUrl = "FrmIdCheck.aspx";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmRegister.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // ID 와 PassWord 둘 중 하나라도 비어있는 경우,
            if ((txtID.Text == "") || (txtPW.Text == ""))
            {
                lbl_error.Text = "* 입력을 확인하세요";
            }
            else // 그 외의 경우(입력 Text는 채워져 있는 상태입니다)
            {
                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
                conn.Open();

                string selectsql = "select * from member where id=@id";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                // 아이디가 없는 경우
                if (!dr.Read())
                {
                    lbl_error.Text = "* 없는 ID 입니다";
                    dr.Close();
                    conn.Close();
                }

                // 아이디가 있는 경우
                else
                {
                    string pw = dr["pw"].ToString();
                    // PW 불일치
                    if (txtPW.Text != dr["pw"].ToString())
                    {
                        lbl_error.Text = "* PW가 일치하지 않습니다";
                        dr.Close();
                        conn.Close();
                    }
                    else // twtPW.Text == dr["pw"].ToString(), pw 일치, 로그인 성공
                    {
                        Application["id"] = dr["id"].ToString();
                        dr.Close();
                        conn.Close();
                        Response.Redirect("../Master/FrmBoardInfo.aspx");
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPW.Text = "";
        }
    }
}