<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster/Guest.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Project1.User.Registration" %>
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
            <td colspan="2">Registration Form</td>
        </tr>
        <tr>
            <td class="auto-style3">Name</td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Address</td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Date</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
            </td>
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
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
