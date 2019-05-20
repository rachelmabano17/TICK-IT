using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



public partial class RESET : Form
{
    public static string user = "";
    public RESET()
    {
        InitializeComponent();
    }

    private void dtpbdate_ValueChanged(object sender, EventArgs e)
    {
        txtage.Text = Convert.ToString(DateTime.Now.Year - dtpbdate.Value.Year);
    }
   
    private void RESET_Load(object sender, EventArgs e)
    {
        lblaccountid.Text = RESET.user;
        cmbusertype.Items.Add("CASHIER");
        cmbusertype.Items.Add("STAFF");
    }

    private void lblaccountid_TextChanged(object sender, EventArgs e)
    {
        if(lblaccountid.Text != "0000000000")
        {
            string user = @"SELECT 
                           [FIRSTNAME]
                          ,[MIDDLENAME]
                          ,[LASTNAME]
                          ,[AGE]
                          ,[BIRTHDATE]
                          ,[ADDRESS]
                          ,[USERNAME]
                          ,[PASSWORDS]
                          ,[USERTYPE]
                      FROM [dbo].[REGISTRATION] WHERE ACCOUNTID = '"+RESET.user+"'";
            DataTable DT = new DataTable();
            DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection,user);
            foreach (DataRow row in DT.Rows)
            {
                txtfname.Text = row["FIRSTNAME"].ToString();
                txtmname.Text = row["MIDDLENAME"].ToString();
                txtlname.Text = row["LASTNAME"].ToString();
                txtaddress.Text = row["ADDRESS"].ToString();
                txtage.Text = row["AGE"].ToString();
                dtpbdate.Text = row["BIRTHDATE"].ToString();
                cmbusertype.Text = row["USERTYPE"].ToString();
            }
        }
        else
        {
            MessageBox.Show("Please click it smoothly!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnsave_Click(object sender, EventArgs e)
    {
        string _sql = @"SELECT [PASSWORDS]
                        FROM [REGISTRATION] WHERE [ACCOUNTID] = '" + lblaccountid.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        string pass = clsSQLClientFunctions.GetData(DT, "PASSWORDS", "0");
        if (pass != txtoldpass.Text)
        {
            MessageBox.Show("Old Password did not match", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtnewpass.Text != txtretypepass.Text)
        {
            MessageBox.Show("Password did not match", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            if (lblaccountid.Text != "0000000000")
            {
                DialogResult R = MessageBox.Show("Reset your password ?", "RESET CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == R)
                {
                    string del = "UPDATE [dbo].[REGISTRATION] SET [PASSWORDS] ='" + txtretypepass.Text + "' WHERE ACCOUNTID = '" + lblaccountid.Text + "'";
                    string del2 = "UPDATE [dbo].[USERLOGIN] SET [PASSWORDS] = '" + txtretypepass.Text + "' WHERE ACCOUNTID = '" + lblaccountid.Text + "'";
                    clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del);
                    clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del2);

                    MessageBox.Show("Reset Successfully!");

                    txtaddress.Text = txtage.Text = txtfname.Text = txtlname.Text = txtmname.Text = txtnewpass.Text = txtoldpass.Text = txtretypepass.Text = null;
                    cmbusertype.Text = null;
                }
            }
            else
            {
                MessageBox.Show("EMPTY FIELDS!");
            }
        }
    }

    private void btnclose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnclear_Click(object sender, EventArgs e)
    {
        txtaddress.Text = txtage.Text = txtfname.Text = txtlname.Text = txtmname.Text = txtnewpass.Text = txtoldpass.Text = txtretypepass.Text = null;
        cmbusertype.Text = null;
    }
}

