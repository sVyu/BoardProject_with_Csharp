<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="FrmRegister.aspx.cs" Inherits="BoardProject.Login.FrmRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="frmRegister">
        <div id="frmRegister_view">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/mandala.png" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/industrial-safety.png" />
                </asp:View>
            </asp:MultiView>
        </div>
        <div id="frmRegister_table">
            <table>
                <tr>
                    <td class="txt1">ID : </td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* ID 입력 필수 !" ControlToValidate="txtID" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td class="txt1">PassWord :</td>
                    <td>
                        <asp:TextBox ID="txtPW" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* 비밀번호: 4~10 자" ValidationExpression="\w{4,10}" ControlToValidate="txtPW" SetFocusOnError="True" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* PW 입력 필수 !" ControlToValidate="txtPW" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="txt1">PassWord(확인) : </td>
                    <td>
                        <asp:TextBox ID="txtPW2" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* PW 입력 필수 !" ControlToValidate="txtPW2" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="* PW 확인 !" ControlToCompare="txtPW" ControlToValidate="txtPW2" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="txt1">확인 질문 등록 : </td>
                    <td>
                        <asp:TextBox ID="txtQue" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* 질문을 등록하세요" ControlToValidate="txtQue" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="txt1">확인 답 등록 : </td>
                    <td>
                        <asp:TextBox ID="txtAns" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* 답을 등록하세요" ControlToValidate="txtAns" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_check" runat="server" Text=""></asp:Label></td>
                    <td align="right">
                        <asp:Button ID="btnRegister" runat="server" Text="회원가입" OnClick="btnRegister_Click" /></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
