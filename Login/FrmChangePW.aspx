<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="FrmChangePW.aspx.cs" Inherits="BoardProject.Login.FrmChangePW" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="frmChangePW">
        <table>
            <tr>
                <td>ID : </td>
                <td><asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>새 비밀번호 : </td>
                <td><asp:TextBox ID="txt_pw" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>새 비밀번호(확인) : </td>
                <td><asp:TextBox ID="txt_pw_check" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="right"><asp:Button ID="btn_check" runat="server" Text="비밀번호 변경" Onclick="btn_check_Click"/></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <br /><br /><br /><br /><br />
                    <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
