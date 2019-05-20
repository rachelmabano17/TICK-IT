using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTU_BARCODE_READER.MODULE
{
    public partial class FORGOTPASS : Form
    {
        public FORGOTPASS()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORGOTPASS_Load(object sender, EventArgs e)
        {
            cmbusertype.Items.Add("CASHIER");
            cmbusertype.Items.Add("STAFF");
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }
        bool newpass()
        {
            bool pas = false;
            string user = @"SELECT 
                           [ACCOUNTID]
                          ,[USERNAME]
                          FROM [dbo].[REGISTRATION] WHERE  USERTYPE = '" + cmbusertype.Text + "' AND LASTNAME = '" + txtlname.Text + "' AND   FIRSTNAME = '" + txtfname.Text + "' AND MIDDLENAME  = '" + txtmname.Text + "'";
            DataTable DT = new DataTable();
            DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, user);
            foreach (DataRow row in DT.Rows)
            {
                lblaccountid.Text = row["ACCOUNTID"].ToString();
                lblusername.Text = row["USERNAME"].ToString();

                pas = true;
            }
            return pas;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtlname.Text != null && txtfname.Text != null && txtmname.Text != null && cmbusertype.Text != null)
            {
                if (newpass() == true)
                {
                    MessageBox.Show("Credential search success!");
                }
                else
                {
                    MessageBox.Show("Make sure in your Credential !");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are not Empty!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnewpasss.Text != null && txtretypepas.Text != null)
            {
                if (txtnewpasss.Text == txtretypepas.Text)
                {
                    DialogResult R = MessageBox.Show("Save your New password ?", "RESET CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == R)
                    {
                        string del = "UPDATE [dbo].[REGISTRATION] SET [PASSWORDS] ='" + txtretypepas.Text + "' WHERE ACCOUNTID = '" + lblaccountid.Text + "'";
                        string del2 = "UPDATE [dbo].[USERLOGIN] SET [PASSWORDS] = '" + txtretypepas.Text + "' WHERE ACCOUNTID = '" + lblaccountid.Text + "'";
                        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del);
                        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del2);

                        MessageBox.Show("New Password Successfully Save!");
                        txtfname.Text = txtlname.Text = txtmname.Text = txtnewpasss.Text = txtretypepas.Text = null;
                        lblaccountid.Text = lblusername.Text = "0000000000";
                        cmbusertype.Text = null;
                        txtfname.Focus();
                        LOGIN_FORM main = (LOGIN_FORM)Application.OpenForms["LOGIN_FORM"];
                        main.Visible = true;
                        this.Dispose();

                    }
                }
                else
                {
                    MessageBox.Show("Password did not match", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
