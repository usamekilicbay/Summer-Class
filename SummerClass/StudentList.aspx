<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerClass.StudentList" %>

<%@ Import Namespace="Helper" %>

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
                        <td><%#Eval(Constant.StudentPath.STUDEND_ID)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_NAME)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_NUMBER)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_PASSWORD)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_PHOTO)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_BALANCE)%></td>
                        <td><%#Eval(Constant.StudentPath.STUDEND_STATUS)%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#$"~/{Constant.PageName.STUDENT_STATUS_PACIFY}?{Constant.StudentPath.STUDEND_ID}={Eval(Constant.StudentPath.STUDEND_ID)}"%>' ID="HLINK_Pacify" CssClass="btn btn-danger" runat="server">Pacify
                                <span class="glyphicon glyphicon-ban-circle"></span>
                            </asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#$"~/{Constant.PageName.STUDENT_UPDATE}?{Constant.StudentPath.STUDEND_ID}={Eval(Constant.StudentPath.STUDEND_ID)}"%>' ID="HLINK_Update" CssClass="btn btn-success" runat="server">Update
                                <span class="glyphicon glyphicon-refresh"></span>
                            </asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
