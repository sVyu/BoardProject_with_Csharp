using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoardProject
{
    public partial class Board : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 로그인을 거치지 않고 FrmLists 주소로 접속한 경우, Application["id"] = "Guest";로 할당
            if (Application["id"] == null)
            {
                Application["id"] = "Guest";
            }
            //id = Request.QueryString["id"];
            //lbl_id.Text = id;
            lbl_id.Text = Application["id"].ToString();

            // ddl 버튼 클릭 시 MultiView 이미지
            if (ddlSearch.SelectedIndex == 0)
                MultiView1.ActiveViewIndex = 0;

            else if (ddlSearch.SelectedIndex == 1)
                MultiView1.ActiveViewIndex = 1;
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            // logout을 한 경우, Application["id"]를 null로 초기화 하고 Login page로 Redirect합니다
            Application["id"] = null;
            Response.Redirect("../Login/FrmLogin.aspx");
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string url = "https://";
            if (ddlSearch.SelectedIndex == 0)
            {
                if(txtWord.Text == "")
                    url += "www.naver.com";
                else
                    url += "search.naver.com/search.naver?query=" + txtWord.Text;

                hlink.NavigateUrl = url;
            }

            else if (ddlSearch.SelectedIndex == 1)
            {
                if (txtWord.Text == "")
                    url += "www.google.com";
                else
                    url += "www.google.com/search?q=" + txtWord.Text;

                hlink.NavigateUrl = url;
            }
        }
    }
}