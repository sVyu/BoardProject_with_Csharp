<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmCheck.aspx.cs" Inherits="BoardProject.Master.FrmCheck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="frmCheck">
        <tr>
            <td colspan="2">◎ 삭제 : 재확인이 필요합니다</td>
        </tr>
        <tr>
            <td colspan="2">◎ 제목 : [<asp:Label ID="lbl_title" runat="server" Text=""></asp:Label>]<hr /></td>
        </tr>
        <tr>
            <td style="width:50px">ID : </td>
            <td align="left"><asp:Label ID="lbl_ID" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="width:50px">PW : </td>
            <td ><asp:TextBox ID="txtPW" runat="server" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label ID="lbl_error" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <br />
                <asp:Button ID="btn_cancle" runat="server" Text="취소" OnClick="btn_cancle_Click"/>&nbsp;
                <asp:Button ID="btn_delete" runat="server" Text="삭제" OnClick="btn_delete_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
