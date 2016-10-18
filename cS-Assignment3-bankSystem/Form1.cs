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

namespace cS_Assignment3_bankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selected); //reaqured for tabControl1_Selected function (when changing tabs)
        }
        ADODB.Connection con = new ADODB.Connection(); //create a new connection and assign it to the variable adoConnection
        ADODB.Recordset rst = new ADODB.Recordset();//create a new recordset and and assign it to the variable adoRecordset
        string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:/Users/edyta.marcisz/Desktop/C#/cS-Assignment3-bankSystem/BankSystem.accdb";
        string sql, sqlOption;
        string user, userName; //keeps the client id
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAccount);
            tabControl1.TabPages.Remove(tabTransactions);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = tbxCID.Text;
            string pass = tbxPass.Text;
            if (user == "" || pass == "") MessageBox.Show("Missing login info!");
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = conStr; //ConnectionString is a property
                con.Open();
                sql = "SELECT * FROM LoginInfo;";

                OleDbDataAdapter adapter;//adapter between my tables from db and my tables in dataSet (in C# application)
                adapter = new OleDbDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "LoginInfo"); //fills out the adapter variable

                bool f = false;
                foreach (DataRow cRow in ds.Tables["LoginInfo"].Rows)
                {
                    if (user == cRow["lClientID"].ToString())
                    {
                        if (pass == cRow["lClientPass"].ToString())
                        {
                            f = true;
                            tabControl1.TabPages.Add(tabAccount); //makes tab Account visible
                            tabControl1.TabPages.Add(tabTransactions);
                            tabControl1.SelectTab(tabAccount); //goes to Tab Account
                            tabControl1.SelectedIndex = 1;
                            displayAccountTab();
                        }
                    }
                }
                if (f == false) MessageBox.Show("Wrong login information");
                con.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAddA_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            cbxAType.Visible = true;
            label11.Visible = true;
            tbxABallance.Visible = true;
            label10.Visible = true;
            tbxACreditLimit.Visible = true;
            label9.Visible = true;
            tbxABranchNo.Visible = true;
            btnSubmit.Visible = true;
            btnCancelA.Visible = true;
            sqlOption = "addAcc";
        }
        private void cbxAType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAType.GetItemText(cbxAType.SelectedItem) == "visa") //if user chooses "visa" as account type
            {
                tbxACreditLimit.Enabled = true; //enable setting the Credit Limit
            }
        }
        private void btnRemoveA_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            tbxAID.Visible = true;
            btnSubmit.Visible = true;
            btnCancelA.Visible = true;
            sqlOption = "delAcc";
        }
        private void btnModifyA_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            tbxAID.Visible = true;
            label12.Visible = true;
            cbxAType.Visible = true;
            label11.Visible = true;
            tbxABallance.Visible = true;
            label10.Visible = true;
            tbxACreditLimit.Visible = true;
            label9.Visible = true;
            tbxABranchNo.Visible = true;
            btnSubmit.Visible = true;
            btnCancelA.Visible = true;
            sqlOption = "modifyAcc";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int aID = Convert.ToInt32(tbxAID.Text);
            string aT = cbxAType.GetItemText(cbxAType.SelectedItem);
            double aB = Convert.ToDouble(tbxABallance.Text);
            double aCL = Convert.ToDouble(tbxACreditLimit.Text);
            int aBN = Convert.ToInt32(tbxABranchNo.Text);

            con.Open(conStr);
            switch (sqlOption)
            {
                case "addAcc":
                    sql = "INSERT INTO AccountInfo (aType, aBallance, aCreditLimit, aBranchNo, aClientID, aClientName) VALUES ('" +
                        aT + "', " + aB + ", " + aCL + ", " + aBN + ", '" + user + "', '" + userName + "');";
                    break;
                case "delAcc":
                    sql = "DELETE FROM AccountInfo WHERE aID="+aID+";";
                    break;
                case "modifyAcc":
                    sql = "SELECT * FROM AccountInfo WHERE aID=" + aID + ";";
                    rst.Open(sql, con);
                    while (!rst.EOF)
                    {
                        if (aT == "") aT = rst.Fields["aType"].Value;
                        else if (aB == 0.0) aB = rst.Fields["aBallance"].Value;
                        else if (aCL == 0.0) aCL = rst.Fields["aCreditLimit"].Value;
                        else if (aBN == 0) aBN = rst.Fields["aBranchNo"].Value;
                        rst.MoveNext();
                    }
                    rst.Close();
                    sql = "UPDATE AccountInfo SET aType='" + aT + "', aBallance=" + aB + ", aCreditLimit=" + aCL + ", aBranchNo=" + aBN + " WHERE aID=" + aID + ";";
                    break;
            }
            rst.Open(sql, con);
            con.Close();
            clearA();
            displayAccountTab();
        }

        public void displayAccountTab()
        {
            lbxAID.Items.Clear();
            lbxAType.Items.Clear();
            lbxBallance.Items.Clear();
            lbxCL.Items.Clear();
            lbxBranchNo.Items.Clear();

            con.Open(conStr);
            sql = "SELECT * FROM AccountInfo WHERE aClientID='"+ user +"' ORDER BY aID;";
            rst.Open(sql, con);

            while (!rst.EOF)
            {
                userName=rst.Fields["aClientName"].Value;
                lblClientName.Text = userName;
                lbxAID.Items.Add(rst.Fields["aID"].Value);
                lbxAType.Items.Add(rst.Fields["aType"].Value);
                lbxBallance.Items.Add(rst.Fields["aBallance"].Value);
                if (rst.Fields["aCreditLimit"].Value == 0) lbxCL.Items.Add("-NA-");
                else lbxCL.Items.Add(rst.Fields["aCreditLimit"].Value);
                lbxBranchNo.Items.Add(rst.Fields["aBranchNo"].Value);
                rst.MoveNext();
            }
            con.Close();
            hideA();//hides account textboxes
        }
        public void hideA()
        {
            label13.Visible = false;
            tbxAID.Visible = false;
            label12.Visible = false;
            cbxAType.Visible = false;
            label11.Visible = false;
            tbxABallance.Visible = false;
            label10.Visible = false;
            tbxACreditLimit.Visible = false;
            label9.Visible = false;
            tbxABranchNo.Visible = false;
            btnSubmit.Visible = false;
            btnCancelA.Visible = false;
        }
        private void btnCancelA_Click(object sender, EventArgs e)
        {
            hideA();//hides account textboxes
            clearA();
        }
        public void clearA()
        {
            tbxAID.Clear();
            cbxAType.SelectedIndex = -1;
            tbxABallance.Text = "0.0";
            tbxACreditLimit.Text = "0.0";
            tbxABranchNo.Text="0";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearA();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void displayTransactionsTab()
        {
            lblClientNameTrans.Text = user.ToString();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == TabLogin.Name)//TabLogin selected
            {
                tabControl1.TabPages.Remove(tabAccount); //hides tabAccount
                tabControl1.TabPages.Remove(tabTransactions);
                user = ""; //logs out the user :p
                tbxCID.Clear();
                tbxPass.Clear();
            }
            if (e.TabPage.Name == tabAccount.Name)//tabAccount selected
            {
                displayAccountTab();
            }
            if (e.TabPage.Name == tabTransactions.Name)//tabTransactions selected
            {
                displayTransactionsTab();
            }

        }








    }
}
