<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="FrmIdCheck.aspx.cs" Inherits="BoardProject.Login.FrmIdCheck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="frmIdCheck">
        <table>
            <tr>
                <td colspan="3" align="center">[비밀번호 찾기]</td>
            </tr>
            
            <tr>
                <td colspan="3" align="center">아이디 확인<hr /></td>
            </tr>
            <tr>
                <td>아이디 : </td>
                <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                <td><asp:Button ID="btnCheck" runat="server" Text="체크" OnClick="btnCheck_Click"/></td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <br /><br /><br /><br /><br />
                    <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
