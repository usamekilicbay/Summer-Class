<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClassAppeal.aspx.cs" Inherits="SummerClass.ClassAppeal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li><a href="ClassList.aspx">Classes</a> </li>
        <li class="active"><a href="ClassAppeal.aspx">New Class Appeal</a> </li>
    </ul>
    <form id="FORM_ClassAppeal" runat="server">
        <div>
            <asp:Label ID="LBL_Classes" for="DDLIST_ClassIDs" runat="server" Text="Classes"></asp:Label>
            <asp:DropDownList ID="DDLIST_ClassIDs" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="LBL_StudentIDs" for="DDLIST_StudentIDs" runat="server" Text="Student ID"></asp:Label>
            <asp:DropDownList ID="DDLIST_StudentIDs" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="BTN_Appeal" runat="server" Text="Appeal for Class" CssClass="btn btn-success" OnClick="BTN_Appeal_Click" />
        </div>
    </form>
</asp:Content>
