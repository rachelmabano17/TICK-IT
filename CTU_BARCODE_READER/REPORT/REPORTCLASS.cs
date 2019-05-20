using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Data.OleDb;


public class REPORTCLASS
{
    TextObject txt1;
    TextObject txt2;
    TextObject txt3;

    TextObject txtm4;
    TextObject txtsalesdatefrom;
    TextObject txtsalesdateto;
    TextObject txtuser;
    TextObject txtdate;
    TextObject txtamount;

    TextObject txtm5;
    TextObject txtm6;
    TextObject txtm7;
    TextObject txtm8;
    TextObject txtm9;
    TextObject txtm10;
    TextObject txtm11;


    Form f;
    CrystalReportViewer cr;
    CTU_BARCODE_READER.REPORT.card c;
    CTU_BARCODE_READER.REPORT.Manifest m;
    CTU_BARCODE_READER.REPORT.Sales s;
    public REPORTCLASS()
    {
        f = new Form();
        cr = new CrystalReportViewer();
        f.WindowState = FormWindowState.Maximized;
        cr.ToolPanelView = ToolPanelViewType.None;
        cr.Dock = DockStyle.Fill;
        f.Controls.Add(cr);
        c = new CTU_BARCODE_READER.REPORT.card();
        m = new CTU_BARCODE_READER.REPORT.Manifest();
        s = new CTU_BARCODE_READER.REPORT.Sales();

    }
    public string ImageToBase64(Image image, ImageFormat format)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            // Convert Image to byte[]
            image.Save(ms, format);
            byte[] imageBytes = ms.ToArray();

            // Convert byte[] to Base64 String
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
    }

    public void showsales(string datefrom, string dateto, string user, DataGridView dvg)
    {
        CTU_BARCODE_READER.REPORT.DataSet1 ds = new CTU_BARCODE_READER.REPORT.DataSet1();
        DataTable dt = ds.Tables["Sales"];

        txtsalesdatefrom = (TextObject)s.ReportDefinition.Sections["PageHeaderSection2"].ReportObjects["datefrom"];
        txtsalesdateto = (TextObject)s.ReportDefinition.Sections["PageHeaderSection2"].ReportObjects["dateto"];
        txtuser = (TextObject)s.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["txtuser"];

        txtsalesdatefrom.Text = datefrom;
        txtsalesdateto.Text = dateto;
        txtuser.Text = user;

        DataRow r;
        int i = 0;
        for (i = 0; i < dvg.Rows.Count; i++)
        {
            r = dt.NewRow();
            r["Date"] = dvg.Rows[i].Cells[0].Value.ToString();
            r["Description"] = dvg.Rows[i].Cells[3].Value.ToString();
            r["Amount"] = dvg.Rows[i].Cells[2].Value.ToString();
            dt.Rows.Add(r);
        }

        s.SetDataSource(ds.Tables[2]);
        cr.ReportSource = s;
        cr.Refresh();

        f.ShowDialog();

    }

    public void showmanifestreport(string portfrom, string transaction, string ferry, string captain,
         string capacity, string travel, string arrival, string port, DataGridView dvg)
    {
        CTU_BARCODE_READER.REPORT.DataSet1 ds = new CTU_BARCODE_READER.REPORT.DataSet1();
        DataTable dt = ds.Tables["Manifest"];
        txtm4 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection3"].ReportObjects["PORTFROM"];
        txtm5 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection2"].ReportObjects["TRANSNO"];
        txtm6 = (TextObject)m.ReportDefinition.Sections["Section2"].ReportObjects["FERRY"];
        txtm7 = (TextObject)m.ReportDefinition.Sections["Section2"].ReportObjects["TRAVEL"];
        txtm8 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection6"].ReportObjects["CAPTAIN"];
        txtm9 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection6"].ReportObjects["ARRIVAL"];
        txtm10 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection7"].ReportObjects["CAPACITY"];
        txtm11 = (TextObject)m.ReportDefinition.Sections["PageHeaderSection7"].ReportObjects["PORT"];

        txtm4.Text = portfrom;
        txtm5.Text = transaction;
        txtm6.Text = ferry;
        txtm7.Text = travel;
        txtm8.Text = captain;
        txtm9.Text = arrival;
        txtm10.Text = capacity;
        txtm11.Text = port;


        DataRow r;
        int i = 0;
        for (i = 0; i < dvg.Rows.Count; i++)
        {
            string id = dvg.Rows[i].Cells[0].Value.ToString();
            string gen = "select gender from cinfo  where idno = '"+id+"' ";
            DataTable dtable = new DataTable();
            dtable = clsSQLClientFunctions.DataList(clsDeclaration.sLclSystemConnection,gen);
            string gender = clsSQLClientFunctions.GetData(dtable, "gender","0");

            r = dt.NewRow();
        
            r["Name"] = dvg.Rows[i].Cells[1].Value.ToString().ToUpper();
            r["Address"] = dvg.Rows[i].Cells[2].Value.ToString().ToUpper();
            r["Category"] = dvg.Rows[i].Cells[3].Value.ToString();
            r["status"] = dvg.Rows[i].Cells[5].Value.ToString();
            r["gender"] = gender;


            dt.Rows.Add(r);

        }

        m.SetDataSource(ds.Tables[1]);
        cr.ReportSource = m;
        cr.Refresh();

        f.ShowDialog();

    }
    public void showreportCard(string id, string name, string address, string transdate, PictureBox pic)
    {

        txt1 = (TextObject)c.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["name"];
        txt2 = (TextObject)c.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["address"];
        txt3 = (TextObject)c.ReportDefinition.Sections["PageHeaderSection1"].ReportObjects["date"];

        txt1.Text = name;
        txt2.Text = address;
        txt3.Text = transdate;
        DataSet ds = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        string cons = clsDeclaration.sLclSystemConnection;
        SqlConnection con = new SqlConnection(cons);
        con.Open();
        DA = new SqlDataAdapter("select PICTURE from qrcode where QRCODE = '" + id.ToString() + "'", con);
        DA.Fill(ds, "QRCODE");
        c.SetDataSource(ds);
        cr.ReportSource = c;
        cr.Refresh();
        f.ShowDialog();

    }

}

