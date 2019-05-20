using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public partial class USERADMINLOGS : Form
{
    clsDrag d = new clsDrag();
    public USERADMINLOGS()
    {
        InitializeComponent();
        btnclose.Click += Btnclose_Click;
        Load += USERADMINLOGS_Load;
    }

    private void USERADMINLOGS_Load(object sender, EventArgs e)
    {
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
        hideall();
        loadlogs();
        Refresh();
    }

    private void Btnclose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    void loadlogs()
    {
        string _sql = @"SELECT [ACCOUNTID]
      ,[NAME]
      ,[USERTYPE]
      ,[INTIME]
      ,[LOGOUTTIME]
      ,[DATEIN] FROM [dbo].[USERADMINLOGS]";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, dt);
    }
    void loadlogs1()
    {
        string _sql = @"SELECT [ACCOUNTID]
      ,[NAME]
      ,[USERTYPE]
      ,[INTIME]
      ,[LOGOUTTIME]
      ,[DATEIN] FROM [dbo].[USERADMINLOGS] WHERE [NAME]  = '" + txtuser.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }

    public void _LoadNAME()
    {
        string _sql = @"SELECT [Idno] as [ID NO.],
                        [Referenceno] AS [REF NO.],
                        ([Fname]+' '+[Mname]+' '+[Lname]) AS [NAME],
                        [Address] AS[ADDRESS],
                        [Bdate] AS[BIRTHDATE],
                        [Age] AS[AGE],
                        [Gender] as [GENDER],
                        [Contactno] AS[CONTACT NO],
                        [Category] AS[CATEGORY],
                        [Date]AS[DATE REGSTR]
                        FROM[dbo].[CINFO] WHERE [Fname]+' '+[Mname]+' '+[Lname] = '" + txtcomsearch.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    public void _LoadNAME1()
    {
        string _sql = @"SELECT [Idno] as [ID NO.],
                        [Referenceno] AS [REF NO.],
                        ([Fname]+' '+[Mname]+' '+[Lname]) AS [NAME],
                        [Address] AS[ADDRESS],
                        [Bdate] AS[BIRTHDATE],
                        [Age] AS[AGE],
                        [Gender] as [GENDER],
                        [Contactno] AS[CONTACT NO],
                        [Category] AS[CATEGORY],
                        [Date]AS[DATE REGSTR]
                        FROM[dbo].[CINFO]  ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    public static AutoCompleteStringCollection LoadAutoComplete(DataTable _table, int num)
    {
        DataTable dt = _table;
        AutoCompleteStringCollection stringcol = new AutoCompleteStringCollection();
        foreach (DataRow row in dt.Rows)
        {
            stringcol.Add(Convert.ToString(row[num]));
        }
        return stringcol;
    }
    void autocompleteuserlogs()
    {
        string _sqlname = "";

          _sqlname = @"SELECT [NAME] FROM USERADMINLOGS";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlname);
        txtuser.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtuser.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtuser.AutoCompleteSource = AutoCompleteSource.CustomSource;
        txtuser.Focus();
    }
    void autocompletecommuterslogs()
    {
        string _sqlname = "";

        _sqlname = @"SELECT (A.Fname+' '+A.Mname+' '+A.Lname) as [NAME] FROM CINFO A";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlname);
        txtcomsearch.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtcomsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtcomsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        txtcomsearch.Focus();
    }
    public void category()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT CATEGORY,REGFARE FROM DSCNT ";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbsearchmanifest.DataSource = ds.Tables[0];
        cmbsearchmanifest.DisplayMember = "CATEGORY";
        cmbsearchmanifest.ValueMember = "REGFARE";
    }
    public void Captain()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT (FIRSTNAME+' '+MIDDLENAME+' '+LASTNAME) AS CAP FROM OFFICER ";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbsearchmanifest.DataSource = ds.Tables[0];
        cmbsearchmanifest.DisplayMember = "CAP";
        cmbsearchmanifest.ValueMember = "CAP";
    }
    public void ferry()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT FERRYNAME FROM FSETUP ";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbsearchmanifest.DataSource = ds.Tables[0];
        cmbsearchmanifest.DisplayMember = "FERRYNAME";
        cmbsearchmanifest.ValueMember = "FERRYNAME";
    }

 
    private void btnclose_Click_1(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }
    private void txtsearchaction_TextChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked == true)
        {
            if (txtuser.Text != "")
            {
                loadlogs1();
            }
            else if (txtuser.Text == "")
            {
                loadlogs();
            }
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        user();
        autocompleteuserlogs();
        radioButton2.Checked = false;
        radioButton3.Checked = false;
        txtuser.Focus();
        loadlogs();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        com();
        autocompletecommuterslogs();
        radioButton1.Checked = false;
        radioButton3.Checked = false;
        txtuser.Focus();
        _LoadNAME1();
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        manifest();
        radioButton1.Checked = false;
        radioButton2.Checked = false;
        txtuser.Focus();
        MANIFEST();
    }

    void user()
    {
        txtcomsearch.Hide() ;
        lblcom.Hide();
        lblmanifest.Hide();
        cmbfilter.Hide();
        lblfrom.Hide();
        lblto.Hide();
        dtpfrom.Hide();
        dtpto.Hide();
        cmbsearchmanifest.Hide();
        txtuser.Show();
        lbluser.Show();
        button1.Hide();
    }

    void com()
    {
        txtcomsearch.Show();
        lblcom.Show();
        lblmanifest.Hide();
        cmbfilter.Hide();
        lblfrom.Hide();
        lblto.Hide();
        dtpfrom.Hide();
        dtpto.Hide();
        cmbsearchmanifest.Hide();
        txtuser.Hide();
        lbluser.Hide();
        button1.Hide();
    }

    void manifest()
    {
        txtcomsearch.Hide();
        lblcom.Hide();
        lblmanifest.Show();
        cmbfilter.Show();
        lblfrom.Hide();
        lblto.Hide();
        dtpfrom.Hide();
        dtpto.Hide();
        cmbsearchmanifest.Hide();
        txtuser.Hide();
        lbluser.Hide();
      
    }
    void hideall()
    {
        txtcomsearch.Hide();
        lblcom.Hide();
        lblmanifest.Hide();
        cmbfilter.Hide();
        lblfrom.Hide();
        lblto.Hide();
        dtpfrom.Hide();
        dtpto.Hide();
        cmbsearchmanifest.Hide();
        txtuser.Hide();
        lbluser.Hide();
        button1.Hide();
    }
    private void txtcomsearch_TextChanged(object sender, EventArgs e)
    {
        if (radioButton2.Checked == true)
        {
            if (txtcomsearch.Text != "")
            {
                _LoadNAME();
            }
            else if (txtcomsearch.Text == "")
            {
                _LoadNAME1();
            }
        }
    }
     void filter()
    {
        if (cmbfilter.Text == "DATE")
        {
            lblfrom.Show();
            lblto.Show();
            dtpfrom.Show();
            dtpto.Show();
            cmbsearchmanifest.Hide();
            button1.Show();
            
        }
        else
        {
            button1.Hide();
            lblfrom.Hide();
            lblto.Hide();
            dtpfrom.Hide();
            dtpto.Hide();
            cmbsearchmanifest.Show();
            if (cmbfilter.Text == "CAPTAIN")
            {
                Captain();
                CAPTAINSEARCH();
            }
            else if (cmbfilter.Text == "FERRY")
            {
                ferry();
                FERRYSEARCH();
            }
            else if(cmbfilter.Text =="CATEGORY")
            {
                category();
                CATEGORYSEARCH();
            }
        }
    }
    private void cmbfilter_TextChanged(object sender, EventArgs e)
    {
        filter();
    }
    public void MANIFEST()
    {
        string _sql = @"SELECT [TRANSNO]
      ,[DATE]
      ,[IDNO]
      ,[CATEGORY]
      ,[FARE]
      ,[TIMEDEPART]
      ,[FERRY]
      ,[CAPTAIN]
      FROM [dbo].[COMLOGS] ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    public void DATESEACH()
    {
        string _sql = "";
      
            _sql = @"SELECT DISTINCT A.TRANSNO
      ,A.DATE
	  ,A.CAPTAIN
      ,A.FERRY
      ,(SELECT B.CAPACITY FROM FSETUP B WHERE B.FERRYNAME = A.FERRY) AS [CAPACITY]
	  , (SELECT COUNT(B.FERRY) FROM COMLOGS B WHERE B.TRANSNO = A.TRANSNO) AS COMMUTERS
      ,A.PORTFROM 
      ,A.PORTTO
      ,A.TIMEDEPART
      FROM COMLOGS A  WHERE A.DATE BETWEEN  '" + DateTime.Parse(dtpfrom.Value.ToShortDateString()) + "' and '" + DateTime.Parse(dtpto.Value.ToShortDateString()) + "' GROUP BY A.IDNO , A.TRANSNO , A.DATE, A.CAPTAIN, A.FERRY,A.PORTFROM,A.PORTTO , A.TIMEDEPART ";
     
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    public void CATEGORYSEARCH()
    {
        string _sql = @"SELECT [TRANSNO]
      ,[DATE]
      ,[IDNO]
      ,[CATEGORY]
      ,[FARE]
      ,[TIMEDEPART]
      ,[FERRY]
      ,[CAPTAIN]
      FROM [dbo].[COMLOGS] WHERE CATEGORY ='"+cmbsearchmanifest.Text+"' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }

    public void FERRYSEARCH()
    {
        string _sql = @"SELECT [TRANSNO]
      ,[DATE]
      ,[IDNO]
      ,[CATEGORY]
      ,[FARE]
      ,[TIMEDEPART]
      ,[FERRY]
      ,[CAPTAIN]
      FROM [dbo].[COMLOGS] WHERE FERRY ='" + cmbsearchmanifest.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }


    public void CAPTAINSEARCH()
    {
        string _sql = @"SELECT [TRANSNO]
      ,[DATE]
      ,[IDNO]
      ,[CATEGORY]
      ,[FARE]
      ,[TIMEDEPART]
      ,[FERRY]
      ,[CAPTAIN]
      FROM [dbo].[COMLOGS] WHERE CAPTAIN ='" + cmbsearchmanifest.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }

    private void vIEWREPORTToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (radioButton3.Checked == true && cmbfilter.Text == "DATE")
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                MANIFEST_REPRINT.transno = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                MANIFEST_REPRINT.date = DateTime.Parse( dataGridView1.SelectedRows[i].Cells[1].Value.ToString());
                MANIFEST_REPRINT.captain = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                MANIFEST_REPRINT.capacity = dataGridView1.SelectedRows[i].Cells[4].Value.ToString();
                MANIFEST_REPRINT.arrival = DateTime.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                MANIFEST_REPRINT.dept = DateTime.Parse( dataGridView1.SelectedRows[i].Cells[8].Value.ToString());
                MANIFEST_REPRINT.ferryname = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();
                MANIFEST_REPRINT.portfrom = dataGridView1.SelectedRows[i].Cells[6].Value.ToString();
                MANIFEST_REPRINT.portto = dataGridView1.SelectedRows[i].Cells[7].Value.ToString();

                MANIFEST_REPRINT m = new MANIFEST_REPRINT();
                m.ShowDialog();
            }
        }
        else
        {
            MessageBox.Show("YOU MUST USE THE VIEWER ONLY IN MANIFEST VIEWS");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DATESEACH();
    }
}
