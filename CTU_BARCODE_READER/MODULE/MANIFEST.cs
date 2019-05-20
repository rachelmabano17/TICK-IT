using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using System.Data.SqlClient;

public partial class MANIFEST : Form
{

    clsDrag d = new clsDrag();
   
  
    Label fullname;

    DataTable _dtdisplaycom = new DataTable();
    DataTable _dtdisplay = new DataTable();
    
    public MANIFEST()
    {
        fullname = new Label();
      
        InitializeComponent();
        btnclose.Click += Btnclose_Click;
       
    }
   
    private void Btnclose_Click(object sender, EventArgs e)
    {
        DialogResult r = MessageBox.Show("Are you want to close this transaction?","CLOSE CONFIRMATION",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if(DialogResult.Yes ==r )
        {
            this.Close();
        }
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
    public void PORT()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT DISTINCT PORTFROM,PORTTO FROM FSETUP";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbport.DataSource = ds.Tables[0];
        cmbport.DisplayMember = "PORTTO";
        cmbport.ValueMember = "PORTFROM";
    }
    public void PORTFROM()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT DISTINCT PORTFROM,PORTTO FROM FSETUP";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbportfrom.DataSource = ds.Tables[0];
        cmbportfrom.DisplayMember = "PORTTO";
        cmbportfrom.ValueMember = "PORTFROM";
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
    private void MANIFEST_Load(object sender, EventArgs e)
    {
        txtcaptain.Enabled = false;
        txtsearchname.Enabled = false;
        PORT();
        PORTFROM();
        FERRY();
        lbltrans.Text = (Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10)).ToUpper();

      //  
        _dtdisplay.Columns.Add("IDNO", typeof(string));
        _dtdisplay.Columns.Add("NAME", typeof(string));
        _dtdisplay.Columns.Add("ADDRESS", typeof(string));
        _dtdisplay.Columns.Add("CATEGORY", typeof(string));
        _dtdisplay.Columns.Add("FARE", typeof(string));
        _dtdisplay.Columns.Add("AGE", typeof(int));
        _dtdisplay.Columns.Add("GENDER", typeof(string));

        clsFunctions.DataGridViewSetup(dataGridView1, _dtdisplay);
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
    }
    private DataGridViewCell GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
    {
        DataGridViewCell cellWhereTextIsMet = null;
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
            {
                cellWhereTextIsMet = row.Cells[columnIndex];
                break;
            }
        }
        return cellWhereTextIsMet;
    }
    void _addtocomlist(string code)
    {
        int count = 1;
        string idno = "";
        string name = "";
        string address = "";
        string cat = "";
        int age = 0;
        string gender = "";
        string _sql = @"SELECT  A.IDNO as [ID],
                                (A.Fname+' '+SUBSTRING( A.Mname,1,1)+' '+A.Lname) as [NAME],
                                A.ADDRESS AS[ADDRESS],
                                A.CATEGORY AS[CATEGORY],
                                A.GENDER AS [GEN],
                                A.AGE AS [AGE]
             FROM CINFO A WHERE A.IDNO = '" + code.ToString() + "' ";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);

        foreach (DataRow row in dt.Rows)
        {
            idno = row["ID"].ToString();
            name = row["NAME"].ToString();
            address = row["ADDRESS"].ToString();
            cat = row["CATEGORY"].ToString();
            age = int.Parse(row["AGE"].ToString());
            gender = row["GEN"].ToString();
        }

        DataGridViewCell cell = GetCellWhereTextExistsInGridView(idno, dataGridView1, 0);
        if (fullname.Text != "")
        {
            if (cell != null)
            {
                //DialogResult Y = MessageBox.Show("You want to add new transaction?","ALREADY EXIST!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                //if(DialogResult.Yes== Y)
                //{
                //    DataRow R = _dtdisplay.NewRow();
                //    R["IDNO"] = idno;
                //    R["NAME"] = name;
                //    R["ADDRESS"] = address;
                //    R["CATEGORY"] = cat;
                //    R["FARE"] = lblfare.Text;
                //    _dtdisplay.Rows.Add(R);
                //    _dtdisplay.AcceptChanges();
                //    dataGridView1.DataSource = _dtdisplay;
                //}
                //else
                //{
                //    return;
                //}

                tslstatus.Text = "COMMUTERS ALREADY EXIST";
            }
            else
            {
                int i;
                if (double.Parse(lblbalance.Text) >= double.Parse(lblfare.Text))
                {
                    for ( i = 1; i < dataGridView1.Rows.Count; i++)
                    {
                        textBox2.Text = dataGridView1.RowCount.ToString();
                    }
                  
                   
                    if (int.Parse(txtcapacity.Text) != i)
                    {
                        DataRow R = _dtdisplay.NewRow();
                          
                        R["IDNO"] = idno;
                        R["NAME"] = name;
                        R["ADDRESS"] = address;
                        R["CATEGORY"] = cat;
                        R["FARE"] = lblfare.Text;
                        R["AGE"] =age;
                        R["GENDER"] = gender;
                        _dtdisplay.Rows.Add(R);
                        _dtdisplay.AcceptChanges();
                        dataGridView1.DataSource = _dtdisplay;

                    }
                    else
                    {
                        tslstatus.Text = "CAPACITY HAVE REACH";
                    }
                }
                else
                {
                    tslstatus.Text = "YOU HAVE NOT ENOUGH BALANCE TO PROCEED!...RELOAD TO THE COUNTER";
                }
            }
        }
    }
  
  
    void _Searchdetails(String code)
    {
        string _sql = @"SELECT (A.Fname+' '+A.Mname+' '+A.Lname) as [NAME],
                                A.AGE AS [AGE],
                                A.ADDRESS AS [ADDRESS],
                                A.CATEGORY AS [CATEGORY] ,
                                C.PERDIS AS [VAT],
								D.AMOUNT AS [AMOUNT],
								C.REGFARE AS [REGFARE],
                                A.Picture 
                                FROM CINFO A 
                                INNER JOIN DSCNT C ON A.CATEGORY = C.CATEGORY
								INNER JOIN ACAMNT D ON A.Idno = D.Idno
                                WHERE A.IDNO = '" + code.ToString()+"' ";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in dt.Rows)
        {
            fullname.Text = row["NAME"].ToString();
            lblname.Text = row["NAME"].ToString();
            lblage.Text = row["AGE"].ToString()  +" "+ "Yrs. Old";
            lbladdress.Text = row["ADDRESS"].ToString();
            lblcat.Text = row["CATEGORY"].ToString();
            lblvat.Text = row["VAT"].ToString()+" "+ "%";
            lblbalance.Text =row["AMOUNT"].ToString();
            byte[] img = (byte[])row["Picture"];
            if(img== null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);  
                       
                pictureBox1.Image = Image.FromStream(ms);
            }
            double percent = double.Parse(row["VAT"].ToString()) / 100;
            double FARE =  ((double.Parse(row["REGFARE"].ToString())-(double.Parse(row["REGFARE"].ToString()) * percent)));
            int intpart = (int)FARE;
            lblfare.Text = intpart.ToString();
        }
    }
    private void button4_Click(object sender, EventArgs e)
    {
     
       if (txtcaptain.Text == "")
        {
            MessageBox.Show("SET CAPTAIN!");
            txtcaptain.Focus();
        }
        else if(cmbportfrom.Text == cmbport.Text)
        {
            MessageBox.Show("INVALID CHOICE OF PORT FROM AND PORT TO!");
        }
        else
        {
            
          
            timer2.Enabled = false;
            timer3.Enabled = true;
            textBox1.Focus();

            MessageBox.Show("READY FOR TRANSAC!");
        }
    }


    private void dtparrivalime_ValueChanged(object sender, EventArgs e)
    {
        errorProvider1.Clear();
    }

    private void txtcaptain_TextChanged(object sender, EventArgs e)
    {
        errorProvider1.Clear();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        timer2.Enabled = true;
        dtpdepttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
        dtparrivalime.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }
    void updatecamount(double fare,string idno)
    {
        string _sql = @"UPDATE[dbo].[ACAMNT] SET [Amount] -='"+fare+"' WHERE Idno = '"+idno+"' ";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection,_sql);
    }
    void savecomlogs(string transno,DateTime date  , string idno , string cat , double fare, DateTime time, string ferry,string captain, string portto, string portfrom)
    {
        string _sqlsave = @"INSERT INTO [dbo].[COMLOGS]([TRANSNO],[DATE],[IDNO],[CATEGORY],[FARE],[TIMEDEPART],[FERRY],[CAPTAIN],[PORTTO],[PORTFROM]) VALUES ('" + transno+"','"+date+"','"+idno+"','"+cat+"','"+fare+"','"+time+"','"+ferry+"','"+captain+"','"+portto+"','"+portfrom+"')";
        clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection,_sqlsave);
    }
    void clear()
    {
        
        txtcapacity.Text = txtcaptain.Text =  "";
        lblname.Text = lblage.Text = lbladdress.Text = lblcat.Text = lblvat.Text = "-----";
        lblbalance.Text = lblfare.Text= lblcurrntbal.Text = "00.00";
        _dtdisplay.Rows.Clear();
       
        pictureBox1.Image = null;
        textBox1.Focus();
    }
    void manifest()
    {
        REPORTCLASS r = new REPORTCLASS();
        r.showmanifestreport(cmbportfrom.Text, lbltrans.Text, comboBox1.Text.ToUpper(), txtcaptain.Text.ToUpper(), txtcapacity.Text, dtparrivalime.Text,dtparrivalime.Value.AddMinutes(15).ToString(), cmbport.Text.ToUpper(),dataGridView1);
    }
    private void button2_Click(object sender, EventArgs e)
    {
        double fare = 0;

        String cat = "";
        string idno = "";
        string cancel = "";
        timer3.Stop();
    
        if (dataGridView1.Rows.Count > 0)
        {
            DialogResult R = MessageBox.Show("Save and Ready for the next Transaction?", "SAVE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == R)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                 
                    idno = row.Cells[0].Value.ToString();
                    cat = row.Cells[3].Value.ToString();
                    fare = Convert.ToDouble(row.Cells[4].Value);
                    cancel = row.Cells[5].Value.ToString();

                    updatecamount(fare, idno);
                    savecomlogs(lbltrans.Text, DateTime.Now, idno, cat, fare,DateTime.Parse(dtpdepttime.Text),comboBox1.Text,txtcaptain.Text,cmbport.Text,cmbportfrom.Text);
                }

                manifest();
                MessageBox.Show("Successfully Save and Ready for Next Transaction");
                lbltrans.Text = (Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10)).ToUpper();
              
                clear();
            }
            else
            {
                textBox1.Focus();
            }
        }
    }

    private void timer4_Tick(object sender, EventArgs e)
    {
      
       
    }
  
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if(textBox1.Text != null)
        {
            _Searchdetails(textBox1.Text);
            _addtocomlist(textBox1.Text);
            fullname.Text = "";
         
           
        }
      
    }

    private void timer5_Tick(object sender, EventArgs e)
    {
        textBox1.Clear();
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }


    private void lblbalance_TextChanged(object sender, EventArgs e)
    {
        if(lblbalance.Text != "0.00")
        {
            double cbal = double.Parse(lblbalance.Text);
            double fare = double.Parse(lblfare.Text);
            double bal = cbal - fare;
            lblcurrntbal.Text = bal.ToString("N2");
        }
    }

    private void lblfare_TextChanged(object sender, EventArgs e)
    {
        if (lblfare.Text != "0.00")
        {
            double cbal = double.Parse(lblbalance.Text);
            double fare = double.Parse(lblfare.Text);
            double bal = cbal - fare;
            lblcurrntbal.Text = bal.ToString("N2");
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if(txtsearchname.Text != null)
        {
            txtsearchname.Enabled = true;
            txtsearchname.Focus();
        }
    }
    private void cANCELToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int count = 1;
        foreach (DataGridViewRow item in dataGridView1.Rows)
        {
            if (item.Selected)
            {
                dataGridView1.Rows.Remove(item);
               
            }
            count = dataGridView1.RowCount;
            textBox2.Text = count.ToString();
            textBox1.Focus();
        }
    }

    private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        int count = 1;
        count = dataGridView1.RowCount;
        textBox2.Text = count.ToString();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1.Text != null)
        {
            string _sql = "SELECT A.FERRYNAME,A.CAPACITY,  (B.FIRSTNAME+' '+B.MIDDLENAME+' '+B.LASTNAME) AS CAPTAIN  FROM FSETUP A INNER JOIN OFFICER B ON A.FERRYNAME = B.FERRY WHERE A.FERRYNAME = '" + comboBox1.Text + "'";
            DataTable dt = new DataTable();
            dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
            txtcapacity.Text = clsSQLClientFunctions.GetData(dt, "CAPACITY", "1");
            txtcaptain.Text = clsSQLClientFunctions.GetData(dt, "CAPTAIN", "0");
        }

        errorProvider1.Clear();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked == true)
        {
            txtcaptain.Enabled = true;
            txtcaptain.Focus();
        }
    }
}

