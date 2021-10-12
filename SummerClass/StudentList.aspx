<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerClass.StudentList" %>

<%@ Import Namespace="Sidekick.Constant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li class="active"><a href="StudentList.aspx">Students</a></li>
        <li><a href="StudentCreate.aspx">New Student Registration</a></li>
    </ul>
    <table class="table table-bordered table-hover ">
        <tr>
            <th><%=StudentLabel.STUDENT_ID%></th>
            <th><%=StudentLabel.STUDENT_NAME%></th>
            <th><%=StudentLabel.STUDENT_PASSWORD%></th>
            <th><%=StudentLabel.STUDENT_NUMBER%></th>
            <th><%=StudentLabel.STUDENT_PASSWORD%></th>
            <th><%=StudentLabel.STUDENT_PHOTO%></th>
            <th><%=StudentLabel.STUDENT_BALANCE%></th>
            <th><%=StudentLabel.STUDENT_STATUS%></th>
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
                            <asp:HyperLink ID="HLINK_Pacify" runat="server" NavigateUrl='<%#$"~/{PageName.StudentPage.STUDENT_STATUS_PACIFY}?{StudentColumn.STUDENT_ID}={Eval(StudentColumn.STUDENT_ID)}"%>' CssClass="btn btn-danger">Pacify
                                <span class="glyphicon glyphicon-ban-circle"></span>
                            </asp:HyperLink>
                            <asp:HyperLink ID="HLINK_Update" runat="server" NavigateUrl='<%#$"~/{PageName.StudentPage.STUDENT_UPDATE}?{StudentColumn.STUDENT_ID}={Eval(StudentColumn.STUDENT_ID)}"%>' CssClass="btn btn-success">Update
                                <span class="glyphicon glyphicon-refresh"></span>
                            </asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
