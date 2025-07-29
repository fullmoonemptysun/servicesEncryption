
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilityLib;
using Assignment5.ServiceReference1;

namespace Assignment5
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    LabelWelcome.Text = "Welcome, " + Session["Username"].ToString() + "!";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }


        protected void HashButton_Click(object sender, EventArgs e)
        {
            string input = PasswordBox.Text;
            string hashed = Hasher.Hash(input);
            ResultLabel.Text = "Hashed Password: " + hashed;
        }

        // Called when the user clicks the "Save Name" button
        // Stores the name in both session and a cookie
        protected void SaveCookieButton_Click(object sender, EventArgs e)
        {
            string name = NameInput.Text;

            Session["userName"] = name;

            HttpCookie cookie = new HttpCookie("userName", name);
            cookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(cookie);

            CookieResultLabel.Text = "Saved name in session and cookie.";
        }

        // Called when the user clicks the "Read Name" button
        // Tries to read the name from session or cookie and displays it
        protected void ReadCookieButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                CookieResultLabel.Text = "Session: Hello, " + Session["userName"].ToString();
            }
            else if (Request.Cookies["userName"] != null)
            {
                CookieResultLabel.Text = "Cookie: Hello, " + Request.Cookies["userName"].Value;
            }
            else
            {
                CookieResultLabel.Text = "No name found in session or cookie.";
            }
        }

        // Called when the user clicks the "Get Average" button
        // Parses two numbers and calls the remote Average method via the ASMX service
        protected void AverageButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(NumberA.Text);
                double b = double.Parse(NumberB.Text);

                MathserviceSoapClient client = new MathserviceSoapClient();
                double result = client.Average(a, b);

                AverageResultLabel.Text = "Average: " + result.ToString("F2");
            }
            catch (Exception ex)
            {
                AverageResultLabel.Text = "Error: " + ex.Message;
            }
        }

        // Called when the user clicks the "Get Square Root" button
        // Parses one number and calls the remote Sqrt method via the ASMX service
        protected void SqrtButton_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(NumberX.Text);

                MathserviceSoapClient client = new MathserviceSoapClient();
                double result = client.Sqrt(x);

                SqrtResultLabel.Text = "Square Root: " + result.ToString("F2");
            }
            catch (Exception ex)
            {
                SqrtResultLabel.Text = "Error: " + ex.Message;
            }
        }


        protected void EncryptWebButton_Click(object sender, EventArgs e)
        {
            var client = new Mathservice();
            string input = EncryptWebInput.Text;
            string seed = EncryptWebSeed.Text;

            string encrypted = client.EncryptWebService(input, seed);
            EncryptedWebResult.Text = encrypted;
        }

        protected void DecryptWebButton_Click(object sender, EventArgs e)
        {
            var client = new Mathservice();
            string input = DecryptWebInput.Text;
            string seed = DecryptWebSeed.Text;

            string decrypted = client.DecryptWebService(input, seed);
            DecryptedWebResult.Text = decrypted;
        }


        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}