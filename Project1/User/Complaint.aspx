<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="Project1.User.Complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            height:582px;
            width:560px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" align="left">
        <div>
            <h1><center>
                <asp:Label ID="Label1" runat="server" Text="Complaint Registration"></asp:Label>
                </center></h1>
            <%--<asp:Label ID="Label3" runat="server" Text="User ID:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
            <asp:Label ID="Label2" runat="server" Text="Product Name:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                
             <br />
            <br />
            <br />

            <asp:Label ID="Label4" runat="server" Text="Complaint:"></asp:Label><br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="cmpmsg" runat="server" Height="264px" Width="812px" ></asp:TextBox>
            <br />                
            <br />
            </div>                
                <%--<asp:Label ID="Label5" runat="server" Text="Date :"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>            
        </br>            --%>
        <br />           
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit"  />  
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />

    </form>           
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                
    &nbsp;                
    &nbsp;                
    &nbsp;&nbsp;&nbsp;                
    &nbsp;                
    &nbsp;                
    &nbsp;                 

</asp:Content>
