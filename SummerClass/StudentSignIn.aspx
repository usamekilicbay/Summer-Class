<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentSignIn.aspx.cs" Inherits="SummerClass.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li class="active"><a href="StudentSignIn.aspx"><span class="glyphicon glyphicon-user"></span>&nbsp; Student Sign In</a></li>
        <li><a href="TeacherSignIn.aspx"><span class="glyphicon glyphicon-education"></span>&nbsp; Teacher Sign In</a></li>
    </ul>
    <form id="FORM_StudentSignIn" runat="server">
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
            <asp:Button ID="BTN_SigIn" runat="server" CssClass="btn btn-info" Text="Sign In" OnClick="BTN_SigIn_Click" />
        </div>
    </form>
</asp:Content>
