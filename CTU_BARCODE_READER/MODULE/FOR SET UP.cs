using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
public partial class FOR_SET_UP : Form
{
    clsDrag d = new clsDrag();
    public FOR_SET_UP()
    {
        InitializeComponent();
    }
    public void FERRY()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT FERRYNAME FROM FSETUP";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        comboBox1.DataSource = ds.Tables[0];
        comboBox1.DisplayMember = "FERRYNAME";
        comboBox1.ValueMember = "FERRYNAME";
    }
    void loadqr()
    {
        string _sqlsearchname = @"SELECT QRCODE as [code] , STATUS as [STATUS] FROM qrcode   ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);
        clsFunctions.DataGridViewSetup(dataGridView1, tablename);
    }
    //of = new OpenFileDialog();
    //of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    //        if (of.ShowDialog() == DialogResult.OK)
    //            pictureBox1.Load(of.FileName);
   
    void savecategory()
    {
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO [dbo].[DSCNT]([REGFARE],[CATEGORY],[PERDIS])VALUES('" + int.Parse(txtregfare.Text) + "','" + txtcategory.Text + "','" + int.Parse(txtdiscount.Text) + "') ");
        MessageBox.Show("SAVE SUCCESS!");
    }
    void updatecategory()
    {
        if (txtregfare.Text != null || txtcategory != null || txtdiscount.Text != null)
        {
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "UPDATE [DSCNT] SET [REGFARE] = '" + int.Parse(txtregfare.Text) + "',[PERDIS] ='" + int.Parse(txtdiscount.Text) + "' WHERE CATEGORY ='" + txtcategory.Text + "'");
            MessageBox.Show("SAVE SUCCESS!");
        }
        else
        {
            txtregfare.Focus();
        }
    }
    void updateferry()
    {
        if (txtcapacity.Text != null || txtportto.Text != null || txtportfrom.Text != null )
        {
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "UPDATE [FSETUP] SET [CAPACITY] = '" + int.Parse(txtcapacity.Text) + "',[PORTFROM] ='" + txtportfrom.Text+ "' , [PORTTO] = '"+txtportto.Text+"' WHERE FERRYNAME ='" + txtferryname.Text + "'");
            loadferry();
            MessageBox.Show("SAVE SUCCESS!");
        }
        else
        {
            txtcapacity.Focus();
        }
    }

    void deleteferry()
    {
        if (txtcapacity.Text != null || txtportto.Text != null || txtportfrom.Text != null)
        {
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "DELETE FSETUP WHERE FERRYNAME ='" + txtferryname.Text + "'");
            loadferry();
            MessageBox.Show("DELETE SUCCESS!");
        }
        else
        {
            txtcapacity.Focus();
        }
    }
    void loadcat()
    {
        string _sqlsearchname = @" SELECT 
           [REGFARE] AS [REGULAR FARE]
           ,[CATEGORY] AS [CATEGORY]
           ,[PERDIS] as [DISCOUNT] FROM [DSCNT]   ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);
        clsFunctions.DataGridViewSetup(dataGridView1, tablename);
    }
    void loadferry()
    {
        string _sqlsearchname = @"SELECT [FERRYNAME]
      ,[CAPACITY]
      ,[DATE]
      ,[PORTFROM]
      ,[PORTTO]
  FROM [dbo].[FSETUP]   ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);
        clsFunctions.DataGridViewSetup(dataGridView3, tablename);
    }
    private void button5_Click(object sender, EventArgs e)
    {
        if (txtdiscount.Text != null || txtcategory.Text != null || txtregfare.Text != null)
        {
            savecategory();
            loadcat();
            txtcategory.Text = txtdiscount.Text = null;
        }
    }

    private void FOR_SET_UP_Load(object sender, EventArgs e)
    {
        loadcat();
        FERRY();
        button10.Enabled = false;
        button2.Enabled = false;
        button4.Enabled = false;
        button1.Enabled = false;
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
        {
            txtregfare.Text = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            txtcategory.Text = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
            txtdiscount.Text = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();

            txtregfare.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        updatecategory();
        loadcat();
      
        button4.Enabled = true;
        button5.Enabled = false;
        txtcategory.Text = txtdiscount.Text = null;

    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
        {
            loadcat();
        }
        else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
        {
            loadferry();
        }
        else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
        {
            loadcaptain();
            FERRY();
        }
    }

    private void button8_Click(object sender, EventArgs e)
    {
        txtcategory.Text = txtdiscount.Text = txtregfare.Text = null;
        button4.Enabled = false;
        button5.Enabled = true;
        txtregfare.Enabled = true;
        txtregfare.Focus();
    }
    void saveferry()
    {
        string _sql = @"INSERT INTO [dbo].[FSETUP]
           ([FERRYNAME]
           ,[CAPACITY]
            ,DATE
           ,[PORTFROM]
           ,[PORTTO])
           VALUES('" + txtferryname.Text + "','" + int.Parse(txtcapacity.Text) + "','" + DateTime.Now.ToShortDateString() + "','"+txtportfrom.Text+"','"+txtportto.Text+"')";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, _sql);
        MessageBox.Show("SAVE SUCCESSFULLY!");
        loadferry();
    }

    private void button11_Click(object sender, EventArgs e)
    {
        saveferry();
    }
    void savecaptain()
    {
        string _sql = @"INSERT INTO [dbo].[OFFICER]
           ([FIRSTNAME]
           ,[MIDDLENAME]
           ,[LASTNAME]  
           ,[ADDRESS]
            ,[FERRY]
           ,[DATE])
        VALUES('" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtsurename.Text + "','"+txtaddres.Text+"','"+comboBox1.Text+"','" + DateTime.Now.ToShortDateString() + "')";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, _sql);
        MessageBox.Show("SAVE SUCCESSFULLY!");
        loadcaptain();
        txtfirstname.Text = txtmiddlename.Text = txtsurename.Text = txtaddres.Text = null;
    }
    void DELETEcaptain()
    {
        string _sql = @"DELETE OFFICER WHERE FIRSTNAME = '"+txtfirstname.Text+"'";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, _sql);
        MessageBox.Show("DELETE SUCCESSFULLY!");
        loadcaptain();
    }
    void loadcaptain()
    {
        string _sqlsearchname = @"SELECT [FIRSTNAME]
      ,[MIDDLENAME]
      ,[LASTNAME]
      ,[ADDRESS]
      ,[FERRY]
      ,[DATE]
  FROM [dbo].[OFFICER]   ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);
        clsFunctions.DataGridViewSetup(dataGridView4, tablename);
    }
    private void button12_Click(object sender, EventArgs e)
    {
        if (txtfirstname.Text != null || txtmiddlename.Text != null || txtsurename.Text != null)
        {
            savecaptain();
        }
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void btnclose_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

   
    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {
        txtsurename.Text = txtfirstname.Text = txtmiddlename.Text = txtaddres.Text  = "";
    }

    private void button9_Click(object sender, EventArgs e)
    {
        txtferryname.Text = txtcapacity.Text = txtportfrom.Text = txtportto.Text = "";
        button10.Enabled = true;
        button11.Enabled = false;
        txtferryname.Enabled = true;
        txtferryname.Focus();
    }

    private void button10_Click(object sender, EventArgs e)
    {
        updateferry();
        txtferryname.Enabled = true;
        txtferryname.Focus();
        button10.Enabled = false;
        button11.Enabled = true;
        button2.Enabled = false;

        txtferryname.Text = txtcapacity.Text = txtportfrom.Text = txtportto.Text = "";
    }

    private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        for (int i = 0; i < dataGridView3.SelectedRows.Count; i++)
        {
            txtferryname.Text = dataGridView3.SelectedRows[i].Cells[0].Value.ToString();
            txtcapacity.Text = dataGridView3.SelectedRows[i].Cells[1].Value.ToString();
            txtportfrom.Text = dataGridView3.SelectedRows[i].Cells[3].Value.ToString();
            txtportto.Text = dataGridView3.SelectedRows[i].Cells[4].Value.ToString();

            txtferryname.Enabled = false;
            txtcapacity.Focus();
            button10.Enabled = true;
            button11.Enabled = false;
            button2.Enabled = true;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        deleteferry();
        txtferryname.Enabled = true;
        txtferryname.Focus();
        button10.Enabled = false;
        button11.Enabled = true;
        button2.Enabled = false;

        txtferryname.Text = txtcapacity.Text = txtportfrom.Text = txtportto.Text = "";
    }

    private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        for (int i = 0; i < dataGridView4.SelectedRows.Count; i++)
        {
            txtfirstname.Text = dataGridView4.SelectedRows[i].Cells[0].Value.ToString();
            txtmiddlename.Text = dataGridView4.SelectedRows[i].Cells[1].Value.ToString();
            txtsurename.Text = dataGridView4.SelectedRows[i].Cells[2].Value.ToString();
            txtaddres.Text = dataGridView4.SelectedRows[i].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView4.SelectedRows[i].Cells[4].Value.ToString();

            button1.Enabled = true;
            button12.Enabled = false;
         
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DELETEcaptain();
        button12.Enabled = true;
        button1.Enabled = false;
        txtfirstname.Text = txtmiddlename.Text = txtsurename.Text = txtaddres.Text = null;
    }
}

