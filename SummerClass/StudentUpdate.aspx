<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentUpdate.aspx.cs" Inherits="SummerClass.StudentUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="FORM_StudentUpdate" runat="server">
        <div class="form-group">
            <div>
                <strong>
                    <asp:Label ID="LBL_StudentID" for="TXTBOX_StudentID" runat="server" Text="Student ID:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
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
            <br />
            <div>
                <strong>
                    <asp:Label ID="LBL_StudentBalance" for="TXTBOX_StudentBalance" runat="server" Text="Student Balance:"></asp:Label>
                </strong>
                <asp:TextBox ID="TXTBOX_StudentBalance" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <strong>
                    <asp:Label ID="LBL_StudentStatus" for="DDL_StudentStatus" runat="server" Text="Student Status:"></asp:Label>
                </strong>
                <asp:DropDownList ID="DDL_StudentStatus" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <asp:Button ID="BTN_UpdateStudent" runat="server" CssClass="btn btn-info" Text="Update Student" OnClick="BTN_UpdateStudent_Click" />
    </form>
</asp:Content>
