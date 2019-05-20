using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

public partial class SETTINGS : Form
{
    public SETTINGS()
    {
        InitializeComponent();

        txtServeripaddress.Text = ConfigurationManager.AppSettings["oServer"];
        txtdbname.Text = ConfigurationManager.AppSettings["oCompanyDB"];
        txtdbusername.Text = ConfigurationManager.AppSettings["oDbUserName"];
        txtdbpassword.Text = ConfigurationManager.AppSettings["oDbPassword"];

    }
    private void SETTINGS_Load(object sender, EventArgs e)
    {

    }


    private void button1_Click_1(object sender, EventArgs e)
    {

        clsFunctions.SetSetting("oServer", txtServeripaddress.Text);
        clsFunctions.SetSetting("oCompanyDB", txtdbname.Text);
        clsFunctions.SetSetting("oDbUserName", txtdbusername.Text);
        clsFunctions.SetSetting("oDbPassword", txtdbpassword.Text);


        MessageBox.Show("New Settings Applied!", "Connection Settings", MessageBoxButtons.OK, MessageBoxIcon.None);
        Application.Restart();
    }
}

