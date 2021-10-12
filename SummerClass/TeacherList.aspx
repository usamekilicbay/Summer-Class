<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TeacherList.aspx.cs" Inherits="SummerClass.TeacherList" %>

<%@ Import Namespace="Sidekick.Constant" %>
<%@ Import Namespace="BusinessLogicLayer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th><%=TeacherLabel.TEACHER_ID%></th>
            <th><%=TeacherLabel.TEACHER_NAME%></th>
            <th><%=TeacherLabel.TEACHER_PASSWORD%></th>
            <th><%=TeacherLabel.TEACHER_PHOTO%></th>
            <th><%=TeacherLabel.TEACHER_BRANCH%></th>
            <th><%=TeacherLabel.TEACHER_STATUS%></th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <accessdatasource></accessdatasource>
                    <tr>
                        <td><%#Eval(TeacherColumn.TEACHER_ID)%></td>
                        <td><%#Eval(TeacherColumn.TEACHER_NAME)%></td>
                        <td><%#Eval(TeacherColumn.TEACHER_PASSWORD)%></td>
                        <td><%#Eval(TeacherColumn.TEACHER_PHOTO)%></td>
                        <td><%#TeacherBusinessLogic.GetTeacherBranch(Convert.ToInt32(Eval(TeacherColumn.TEACHER_BRANCH)))%></td>
                        <td><%#Eval(TeacherColumn.TEACHER_STATUS)%></td>
                        <td>
                            <asp:HyperLink ID="HLINK_Pacify" runat="server" NavigateUrl='<%#$"{PageName.TeacherPage.TEACHER_STATUS_PACIFY}?{TeacherColumn.TEACHER_ID}={Eval(TeacherColumn.TEACHER_ID)}"%>' CssClass="btn btn-danger">Pacify
                            <span class="glyphicon glyphicon-ban-circle"></span>
                            </asp:HyperLink>
                            <asp:HyperLink ID="HLINK_Update" runat="server" NavigateUrl='<%#$"{PageName.TeacherPage.TEACHER_UPDATE}?{TeacherColumn.TEACHER_ID}={Eval(TeacherColumn.TEACHER_ID)}"%>' CssClass="btn btn-success">Pacify
                            <span class="glyphicon glyphicon-refresh"></span>
                            </asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
