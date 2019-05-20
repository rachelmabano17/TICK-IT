using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class GET_CARD : Form
{
   
    clsDrag d = new clsDrag();
    DataTable _Barcodedt = new DataTable();
    public static string refno = "";
    public static string name = "";
    public static string username = "";
    public static PictureBox qrimage;
    string code = "";

    Label USER;

    MAIN_FROM main = new MAIN_FROM();
    public GET_CARD()
    {
        USER = new Label();
        InitializeComponent();
    }
    void searchrefrence()
    {
        string _sql = @"SELECT [Idno] ,
                        [Referenceno] ,
                        [Fname],[Mname],[Lname],
                        [Address] ,
                        [Bdate] ,
                        [Age] ,
                        [Contactno] ,
                  
                        [Category] ,
                        [Date]
                        FROM [CINFO] WHERE [Referenceno]  = '" + lblrefno.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in DT.Rows)
        {
            lblidno.Text = row["Idno"].ToString();
            lblfname.Text = row["Fname"].ToString();
            lblmname.Text = row["Mname"].ToString();
            lblsname.Text = row["Lname"].ToString();
            lbladd.Text = row["Address"].ToString();
         
            lblbdate.Text = Convert.ToDateTime(row["Bdate"]).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            lblage.Text = row["Age"].ToString();
            lblcontactno.Text = row["Contactno"].ToString();
            lblcat.Text = row["Category"].ToString();
            lbldateregs.Text = Convert.ToDateTime(row["Date"]).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
        }
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


    private void GET_CARD_Load(object sender, EventArgs e)
    {
       

        this.txtsearchaction.TabIndex = 0;
        this.ActiveControl = txtsearchaction;
       // txtgetcardsearch.Enabled = true;
        button2.Enabled = false;
      

        string _sqlsearchname = @"SELECT (B.Fname +' '+B.Mname+' '+B.Lname) FROM CINFO B  ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);

        txtgetcardsearch.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtgetcardsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtgetcardsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        txtgetcardsearch.Focus();

        lblrefno.Text = GET_CARD.refno;


        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;

        panel1.MouseDown += Panel1_MouseDown;
        panel1.MouseMove += Panel1_MouseMove;

     //   txtsearchaction.Hide();
        txtsearchaction.Focus();
        USER.Text = GET_CARD.username;
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

  
    private void lblrefno_TextChanged(object sender, EventArgs e)
    {
        if (lblrefno.Text != "0000000000")
        {
            searchrefrence();
        }
        else
        {
            clearall();
            MessageBox.Show("Search Commuters First!");
            txtsearchaction.Focus();
        }
    }
    void searchcat()
    {
        string _sql = @"SELECT *
                        FROM [DSCNT] WHERE [CATEGORY]  = '" + lblcat.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in DT.Rows)
        {
            lblregularfare.Text = row["REGFARE"].ToString();
            lblvat.Text = row["PERDIS"].ToString();
        }
    }
    void calculate()
    {
        double reg, vat, fare;
        double.TryParse(lblregularfare.Text, out reg);
        double.TryParse(lblvat.Text, out vat);
        double per = vat / 100;
        fare = reg - (reg * per);
        txttotalfare.Text = fare.ToString("N2");
    }
    private void lblcat_TextChanged(object sender, EventArgs e)
    {
        if (lblcat.Text != "- - - - -")
        {
            searchcat();
            calculate();
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      
    }
    public byte[] convertImageToByteArray(System.Drawing.Image image)
    {
        MemoryStream ms = new MemoryStream();

        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        // or whatever output format you like
        return ms.ToArray();

    }
    void NewLoad()
    {

        DialogResult r = MessageBox.Show("Load this Commuters?", "NEW LOAD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == r)
        {

            byte[] imgbnry = convertImageToByteArray(pictureBox1.Image);
            string _SQL = @"INSERT INTO QRCODE (QRCODE,PICTURE,IDNO,STATUS,DATE) VALUES ('" + lblidno.Text + "',@img,'" + lblidno.Text + "','" + "ACTIVATED" + "','" + DateTime.Now.ToShortDateString() + "')";
            string cons = clsDeclaration.sLclSystemConnection;
            SqlConnection con = new SqlConnection(cons);
            con.Open();
            SqlCommand cmd = new SqlCommand(_SQL, con);
            cmd.Parameters.AddWithValue("@img",imgbnry);
            int n = cmd.ExecuteNonQuery();

            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO [dbo].[ACAMNT]([Idno],[Amount],[Date])VALUES ('" + lblidno.Text + "','" + double.Parse(txtloadamount.Text) + "','" + DateTime.Now.ToShortDateString() + "') ");
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "Update qrcode set idno = '" + lblidno.Text + "', Status = '" + "ACTIVATE" + "',DATE ='" + DateTime.Now.ToShortDateString() + "' WHERE qrcode = '" + code + "'");

            reportcard();
            
            txtloadamount.Text = "0.00";

            MessageBox.Show("SAVE SUCCESS AND CARD ACTIVATED!");
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection,"DELETE FROM QRCODE WHERE QRCODE = '"+lblidno.Text+"'");
            clearall();
        }
    }
   
    void Reload()
    {
        if (txtloadamount.Text != null)
        {
            DialogResult r = MessageBox.Show("Reload this Commuters?", "RELOAD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
               
                clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO RELOAD (IDNO,AMOUNT,DATE) VALUES ('" + lblidno.Text + "','" + double.Parse(txtloadamount.Text) + "','" + DateTime.Now.ToShortDateString() + "')");
                clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "UPDATE ACAMNT SET AMOUNT +='" + Double.Parse(txtloadamount.Text) + "',DATE ='" + DateTime.Now.ToShortDateString() + "' WHERE IDNO ='" + lblidno.Text + "' ");
                MessageBox.Show("RELOAD SUCCESS!");
               
                clearall();
                SEARCHbALANCE();
                txtloadamount.Text = "0.00";
            }
        }
    }
    void SAVEIMAGE()
    {
        SaveFileDialog sd;
        sd = new SaveFileDialog();
        sd.Filter = "PNG File|*.png";
        if (sd.ShowDialog() == DialogResult.OK)
            pictureBox1.Image.Save(sd.FileName, System.Drawing.Imaging.ImageFormat.Png);
    }
    void clearall()
    {
        txtloadamount.Text = "0.00";
        txttotalfare.Text = txtsearchaction.Text = txtstatus.Text = null;
        lblrefno.Text = lblidno.Text = "0000000000";
        lblfname.Text=  lbldateregs.Text = lblmname.Text = lblsname.Text = lbladd.Text = lblbdate.Text = lblage.Text = lblcontactno.Text = lblcat.Text = lblregularfare.Text = lblvat.Text = "- - - - -";
        lblbal.Text = "0.00";
        pictureBox1.Image = null;
        txtgetcardsearch.Text = null;
    }
    void savesales()
    {
        string _sqlsa = "";
        if (button2.Text == "RELOAD")
        {

             _sqlsa = @"INSERT INTO [dbo].[SALES]
           ([Dates]
           ,[Idno]
           ,[Des]
           ,[Amount]
           ,[Userlog]) VALUES ('" + DateTime.Now.ToShortDateString() + "','" + lblidno.Text + "','"+"RELOAD"+"','" + Double.Parse(txtloadamount.Text) + "','" + USER.Text + "')";
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, _sqlsa);
        }
        else
        {
             _sqlsa = @"INSERT INTO [dbo].[SALES]
           ([Dates]
           ,[Idno]
           ,[Des]
           ,[Amount]
           ,[Userlog]) VALUES ('" + DateTime.Now.ToShortDateString() + "','" + lblidno.Text + "','"+ "ACTIVATION LOAD" + "' ,'" + Double.Parse(txtloadamount.Text) + "','" + USER.Text + "')";
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, _sqlsa);
        }
       
    }
    void reportcard()
    {
        REPORTCLASS rc = new REPORTCLASS();
       rc.showreportCard(lblidno.Text,(lblfname.Text.ToUpper() + ' ' + lblmname.Text.Substring(0,1).ToUpper() + ' ' + lblsname.Text.ToUpper()), (lbladd.Text.ToUpper() + ' ' + lblbdate.Text),DateTime.Now.ToShortDateString(),pictureBox1);
    }
 
    private void button2_Click(object sender, EventArgs e)
    {
        if (lblrefno.Text == "0000000000")
        {
            MessageBox.Show("Reference No is missing!");
        }
        else if (txtloadamount.Text == "0.00" || txtloadamount.Text == "")
        {
            MessageBox.Show("Cannot proceed if load is Zero");
        }
        else
        {
            savesales();
            if (button2.Text != "RELOAD")
            {
                NewLoad();
              
            }
            else
            {
                Reload();
               
            }
         
            txtsearchaction.Focus();
        }
        
    }

    private void txtloadamount_TextChanged(object sender, EventArgs e)
    {
        if(txtloadamount.Text != null)
        {
            double pay;
            double.TryParse(txtloadamount.Text, out pay);
            lbltotalamounttopay.Text = "Php."+pay.ToString("N2");
            button2.Enabled = true;
        }
        else
        {
            lbltotalamounttopay.Text = "00.00";
            button2.Enabled = false;
        }
    }

    private void lblidno_TextChanged(object sender, EventArgs e)
    {
        if(lblidno.Text != "0000000000")
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(lblidno.Text, QRCodeGenerator.ECCLevel.H);
            QRCode codes = new QRCode(data);
            pictureBox1.Image = codes.GetGraphic(5);
          
        }
    }
    void SEARCHbALANCE()
    {
     
        String _SQL = "SELECT AMOUNT FROM ACAMNT WHERE IDNO = '"+lblidno.Text+"'";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection,_SQL);

        lblbal.Text ="Php."+" "+clsSQLClientFunctions.GetData(dt, "AMOUNT", "1");

        if (lblbal.Text != "Php. 0")
        {
            txtstatus.Text = "OLD";
            button2.Text = "RELOAD";
        }
        else
        {
            button2.Text = "PAY AND ACTIVATE";
            txtstatus.Text = "NEW";
        }
        

    }

    private void timer2_Tick(object sender, EventArgs e)
    {
     
    }


    private void btnclose_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void txtsearchaction_TextChanged(object sender, EventArgs e)
    {
        if(txtsearchaction.Text != null)
        {
            string refno =  @"SELECT referenceno from CINFO where idno = '"+txtsearchaction.Text+"'";
            DataTable DT = new DataTable();
            DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection,refno);
            string referenceno = clsSQLClientFunctions.GetData(DT,"referenceno","0");
            lblrefno.Text = referenceno.ToString();
            searchrefrence();
            SEARCHbALANCE();
            txtsearchaction.Focus();
        }
        else
        {
            clearall();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        clearall();
        txtsearchaction.Focus();
        txtsearchaction.Text = null;
        txtgetcardsearch.Text = null;
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        if (txtgetcardsearch.Text != null)
        {
            string _sqlname = @"SELECT Referenceno from CINFO where [Fname]+' '+[Mname]+' '+[Lname] = '" + txtgetcardsearch.Text + "'";
            DataTable dt = new DataTable();
            dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlname);
            string refno = clsSQLClientFunctions.GetData(dt, "Referenceno", "0");
            if (refno != null)
            {
                lblrefno.Text = refno;
                SEARCHbALANCE();
            }
            else
            {
                MessageBox.Show("Search Commuters First!");
                txtgetcardsearch.Focus();
            }
        }
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        DialogResult R = MessageBox.Show("Reprint Card?","REPRINT",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if(DialogResult.Yes == R)
        {
            byte[] imgbnry = convertImageToByteArray(pictureBox1.Image);
            string _SQL = @"INSERT INTO QRCODE (QRCODE,PICTURE,IDNO,STATUS,DATE) VALUES ('" + lblidno.Text + "',@img,'" + lblidno.Text + "','" + "ACTIVATED" + "','" + DateTime.Now.ToShortDateString() + "')";
            string cons = clsDeclaration.sLclSystemConnection;
            SqlConnection con = new SqlConnection(cons);
            con.Open();
            SqlCommand cmd = new SqlCommand(_SQL, con);
            cmd.Parameters.AddWithValue("@img", imgbnry);
            int n = cmd.ExecuteNonQuery();

            reportcard();
            MessageBox.Show("REPRINT SUCCESS!");
        }
    }
}

