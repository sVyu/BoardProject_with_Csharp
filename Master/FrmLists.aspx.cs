using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoardProject.Master
{
    public partial class FrmLists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            // 로그인 과정을 거치지 않고 FrmLists.aspx로 들어온 경우, 글쓰기를 못 하게 합니다
            if(Application["id"].ToString() == "Guest")
            {
                lbl_error.Text = "* Guest는 글쓰기 권한이 없습니다 !!";
            }
            else
            {
                Response.Redirect("FrmWrite.aspx");
            }
        }
    }
}