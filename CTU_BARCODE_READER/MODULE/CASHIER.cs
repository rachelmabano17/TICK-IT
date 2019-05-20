using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class CASHIER : Form
{

    clsDrag d = new clsDrag();
    public static string name = "";
    public static string fname = "";
    public CASHIER()
    {
        InitializeComponent();

    }

    void saveLogs()
    {
        string refno = "";
        string id = "";
        string fullname = "";
        string address = "";
        string date="";
        string age = "";
        string cnumber = "";
        string cat = "";
        foreach (DataGridViewRow item in dataGridView1.Rows)
        {
            id = item.Cells[0].Value.ToString();
            refno = item.Cells[1].Value.ToString();
            fullname = item.Cells[2].Value.ToString();
            address = item.Cells[3].Value.ToString();
            date = item.Cells[4].Value.ToString();
            age = item.Cells[5].Value.ToString();
            cnumber = item.Cells[6].Value.ToString();
          
            cat = item.Cells[8].Value.ToString();

            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO [dbo].[COMMUTERDELTELOGS]([Idno],[Referenceno],[Fullname]," +
                "[Address],[Bdate],[Age],[Contactno],[Category],[remove_Date])VALUES('" + id.ToString() + "'," +
                "'" + refno + "','" + fullname + "','" + address + "'," +
                "'" + date + "','" + age + "','" + cnumber + "'," +
                "'" + cat + "','" + DateTime.Now.ToString() + "')");
        }
    }

    public void _LoadNAME()
    {
        string _sql = @"SELECT A.Idno as [ID NO.],
                        A.Referenceno AS [REF NO.],
                        (A.Fname+' '+A.Mname+' '+A.Lname) AS [NAME],
                        A.Address AS[ADDRESS],
                       A.Bdate AS[BIRTHDATE],
                        A.Age AS[AGE],
                        A.Gender as [GENDER],
                        A.Contactno AS[CONTACT NO],
                        A.Category AS[CATEGORY],
                        A.Date AS[DATE REGSTR]
                        FROM [CINFO] A  WHERE  (A.Fname+' '+A.Mname+' '+A.Lname)= '" + txtsearchaction.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    public void _Loadonly()
    {
        string _sql = @"SELECT A.Idno as [ID NO.],
                        A.Referenceno AS [REF NO.],
                        (A.Fname+' '+A.Mname+' '+A.Lname) AS [NAME],
                        A.Address AS[ADDRESS],
                       A.Bdate AS[BIRTHDATE],
                        A.Age AS[AGE],
                        A.Gender as [GENDER],
                        A.Contactno AS[CONTACT NO],
                        A.Category AS[CATEGORY],
                        A.Date AS[DATE REGSTR]
                        FROM [CINFO] A   ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    void _Loadrefno()
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
                        FROM[dbo].[CINFO] WHERE [Referenceno]  = '" + txtsearchaction.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    private void CASHIER_Load(object sender, EventArgs e)
    {

        string _sqlsearchname = @"SELECT (B.Fname +' '+B.Mname+' '+B.Lname) FROM CINFO B  ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);

        txtsearchaction.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtsearchaction.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtsearchaction.AutoCompleteSource = AutoCompleteSource.CustomSource;
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
        _Loadonly();
        Refresh();

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
    private void button2_Click(object sender, EventArgs e)
    {

        ADD_NEW_COMMUTER add = new ADD_NEW_COMMUTER();
        add.ShowDialog();

        if (add.DialogResult == DialogResult.OK)
        {
            txtsearchaction.Text = CASHIER.fname;
       
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
            GET_CARD GC = new GET_CARD();
            GC.ShowDialog();
        
    }


    private void txtsearchaction_TextChanged(object sender, EventArgs e)
    {
        if (txtsearchaction.Text != null)
        {
            _LoadNAME();

        }
        else
        {
            _Loadonly();
        }
    } 
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (txtsearchaction.Text=="")
        {
            _Loadonly();
        }
        else
        {
            if (dataGridView1.RowCount==0)
            {
                _Loadonly();
            }
        }
       
    }
    void logout()
    {
        DateTime times = DateTime.Now;
        string format = "HH:mm:ss";
        DateTime dates = DateTime.Now;
        string formatdate = "MM/dd/yyyy";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "UPDATE USERADMINLOGS SET [LOGOUTTIME]='" + times.ToString(format) + "' WHERE [ACCOUNTID]='" + toolStripAccountid.Text + "' AND [DATEIN]='" + dates.ToString(formatdate) + "'");
    }
    private void btnclose_Click(object sender, EventArgs e)
    {
        if (statusStrip2.Visible==false)
        {
            this.Dispose();
        }
        else if (statusStrip2.Visible==true)
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
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this,e);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        SALES s = new SALES();
        s.Show();
    }
}

