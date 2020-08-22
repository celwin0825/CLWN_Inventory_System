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
using System.Net.Mail;
namespace Inventory_System
{
    public partial class Transaction : Form
    {
        public static string OledbCon = "";
        public string iName = "";
        public string iQty = "";
        public string iPrice = "";
        DataTable Purchase_data = new DataTable();
        public Transaction()
        {
            InitializeComponent();
            var MyINI = new IniFile("config.ini");
            OledbCon = MyINI.Read("CONNECTION", "connection");
            OR_Number();
          
        }
        private void CheckOutbtn_Click(object sender, EventArgs e)
        {
            Check_Out();
            Update_OR();
            Clear_Data();
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }
        #region Display OR Number
        private void OR_Number()
        {
            using (OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "Select * from ORNO";
                using(OleDbDataAdapter sda = new OleDbDataAdapter(query,con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    ORnumlbl.Text = dt.Rows[0][0].ToString();
                }
            }
        }
        #endregion
        #region Update OR NUMBER
        private void Update_OR()
        {
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "UPDATE ORNO SET [OR_Number]=@OR where [OR_Number] = @ORNO";
                using(OleDbCommand cmd = new OleDbCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@OR", (Convert.ToInt64(ORnumlbl.Text) + 1).ToString());
                    cmd.Parameters.AddWithValue("ORNO", ORnumlbl.Text);
                    con.Open();
                    int result  =cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        ORnumlbl.Text = (Convert.ToInt64(ORnumlbl.Text) + 1).ToString();
                    }
                    con.Close();
                }
            }

        }
        #endregion
        #region Display Item Data
        private void Master_Data()
        {
            using (OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "Select * From Master_Data where Item_Number=@iNumber";
                using(OleDbCommand cmd = new OleDbCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@iNumber", iNumbertxt.Text);
                        using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            iName = dt.Rows[0]["Item_Name"].ToString();
                            iPrice = dt.Rows[0]["Item_Price"].ToString();
                            iQty = dt.Rows[0]["Item_Quantity"].ToString();
                        }
                }
            }
        }
        #endregion
        #region Add Items
        bool isColumnCreated = false;
        private void Add_Items()
        {
            if(!isColumnCreated)
            {
                Purchase_data.Columns.Add("Item Number");
                Purchase_data.Columns.Add("Item Name");
                Purchase_data.Columns.Add("Quantity");
                Purchase_data.Columns.Add("Price");
                Purchase_data.Columns.Add("Total Price");
                isColumnCreated = true;
            }
            double x, y, z, sum;
            x = Convert.ToDouble(iQtytxt.Text);
            y = Convert.ToDouble(iPrice);
            z = Convert.ToDouble(iPricetxt.Text);
            sum = (x * y) + z;
            iPricetxt.Text = Math.Round(sum, 2).ToString();

            Purchase_data.Rows.Add(iNumbertxt.Text, iName, iQtytxt.Text, iPrice,Math.Round((x*y),2).ToString());
            DisplayData.DataSource = Purchase_data;
            DisplayData.AutoResizeColumns();
            DisplayData.AutoResizeRows();
            
            

            iNumbertxt.Text = "";
            iQtytxt.Text = "";
        }
        #endregion
        #region Common commands
        private void iAmmountxt_Click(object sender, EventArgs e)
        {
            iAmmountxt.SelectAll();
        }
        private void iNumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Master_Data();
                iQtytxt.Focus();
            }
            else if(e.KeyCode == Keys.ControlKey)
            {
                iAmmountxt.Focus();
            }
        }
        private void iQtytxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 Add_Items();
                iNumbertxt.Focus();
            }
        }
        private void iAmmountxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double x, y, diff;

                x = Convert.ToDouble(iPricetxt.Text);
                y = Convert.ToDouble(iAmmountxt.Text);
                diff = y - x;
                iChange.Text = Math.Round(diff, 2).ToString();
                CheckOutbtn.Enabled = true;
                CheckOutbtn.Focus();
            }
        }
        #endregion
        #region Check OUT
        private void Check_Out()
        {
            for (int i = 0; i < Purchase_data.Rows.Count; i++)
            {
                using (OleDbConnection con = new OleDbConnection(OledbCon))
                {
                string query = "INSERT INTO Sales_Data(OR_NUMBER,Item_Number,Item_Name,Item_Price,Purchased_Qty,Total_Item_Price) VALUES " +
                    "(@OR,@iNum,@iName,iPrice,@iQty,@iTotalPrice)";
                    using(OleDbCommand cmd = new OleDbCommand(query,con))
                    {
                        cmd.Parameters.AddWithValue("@OR", ORnumlbl.Text);
                        cmd.Parameters.AddWithValue("@iNum", Purchase_data.Rows[i]["Item Number"].ToString());
                        cmd.Parameters.AddWithValue("@iName", Purchase_data.Rows[i]["Item Name"].ToString());
                        cmd.Parameters.AddWithValue("@iPrice", Purchase_data.Rows[i]["Price"].ToString());
                        cmd.Parameters.AddWithValue("@iQty", Purchase_data.Rows[i]["Quantity"].ToString());
                        cmd.Parameters.AddWithValue("@iTotalPrice", Purchase_data.Rows[i]["Total Price"].ToString());
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        if(result > 0)
                        {
                           
                        }
                        con.Close();
                    }
                }
            }
        }
        #endregion
        #region Clear Data
        private void Clear_Data()
        {
            iName = "";
            iQty = "";
            iPrice = "";
            Purchase_data.Clear();
            isColumnCreated = false;
            iNumbertxt.Text = "";
            iQtytxt.Text = "";
            iPricetxt.Text = "0.00";
            iAmmountxt.Text = "0.00";
            iChange.Text = "0.00";
            OR_Number();
            DisplayData.DataSource = null;
            CheckOutbtn.Enabled = false ;
            iNumbertxt.Focus();
        }

        #endregion

    }
}
