using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

public partial class MAIN_FROM : Form
{

    Timer animatedblink = new Timer();

    public MAIN_FROM()
    {
        InitializeComponent();

        clsDeclaration.sSAPServerName = ConfigurationManager.AppSettings["oServer"];
        clsDeclaration.sSAPDatabaseName = ConfigurationManager.AppSettings["oCompanyDB"];
        clsDeclaration.sSAPUsername = ConfigurationManager.AppSettings["oDbUserName"];
        clsDeclaration.sSAPPassword = ConfigurationManager.AppSettings["oDbPassword"];

        animatedblink.Tick += new EventHandler(animatedblink_Tick);
        cashierToolStripMenuItem.Click += CashierToolStripMenuItem_Click;
    }

    private void CashierToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CASHIER _cashier = new CASHIER();
        _cashier.MdiParent = this;
        _cashier.statusStrip2.Visible = false;
        _cashier.Show();
        _cashier.BringToFront();
    }

    private void MAIN_FROM_Load(object sender, EventArgs e)
    {
        
        GET_CARD.username = toolStripAccountid.Text;
        //MdiClient ctlmdi;
        foreach (Control ctrl in this.Controls)
        {
            if (ctrl is MdiClient)
            {
                ctrl.BackColor=Color.White;
                break;
            }
            /*try
            {
                ctlmdi = (MdiClient)ctrl;
                ctlmdi.BackColor = System.Drawing.SystemColors.Control;
                ctlmdi.BackgroundImage = 
                
            }
            catch (InvalidCastException ex)
            {

                //throw ex;
            }*/
        }
        animatedblink.Start();
        //string sysDBServer = ConfigurationManager.AppSettings["oServer"];
        //string sysDftDBCompany = ConfigurationManager.AppSettings["oCompanyDB"];
        //string sysDBUsername = ConfigurationManager.AppSettings["oDbUserName"];
        //string sysDBPassword = ConfigurationManager.AppSettings["oDbPassword"];

        //clsDeclaration.sLclSystemConnection = clsSQLClientFunctions.GlobalConnectionString(sysDBServer, sysDftDBCompany, sysDBUsername, sysDBPassword);
        //if (clsSQLClientFunctions.CheckConnection(clsDeclaration.sLclSystemConnection) == false)
        //{
        //    SETTINGS set = new SETTINGS();
        //    set.ShowDialog();
        //}

       
    }

    private void sETUPToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType() == typeof(FOR_SET_UP))
            {
                form.Activate();
                return;
            }
        }
        FOR_SET_UP SS = new FOR_SET_UP();
        SS.ShowDialog();
    }

    private void cONFIGURATIONToolStripMenuItem_Click(object sender, EventArgs e)
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
        SS.ShowDialog();
    }


    void animatedblink_Tick(object sender, EventArgs e)
    {
        lbldate.Text = DateTime.Now.ToLongDateString();
        txttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }
    


    private void mANIFESTToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType() == typeof(MANIFEST))
            {
                form.Activate();
                return;
            }
        }
        MANIFEST SS = new MANIFEST();
        SS.MdiParent = this;
        SS.Show();
        SS.BringToFront();
    }


    private void rEGISTRATIONToolStripMenuItem1_Click(object sender, EventArgs e)
    {
     
        if (toolStripName.Text == "ADMINISTRATOR")
        {
            REGISTRATION_FORM.user = toolStripName.Text;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(REGISTRATION_FORM))
                {
                    form.Activate();
                    return;
                }
            }
            REGISTRATION_FORM SS = new REGISTRATION_FORM();
            SS.MdiParent = this;

            SS.Show();
            SS.BringToFront();
        }
        else
        {
            RESET.user = toolStripAccountid.Text;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RESET))
                {
                    form.Activate();
                    return;
                }
            }
            RESET SS = new RESET();
            SS.MdiParent = this;
            SS.Show();
            SS.BringToFront();
        }

    }


    private void lOGSToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType() == typeof(USERADMINLOGS))
            {
                form.Activate();
                return;
            }
        }
        USERADMINLOGS SS = new USERADMINLOGS();
        SS.MdiParent = this;
        SS.Show();
        SS.BringToFront();
    }

    void logout()
    {
        DateTime times = DateTime.Now;
        string format = "HH:mm:ss";
        DateTime dates = DateTime.Now;
        string formatdate = "MM/dd/yyyy";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "UPDATE USERADMINLOGS SET [LOGOUTTIME]='" + times.ToString(format) + "' WHERE [ACCOUNTID]='"+toolStripAccountid.Text+"' AND [DATEIN]='"+ dates.ToString(formatdate) + "'");
    }


    private void sALESRECORDToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            if (form.GetType()==typeof(SALES))
            {
                form.Activate();
                return;
            }
        }
        SALES s = new SALES();
        s.MdiParent = this;
        s.Show();
    }

    private void btnlogout_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            logout();
            LOGIN_FORM main = (LOGIN_FORM)Application.OpenForms["LOGIN_FORM"];
            main.Visible = true;
            this.Dispose();
        }
    }

    private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}

