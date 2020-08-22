namespace Inventory_System
{
    partial class Transaction
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
            this.iNumbertxt = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iChange = new System.Windows.Forms.TextBox();
            this.DisplayData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ORnumlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iPricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iAmmountxt = new System.Windows.Forms.TextBox();
            this.CheckOutbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.iQtytxt = new System.Windows.Forms.TextBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).BeginInit();
            this.SuspendLayout();
            // 
            // iNumbertxt
            // 
            this.iNumbertxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNumbertxt.Location = new System.Drawing.Point(151, 36);
            this.iNumbertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iNumbertxt.Name = "iNumbertxt";
            this.iNumbertxt.Size = new System.Drawing.Size(375, 39);
            this.iNumbertxt.TabIndex = 0;
            this.iNumbertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iNumbertxt_KeyDown);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(9, 7);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(190, 23);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "Hi Celwin Hernandez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHANGE:";
            // 
            // iChange
            // 
            this.iChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iChange.Location = new System.Drawing.Point(285, 348);
            this.iChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iChange.Name = "iChange";
            this.iChange.ReadOnly = true;
            this.iChange.Size = new System.Drawing.Size(157, 26);
            this.iChange.TabIndex = 2;
            this.iChange.Text = "0.00";
            this.iChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DisplayData
            // 
            this.DisplayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayData.Location = new System.Drawing.Point(151, 120);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.Size = new System.Drawing.Size(375, 155);
            this.DisplayData.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR NO:";
            // 
            // ORnumlbl
            // 
            this.ORnumlbl.AutoSize = true;
            this.ORnumlbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORnumlbl.Location = new System.Drawing.Point(49, 359);
            this.ORnumlbl.Name = "ORnumlbl";
            this.ORnumlbl.Size = new System.Drawing.Size(37, 14);
            this.ORnumlbl.TabIndex = 6;
            this.ORnumlbl.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL PRICE:";
            // 
            // iPricetxt
            // 
            this.iPricetxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPricetxt.Location = new System.Drawing.Point(285, 282);
            this.iPricetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iPricetxt.Name = "iPricetxt";
            this.iPricetxt.ReadOnly = true;
            this.iPricetxt.Size = new System.Drawing.Size(157, 26);
            this.iPricetxt.TabIndex = 7;
            this.iPricetxt.Text = "0.00";
            this.iPricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL AMOUNT:";
            // 
            // iAmmountxt
            // 
            this.iAmmountxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iAmmountxt.Location = new System.Drawing.Point(285, 316);
            this.iAmmountxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iAmmountxt.Name = "iAmmountxt";
            this.iAmmountxt.Size = new System.Drawing.Size(157, 26);
            this.iAmmountxt.TabIndex = 9;
            this.iAmmountxt.Text = "0.00";
            this.iAmmountxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.iAmmountxt.Click += new System.EventHandler(this.iAmmountxt_Click);
            this.iAmmountxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iAmmountxt_KeyDown);
            // 
            // CheckOutbtn
            // 
            this.CheckOutbtn.Enabled = false;
            this.CheckOutbtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutbtn.Location = new System.Drawing.Point(448, 281);
            this.CheckOutbtn.Name = "CheckOutbtn";
            this.CheckOutbtn.Size = new System.Drawing.Size(78, 93);
            this.CheckOutbtn.TabIndex = 11;
            this.CheckOutbtn.Text = "CHECK\r\nOUT\r\n";
            this.CheckOutbtn.UseVisualStyleBackColor = true;
            this.CheckOutbtn.Click += new System.EventHandler(this.CheckOutbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Item Quantity:";
            // 
            // iQtytxt
            // 
            this.iQtytxt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iQtytxt.Location = new System.Drawing.Point(151, 83);
            this.iQtytxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iQtytxt.Name = "iQtytxt";
            this.iQtytxt.Size = new System.Drawing.Size(375, 30);
            this.iQtytxt.TabIndex = 12;
            this.iQtytxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iQtytxt_KeyDown);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(12, 214);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(130, 61);
            this.Cancelbtn.TabIndex = 14;
            this.Cancelbtn.Text = "Cancel Order";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Barcode No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
           // this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iQtytxt);
            this.Controls.Add(this.CheckOutbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iAmmountxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iPricetxt);
            this.Controls.Add(this.ORnumlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iChange);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.iNumbertxt);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iNumbertxt;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iChange;
        private System.Windows.Forms.DataGridView DisplayData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ORnumlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iPricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iAmmountxt;
        private System.Windows.Forms.Button CheckOutbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iQtytxt;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}