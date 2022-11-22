<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Project1.Admin.product" %>
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
    <table align="center" class="auto-style1">
        <tr>
            <td colspan="2">Products</td>
        </tr>
        <tr>
            <td>Product Name</td>
            <td>
                <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox>
            </td> 
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </td> 
        </tr>
        <tr>
            <td colspan="2">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="productid" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="Gridview1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit">
                <columns>
                    <asp:BoundField DataField="productname" HeaderText="ProductName"/>
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                </columns>
            </asp:GridView>
            </td>
        </tr>
    </table>
        </form>
</asp:Content>
