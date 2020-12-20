<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="BoardProject.Login.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="frmLogin">
        <table>
            <tr>
                <td>ID : </td>
                <td colspan="2">
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>PassWord : </td>
                <td colspan="2">
                    <asp:TextBox ID="txtPW" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Button ID="btnRegister" runat="server" Text="회원가입" OnClick="btnRegister_Click" /></td>
                <td colspan="2" align="right">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />&nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="Reset" OnClick="btnCancel_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3" align="right">
                    <br />
                    <asp:HyperLink ID="hlink" runat="server">비밀번호 찾기</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <br /><br /><br /><br />
                    <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
