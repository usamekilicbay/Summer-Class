<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TeacherSignIn.aspx.cs" Inherits="SummerClass.TeacherSignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li><a href="StudentSignIn.aspx"><span class="glyphicon glyphicon-user"></span>&nbsp; Student Sign In</a></li>
        <li class="active"><a href="TeacherSignIn.aspx"><span class="glyphicon glyphicon-education"></span>&nbsp; Teacher Sign In</a></li>
    </ul>
    <form id="FORM_TeacherSignIn" runat="server">
        <br />
        <div>
            <asp:Label ID="LBL_TeacherName" for="TXTBOX_TeacherName" runat="server" Text="Teacher Name"></asp:Label>
            <asp:TextBox ID="TXTBOX_TeacherName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="LBL_TeacherPassword" for="TXTBOX_TeacherPassword" runat="server" Text="Teacher Password"></asp:Label>
            <asp:TextBox ID="TXTBOX_TeacherPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="BTN_SignIn" runat="server" CssClass="btn btn-info" Text="Sign In" OnClick="BTN_SignIn_Click" />
        </div>
    </form>
</asp:Content>
