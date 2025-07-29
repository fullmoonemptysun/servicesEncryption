        
<%@ Page Title="Staff" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Assignment5.Staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
            <h2>Staff Area</h2>

            <asp:Label ID="lblWelcome" runat="server" Font-Size="X-Large" ForeColor="Green"></asp:Label>
            <br /><br />

            <asp:Label ID="lblStaffOnly" runat="server" 
                Text="This page is for Staff only." Font-Size="Large" ForeColor="Blue"></asp:Label>
    </div>
</asp:Content>
