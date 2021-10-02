<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClassList.aspx.cs" Inherits="SummerClass.ClassList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
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
