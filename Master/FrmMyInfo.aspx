<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmMyInfo.aspx.cs" Inherits="BoardProject.Master.FrmMyInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="board_info">
        <div class="board_info_image">
             <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/gachon.png" />
        </div>
        <div class="board_info_text">
            <p>가천대학교 컴퓨터공학과</p>
            <p>3학년 윤병헌 (201533797)</p>
            <br />
            <p>e-mail : vyuvyu@gc.gachon.ac.kr</p>
            <p>phone number : 010 - 5441 - 9657</p>
        </div>
    </div>
</asp:Content>
