<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmView.aspx.cs" Inherits="BoardProject.Master.FrmView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="board">
        <table>
            <tr>
                <td align="center" colspan="3"><h3>게시판 글보기</h3>
                    <hr />
                </td>
            </tr>
            
            <tr> 
                <td align="center" colspan="3">
                    <asp:Label ID="lbl_title" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <br /><br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;작성자: <asp:Label ID="txtname" runat="server" Text="Label"></asp:Label></td>
                <td colspan="2" align="right">
                    작성일: <asp:Label ID="txtwritedate" runat="server" Text="Label"></asp:Label>&nbsp;
                    조회수: <asp:Label ID="txtreadcnt" runat="server" Text="Label"></asp:Label>
                <td />
            </tr>
            <tr>
                <td colspan="3" align="center">   
                    <asp:TextBox ID="txtcontents" runat="server" TextMode="MultiLine" Height="100px" Width="500px"></asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td colspan="3" align="right" >
                    <asp:Button ID="btnList" runat="server" Text="리스트" OnClick ="btnList_Click"/>&nbsp;
                    <asp:Button ID="btnInsert" runat="server" Text="수정" CommandArgument="Insert" CommandName="Edit" OnCommand="CmdEdit_Click"/>&nbsp;
                    <asp:Button ID="btnDelete" runat="server" Text="삭제" CommandArgument="Delete" CommandName="Edit" OnCommand="CmdEdit_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="3" align="right">
                <br /><asp:Label ID="lbl_error" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
