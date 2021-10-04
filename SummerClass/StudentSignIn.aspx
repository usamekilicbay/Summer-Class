<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentSignIn.aspx.cs" Inherits="SummerClass.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="FORM_StudentLogin" class="form-control" runat="server">
        <div>
            <asp:Label ID="LBL_StudentNumber" for="TXTBOX_StudentNumber" runat="server" Text="Student Number"></asp:Label>
            <asp:TextBox ID="TXTBOX_StudentNumber" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="LBL_StudentPassword" for="TXTBOX_StudentPassword" runat="server" Text="Student Password"></asp:Label>
            <asp:TextBox ID="TXTBOX_StudentPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="BTN_Login" runat="server" CssClass="btn btn-info" Text="Login" OnClick="BTN_Login_Click"  />
        </div>
    </form>
</asp:Content>
