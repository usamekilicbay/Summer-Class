<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ClassList.aspx.cs" Inherits="SummerClass.ClassList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <ul class="nav nav-tabs">
        <li class="active"><a href="ClassList.aspx">Classes</a> </li>
        <li><a href="ClassAppeal.aspx">New Class Appeal</a> </li>
    </ul>
    <table class="table table-bordered table-hover">
        <tr>
            <th>Class ID</th>
            <th>Class Name</th>
            <th>Class Required Appeal</th>
            <th>Class Quota</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <accessdatasource></accessdatasource>
                    <tr>
                        <td><%#Eval("ClassID") %></td>
                        <td><%#Eval("ClassName") %></td>
                        <td><%#Eval("ClassRequiredAppeal") %></td>
                        <td><%#Eval("ClassQuota") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#$"~/ClassDelete.aspx?ClassID={Eval("ClassID")}"%>' ID="HLINK_Delete" CssClass="btn btn-danger" runat="server">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#$"~/ClassDelete.aspx?ClassID={Eval("ClassID")}"%>' ID="HLINK_Update" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
