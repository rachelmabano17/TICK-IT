using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Configuration;


public partial class LOGIN_FORM : Form
{

    clsDrag d = new clsDrag();
    string accountid;
    string name;
    string usertype;
    public LOGIN_FORM()
    {
        InitializeComponent();
        Load += LOGIN_FORM_Load;
        clsDeclaration.sSAPServerName = ConfigurationManager.AppSettings["oServer"];
        clsDeclaration.sSAPDatabaseName = ConfigurationManager.AppSettings["oCompanyDB"];
        clsDeclaration.sSAPUsername = ConfigurationManager.AppSettings["oDbUserName"];
        clsDeclaration.sSAPPassword = ConfigurationManager.AppSettings["oDbPassword"];
        btnexit.Click += Btnexit_Click;
    }

    private void Btnexit_Click(object sender, EventArgs e)
    {
        DialogResult r = MessageBox.Show("Are you sure you don't want to log-in.?","NOTICE",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        if (r== DialogResult.Yes)
        {
            Application.ExitThread();
        }
        else
        {
            txtuser.Text = null;
            txtpass.Text = null;
            txtuser.Focus();
        }
    }

    private void LOGIN_FORM_Load(object sender, EventArgs e)
    {
        string sysDBServer = ConfigurationManager.AppSettings["oServer"];
        string sysDftDBCompany = ConfigurationManager.AppSettings["oCompanyDB"];
        string sysDBUsername = ConfigurationManager.AppSettings["oDbUserName"];
        string sysDBPassword = ConfigurationManager.AppSettings["oDbPassword"];

        clsDeclaration.sLclSystemConnection = clsSQLClientFunctions.GlobalConnectionString(sysDBServer, sysDftDBCompany, sysDBUsername, sysDBPassword);
        if (clsSQLClientFunctions.CheckConnection(clsDeclaration.sLclSystemConnection) == false)
        {
            SETTINGS set = new SETTINGS();
            set.ShowDialog();
        }
    }

    bool userlogin()
    {
        bool login = false; 
        string _sql = @"SELECT [ACCOUNTID],[NAME],
                        [USERTYPE] 
                        FROM [USERLOGIN] WHERE [USERNAME] = '" + txtuser.Text + "' AND [PASSWORDS]='" + txtpass.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in DT.Rows)
        {
            accountid = row["ACCOUNTID"].ToString();
            name = row["NAME"].ToString();
            usertype = row["USERTYPE"].ToString();
            login = true;
        }
        return login;
    }
    

    void savetologs()
    {
        DateTime times = DateTime.Now;
        string format = "HH:mm:ss";
        DateTime dates = DateTime.Now;
        string formatdate = "MM/dd/yyyy";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO USERADMINLOGS([ACCOUNTID],[NAME],[USERTYPE],[INTIME],[LOGOUTTIME],[DATEIN]) VALUES('" + accountid + "','" + name + "','" + usertype + "','" + times.ToString(format) + "','" + "00:00:00" + "','"+ dates.ToString(formatdate) + "')");
    }


    void SaveLogin()
    {
        MAIN_FROM main = new MAIN_FROM();
        if (userlogin() == false)
        {
            MessageBox.Show("Incorrect username or password!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtpass.Clear();
            txtuser.Focus();
        }
        else
        {
            if (usertype == "ADMINISTRATOR")
            {
                main.lblusertype.Text = usertype;
                main.toolStripAccountid.Text = accountid;
                main.toolStripName.Text = name;
                main.mANIFESTToolStripMenuItem1.Visible = false;
                main.cashierToolStripMenuItem.Visible = false;
                main.Show();
                savetologs();
            }
            else if (usertype == "CASHIER")
            {
                main.lblusertype.Text = usertype;
                main.toolStripAccountid.Text = accountid;
                main.toolStripName.Text = name;
                main.mANIFESTToolStripMenuItem1.Visible = false;
                main.rEGISTRATIONToolStripMenuItem1.Text = "RESET ACCOUNT";
                main.sETTINGSToolStripMenuItem.Visible = false;
                main.dASHBOARDToolStripMenuItem.Visible = false;
                main.Show();
                savetologs();
            }
            else if (usertype == "STAFF")
            {
                main.dASHBOARDToolStripMenuItem.Visible = false;
                main.lblusertype.Text = usertype;
                main.toolStripAccountid.Text = accountid;
                main.toolStripName.Text = name;
                main.cashierToolStripMenuItem.Visible = false;
                main.rEGISTRATIONToolStripMenuItem1.Text = "RESET ACCOUNT";
                main.sETTINGSToolStripMenuItem.Visible = false;
                main.sALESRECORDToolStripMenuItem.Visible = false;
                main.Show();
                savetologs();
                userlogin();
            }
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
            this.Hide();
        }
    }
    private void btnlogin_Click(object sender, EventArgs e)
    {
        SaveLogin();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void txtuser_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode==Keys.Enter)
        {
            if (String.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Please enter username.","NOTICE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtuser.Focus();
            }
            else
            {
                txtpass.Focus();
            }
        }
    }

    private void txtpass_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (String.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Please enter password.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Focus();
            }
            else
            {
                btnlogin.PerformClick();
            }
        }
    }

    private void label3_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType() == typeof(CTU_BARCODE_READER.MODULE.FORGOTPASS))
            {
                form.Activate();
                return;
            }
        }
        CTU_BARCODE_READER.MODULE.FORGOTPASS SS = new CTU_BARCODE_READER.MODULE.FORGOTPASS();
        SS.Show();
        SS.BringToFront();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType() == typeof(SETTINGS))
            {
                form.Activate();
                return;
            }
        }
        SETTINGS SS = new SETTINGS();
        SS.Show();
        SS.BringToFront();
    }
}

