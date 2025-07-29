<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <!-- Header section with title and short summary -->
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Assignment 6</h1>
            <p class="lead">
                Submission for Group 30 . This web app is a handy pocket calculator-like tool application. Please Log in to continue.
            </p>
        </section>

        <!-- Summary table outlining each component with TryIt links -->
        <section class="TryIt table">
            <h2>Application and Components Summary Table</h2>
<table border="1" cellpadding="5">
    <tr>
        <th>Provider Name</th>
        <th>Component Type</th>
        <th>Component Description</th>
        <th>Inputs</th>
        <th>Outputs</th>
        <th>Test Link / TryIt</th>
    </tr>


    <tr>
        <td>Jia-Jui Jang</td>
        <td>DLL (FrankEncrypt.dll)</td>
        <td>Custom encryption DLL used for hashing passwords</td>
        <td>Plaintext, Seed</td>
        <td>Encrypted or Decrypted Text</td>
        <td>Used in Registration and Login</td>
    </tr>
    <tr>
        <td>Jia-Jui Jang</td>
        <td>Member Registration (Member.aspx)</td>
        <td>Registers a new member after CAPTCHA verification</td>
        <td>Username, Password, CAPTCHA</td>
        <td>Saved encrypted credentials in Member.xml</td>
        <td>After login, access Member page</td>
    </tr>
    <tr>
        <td>Jia-Jui Jang</td>
        <td>Access Control for Members</td>
        <td>Only logged-in users can access Member.aspx</td>
        <td>Session Username</td>
        <td>Access to Member Services</td>
        <td>Post-login redirection</td>
    </tr>
    <td>Jia-Jui Jang</td>
    <td>Web Service: Encryptor/Decryptor</td>
    <td>Web Service</td>
    <td>All Components Listed</td>
    <td>Use Library to call the webservice</td>
    <td>Log in as a Member to Try</td>


    <tr>
        <td>Joseph Smirnoff</td>
        <td>Staff Login (Login.aspx)</td>
        <td>Login functionality for Staff (TA/Cse445!) users</td>
        <td>Username, Password</td>
        <td>Session with Role = Staff</td>
        <td>Redirect to Staff.aspx on success</td>
    </tr>
    <tr>
        <td>Joseph Smirnoff</td>
        <td>Staff.xml Management</td>
        <td>XML file containing Staff login credentials</td>
        <td>Username, Password</td>
        <td>Staff authentication</td>
        <td>Login process</td>
    </tr>
    <tr>
        <td>Joseph Smirnoff</td>
        <td>Access Control for Staff</td>
        <td>Only Staff role users can access Staff.aspx</td>
        <td>Session Role</td>
        <td>Access to Staff page</td>
        <td>Post-login redirection</td>
    </tr>


    <tr>
        <td>Vinnie Kumar</td>
        <td>CAPTCHA Control</td>
        <td>Math CAPTCHA added to registration for bot prevention</td>
        <td>Two random numbers</td>
        <td>Sum must match user input</td>
        <td>Displayed during Registration</td>
    </tr>
    <tr>
        <td>Vinnie Kumar</td>
        <td>Integration and Layout</td>
        <td>Combined Member, Staff, Login, and Default pages with Master styling</td>
        <td>N/A</td>
        <td>Final unified website</td>
        <td>Visible on all pages</td>
    </tr>
    <tr>
        <td>Vinnie Kumar</td>
        <td>Service Directory / UI Polish</td>
        <td>Default.aspx completed with full Service Directory Table and UI polish</td>
        <td>All Components Listed</td>
        <td>Navigation and Service List</td>
        <td>Home page (Default.aspx)</td>
    </tr>

    <tr>
        <td>Vinnie Kumar</td>
        <td>Web Services</td>
        <td>2 Simple Math Webservices (AVG, SQRT) and Components with TryIt add to the Members' page</td>
        <td>All Components Listed</td>
        <td>Navigation and Service List</td>
        <td>Members' Page (Must be logged-in to see)</td>
    </tr>

</table>

        </section>
    </main>

</asp:Content>
