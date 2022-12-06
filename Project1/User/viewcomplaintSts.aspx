<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="viewcomplaintSts.aspx.cs" Inherits="Project1.User.viewcomplaintSts" %>
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
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="userid" AutoGenerateColumns="false">
            <Columns>
                     <asp:BoundField DataField="date" HeaderText="Complaint Date" />
                     <asp:BoundField DataField="productname" HeaderText="Product Name" />
                     <%--<asp:BoundField DataField="productid" HeaderText="Product id" />--%>
                     <asp:BoundField DataField="userid" HeaderText="user id" />
                     <asp:BoundField DataField="name" HeaderText="user name" />
                      <asp:BoundField DataField="complaint" HeaderText="Complaint Message"/>
                     <asp:BoundField DataField="status" HeaderText="Complaint Status" />
                </Columns>
        </asp:GridView>
    </form>
</asp:Content>
