<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentCreate.aspx.cs" Inherits="SummerClass.StudentCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label ID="LBL_StudentName" for="TXTBOX_StudentName" runat="server" Text="Student Name:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label ID="LBL_StudentNumber" for="TXTBOX_StudentNumber" runat="server" Text="Student Number:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label ID="LBL_StudentPassword" for="TXTBOX_StudentPassword" runat="server" Text="Student Password:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label ID="LBL_StudentPhoto" for="TXTBOX_StudentPhoto" runat="server" Text="Student Photo:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="BTN_SaveStudent" runat="server" CssClass="btn btn-info" Text="Save Student" OnClick="BTN_SaveStudent_Click"/>
    </form>
</asp:Content>
