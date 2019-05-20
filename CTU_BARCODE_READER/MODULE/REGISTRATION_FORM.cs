using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


public partial class REGISTRATION_FORM : Form
{
    Label ID;
    clsDrag d = new clsDrag();
    Timer t;
    public static string user;
    public REGISTRATION_FORM()
    {
        ID = new Label();
        InitializeComponent();
        Load += REGISTRATION_FORM_Load;
        btnsave.Click += Btnsave_Click;
        t = new Timer();
        t.Enabled = true;
        t.Interval = 5000;
        btnclose.Click += Btnclose_Click;
        btnclear.Click += Btnclear_Click;
    }

    private void Btnclear_Click(object sender, EventArgs e)
    {
       
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
  
    private void Btnclose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Btnsave_Click(object sender, EventArgs e)
    {
       
    }
  
    private void REGISTRATION_FORM_Load(object sender, EventArgs e)
    {
       
        string _sqlsearchname = @"SELECT ([FIRSTNAME]+''+[MIDDLENAME]+''+[LASTNAME]) as [NAME]FROM [dbo].[REGISTRATION]  ";
        DataTable tablename = new DataTable();
        tablename = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sqlsearchname);
        txtsearch.AutoCompleteCustomSource = LoadAutoComplete(tablename, 0);
        txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest;
        txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
      
        txtage.Enabled = false;
        cmbusertype.Items.Add("CASHIER");
        cmbusertype.Items.Add("STAFF");

        cmbuuser.Items.Add("CASHIER");
        cmbuuser.Items.Add("STAFF");

        txtpass.PasswordChar = '*';
        txtretypepass.PasswordChar = '*';
        t.Tick += T_Tick;
        btnclose.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
        btnclose.FlatAppearance.MouseOverBackColor = Color.Red;
    }

    private void T_Tick(object sender, EventArgs e)
    {
        tslstatus.Text = "Reading...";
    }

