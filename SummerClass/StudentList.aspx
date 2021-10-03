<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerClass.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li class="active"><a href="StudentList.aspx">Students</a></li>
        <li><a href="StudentCreate.aspx">New Student Registration</a></li>
    </ul>
    <table class="table table-bordered table-hover ">
        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Number</th>
            <th>Student Password</th>
            <th>Student Photo</th>
            <th>Student Balance</th>
            <th>Operations</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <accessdatasource></accessdatasource>
                    <tr>
                        <td><%#Eval("StudentID")%></td>
                        <td><%#Eval("StudentName")%></td>
                        <td><%#Eval("StudentNumber")%></td>
                        <td><%#Eval("StudentPassword")%></td>
                        <td><%#Eval("StudentPhoto")%></td>
                        <td><%#Eval("StudentBalance")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#$"~/StudentDelete.aspx?StudentID={Eval("StudentID")}"%>' ID="HLINK_Delete" CssClass="btn btn-danger" runat="server">Delete
                                <span class="glyphicon glyphicon-trash"></span>
                            </asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#$"~/StudentUpdate.aspx?StudentID={Eval("StudentID")}"%>' ID="HLINK_Update" CssClass="btn btn-success" runat="server">Update
                                <span class="glyphicon glyphicon-refresh"></span>
                            </asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
