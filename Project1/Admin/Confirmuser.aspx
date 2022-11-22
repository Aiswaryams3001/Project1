<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Confirmuser.aspx.cs" Inherits="Project1.Admin.Confirmuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            height:582px;
            width:560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Details</h2>     
    <form id="form1" runat="server">
          <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>
                
            </asp:GridView>
    </form>
   
</asp:Content>
