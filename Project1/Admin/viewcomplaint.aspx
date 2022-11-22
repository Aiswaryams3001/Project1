<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="Project1.Admin.viewcomplaint" %>
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
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="complaintid" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Complaintid" HeaderText="Complaintid"/>
                <asp:BoundField DataField="Complaint" HeaderText="Complaint"/>
                <asp:BoundField DataField="productid" HeaderText="Productid"/>
                <asp:BoundField DataField="Userid" HeaderText="Userid"/>
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:CommandField HeaderText="Sts Edit" ShowEditButton="true" EditText="confirm" />
                <asp:BoundField DataField="date" HeaderText="date"/>
            </Columns>
        </asp:GridView>
    </form>
</asp:Content>
