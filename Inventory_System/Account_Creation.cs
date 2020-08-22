using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inventory_System
{
    public partial class Account_Creation : Form
    {
        public static string OledbCon = "";
        public Account_Creation()
        {
            InitializeComponent();
            var MyINI = new IniFile("config.ini");
            OledbCon = MyINI.Read("CONNECTION", "connection");
        }

        #region Verify Account
        bool isAccountCreated = false;
        private void Verify_Account()
        {
            OleDbConnection con = new OleDbConnection(OledbCon);
            using (OleDbCommand StrQuer = new OleDbCommand("SELECT *  FROM Login WHERE User_Account=@userid", con))
            {
                StrQuer.Parameters.AddWithValue("@userid", UserNametxt.Text);
                con.Open();
                OleDbDataReader dr = StrQuer.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Nametxt.Text = dr["Full_Name"].ToString();
                        Postxt.Text = dr["Position"].ToString();
                        isAccountCreated = true;
                    }
                }
                else
                {
                    isAccountCreated = false;
                }

            }
            con.Close();
        }
        #endregion
        #region REGISTRATION
        private void Regbtn_Click(object sender, EventArgs e)
        {
            #region Password Confirmation
            if (Passwordtxt.Text != CPasswordtxt.Text)
            {
                MessageBox.Show("Password not match. \n Please try again.");
                Passwordtxt.Text = "";
                CPasswordtxt.Text = "";
            }
            else
            { 
            #endregion
            Verify_Account();
                if (isAccountCreated == true)
                {
                    MessageBox.Show("User Account is already registered. \n Please try different User Account.");
                    Clear();
                }
                else
                {
                    using (OleDbConnection con = new OleDbConnection(OledbCon))
                    {
                        string query = "INSERT INTO Login([User_Account],[Password],[Full_Name],[Position]) VALUES (@user,@pass,@name,@pos)";
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("user", UserNametxt.Text);
                            cmd.Parameters.AddWithValue("pass", Passwordtxt.Text);
                            cmd.Parameters.AddWithValue("name", Nametxt.Text);
                            cmd.Parameters.AddWithValue("pos", Postxt.Text);
                            con.Open();
                            int result = cmd.ExecuteNonQuery();
                            if (result < 0)
                            {
                                MessageBox.Show("Encountered Error in Database.");
                            }
                            else
                            {
                                MessageBox.Show("Registration Complete.");
                                this.Close();
                            }
                            con.Close();
                        }
                    }
                }
            }
        }
        #endregion
        string GENERATE_COMMAND = "";
        #region UPDATE
        string Update_query = "";
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Update_query = "";
            GENERATE_COMMAND = "UPDATE";
            if (Passwordtxt.Text != CPasswordtxt.Text)
            {
                MessageBox.Show("Password not match. \n Please try again.");
                Passwordtxt.Text = "";
                CPasswordtxt.Text = "";
            }
            else
            {
                    if(PassCbx.Checked == false)
                    {
                        login();
                    }
                    else
                    {
                    Update_query = "UPDATE  Login SET [Password] = @pass,[Full_Name]=@name,[Position]=@pos  where User_Account ='" + UserNametxt.Text + "'";
                    UPDATE_DATA();
                    }
            }

        }
        private void UPDATE_DATA()
        {
            using (OleDbConnection con = new OleDbConnection(OledbCon))
            {
                using (OleDbCommand cmd = new OleDbCommand(Update_query, con))
                {
                    cmd.Parameters.AddWithValue("pass", Passwordtxt.Text);
                    cmd.Parameters.AddWithValue("name", Nametxt.Text);
                    cmd.Parameters.AddWithValue("pos", Postxt.Text);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Encountered Error in Database.");
                    }
                    else
                    {
                        MessageBox.Show("Update Complete.");
                        Clear();
                    }
                    con.Close();
                }
            }
        }
        #endregion
        #region Clear
        private void Clear()
        {
            UserNametxt.Text = "";
            Passwordtxt.Text = "";
            CPasswordtxt.Text = "";
            Nametxt.Text = "";
            Postxt.Text = "";
            PassCbx.Checked = false;
        }
        #endregion
        #region common commands
        private void UserNametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Verify_Account();
                Passwordtxt.Focus();
            }
        }
        private void Passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CPasswordtxt.Focus();
            }
        }
        private void CPasswordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Nametxt.Focus();
            }
        }
        private void Nametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Postxt.Focus();
            }
        }
        #endregion
        #region Delete
        private void Delbtn_Click(object sender, EventArgs e)
        {
            GENERATE_COMMAND="DELETE";
            if (Passwordtxt.Text != CPasswordtxt.Text)
            {
                MessageBox.Show("Password not match. \n Please try again.");
                Passwordtxt.Text = "";
                CPasswordtxt.Text = "";
            }
            else
            {
                login();
            }
        }
        private void DELETE_DATA()
        {
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "Delete From Login where User_Account =@user AND @pass";
                using(OleDbCommand cmd = new OleDbCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@user", UserNametxt.Text);
                    cmd.Parameters.AddWithValue("@pass", Passwordtxt.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Delete Complete.");
            Clear();
        }
        #endregion
        #region For Confirmation

        private void login()
        {

            OleDbConnection con = new OleDbConnection(OledbCon);
            using (OleDbCommand StrQuer = new OleDbCommand("SELECT *  FROM Login WHERE User_Account=@userid AND Password=@password", con))
            {
                StrQuer.Parameters.AddWithValue("@userid", UserNametxt.Text);
                StrQuer.Parameters.AddWithValue("@password", Passwordtxt.Text);
                con.Open();
                OleDbDataReader dr = StrQuer.ExecuteReader();

                if (dr.HasRows)
                {
                    if (GENERATE_COMMAND == "UPDATE")
                    {
                        Update_query = "UPDATE  Login SET [Password] = @pass,[Full_Name]=@name,[Position]=@pos where User_Account ='" + UserNametxt.Text + "'";
                        UPDATE_DATA();
                    }
                    else if(GENERATE_COMMAND == "DELETE")
                    {
                        DELETE_DATA();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password. \n Please try again.");
                    Passwordtxt.Text = "";
                    CPasswordtxt.Text = "";
                }

            }
            con.Close();
        }
        #endregion
    }
}
