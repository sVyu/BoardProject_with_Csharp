<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Board.Master" AutoEventWireup="true" CodeBehind="FrmLists.aspx.cs" Inherits="BoardProject.Master.FrmLists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="num" DataSourceID="SqlDataSource1" AllowPaging="True" CellPadding="4" GridLines="None" ForeColor="#333333">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
        <Columns>
            <asp:BoundField DataField="num" HeaderText="No" ReadOnly="True" InsertVisible="False" SortExpression="num"></asp:BoundField>
            <asp:TemplateField HeaderText="제목">
                <ItemTemplate>
                    &nbsp;&nbsp;
                    <a href="<%# "FrmView.aspx?No=" + Eval("num") %>">
                        <%# Eval("title") %>
                    </a>
                </ItemTemplate>
                <HeaderStyle Width="250px" />
            </asp:TemplateField>
            <asp:BoundField DataField="name" HeaderText="작성자" SortExpression="name"></asp:BoundField>
            <asp:BoundField DataField="writedate" HeaderText="작성일" SortExpression="writedate"></asp:BoundField>
            <asp:BoundField DataField="readcnt" HeaderText="조회수" SortExpression="readcnt"></asp:BoundField>
        </Columns>

        <EditRowStyle BackColor="#999999"></EditRowStyle>

        <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True"></FooterStyle>

        <HeaderStyle BackColor="#95c2f0" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:BoardConnectionString %>' SelectCommand="SELECT [num], [name], [title], [writedate], [readcnt] FROM [tblBrd]"></asp:SqlDataSource>
    <table style="width:500px">
        <tr>
            <td style="width:450px"><asp:Label ID="lbl_error" runat="server" Text=""></asp:Label></td>
            <td style="width:50px"><asp:Button ID="btnWrite" runat="server" Text="글쓰기" OnClick="btnWrite_Click" align="right"/></td>
        </tr>
    </table>
</asp:Content>
