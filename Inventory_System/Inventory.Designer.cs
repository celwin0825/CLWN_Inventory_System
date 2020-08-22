namespace Inventory_System
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNumtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemCattxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemQtytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemPricetxt = new System.Windows.Forms.TextBox();
            this.Regbtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OrigPricetxt = new System.Windows.Forms.TextBox();
            this.ItemPriceMultipliertxt = new System.Windows.Forms.TextBox();
            this.PriceMultipliercheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryData
            // 
            this.InventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryData.Location = new System.Drawing.Point(13, 177);
            this.InventoryData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InventoryData.Name = "InventoryData";
            this.InventoryData.Size = new System.Drawing.Size(603, 220);
            this.InventoryData.TabIndex = 0;
            this.InventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryData_CellClick);
            this.InventoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Number:";
            // 
            // ItemNumtxt
            // 
            this.ItemNumtxt.Location = new System.Drawing.Point(110, 36);
            this.ItemNumtxt.Name = "ItemNumtxt";
            this.ItemNumtxt.Size = new System.Drawing.Size(338, 22);
            this.ItemNumtxt.TabIndex = 5;
            this.ItemNumtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemNumtxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Name:";
            // 
            // ItemNametxt
            // 
            this.ItemNametxt.Location = new System.Drawing.Point(110, 64);
            this.ItemNametxt.Name = "ItemNametxt";
            this.ItemNametxt.Size = new System.Drawing.Size(338, 22);
            this.ItemNametxt.TabIndex = 7;
            this.ItemNametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemNametxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category:";
            // 
            // ItemCattxt
            // 
            this.ItemCattxt.Location = new System.Drawing.Point(110, 92);
            this.ItemCattxt.Name = "ItemCattxt";
            this.ItemCattxt.Size = new System.Drawing.Size(338, 22);
            this.ItemCattxt.TabIndex = 9;
            this.ItemCattxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemCattxt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity:";
            // 
            // ItemQtytxt
            // 
            this.ItemQtytxt.Location = new System.Drawing.Point(110, 120);
            this.ItemQtytxt.Name = "ItemQtytxt";
            this.ItemQtytxt.Size = new System.Drawing.Size(338, 22);
            this.ItemQtytxt.TabIndex = 11;
            this.ItemQtytxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemQtytxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Market Price:";
            // 
            // ItemPricetxt
            // 
            this.ItemPricetxt.Location = new System.Drawing.Point(375, 148);
            this.ItemPricetxt.Name = "ItemPricetxt";
            this.ItemPricetxt.Size = new System.Drawing.Size(73, 22);
            this.ItemPricetxt.TabIndex = 13;
            this.ItemPricetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemPricetxt_KeyDown);
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(510, 136);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(106, 34);
            this.Regbtn.TabIndex = 16;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(558, 36);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(60, 22);
            this.Refreshbtn.TabIndex = 17;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(448, 8);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(168, 22);
            this.Searchtxt.TabIndex = 18;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(510, 98);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(106, 34);
            this.Updatebtn.TabIndex = 19;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Original Price:";
            // 
            // OrigPricetxt
            // 
            this.OrigPricetxt.Location = new System.Drawing.Point(110, 148);
            this.OrigPricetxt.Name = "OrigPricetxt";
            this.OrigPricetxt.Size = new System.Drawing.Size(74, 22);
            this.OrigPricetxt.TabIndex = 20;
            this.OrigPricetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrigPricetxt_KeyDown);
            // 
            // ItemPriceMultipliertxt
            // 
            this.ItemPriceMultipliertxt.Location = new System.Drawing.Point(190, 148);
            this.ItemPriceMultipliertxt.Name = "ItemPriceMultipliertxt";
            this.ItemPriceMultipliertxt.Size = new System.Drawing.Size(41, 22);
            this.ItemPriceMultipliertxt.TabIndex = 22;
            this.ItemPriceMultipliertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemPriceMultipliertxt_KeyDown);
            // 
            // PriceMultipliercheckbox
            // 
            this.PriceMultipliercheckbox.AutoSize = true;
            this.PriceMultipliercheckbox.Location = new System.Drawing.Point(256, 156);
            this.PriceMultipliercheckbox.Name = "PriceMultipliercheckbox";
            this.PriceMultipliercheckbox.Size = new System.Drawing.Size(15, 14);
            this.PriceMultipliercheckbox.TabIndex = 23;
            this.PriceMultipliercheckbox.UseVisualStyleBackColor = true;
            this.PriceMultipliercheckbox.CheckedChanged += new System.EventHandler(this.PriceMultipliercheckbox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "%";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceMultipliercheckbox);
            this.Controls.Add(this.ItemPriceMultipliertxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrigPricetxt);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemPricetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemQtytxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemCattxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNumtxt);
            this.Controls.Add(this.InventoryData);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.InventoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNumtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemCattxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemQtytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemPricetxt;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OrigPricetxt;
        private System.Windows.Forms.TextBox ItemPriceMultipliertxt;
        private System.Windows.Forms.CheckBox PriceMultipliercheckbox;
        private System.Windows.Forms.Label label7;
    }
}