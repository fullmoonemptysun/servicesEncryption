<%@ Page Title="Member" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment5.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <!-- Header section with title and short summary -->
        <section class="row" aria-labelledby="memberTitle">
            
            <p class="lead">
                Welcome to the members-only area. You have successfully logged in.
            </p>
        </section>

        <!-- Member Details Section -->
        <section class="component-form">
            <div id="member-info">
                <h2>Your Information</h2>
                <asp:Label ID="LabelWelcome" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="Green" />
                <br /><br />

                 <!-- Section for local components with forms and output labels -->
 <section class="component-form">
     <h1 id="component-start">The Local Components</h1>
     <br />
     <div id="local-comp-form">

         <!-- Local Component 1: Hasher DLL -->
         <h2 id="hasher">▶ Local Component 1</h2>
         <p>A basic SHA-256 hasher. </p>
         <asp:TextBox ID="PasswordBox" runat="server" />
         <asp:Button Style="background-color: #007BFF; color: white; border: none; padding: 6px 12px; border-radius: 4px;" ID="HashButton" runat="server" Text="Hash" OnClick="HashButton_Click" />
         <br />
         <asp:Label ID="ResultLabel" runat="server" />
         <br />

         <!-- Local Component 2: Cookie + Session -->
         <h2 id="cookie">▶ Local Component 2</h2>
         <p>A cookie implementation.</p>
         <asp:TextBox ID="NameInput" runat="server" />
         <asp:Button Style="background-color: #007BFF; color: white; border: none; padding: 6px 12px; border-radius: 4px;" ID="SaveCookieButton" runat="server" Text="Save Name" OnClick="SaveCookieButton_Click" />
         <asp:Button Style="background-color: #007BFF; color: white; border: none; padding: 6px 12px; border-radius: 4px;" ID="ReadCookieButton" runat="server" Text="Read Name" OnClick="ReadCookieButton_Click" />
         <asp:Label ID="CookieResultLabel" runat="server" />
         


     </div>

     <br />
     <hr />

     <!-- Section for web service integration -->
     <h1>The Webservice</h1>
     <br />

     <div>
         <!-- Web service method: Average -->
         <h2 id="avg">Average</h2>
         <asp:Label runat="server" Text="Enter number A:" />
         <asp:TextBox ID="NumberA" runat="server" />
         <br />
         <asp:Label runat="server" Text="Enter number B:" />
         <asp:TextBox ID="NumberB" runat="server" />
         <br />
         <asp:Button Style="background-color: #007BFF; color: white; border: none; padding: 6px 12px; border-radius: 4px;" ID="AverageButton" runat="server" Text="Get Average" OnClick="AverageButton_Click" />
         <br />
         <asp:Label ID="AverageResultLabel" runat="server" Font-Bold="true" ForeColor="Green" />
         <br />

         <!-- Web service method: Square Root -->
         <h2 id="sqrt">Square Root</h2>
         <asp:Label runat="server" Text="Enter number:" />
         <asp:TextBox ID="NumberX" runat="server" />
         <br />
         <asp:Button Style="background-color: #007BFF; color: white; border: none; padding: 6px 12px; border-radius: 4px;" ID="SqrtButton" runat="server" Text="Get Square Root" OnClick="SqrtButton_Click" />
         <br />
         <asp:Label ID="SqrtResultLabel" runat="server" Font-Bold="true" ForeColor="Green" />
         <br />


         <!--Web Service Encryptor Decryptor -->
                <h2 id="encryptor-web">Encryption and decryption</h2>

                <asp:TextBox ID="EncryptWebInput" runat="server" Placeholder="Text to Encrypt (Web)" />
                <asp:TextBox ID="EncryptWebSeed" runat="server" Placeholder="Seed value" />
                <asp:Button ID="EncryptWebButton" runat="server" Text="Encrypt (Web)" OnClick="EncryptWebButton_Click" />
                <br />
                <asp:Label ID="EncryptedWebResult" runat="server" Font-Bold="true" ForeColor="Green" />
                <br /><br />

                <asp:TextBox ID="DecryptWebInput" runat="server" Placeholder="Text to Decrypt (Web)" />
                <asp:TextBox ID="DecryptWebSeed" runat="server" Placeholder="Seed value" />
                <asp:Button ID="DecryptWebButton" runat="server" Text="Decrypt (Web)" OnClick="DecryptWebButton_Click" />
                <br />
                <asp:Label ID="DecryptedWebResult" runat="server" Font-Bold="true" ForeColor="Green" />
     
        

     </div>
 </section>
                <br />
                <br />
                <hr />

                <asp:Button ID="LogoutButton" runat="server" Text="Logout" 
                    Style="background-color: #DC3545; color: white; border: none; padding: 6px 12px; border-radius: 4px;" 
                    OnClick="LogoutButton_Click" />
            </div>
        </section>
    </main>

</asp:Content>