    public string GenerateID(string genid1, string genid2)
    {
        string genacctid = genid1.Substring(0, 3);
        string sec = DateTime.Now.Second.ToString();
        string min = DateTime.Now.Minute.ToString();
        string hour = DateTime.Now.Hour.ToString();
        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();

        string genresult = genacctid + year + month + day + hour + min + sec;
        if (genresult.Length < 15)
        {
            while (genresult.Length < 15)
            {
                genresult += "0";
            }
        }
        return genresult.ToUpper();
    }
    public void clearfield()
    {
        txtfname.Text = txtlname.Text = txtmname.Text = txtage.Text = txtuser.Text = txtpass.Text = txtage.Text= txtaddress.Text=txtretypepass.Text = null;
        cmbusertype.Text = null;
        dtpbdate.Value = DateTime.Now;
    }
    void LOAD ()
    {
        String load = @"SELECT [ACCOUNTID]
      ,[FIRSTNAME]
      ,[MIDDLENAME]
      ,[LASTNAME]
      ,[AGE]
      ,[BIRTHDATE]
      ,[ADDRESS]
      ,[USERTYPE]
  FROM[dbo].[REGISTRATION] WHERE [FIRSTNAME]+''+[MIDDLENAME]+''+[LASTNAME] = '" + txtsearch.Text+"'";
        DataTable dt = new DataTable();
        dt = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, load);
        clsFunctions.DataGridViewSetup(dataGridView1, dt);
    }
    bool checkusername()
    {
        bool user = false;
        string _sql = @"SELECT [ACCOUNTID]
                        FROM [REGISTRATION] WHERE [USERNAME] = '" + txtuser.Text + "' ";
        DataTable DT = new DataTable();
        DT = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection, _sql);
        foreach (DataRow row in DT.Rows)
        {
            user = true;
        }
        return user;
    }
    void SaveRegistration()
    {
        string id = lblaccountid.Text;
        string name = txtfname.Text + " " + txtmname.Text + " " + txtlname.Text;
        string user = txtuser.Text;
        string pass = txtpass.Text;
        string type = cmbusertype.Text;
        DialogResult R = MessageBox.Show("Save this New Employee ?", "SAVE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == R)
        {
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO REGISTRATION([ACCOUNTID],[FIRSTNAME],[MIDDLENAME],[LASTNAME],[AGE],[BIRTHDATE],[ADDRESS],[USERNAME],[PASSWORDS],[USERTYPE],[DATEREGISTER]) VALUES('" + lblaccountid.Text + "','" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtage.Text + "','" + dtpbdate.Value.ToShortDateString() + "','" + txtaddress.Text + "','" + txtuser.Text + "','" + txtpass.Text + "','" + cmbusertype.Text + "','" + DateTime.Now.ToShortDateString() + "')");
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, "INSERT INTO USERLOGIN([ACCOUNTID],[NAME],[USERNAME],[PASSWORDS],[USERTYPE]) VALUES('" + id + "','" + name + "','" + user + "','" + pass + "','" + type + "')");

            MessageBox.Show("Save Successfully!");
            clearfield();
            txtfname.Focus();
        }
    }

    void UpdateRegistration()
    {
        string id = ID.Text;
        string type = txtretypepass.Text;
        DialogResult R = MessageBox.Show("Update  this  Employee ?", "UPDATE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == R)
        {
            string update = @" UPDATE [dbo].[USERLOGIN] set [USERTYPE] ='"+cmbuuser.Text+"' WHERE [ACCOUNTID] = '" + ID.Text + "' ";
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, update);

            string UPDATE2 = @"UPDATE [dbo].[REGISTRATION] SET [FIRSTNAME] = '"+txtufname.Text+"' ,[MIDDLENAME] = '"+txtumname.Text+"',[LASTNAME] = '"+txtulname.Text+"',[AGE] = '"+int.Parse(txtuage.Text)+"',[BIRTHDATE] = '"+dateTimePicker1.Text+"' ,[ADDRESS] = '"+txtuadd.Text+"' ,[USERTYPE] = '"+cmbuuser.Text+"'  WHERE ACCOUNTID  ='" + ID.Text + "'";
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, UPDATE2);

            MessageBox.Show("Update Successfully!");
            clear();
            LOAD();
        }
    }

    public void SaveToRegistration()
    {

        if (txtfname.Text == "")
        {
            MessageBox.Show("please enter first name", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtmname.Text == "")
        {
            MessageBox.Show("please enter middle name", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtlname.Text == "")
        {
            MessageBox.Show("please enter last name", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtage.Text == "")
        {
            MessageBox.Show("please set birthdate", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtaddress.Text == "")
        {
            MessageBox.Show("please enter address", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (cmbusertype.Text == "")
        {
            MessageBox.Show("please select user type", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtuser.Text == "")
        {
            MessageBox.Show("please enter username", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtpass.Text == "")
        {
            MessageBox.Show("please enter password", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (txtretypepass.Text != txtpass.Text)
        {
            MessageBox.Show("Password did not match", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            if (checkusername() == true)
            {
                MessageBox.Show("Username is already exist.!");
            }
            else
            {

                SaveRegistration();

            }
        }

    }
   
    private void txtfname_TextChanged(object sender, EventArgs e)
    {
        if (txtfname.Text != null)
        {
            
            if (txtfname.Text.Length == 3)
            {
                lblaccountid.Text = GenerateID(txtfname.Text, txtlname.Text);
            }
            else if (txtfname.Text == "")
            {
                lblaccountid.Text = "0000000000";
            }
        }
        else
        {
            txtfname.Focus();
        }
    }

    private void dtpbdate_ValueChanged(object sender, EventArgs e)
    {
        txtage.Text = Convert.ToString(DateTime.Now.Year - dtpbdate.Value.Year);
    }

    private void btnsave_Click_1(object sender, EventArgs e)
    {
        SaveToRegistration();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        d.drag(this, e);
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        d.down(e);
    }

    private void btnclose_Click_1(object sender, EventArgs e)
    {
        this.Dispose();
    }

    private void btnclear_Click_1(object sender, EventArgs e)
    {
        txtaddress.Text = txtage.Text = txtfname.Text = txtlname.Text = txtmname.Text = txtpass.Text = txtretypepass.Text = txtuser.Text = "";
        dtpbdate.Value = DateTime.Now;
        lblaccountid.Text = "0000000000";
        txtfname.Focus();
    }

    private void txtsearch_TextChanged(object sender, EventArgs e)
    {
        if(txtsearch.Text != null)
        {
            LOAD();
          
        }
        else
        {
            txtsearch.Focus();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (ID.Text != null)
        {
            UpdateRegistration();
        }
        else
        {
            MessageBox.Show("Please Choose employees to update!");
        }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if(dataGridView1.Rows.Count >0)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                ID.Text = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                txtufname.Text = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                txtumname.Text = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                txtulname.Text = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();
               dateTimePicker1.Text = dataGridView1.SelectedRows[i].Cells[5].Value.ToString();
               txtuadd.Text = dataGridView1.SelectedRows[i].Cells[6].Value.ToString();
                cmbuuser.Text = dataGridView1.SelectedRows[i].Cells[7].Value.ToString();
            }
        }
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        txtuage.Text = Convert.ToString(DateTime.Now.Year - dateTimePicker1.Value.Year);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult R = MessageBox.Show("Delete  this  Employee ?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (DialogResult.Yes == R)
        {
            string del = "DELETE FROM [REGISTRATION] WHERE ACCOUNTID = '" + ID.Text + "'";
            string del2 = "DELETE FROM [USERLOGIN] WHERE ACCOUNTID = '" + ID.Text + "'";
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del);
            clsSQLClientFunctions.GlobalExecuteCommand(clsDeclaration.sLclSystemConnection, del2);

            MessageBox.Show("Update Successfully!");
            clear();
            LOAD();
        }

    }

    void clear()
    {
        txtuadd.Text = txtuage.Text = txtufname.Text = txtulname.Text = txtumname.Text = txtuser.Text = null;
    }
}