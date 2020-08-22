namespace Inventory_System
{
    partial class Account_Creation
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPasswordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Postxt = new System.Windows.Forms.TextBox();
            this.Regbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.PassCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME:";
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(15, 28);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(188, 22);
            this.UserNametxt.TabIndex = 3;
            this.UserNametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNametxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD:";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(17, 79);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(188, 22);
            this.Passwordtxt.TabIndex = 5;
            this.Passwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passwordtxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONFIRM PASSWORD:";
            // 
            // CPasswordtxt
            // 
            this.CPasswordtxt.Location = new System.Drawing.Point(17, 123);
            this.CPasswordtxt.Name = "CPasswordtxt";
            this.CPasswordtxt.PasswordChar = '*';
            this.CPasswordtxt.Size = new System.Drawing.Size(188, 22);
            this.CPasswordtxt.TabIndex = 7;
            this.CPasswordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPasswordtxt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FULL NAME:";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(17, 167);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(188, 22);
            this.Nametxt.TabIndex = 9;
            this.Nametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nametxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "POSITION:";
            // 
            // Postxt
            // 
            this.Postxt.Location = new System.Drawing.Point(17, 211);
            this.Postxt.Name = "Postxt";
            this.Postxt.Size = new System.Drawing.Size(188, 22);
            this.Postxt.TabIndex = 11;
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(211, 121);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(106, 34);
            this.Regbtn.TabIndex = 13;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(211, 161);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(106, 34);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(211, 199);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(106, 34);
            this.Delbtn.TabIndex = 15;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // PassCbx
            // 
            this.PassCbx.AutoSize = true;
            this.PassCbx.Location = new System.Drawing.Point(131, 56);
            this.PassCbx.Name = "PassCbx";
            this.PassCbx.Size = new System.Drawing.Size(129, 20);
            this.PassCbx.TabIndex = 16;
            this.PassCbx.Text = "Update Password";
            this.PassCbx.UseVisualStyleBackColor = true;
            // 
            // Account_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.PassCbx);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Postxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPasswordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNametxt);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPasswordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Postxt;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.CheckBox PassCbx;
    }
}