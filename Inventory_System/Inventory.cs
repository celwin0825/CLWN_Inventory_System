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
    public partial class Inventory : Form
    {

        public static string OledbCon = "";
        public Inventory()
        {
            InitializeComponent();
            var MyINI = new IniFile("config.ini");
            OledbCon = MyINI.Read("CONNECTION", "connection");
            View_Data();
            datagridview();
        }
        #region View Data
        DataTable dt = new DataTable();
        private void View_Data()
        {
            dt.Clear();
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "Select * From Master_Data";
                using(OleDbDataAdapter sda = new OleDbDataAdapter(query,con))
                {
                    sda.Fill(dt);
                    InventoryData.DataSource = dt;
                    InventoryData.AutoResizeColumns();
                    InventoryData.AutoResizeRows();
                }
            }
           
        }

        #endregion
        #region Check Data
        bool Proceed_Registration = false;
        private void Check_Data()
        {
            Proceed_Registration = false;
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "Select * From Master_Data where Item_Number = @ItemNum";
                using(OleDbCommand cmd = new OleDbCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@ItemNum", ItemNumtxt.Text);
                    con.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if(dr.HasRows)
                    {
                        Proceed_Registration = false;
                        MessageBox.Show("Item: " + ItemNumtxt.Text + " is already registered in the database.");
                        Clear_Data();
                        ItemNumtxt.Focus();
                    }
                    else
                    {
                        Proceed_Registration = true;
                    }
                   
                }
            }
        }
        #endregion
        #region Common Commmands
        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }
        private void ItemNumtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Check_Data();
                ItemNametxt.Focus();
            }
        }

        private void ItemNametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ItemCattxt.Focus();
            }
        }

        private void ItemCattxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemQtytxt.Focus();
            }
        }

        private void ItemQtytxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               OrigPricetxt.Focus();
            }
        }

        private void ItemPricetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Regbtn.Focus();
            }
        }
        private void OrigPricetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ItemPriceMultipliertxt.ReadOnly == true)
                {
                    decimal x, y, z;
                    x = Convert.ToInt32(OrigPricetxt.Text);
                    y = Convert.ToInt32(ItemPriceMultipliertxt.Text);
                    z = Math.Round(x * (y / 100), 2) + x;
                    ItemPricetxt.Text = z.ToString();

                    Regbtn.Focus();
                }
                else
                {
                    ItemPriceMultipliertxt.Focus();
                }
            }
        }
        private void ItemPriceMultipliertxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                decimal x, y, z;
                x = Convert.ToInt32(OrigPricetxt.Text);
                y = Convert.ToInt32(ItemPriceMultipliertxt.Text);
                z = Math.Round(x * (y / 100), 2) + x;
                ItemPricetxt.Text = z.ToString();

                Regbtn.Focus();
            }
        }
        private void PriceMultipliercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriceMultipliercheckbox.Checked == true)
            {
                ItemPriceMultipliertxt.ReadOnly = true;
            }
            else
            {
                ItemPriceMultipliertxt.ReadOnly = false;
            }
        }
        #endregion
        #region Clear Data
        private  void Clear_Data()
        {
            ItemNumtxt.Text = "";
            ItemNametxt.Text = "";
            ItemCattxt.Text = "";
            ItemQtytxt.Text = "";
            ItemPricetxt.Text = "";
            OrigPricetxt.Text = "";
            if (ItemPriceMultipliertxt.ReadOnly == false)
            {
                ItemPriceMultipliertxt.Text = "";
            }
            View_Data();
        }
        #endregion
        #region Registration
        private void Regbtn_Click(object sender, EventArgs e)
        {
            Check_Data();
            if (Proceed_Registration == true)
            {
                Item_Registration();
            }
        }
        private void Item_Registration()
        {
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "INSERT INTO Master_Data(Item_Number, Item_Name, Item_Category, Item_Quantity, Item_Orig_Price,Item_Price) "  
                    + "Values(@iNumber,@iName,@iCategory,@iQty,@iOPrice,@iPrice)";
                using (OleDbCommand cmd = new OleDbCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("@iNumber", ItemNumtxt.Text);
                    cmd.Parameters.AddWithValue("@iName", ItemNametxt.Text);
                    cmd.Parameters.AddWithValue("@iCategory", ItemCattxt.Text);
                    cmd.Parameters.AddWithValue("@iQty", ItemQtytxt.Text);
                    cmd.Parameters.AddWithValue("@iOPrice", OrigPricetxt.Text);
                    cmd.Parameters.AddWithValue("@iPrice", ItemPricetxt.Text);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if(result>0)
                    {
                        MessageBox.Show("Registration Complete");
                        Clear_Data();
                        ItemNumtxt.Focus();
                    }
                    con.Close();
                }
            }
        }
        #endregion
        #region Update
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Item_Update();
            ItemNumtxt.ReadOnly = false;
        }
        private void Item_Update()
        {
            using(OleDbConnection con = new OleDbConnection(OledbCon))
            {
                string query = "UPDATE Master_Data SET Item_Name=@iName, Item_Category=@iCategory, Item_Quantity=@iQty, Item_Orig_Price=@iOPrice,Item_Price=@iPrice where Item_Number=@iNumber";
                using(OleDbCommand cmd = new OleDbCommand(query,con))
                {
                    
                    cmd.Parameters.AddWithValue("@iName", ItemNametxt.Text);
                    cmd.Parameters.AddWithValue("@iCategory", ItemCattxt.Text);
                    cmd.Parameters.AddWithValue("@iQty", ItemQtytxt.Text);
                    cmd.Parameters.AddWithValue("@iOPrice", OrigPricetxt.Text);
                    cmd.Parameters.AddWithValue("@iPrice", ItemPricetxt.Text);
                    cmd.Parameters.AddWithValue("@iNumber", ItemNumtxt.Text);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Update Complete");
                        Clear_Data();
                    }
                    con.Close();


                }
            }
        }
        #endregion
        #region Delete
        private void item_Delete()
        {
            DialogResult result1 = new DialogResult();
            result1 = MessageBox.Show("Do you want to delete item: " + ItemNumtxt.Text + "?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result1 == DialogResult.Yes)
            {
                using (OleDbConnection con = new OleDbConnection(OledbCon))
                {
                    string query = "Delete From Master_Data where Item_Number=@iNumber";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@iNumber", ItemNumtxt.Text);
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Delete Complete");
                            Clear_Data();
                        }
                        con.Close();
                    }

                }
            }
            else
            {
                Clear_Data();
            }
        }
        #endregion
        #region DatagridView Commands
        private void datagridview()
        {
            DataGridViewButtonColumn EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            EditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InventoryData.Columns.Add(EditButton);

            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn();
            DeleteButton.Name = "";
            DeleteButton.Text = "Delete";
            DeleteButton.UseColumnTextForButtonValue = true;
            DeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InventoryData.Columns.Add(DeleteButton);

        }
        private void InventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                ItemNumtxt.ReadOnly = true;
               
               
            }
            else if(e.ColumnIndex == 1)
            {
                item_Delete();
            }
        }
        private void InventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.InventoryData.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                ItemNumtxt.Text = row.Cells["Item_Number"].Value.ToString();
                ItemNametxt.Text = row.Cells["Item_Name"].Value.ToString();
                ItemCattxt.Text = row.Cells["Item_Category"].Value.ToString();
                ItemQtytxt.Text = row.Cells["Item_Quantity"].Value.ToString();
                ItemPricetxt.Text = row.Cells["Item_Price"].Value.ToString();
            }
        }



        #endregion
        #region
        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                var rows = dt.Select(string.Format("Item_Number LIKE '%{0}%' OR Item_Name LIKE '%{0}%' OR Item_Quantity LIKE '%{0}%' OR Item_Price LIKE '%{0}%'", Searchtxt.Text));
                InventoryData.DataSource = rows.CopyToDataTable();
                InventoryData.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

       
    }
}
