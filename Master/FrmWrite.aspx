<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmWrite.aspx.cs" Inherits="BoardProject.Master.FrmWrite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="board">
        <table>
            <tr>
                <td align="center" colspan="2">
                    <h3>게시판 글<asp:Label ID="lbl_title" runat="server" Text="쓰기"></asp:Label></h3>
                </td>
            </tr>
            <tr>
                <td>작성자 : </td>
                <td>
                    <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>비밀번호 : </td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" Width="150px"></asp:TextBox>
                    <asp:Label ID="lbl_valpass" runat="server" Text="*필수"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr />
                </td>
            </tr>
            <tr>
                <td>글제목</td>
                <td>
                    <asp:TextBox ID="txttitle" runat="server" Width="220px"></asp:TextBox>
                    <asp:Label ID="lbl_valtitle" runat="server" Text="*필수"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>글내용</td>
                <td>
                    <asp:TextBox ID="txtcontents" runat="server" Height="100px" Width="400px" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="right">
                    <asp:Button ID="btnWrite" runat="server" Text="게시물 등록" OnClick="btnWrite_Click" />
                    <asp:Button ID="btnList" runat="server" Text="리스트" OnClick="btnList_Click" />
                </td>
                <td>
            </tr>
        </table>
    </div>
</asp:Content>
