<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmBoardInfo.aspx.cs" Inherits="BoardProject.Master.FrmBoardInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="board_info">
        <div class="board_info_image">
             <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/c-sharp.png" />
        </div>
        <div class="board_info_text">
            <p>모두를 위한 개방형 게시판입니다</p>
            <p>마음껏 사용해주기 바랍니다 !!</p>
            <br />
            <p>This is Open board for Everyone</p>
            <p>Feel free to use it !!</p>
        </div>
    </div>
</asp:Content>
