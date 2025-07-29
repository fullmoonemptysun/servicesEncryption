<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment5.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Login Section -->
    <h2>Login</h2>
    <asp:Label runat="server" Text="Username:" /><br />
    <asp:TextBox ID="TextBoxLoginUsername" runat="server" /><br />
    <asp:Label runat="server" Text="Password:" /><br />
    <asp:TextBox ID="TextBoxLoginPassword" runat="server" TextMode="Password" /><br />
    <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" CssClass="btn btn-primary mt-2" /><br />
    <asp:Label ID="LabelLoginResult" runat="server" ForeColor="Red" />

    <hr />

    <!-- Register Section -->
    <h2>Register</h2>
    <asp:Label runat="server" Text="Username:" /><br />
    <asp:TextBox ID="TextBoxRegisterUsername" runat="server" /><br />
    <asp:Label runat="server" Text="Password:" /><br />
    <asp:TextBox ID="TextBoxRegisterPassword" runat="server" TextMode="Password" /><br />
    <asp:Label runat="server" Text="Confirm Password:" /><br />
    <asp:TextBox ID="TextBoxRegisterConfirmPassword" runat="server" TextMode="Password" /><br />
    
    <!-- Captcha Integration -->
    <asp:Label ID="LabelCaptchaQuestion" runat="server" Font-Bold="true" /><br />
    <asp:TextBox ID="TextBoxCaptchaAnswer" runat="server" /><br />
    <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" CssClass="btn btn-success mt-2" /><br />
    <asp:Label ID="LabelRegisterResult" runat="server" ForeColor="Red" />
</asp:Content>
