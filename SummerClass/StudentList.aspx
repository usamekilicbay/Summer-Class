<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerClass.StudentList" %>

<%@ Import Namespace="Helper.Constant" %>

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
            <th>Student Status</th>
            <th>Operations</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <accessdatasource></accessdatasource>
                    <tr>
                        <td><%#Eval(StudentColumn.STUDENT_ID)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_NAME)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_NUMBER)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_PASSWORD)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_PHOTO)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_BALANCE)%></td>
                        <td><%#Eval(StudentColumn.STUDENT_STATUS)%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#$"~/{PageName.STUDENT_STATUS_PACIFY}?{StudentColumn.STUDENT_ID}={Eval(StudentColumn.STUDENT_ID)}"%>' ID="HLINK_Pacify" CssClass="btn btn-danger" runat="server">Pacify
                                <span class="glyphicon glyphicon-ban-circle"></span>
                            </asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#$"~/{PageName.STUDENT_UPDATE}?{StudentColumn.STUDENT_ID}={Eval(StudentColumn.STUDENT_ID)}"%>' ID="HLINK_Update" CssClass="btn btn-success" runat="server">Update
                                <span class="glyphicon glyphicon-refresh"></span>
                            </asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
