using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public partial class MANIFEST_REPRINT : Form
{
    public static string transno = "";
    public static DateTime date ;
    public static string ferryname = "";
    public static string captain = "";
    public static string capacity = "";
    public static string portfrom = "";
    public static string portto = "";
    public static DateTime dept ;
    public static DateTime arrival ;

    public MANIFEST_REPRINT()
    {
        InitializeComponent();
       // btnclose.Click += Btnclose_Click;
    }
    public void LOAD()
    {
        string _sql = "";

        _sql = @"SELECT  A.IDNO ,(B.Lname+' '+SUBSTRING( B.Mname,1,1)+' '+B.Lname) AS [NAME] , B.Address  AS [ADDRESS],B.Category AS [CATEGORY] , A.FARE ,B.AGE FROM COMLOGS A 
                INNER JOIN CINFO B ON B.Idno = A.IDNO WHERE A.TRANSNO = '" + txttrans.Text+"'";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView1, DT);
    }
    private void MANIFEST_REPRINT_Load(object sender, EventArgs e)
    {
        txttrans.Text = MANIFEST_REPRINT.transno;
        txtdate.Text = MANIFEST_REPRINT.date.ToShortDateString();
        txtferryname.Text = MANIFEST_REPRINT.ferryname;
        txtcapacity.Text = MANIFEST_REPRINT.capacity;
        txtcapt.Text = MANIFEST_REPRINT.captain;
        
        txttimearrival.Text =  MANIFEST_REPRINT.arrival.ToLongTimeString();
        txttimedept.Text = MANIFEST_REPRINT.dept.ToLongTimeString();
        txtportfrom.Text = MANIFEST_REPRINT.portfrom;
        txtportto.Text = MANIFEST_REPRINT.portto;
    }

    private void txttrans_TextChanged(object sender, EventArgs e)
    {
        if(txttrans.Text == null)
        {
            txttrans.Text = txttimedept.Text = txttimearrival.Text = txtportto.Text = txtportfrom.Text =
                txtferryname.Text = txtdate.Text = txtcapt.Text = txtcapacity.Text = null;
        }
        else
        {
            LOAD();
        }
    }

    private void btnclose_Click_1(object sender, EventArgs e)
    {
        this.Dispose();
    }
    void manifest()
    {
        REPORTCLASS r = new REPORTCLASS();
        r.showmanifestreport(txtportfrom.Text, txttrans.Text, txtferryname.Text.ToUpper(), txtcapt.Text.ToUpper(), txtcapacity.Text, txttimearrival.Text, txttimearrival.Text, txtportto.Text.ToUpper(), dataGridView1);
    }
    private void btnprint_Click(object sender, EventArgs e)
    {
        if (dataGridView1.Rows.Count > 0)
        {
            DialogResult r = MessageBox.Show("YOU WANT TO REPRINT?", "REPRINT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                manifest();

                MessageBox.Show("REPRINT SUCCESS!");
                this.Close();
            }
        }
        else
        {
            MessageBox.Show("NO RECORD FOUND!");
        }
    }
}

