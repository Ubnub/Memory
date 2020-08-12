using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{  
    public partial class Form1 : Form
    {
        Thread th;
        public static LogregDataContext db = new LogregDataContext();
        public string CurrentUser;
        public Form1()
        {
            InitializeComponent();
            MainGB.Visible = true;
            MainGB.BringToFront();
            LoginGB.Visible = false;
            RegisterGB.Visible = false;
            Reset();
        }

        private void Reset()
        {
            LoginPasswordTB.Text="";
            LoginUserNameTB.Text = "";
            RegEmailTB.Text = "";
            RegUNTB.Text = "";
            RegPWTB.Text = "";
            RegPWTB2.Text = "";
            LoginUserNameLB.Text = "Username";
            LoginUserNameLB.ForeColor = System.Drawing.Color.Black;
            LoginPWLB.Text = "Password";
            LoginPWLB.ForeColor = System.Drawing.Color.Black;
            RegUserNameLB.Text = "Username*";
            RegUserNameLB.ForeColor = System.Drawing.Color.Black;
            RegPasswordLB.Text = "Password*";
            RegPasswordLB.ForeColor = System.Drawing.Color.Black;
            RegPasswordLB2.Text = "Re-enter*";
            RegPasswordLB2.ForeColor = System.Drawing.Color.Black;
            RegEmailLB.Text = "Email*";
            RegEmailLB.ForeColor = System.Drawing.Color.Black;
            LoginErrorLB.Visible = false;
            RegisterErrorLB.Visible = false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            MainGB.Visible = false;
            RegisterGB.Visible = false;
            LoginGB.Visible = true;

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MainGB.Visible = false;
            RegisterGB.Visible = true;
            LoginGB.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBackButton_Click(object sender, EventArgs e)
        {
            MainGB.Visible = true;
            RegisterGB.Visible = false;
            LoginGB.Visible = false;
            Reset();
        }

        private void RegisterBackButton_Click(object sender, EventArgs e)
        {
            MainGB.Visible = true;
            RegisterGB.Visible = false;
            LoginGB.Visible = false;
            Reset();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var UNquery = (from x in db.GetTable<User>() where x.UserName==LoginUserNameTB.Text select x.UserName).FirstOrDefault();
                var PWquery = (from x in db.GetTable<User>() where x.UserName == UNquery select x.Password).FirstOrDefault();
                //conn.Open();
                if (!String.IsNullOrEmpty(LoginUserNameTB.Text) && !String.IsNullOrEmpty(LoginPasswordTB.Text))
                {
                    if (UNquery!=null)
                    {
                        if (PWquery!=null)
                        {
                            if (LoginPasswordTB.Text == Crypto.Decrypt(PWquery.ToString()))
                            {
                                CurrentUser=LoginUserNameTB.Text;
                                this.Close();
                                th = new Thread(OpenMemory); 
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();              
                                Reset();
                            }
                            else
                            {
                                LoginErrorLB.Text = "Password incorrect";
                                LoginErrorLB.Visible = true;
                                LoginErrorLB.ForeColor = System.Drawing.Color.Red;
                                LoginUserNameLB.ForeColor = System.Drawing.Color.Black;
                                LoginUserNameLB.Text = "Username";
                                LoginPWLB.ForeColor = System.Drawing.Color.Red;
                                LoginPWLB.Text = "Password*";
                                LoginPasswordTB.Text = "";
                            }
                        }
                    }
                    else
                    {
                        LoginErrorLB.Text = "UserName doesn't exist";
                        LoginErrorLB.Visible = true;
                        LoginErrorLB.ForeColor = System.Drawing.Color.Red;
                        LoginUserNameLB.ForeColor = System.Drawing.Color.Red;
                        LoginUserNameLB.Text = "Username*";
                        LoginPWLB.ForeColor = System.Drawing.Color.Black;
                        LoginPWLB.Text = "Password";
                    }
                }
                else if (String.IsNullOrEmpty(LoginUserNameTB.Text) && String.IsNullOrEmpty(LoginPasswordTB.Text))
                {
                    LoginPWLB.ForeColor = System.Drawing.Color.Red;
                    LoginPWLB.Text = "Password*";
                    LoginUserNameLB.ForeColor = System.Drawing.Color.Red;
                    LoginUserNameLB.Text = "Username*";
                    LoginErrorLB.Text = "Both fields must be filled";
                    LoginErrorLB.Visible = true;
                    LoginErrorLB.ForeColor = System.Drawing.Color.Red;
                }
                else if(String.IsNullOrEmpty(LoginPasswordTB.Text))
                {
                    LoginPWLB.ForeColor = System.Drawing.Color.Red;
                    LoginPWLB.Text = "Password*";
                    LoginUserNameLB.ForeColor = System.Drawing.Color.Black;
                    LoginUserNameLB.Text = "Username";
                    LoginErrorLB.Text = "You must enter a password";
                    LoginErrorLB.Visible = true;
                    LoginErrorLB.ForeColor = System.Drawing.Color.Red;
                }
                else if (String.IsNullOrEmpty(LoginUserNameTB.Text))
                {
                    LoginUserNameLB.ForeColor = System.Drawing.Color.Red;
                    LoginUserNameLB.Text = "Username*";
                    LoginPWLB.ForeColor = System.Drawing.Color.Black;
                    LoginPWLB.Text = "Password";
                    LoginErrorLB.Text = "You must enter a username";
                    LoginErrorLB.Visible = true;
                    LoginErrorLB.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RegisterButton2_Click(object sender, EventArgs e)
        {
            bool filled = false;
            bool success = false;
            bool IsValidEmail(string email)
            {
                Regex regex=new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            var UNquery2 = (from x in db.GetTable<User>() where x.UserName == RegUNTB.Text select x.UserName).FirstOrDefault();

            if ((String.IsNullOrEmpty(RegUNTB.Text)) || (String.IsNullOrEmpty(RegPWTB.Text)) || (String.IsNullOrEmpty(RegPWTB2.Text)) || (String.IsNullOrEmpty(RegEmailTB.Text)))
            {
                RegisterErrorLB.Text = "All fields must be filled";
                RegisterErrorLB.Visible = true;
                RegisterErrorLB.ForeColor = System.Drawing.Color.Red;
            }
            else if (UNquery2 != null)
            {
                RegisterErrorLB.Text = "Username is taken";
                RegisterErrorLB.ForeColor = System.Drawing.Color.Red;
                RegisterErrorLB.Visible = true;
            }
            else if (RegPWTB.Text != RegPWTB2.Text)
            {
                RegisterErrorLB.Visible = true;
                RegisterErrorLB.Text = "Passwords do not match";
                RegisterErrorLB.ForeColor = System.Drawing.Color.Red;
            }
            else if (!IsValidEmail(RegEmailTB.Text))
            {
                RegisterErrorLB.Text = "You must enter a valid email address";
                RegisterErrorLB.ForeColor = System.Drawing.Color.Red;
                RegisterErrorLB.Visible = true;
            }
            else
            {
                filled = true;
            }
            if (filled)
            {
                try
                {
                    User newuser = new User();
                    newuser.UserName = RegUNTB.Text;
                    newuser.Password = Crypto.Encrypt(RegPWTB.Text);
                    newuser.Email = RegEmailTB.Text;
                    db.Users.InsertOnSubmit(newuser);
                    db.SubmitChanges();
                    Score scoreuser = new Score();
                    scoreuser.Username = RegUNTB.Text;
                    scoreuser.Score1 = 0;
                    scoreuser.ID=(from x in db.GetTable<User>() where x.UserName == RegUNTB.Text select x.ID).FirstOrDefault();
                    db.Scores.InsertOnSubmit(scoreuser);
                    db.SubmitChanges();
                    MessageBox.Show("Registration succesful");
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (success)
            {
                MainGB.Visible = true;
                RegisterGB.Visible = false;
                LoginGB.Visible = false;
                Reset();
            }
        }

        private void OpenMemory()
        {
            Application.Run(new MemoryForm(CurrentUser));
        }


    }
}
