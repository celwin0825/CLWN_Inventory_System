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
    public partial class Login : Form
    {
        public static string OledbCon = "";
        
        public Login()
        {
            InitializeComponent();
            var MyINI = new IniFile("config.ini");
            OledbCon = MyINI.Read("CONNECTION", "connection");
        }

        private void Loginbtn_Click(object sender, EventArgs e)
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
                   MessageBox.Show("Login Success.");    
                }
                else
                {
                    MessageBox.Show("Account Not Found.");
                }
            }
            con.Close();
        }

        private void CAbtn_Click(object sender, EventArgs e)
        {
            Account_Creation AC = new Account_Creation();
            AC.Show();
        }
    }
}
