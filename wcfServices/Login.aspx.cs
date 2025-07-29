using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace Assignment5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateCaptcha();
            }
        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);

            LabelCaptchaQuestion.Text = $"What is {num1} + {num2}?";
            Session["CaptchaAnswer"] = (num1 + num2).ToString();
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = TextBoxLoginUsername.Text.Trim();
            string passwordInput = TextBoxLoginPassword.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                LabelLoginResult.Text = "Please enter both username and password.";
                LabelLoginResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            //  Check Staff.xml first
            string staffPath = Server.MapPath("./App_Data/Staff.xml");

            if (File.Exists(staffPath))
            {
                XmlDocument staffDoc = new XmlDocument();
                staffDoc.Load(staffPath);

                foreach (XmlNode staff in staffDoc.SelectNodes("//Staff"))
                {
                    string staffUsername = staff.SelectSingleNode("Username")?.InnerText;
                    string staffPassword = staff.SelectSingleNode("Password")?.InnerText;

                    if (staffUsername == usernameInput && staffPassword == passwordInput)
                    {
                        Session["Username"] = usernameInput;
                        Session["Role"] = "Staff";
                        Response.Redirect("Staff.aspx");
                        return;
                    }
                }
            }

            //  If not staff, check Member.xml (encrypted password)
            string encryptedInputPassword = FrankEncrypt.Encryptor.Encrypt(passwordInput, "5");
            string memberPath = Server.MapPath("~/App_Data/Member.xml");

            if (!File.Exists(memberPath))
            {
                LabelLoginResult.Text = "No registered users found.";
                LabelLoginResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            XmlDocument memberDoc = new XmlDocument();
            memberDoc.Load(memberPath);

            bool found = false;

            foreach (XmlNode member in memberDoc.SelectNodes("//Member"))
            {
                string username = member.SelectSingleNode("Username")?.InnerText;
                string password = member.SelectSingleNode("Password")?.InnerText;

                if (username == usernameInput && password == encryptedInputPassword)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Session["Username"] = usernameInput;
                Session["Role"] = "Member";
                Response.Redirect("Member.aspx");
            }
            else
            {
                LabelLoginResult.Text = "Invalid username or password.";
                LabelLoginResult.ForeColor = System.Drawing.Color.Red;
            }
        }


        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = TextBoxRegisterUsername.Text.Trim();
            string password = TextBoxRegisterPassword.Text.Trim();
            string confirmPassword = TextBoxRegisterConfirmPassword.Text.Trim();
            string captchaInput = TextBoxCaptchaAnswer.Text.Trim();

            if (Session["CaptchaAnswer"] == null || captchaInput != Session["CaptchaAnswer"].ToString())
            {
                LabelRegisterResult.Text = "Incorrect CAPTCHA answer. Please try again.";
                LabelRegisterResult.ForeColor = System.Drawing.Color.Red;
                GenerateCaptcha();
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                LabelRegisterResult.Text = "Please fill in all fields.";
                LabelRegisterResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (password != confirmPassword)
            {
                LabelRegisterResult.Text = "Passwords do not match.";
                LabelRegisterResult.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string encryptedPassword = FrankEncrypt.Encryptor.Encrypt(password, "5");

            string xmlPath = Server.MapPath("~/App_Data/Member.xml");

            try
            {
                if (!File.Exists(xmlPath))
                {
                    using (StreamWriter writer = new StreamWriter(xmlPath))
                    {
                        writer.WriteLine("<Members>");
                        writer.WriteLine("</Members>");
                    }
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);

                XmlElement newMember = doc.CreateElement("Member");

                XmlElement usernameElement = doc.CreateElement("Username");
                usernameElement.InnerText = username;
                newMember.AppendChild(usernameElement);

                XmlElement passwordElement = doc.CreateElement("Password");
                passwordElement.InnerText = encryptedPassword;
                newMember.AppendChild(passwordElement);

                doc.DocumentElement.AppendChild(newMember);
                doc.Save(xmlPath);

                LabelRegisterResult.Text = "Registration successful! Please login.";
                LabelRegisterResult.ForeColor = System.Drawing.Color.Green;
                GenerateCaptcha();
            }
            catch (Exception ex)
            {
                LabelRegisterResult.Text = "Error: " + ex.Message;
                LabelRegisterResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}