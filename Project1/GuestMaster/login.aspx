<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster/Guest.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Project1.GuestMaster.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            height:582px;
            width:560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td colspan="2">Login</td>
        </tr>
        <tr>
            <td class="auto-style3">Username</td>
            <td>
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
