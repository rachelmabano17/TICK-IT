using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarrenLee.Media;

public partial class ADD_NEW_COMMUTER : Form
{
 
    clsDrag d = new clsDrag();
    Camera cam = new Camera();
    DataTable _ADDLIST = new DataTable();
    public ADD_NEW_COMMUTER()
    {
        cam.OnFrameArrived += Cam_OnFrameArrived;
        cam.Stop();
        InitializeComponent();
    }

    private void Cam_OnFrameArrived(object source, FrameArrivedEventArgs e)
    {
        Image img = e.GetFrame();
        pictureBox1.Image = img;

    }

    public string generatecode(string gen,string genl)
    {
        string first = gen.Substring(0, 2);
        string sec = DateTime.Now.Second.ToString();
        string min = DateTime.Now.Minute.ToString();
        string hour = DateTime.Now.Hour.ToString();
        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();
   
        string final = first + year + month + day + hour + min + sec ;
        if (final.Length < 15)
        {
            while (final.Length < 15)
            {
                final += "0";
            }
        }
        return final.ToUpper();
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
        cmbcategory.DataSource = ds.Tables[0];
        cmbcategory.DisplayMember = "CATEGORY";
        cmbcategory.ValueMember = "REGFARE";
    }

    public void category2()
    {
        string _sqlqry;
        DataTable _table = new DataTable();
        _sqlqry = @"SELECT CATEGORY,REGFARE FROM DSCNT ";
        _table = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlqry);
        SqlDataAdapter da = new SqlDataAdapter(_sqlqry, clsDeclaration.sLclSystemConnection);
        DataSet ds = new DataSet();
        da.Fill(ds);
        cmbcat.DataSource = ds.Tables[0];
        cmbcat.DisplayMember = "CATEGORY";
        cmbcat.ValueMember = "REGFARE";
    }


    private void ADD_NEW_COMMUTER_Load(object sender, EventArgs e)
    {
        button9.Enabled = false;
        category2();
        category();
        _ADDLIST.Columns.Add("REFERENCE NO",typeof(String));
        _ADDLIST.Columns.Add("ID NO", typeof(String));
        _ADDLIST.Columns.Add("FIRST NAME", typeof(String));
        _ADDLIST.Columns.Add("MIDDLE NAME", typeof(String));
        _ADDLIST.Columns.Add("SURNAME", typeof(String));
        _ADDLIST.Columns.Add("ADDRESS", typeof(String));
        _ADDLIST.Columns.Add("BIRTH DATE", typeof(DateTime));
        _ADDLIST.Columns.Add("AGE", typeof(int));
        _ADDLIST.Columns.Add("GENDER", typeof(string));
        _ADDLIST.Columns.Add("CONTACT NO", typeof(string));
        _ADDLIST.Columns.Add("CATEGORY", typeof(String));
        _ADDLIST.Columns.Add("PICTURE", typeof(Image));

        clsFunctions.DataGridViewSetup(dataGridView1, _ADDLIST);

        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;


        string _sqlsearchname = @"SELECT (B.Fname +' '+B.Mname+' '+B.Lname) FROM CINFO B  ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);

        txtcomsearch.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtcomsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtcomsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
    private void txtfname_TextChanged(object sender, EventArgs e)
    {
        if (txtfname.Text != null)
        {
            if (txtfname.Text.Length == 2)
            {
                lblbidno.Text = generatecode(txtfname.Text, txtlname.Text);
                lblrefno.Text = (Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10)).ToUpper();
            }
        }
        else
        {
            lblbidno.Text = lblrefno.Text = "0000000000";
            txtfname.Focus();
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
                        FROM [CINFO] A  WHERE  (A.Fname+' '+A.Mname+' '+A.Lname)= '" + txtcomsearch.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView2, DT);
    }
    public void _Load()
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
                        FROM [CINFO] A  ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        clsFunctions.DataGridViewSetup(dataGridView2, DT);
    }
    private void dtpbdate_ValueChanged(object sender, EventArgs e)
    {
        lblage.Text =Convert.ToString(DateTime.Now.Year - dtpbdate.Value.Year);

    }
    void clearall()
    {
        txtaddress.Text = txtfname.Text = txtlname.Text = txtmiddlename.Text = txtcontact.Text = txtaddress.Text =  null;
        lblbidno.Text = lblrefno.Text = "0000000000";
        lblage.Text = "00";
        pictureBox1.Image = null;
        cmbcategory.Text = null;
        txtfname.Focus();
       
    }
    private void button3_Click(object sender, EventArgs e)
    {
        clearall();
    
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //this.Close();
    }

   
    void _savenewcommuters()
    {
      
        string refno = "";
        string id = "";
        string fname = "";
        string mname = "";
        string lname = "";
        string address = "";
        string gender = "";
        DateTime date;
        int age = 0;
        string cnumber = "";
        string cat = "";
        Image pic;
        foreach (DataGridViewRow item in dataGridView1.Rows)
        {
            refno = item.Cells[0].Value.ToString();
            id = item.Cells[1].Value.ToString();
            fname = item.Cells[2].Value.ToString();
            mname = item.Cells[3].Value.ToString();
            lname = item.Cells[4].Value.ToString();
            address = item.Cells[5].Value.ToString();
            gender = item.Cells[8].Value.ToString();
            date = DateTime.Parse(item.Cells[6].Value.ToString());
            age = int.Parse(item.Cells[7].Value.ToString());
            cnumber = item.Cells[9].Value.ToString();
            cat = item.Cells[10].Value.ToString();
            MemoryStream ms = new MemoryStream();
            Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[11].Value;
            img.Save(ms, ImageFormat.Jpeg);
            pic = Image.FromStream(ms);

            byte[] imgbnry = convertImageToByteArray(pic);
            string _SQL = @" INSERT INTO[dbo].[CINFO]([Idno],[Referenceno],[Lname]," +
                "[Mname],[Fname],[Address],[Bdate],[Age],[Gender],[Contactno],[Category],[Date],[Picture])VALUES('" + id.ToString() + "'," +
                "'" + refno + "','" + lname + "','" + mname + "','" + fname + "','" + address + "'," +
                "'" + date + "','" + age + "','"+gender+"','" + cnumber + "'," +
                "'" + cat + "','" + DateTime.Now.ToShortDateString() + "',@img)";
            string cons = clsDeclaration.sLclSystemConnection;
            SqlConnection con = new SqlConnection(cons);
            con.Open();
            SqlCommand cmd = new SqlCommand(_SQL, con);
            cmd.Parameters.AddWithValue("@img", imgbnry);
            int n = cmd.ExecuteNonQuery();
      
        }

        tslstatus.Text = "SAVE SUCCESSFULLY";
        CASHIER.fname = (txtfname.Text.ToUpper()+' '+txtmiddlename.Text.ToUpper()+' '+txtlname.Text.ToUpper());
        _ADDLIST.Rows.Clear();
        txtfname.Focus();
        
    }
    public byte[] convertImageToByteArray(System.Drawing.Image image)
    {
        MemoryStream ms = new MemoryStream();

        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        // or whatever output format you like
        return ms.ToArray();

    }
    private void button2_Click(object sender, EventArgs e)
    {
        if (dataGridView1.Rows.Count > 0)
        {
            DialogResult r = MessageBox.Show("ADD NEW COMMUTERS?", "ADD CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                _savenewcommuters();
                CASHIER.ActiveForm.Refresh();
            }
        }
        else
        {
            tslstatus.Text = "EMPTY LIST!";
        }
    }

    void stretch()
    {
        ((DataGridViewImageColumn)dataGridView1.Columns["PICTURE"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        dataGridView1.RowTemplate.Height = 60;

        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }
    void _addtolist()
    {

        if (txtcontact.Text == null)
        {
           MessageBox.Show( "PLEASE INPUT CONTACT NUMBER!");
        }
        else if (lblrefno.Text == "0000000000")
        {
            MessageBox.Show("CANNOT ADD TO LIST!");
        }
        else if (pictureBox1.Image == null)
        {
            MessageBox.Show("PLEASE ADD IMAGE TO CONTINUE!");
        }
        else
        {

            DataRow dr = _ADDLIST.NewRow();
            dr["REFERENCE NO"] = lblrefno.Text;
            dr["ID NO"] = lblbidno.Text;
            dr["FIRST NAME"] = txtfname.Text;
            dr["MIDDLE NAME"] = txtmiddlename.Text;
            dr["SURNAME"] = txtlname.Text;
            dr["ADDRESS"] = txtaddress.Text;
            dr["GENDER"] = cmbgender.Text;
            dr["BIRTH DATE"] = DateTime.Parse(dtpbdate.Text);
            dr["AGE"] = int.Parse(lblage.Text);
            dr["CONTACT NO"] = txtcontact.Text;
            dr["CATEGORY"] = cmbcategory.Text;
            dr["PICTURE"] = pictureBox1.Image;
            stretch();
            _ADDLIST.Rows.Add(dr);
            _ADDLIST.AcceptChanges();
            dataGridView1.DataSource = _ADDLIST;
        }
    }
    private void button4_Click(object sender, EventArgs e)
    {
        if (cmbcategory.Enabled==true)
        {
            DialogResult r = MessageBox.Show("Is the choosen category is correct?", "NOTICE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r==DialogResult.Yes)
            {
                _addtolist();
                clearall();
                dtpbdate.Value = DateTime.Now;
                timer2.Stop();
            }
            else if (r==DialogResult.No)
            {
                cmbcategory.Focus();
            }
        }
    }

     private void txtcontact_TextChanged(object sender, EventArgs e)
    {
        double num;
        if (!double.TryParse(txtcontact.Text, out num))
        {
            txtcontact.Clear();
                txtcontact.Focus();
        }else if (txtcontact.Text.Length == 12)
        {
            txtcontact.Text = txtcontact.Text.Substring(0, 11);
        }
    }


    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this,e);
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void btnclose_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }

  
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridView1.RowCount!=0)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Selected)
                {
                    lblrefno.Text = item.Cells[0].Value.ToString();
                    lblbidno.Text = item.Cells[1].Value.ToString();
                    txtfname.Text = item.Cells[2].Value.ToString();
                    txtmiddlename.Text = item.Cells[3].Value.ToString();
                    txtlname.Text = item.Cells[4].Value.ToString();
                    txtaddress.Text = item.Cells[5].Value.ToString();
                    cmbgender.Text = item.Cells[8].Value.ToString();
                    DateTime date =  DateTime.Parse(item.Cells[6].Value.ToString());
                    dtpbdate.Value = date;
                    lblage.Text = item.Cells[7].Value.ToString();
                    txtcontact.Text = item.Cells[9].Value.ToString();
                    cmbcategory.Text = item.Cells[10].Value.ToString();
                    MemoryStream ms = new MemoryStream();
                    Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[11].Value;
                    img.Save(ms, ImageFormat.Jpeg);
                    pictureBox1.Image = Image.FromStream(ms);
                    dataGridView1.Rows.Remove(item);
                }
            }
        }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
      
        cam.Start();
        button9.Enabled = true;
        button5.Enabled = false;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        cam.Start();
        button8.Enabled = false;
        button10.Enabled = true;
    }

    private void txtcomsearch_TextChanged(object sender, EventArgs e)
    {
        if(txtcomsearch.Text == null)
        {
            _Load();
        }
        else
        {
            _LoadNAME();
        }
    }
    void searchpic()
    {
        string _sql = @"SELECT 
                        A.Fname,
                        A.Mname,
                        A.Lname,
                        A.PICTURE
                        FROM [CINFO] A WHERE IDNO = '"+lblid2.Text+"'";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        txtfname2.Text = clsSQLClientFunctions.GetData(DT , "Fname","0");
        txtmname2.Text = clsSQLClientFunctions.GetData(DT , "Mname", "0");
        txtsurname2.Text = clsSQLClientFunctions.GetData(DT, "Lname", "0");
        foreach (DataRow row in DT.Rows)
        {
            byte[] img = (byte[])row["Picture"];
            if (img == null)
            {
                pictureBox2.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);

                pictureBox2.Image = Image.FromStream(ms);
            }
        }

    }

    void update()
    {
        DialogResult r = MessageBox.Show("You want to update commuters info?","UPDATE CONFIRAMTION",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        if (DialogResult.Yes == r)
        {
            Image pic;
            MemoryStream ms = new MemoryStream();
            Bitmap img = (Bitmap)pictureBox2.Image;
            img.Save(ms, ImageFormat.Jpeg);
            pic = Image.FromStream(ms);

            byte[] imgbnry = convertImageToByteArray(pic);
            string update = @"UPDATE CINFO SET Fname = '" + txtfname2.Text + "', Mname = '" + txtmname2.Text + "', Lname = '" + txtsurname2.Text + "',Address ='" + txtadd2.Text + "',Bdate = '" + DateTime.Parse(dateTimePicker1.Value.ToShortDateString()) + "',Age = '" + int.Parse(lblage2.Text) + "',Contactno ='" + txtcontactno2.Text + "',Category = '" + txtcontactno2.Text + "',Picture = @img WHERE IDNO = '"+lblid2.Text+"'";
            string cons = clsDeclaration.sLclSystemConnection;
            SqlConnection con = new SqlConnection(cons);
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.Parameters.AddWithValue("@img", imgbnry);
            int n = cmd.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY UPDATED!");
            CLEAR2();
            _LoadNAME();
        }
    }
    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridView2.RowCount != 0)
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (item.Selected)
                {
                    if (lblref2.Text == "0000000000")
                    {
                        lblref2.Text = item.Cells[1].Value.ToString();
                        lblid2.Text = item.Cells[0].Value.ToString();
                        txtadd2.Text = item.Cells[3].Value.ToString();
                        cmbgen.Text = item.Cells[6].Value.ToString();
                        DateTime date = DateTime.Parse(item.Cells[4].Value.ToString());
                        dateTimePicker1.Value = date;
                        lblage2.Text = item.Cells[5].Value.ToString();
                        txtcontactno2.Text = item.Cells[7].Value.ToString();
                        cmbcat.Text = item.Cells[8].Value.ToString();
                        searchpic();
                    }
                    else
                    {
                        MessageBox.Show("PLEASE CLEAR THE FIELD FIRST !");
                    }
                }
            }
        }
    }
    void CLEAR2()
    {
        lblref2.Text = lblid2.Text = "0000000000";
        txtfname2.Text = txtmname2.Text = txtsurname2.Text = txtcontactno2.Text = txtadd2.Text = "";
        cmbcat.Text = cmbgen.Text = null;
        lblage2.Text = "00";
        dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        pictureBox2.Image = null;
    }
    private void button6_Click(object sender, EventArgs e)
    {
        CLEAR2();
        txtcomsearch.Focus();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        update();
    }

    private void button9_Click(object sender, EventArgs e)
    {
        cam.Stop();
        button5.Enabled = true;
        button9.Enabled = false;
    }

    private void button10_Click(object sender, EventArgs e)
    {
        cam.Stop();
        button10.Enabled = false;
        button8.Enabled = true;
    }
}

