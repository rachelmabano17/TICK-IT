using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class SALES : Form
{
    clsDrag d = new clsDrag();
    MAIN_FROM main = new MAIN_FROM();
    public SALES()
    {
        InitializeComponent();
        Load += SALES_Load;
        btnclose.Click += Btnclose_Click;
        panel1.MouseMove += Panel1_MouseMove;
        panel1.MouseDown += Panel1_MouseDown;

     
        // btnexcel.Click += Btnexcel_Click;
    }

    private void Btnexcel_Click(object sender, EventArgs e)
    {
        //  ExportToExcel();
    }

    void loadsales()
    {
        string _sql = @"SELECT s.[Dates]
       ,(C.Fname+' '+C.Mname+' '+C.Lname)AS [Commuters Name]
      ,FORMAT(s.Amount,'#,0.00') as [Amount]
      ,c.Category
  FROM SALES s inner join CINFO c on s.Idno = c.Idno ORDER BY s.Dates ASC ";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, dt);
    }
    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void Btnclose_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void SALES_Load(object sender, EventArgs e)
    {
        USER();
        string user = @"SELECT NAME FROM USERLOGIN  WHERE ACCOUNTID = '"+GET_CARD.username+"'";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection,user);
        string username = clsSQLClientFunctions.GetData(DT,"NAME","0");
        comboBox2.Text = username.ToString();
        if (username == "ADMINISTRATOR")
        {
            comboBox2.Enabled = true;
        }
        else
        {
            comboBox2.Enabled = false;
        }
     
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
        category();

      
    }
    public void category()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT X.CATEGORY AS [CAT] FROM (SELECT CATEGORY AS [CATEGORY] FROM DSCNT
UNION ALL
SELECT DISTINCT 'ALL' AS [CATEGORY] FROM DSCNT) X ";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        comboBox1.DataSource = ds.Tables[0];
        comboBox1.DisplayMember = "CAT";
        comboBox1.ValueMember = "CAT";
    }
    public void USER()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT NAME FROM USERLOGIN";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        comboBox2.DataSource = ds.Tables[0];
        comboBox2.DisplayMember = "NAME";
        comboBox2.ValueMember = "NAME";
    }
    bool gettotalincome()
    {
        string _sql = "";
        bool total = false;
        string datepick1 = "MM/dd/yyyy";
        if (comboBox2.Text == "ALL")
        {
             _sql = @"SELECT FORMAT(SUM(s.Amount), '#,0.00') AS[TOTALINCOME] FROM SALES s inner join CINFO c on s.Idno = c.Idno WHERE s.Dates BETWEEN '" + dateTimePicker1.Value.ToString(datepick1) + "' AND '" + dateTimePicker2.Value.ToString(datepick1) + "' ";
        }
        else
        {
             _sql = @"SELECT FORMAT(SUM(s.Amount), '#,0.00') AS[TOTALINCOME] FROM SALES s inner join CINFO c on s.Idno = c.Idno WHERE s.Dates BETWEEN '" + dateTimePicker1.Value.ToString(datepick1) + "' AND '" + dateTimePicker2.Value.ToString(datepick1) + "' AND c.Category like '%" + comboBox1.Text + "%'";
        }
            DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in dt.Rows)
        {

            lblincome.Text = row["TOTALINCOME"].ToString();
            if (lblincome.Text == "")
            {
                lblincome.Text = "00.00";
            }
            total = true;
        }
        return total;

    }
   

    private void button1_Click(object sender, EventArgs e)
    {
        double total = 0;
      
        string _sql = "";
        if (comboBox2.Text == "ADMINISTRATOR")
        {
            if (comboBox1.Text == "ALL")
            {

                _sql = @"SELECT s.[Dates]
          ,(C.Fname+' '+C.Mname+' '+C.Lname)AS [Commuters Name]
          ,FORMAT(s.Amount,'#,0.00') as [Amount]
          ,s.Des as [Description]
          ,c.Category
          ,(select a.name from userlogin a where a.ACCOUNTID=S.Userlog) as [User Name]
           FROM SALES s inner join CINFO c on s.Idno = c.Idno where  s.dates between '" + DateTime.Parse(dateTimePicker1.Value.ToShortDateString()) + "' AND '" + DateTime.Parse(dateTimePicker2.Value.ToShortDateString()) + "' ORDER BY s.Dates ASC ";
            }
            else
            {
                _sql = @"SELECT s.[Dates]
          ,(C.Fname+' '+C.Mname+' '+C.Lname)AS [Commuters Name]
          ,FORMAT(s.Amount,'#,0.00') as [Amount]
           ,s.Des as [Description]
          ,c.Category
          ,(select a.name from userlogin a where a.ACCOUNTID=S.Userlog) as [User Name]
           FROM SALES s inner join CINFO c on s.Idno = c.Idno where  s.dates between '" + DateTime.Parse(dateTimePicker1.Value.ToShortDateString()) + "' AND '" + DateTime.Parse(dateTimePicker2.Value.ToShortDateString()) + "'  AND C.Category like '%" + comboBox1.Text + "%' ORDER BY s.Dates ASC ";
            }
        }
        else
        {
            if (comboBox1.Text == "ALL")
            {
                _sql = @"SELECT s.[Dates]
        ,(C.Fname+' '+C.Mname+' '+C.Lname)AS [Commuters Name]
        ,FORMAT(s.Amount,'#,0.00') as [Amount]
        ,s.Des as [Description]
        ,c.Category
        FROM SALES s inner join CINFO c on s.Idno = c.Idno where  s.[Userlog] = (select u.ACCOUNTID from USERLOGIN u where u.NAME ='" + comboBox2.Text + "') and " +
            " s.dates between '" + DateTime.Parse(dateTimePicker1.Value.ToShortDateString()) + "' AND '" + DateTime.Parse(dateTimePicker2.Value.ToShortDateString()) + "'  ORDER BY s.Dates ASC ";
            }
            else
            {
                _sql = @"SELECT s.[Dates]
        ,(C.Fname+' '+C.Mname+' '+C.Lname)AS [Commuters Name]
        ,FORMAT(s.Amount,'#,0.00') as [Amount],
        s.Des as [Description]
        ,c.Category
        FROM SALES s inner join CINFO c on s.Idno = c.Idno where  s.[Userlog] = (select u.ACCOUNTID from USERLOGIN u where u.NAME ='" + comboBox2.Text + "') and " +
            " s.dates between '" + DateTime.Parse(dateTimePicker1.Value.ToShortDateString()) + "' AND '" + DateTime.Parse(dateTimePicker2.Value.ToShortDateString()) + "' AND C.Category like '%" + comboBox1.Text + "%'  ORDER BY s.Dates ASC ";
            }
       }
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, dt);

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
        
            total += double.Parse(row.Cells[2].Value.ToString());
        }
        lblincome.Text = total.ToString("N2");


    }

    private void btnprint_Click(object sender, EventArgs e)
    {
        if (dataGridView1.Rows.Count > 0)
        {
            REPORTCLASS s = new REPORTCLASS();
            s.showsales(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),comboBox2.Text,dataGridView1);
        }
        else
        {
            MessageBox.Show("NO RECORDS TO PRINT!");
        }
    }
}
