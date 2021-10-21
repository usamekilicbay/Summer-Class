<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClassList.aspx.cs" Inherits="SummerClass.ClassList" %>

<%@ Import Namespace="Sidekick.Constant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul id="UL_ClassNavTabs"  runat="server" class="nav nav-tabs">
        <li class="active"><a href="ClassList.aspx">Classes</a> </li>
        <li><a href="ClassAppeal.aspx">New Class Appeal</a> </li>
    </ul>
    <table class="table table-bordered table-hover">
        <tr>
            <th><%=ClassLabel.CLASS_ID%></th>
            <th><%=ClassLabel.CLASS_NAME%></th>
            <th><%=ClassLabel.CLASS_REQUIRED_APPEAL%></th>
            <th><%=ClassLabel.CLASS_QUOTA%></th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <accessdatasource></accessdatasource>
                    <tr>
                        <td><%#Eval(ClassColumn.CLASS_ID) %></td>
                        <td><%#Eval(ClassColumn.CLASS_NAME) %></td>
                        <td><%#Eval(ClassColumn.CLASS_REQUIRED_APPEAL) %></td>
                        <td><%#Eval(ClassColumn.CLASS_QUOTA) %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#$"~/{PageName.ClassPage.CLASS_DELETE}?{ClassColumn.CLASS_ID}={Eval(ClassColumn.CLASS_ID)}"%>' ID="HLINK_Delete" CssClass="btn btn-danger" runat="server">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#$"~/{PageName.ClassPage.CLASS_DELETE}?{ClassColumn.CLASS_ID}={Eval(ClassColumn.CLASS_ID)}"%>' ID="HLINK_Update" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
