<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="viewquery.aspx.cs" Inherits="Project1.Admin.viewquery" %>
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
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="queryid" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Queryid" HeaderText="Queryid"/>
                <asp:BoundField DataField="Query" HeaderText="Query"/>
                <asp:BoundField DataField="productid" HeaderText="Productid"/>
                <asp:BoundField DataField="Userid" HeaderText="Userid"/>
                <asp:BoundField DataField="Reply" HeaderText="Reply" />
                <asp:CommandField HeaderText="rply Edit" ShowEditButton="true" EditText="confirm" />
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>
