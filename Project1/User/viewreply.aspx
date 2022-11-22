<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="viewreply.aspx.cs" Inherits="Project1.User.viewreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            height:582px;
            width:560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="queryid" AutoGenerateColumns="false">
    
        </asp:GridView>
    </form>
</asp:Content>
