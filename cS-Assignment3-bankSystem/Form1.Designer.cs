namespace cS_Assignment3_bankSystem
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxABranchNo = new System.Windows.Forms.TextBox();
            this.tbxACreditLimit = new System.Windows.Forms.TextBox();
            this.cbxAType = new System.Windows.Forms.ComboBox();
            this.tbxABallance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnModifyA = new System.Windows.Forms.Button();
            this.btnRemoveA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxBranchNo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxCL = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxBallance = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxAType = new System.Windows.Forms.ListBox();
            this.lbxAID = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.lblClientNameTrans = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxAID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancelA = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLogin);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabTransactions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.btnCancel);
            this.TabLogin.Controls.Add(this.btnLogin);
            this.TabLogin.Controls.Add(this.tbxPass);
            this.TabLogin.Controls.Add(this.label2);
            this.TabLogin.Controls.Add(this.tbxCID);
            this.TabLogin.Controls.Add(this.label1);
            this.TabLogin.Location = new System.Drawing.Point(4, 22);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabLogin.Size = new System.Drawing.Size(605, 281);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "Login";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(27, 112);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(83, 74);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbxCID
            // 
            this.tbxCID.Location = new System.Drawing.Point(83, 48);
            this.tbxCID.Name = "tbxCID";
            this.tbxCID.Size = new System.Drawing.Size(100, 20);
            this.tbxCID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID:";
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.btnCancelA);
            this.tabAccount.Controls.Add(this.btnSubmit);
            this.tabAccount.Controls.Add(this.tbxAID);
            this.tabAccount.Controls.Add(this.label13);
            this.tabAccount.Controls.Add(this.btnClear);
            this.tabAccount.Controls.Add(this.tbxABranchNo);
            this.tabAccount.Controls.Add(this.tbxACreditLimit);
            this.tabAccount.Controls.Add(this.cbxAType);
            this.tabAccount.Controls.Add(this.tbxABallance);
            this.tabAccount.Controls.Add(this.label9);
            this.tabAccount.Controls.Add(this.label10);
            this.tabAccount.Controls.Add(this.label11);
            this.tabAccount.Controls.Add(this.label12);
            this.tabAccount.Controls.Add(this.btnModifyA);
            this.tabAccount.Controls.Add(this.btnRemoveA);
            this.tabAccount.Controls.Add(this.btnAddA);
            this.tabAccount.Controls.Add(this.label8);
            this.tabAccount.Controls.Add(this.lbxBranchNo);
            this.tabAccount.Controls.Add(this.label7);
            this.tabAccount.Controls.Add(this.lbxCL);
            this.tabAccount.Controls.Add(this.label6);
            this.tabAccount.Controls.Add(this.lbxBallance);
            this.tabAccount.Controls.Add(this.label5);
            this.tabAccount.Controls.Add(this.lbxAType);
            this.tabAccount.Controls.Add(this.lbxAID);
            this.tabAccount.Controls.Add(this.label4);
            this.tabAccount.Controls.Add(this.lblClientName);
            this.tabAccount.Controls.Add(this.label3);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(605, 281);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxABranchNo
            // 
            this.tbxABranchNo.Location = new System.Drawing.Point(422, 112);
            this.tbxABranchNo.Name = "tbxABranchNo";
            this.tbxABranchNo.Size = new System.Drawing.Size(80, 20);
            this.tbxABranchNo.TabIndex = 22;
            this.tbxABranchNo.Text = "0";
            this.tbxABranchNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxACreditLimit
            // 
            this.tbxACreditLimit.Enabled = false;
            this.tbxACreditLimit.Location = new System.Drawing.Point(422, 86);
            this.tbxACreditLimit.Name = "tbxACreditLimit";
            this.tbxACreditLimit.Size = new System.Drawing.Size(80, 20);
            this.tbxACreditLimit.TabIndex = 21;
            this.tbxACreditLimit.Text = "0.0";
            this.tbxACreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxAType
            // 
            this.cbxAType.FormattingEnabled = true;
            this.cbxAType.Items.AddRange(new object[] {
            "checking",
            "saving",
            "visa"});
            this.cbxAType.Location = new System.Drawing.Point(422, 33);
            this.cbxAType.Name = "cbxAType";
            this.cbxAType.Size = new System.Drawing.Size(80, 21);
            this.cbxAType.TabIndex = 20;
            this.cbxAType.SelectedIndexChanged += new System.EventHandler(this.cbxAType_SelectedIndexChanged);
            // 
            // tbxABallance
            // 
            this.tbxABallance.Location = new System.Drawing.Point(422, 60);
            this.tbxABallance.Name = "tbxABallance";
            this.tbxABallance.Size = new System.Drawing.Size(80, 20);
            this.tbxABallance.TabIndex = 19;
            this.tbxABallance.Text = "0.0";
            this.tbxABallance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Branch no:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Credit limit:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ballance:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Acc Type:";
            // 
            // btnModifyA
            // 
            this.btnModifyA.Location = new System.Drawing.Point(269, 77);
            this.btnModifyA.Name = "btnModifyA";
            this.btnModifyA.Size = new System.Drawing.Size(86, 23);
            this.btnModifyA.TabIndex = 14;
            this.btnModifyA.Text = "Modify";
            this.btnModifyA.UseVisualStyleBackColor = true;
            this.btnModifyA.Click += new System.EventHandler(this.btnModifyA_Click);
            // 
            // btnRemoveA
            // 
            this.btnRemoveA.Location = new System.Drawing.Point(269, 48);
            this.btnRemoveA.Name = "btnRemoveA";
            this.btnRemoveA.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveA.TabIndex = 13;
            this.btnRemoveA.Text = "Remove";
            this.btnRemoveA.UseVisualStyleBackColor = true;
            this.btnRemoveA.Click += new System.EventHandler(this.btnRemoveA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(269, 18);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(86, 23);
            this.btnAddA.TabIndex = 12;
            this.btnAddA.Text = "Add Account";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Branch no";
            // 
            // lbxBranchNo
            // 
            this.lbxBranchNo.FormattingEnabled = true;
            this.lbxBranchNo.Location = new System.Drawing.Point(197, 48);
            this.lbxBranchNo.Name = "lbxBranchNo";
            this.lbxBranchNo.Size = new System.Drawing.Size(56, 147);
            this.lbxBranchNo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Credit limit";
            // 
            // lbxCL
            // 
            this.lbxCL.FormattingEnabled = true;
            this.lbxCL.Location = new System.Drawing.Point(144, 48);
            this.lbxCL.Name = "lbxCL";
            this.lbxCL.Size = new System.Drawing.Size(56, 147);
            this.lbxCL.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ballance";
            // 
            // lbxBallance
            // 
            this.lbxBallance.FormattingEnabled = true;
            this.lbxBallance.Location = new System.Drawing.Point(91, 48);
            this.lbxBallance.Name = "lbxBallance";
            this.lbxBallance.Size = new System.Drawing.Size(54, 147);
            this.lbxBallance.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Acc Type";
            // 
            // lbxAType
            // 
            this.lbxAType.FormattingEnabled = true;
            this.lbxAType.Location = new System.Drawing.Point(38, 48);
            this.lbxAType.Name = "lbxAType";
            this.lbxAType.Size = new System.Drawing.Size(54, 147);
            this.lbxAType.TabIndex = 4;
            // 
            // lbxAID
            // 
            this.lbxAID.FormattingEnabled = true;
            this.lbxAID.Location = new System.Drawing.Point(10, 48);
            this.lbxAID.Name = "lbxAID";
            this.lbxAID.Size = new System.Drawing.Size(29, 147);
            this.lbxAID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "lD";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(56, 7);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(0, 13);
            this.lblClientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client:";
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.lblClientNameTrans);
            this.tabTransactions.Controls.Add(this.label15);
            this.tabTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactions.Size = new System.Drawing.Size(605, 281);
            this.tabTransactions.TabIndex = 2;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // lblClientNameTrans
            // 
            this.lblClientNameTrans.AutoSize = true;
            this.lblClientNameTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNameTrans.Location = new System.Drawing.Point(55, 7);
            this.lblClientNameTrans.Name = "lblClientNameTrans";
            this.lblClientNameTrans.Size = new System.Drawing.Size(0, 13);
            this.lblClientNameTrans.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Client:";
            // 
            // tbxAID
            // 
            this.tbxAID.Location = new System.Drawing.Point(422, 7);
            this.tbxAID.Name = "tbxAID";
            this.tbxAID.Size = new System.Drawing.Size(80, 20);
            this.tbxAID.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Account ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(364, 138);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancelA
            // 
            this.btnCancelA.Location = new System.Drawing.Point(436, 138);
            this.btnCancelA.Name = "btnCancelA";
            this.btnCancelA.Size = new System.Drawing.Size(66, 23);
            this.btnCancelA.TabIndex = 27;
            this.btnCancelA.Text = "Cancel";
            this.btnCancelA.UseVisualStyleBackColor = true;
            this.btnCancelA.Click += new System.EventHandler(this.btnCancelA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxBranchNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxCL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxBallance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxAType;
        private System.Windows.Forms.ListBox lbxAID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClientNameTrans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxABranchNo;
        private System.Windows.Forms.TextBox tbxACreditLimit;
        private System.Windows.Forms.ComboBox cbxAType;
        private System.Windows.Forms.TextBox tbxABallance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnModifyA;
        private System.Windows.Forms.Button btnRemoveA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxAID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancelA;
    }
}

