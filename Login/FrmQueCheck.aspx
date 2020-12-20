<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="FrmQueCheck.aspx.cs" Inherits="BoardProject.Login.FrmQueCheck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="frmQueCheck">
        <table>
            <tr>
                <td>ID : </td>
                <td colspan="2"><asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>확인 질문 :</td>
                <td colspan="2"><asp:Label ID="lbl_que" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>확인 답 :</td>
                <td><asp:TextBox ID="txtAns" runat="server"></asp:TextBox></td>
                <td><asp:Button ID="btn_check" runat="server" Text="확인" OnClick="btn_check_Click"/></td>
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
