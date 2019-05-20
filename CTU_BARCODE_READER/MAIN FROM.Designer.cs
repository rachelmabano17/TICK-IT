
public partial class MAIN_FROM
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    public void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_FROM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.lblusertype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.animated1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANIFESTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRATIONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESRECORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAccountid = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txttime);
            this.panel1.Controls.Add(this.lblusertype);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.animated1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 95);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(515, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "TIME";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(815, 62);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(142, 18);
            this.lbldate.TabIndex = 18;
            this.lbldate.Text = "mm\\\\/dd\\\\/yyyy";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Image = global::CTU_BARCODE_READER.Properties.Resources.logout_1;
            this.btnlogout.Location = new System.Drawing.Point(1140, 50);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(143, 40);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "    Logout";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CTU_BARCODE_READER.Properties.Resources._367e44719c;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(768, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.txttime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.ForeColor = System.Drawing.Color.White;
            this.txttime.Location = new System.Drawing.Point(563, 62);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(182, 19);
            this.txttime.TabIndex = 3;
            this.txttime.Text = "00:00:00 00";
            this.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblusertype
            // 
            this.lblusertype.AutoSize = true;
            this.lblusertype.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.ForeColor = System.Drawing.Color.White;
            this.lblusertype.Location = new System.Drawing.Point(315, 67);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(129, 19);
            this.lblusertype.TabIndex = 15;
            this.lblusertype.Text = "000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CTU_BARCODE_READER.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(192, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // animated1
            // 
            this.animated1.AutoSize = true;
            this.animated1.Font = new System.Drawing.Font("Baskerville Old Face", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animated1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animated1.Location = new System.Drawing.Point(584, 1);
            this.animated1.Name = "animated1";
            this.animated1.Size = new System.Drawing.Size(266, 40);
            this.animated1.TabIndex = 0;
            this.animated1.Text = "Metro Ferry Inc.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 634);
            this.panel2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dASHBOARDToolStripMenuItem,
            this.cashierToolStripMenuItem,
            this.mANIFESTToolStripMenuItem1,
            this.rEGISTRATIONToolStripMenuItem1,
            this.sETTINGSToolStripMenuItem,
            this.lOGSToolStripMenuItem1,
            this.sALESRECORDToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(188, 634);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(145, 27);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            // 
            // cashierToolStripMenuItem
            // 
            this.cashierToolStripMenuItem.Image = global::CTU_BARCODE_READER.Properties.Resources.cash;
            this.cashierToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashierToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            this.cashierToolStripMenuItem.Size = new System.Drawing.Size(126, 43);
            this.cashierToolStripMenuItem.Text = "CASHIER";
            // 
            // mANIFESTToolStripMenuItem1
            // 
            this.mANIFESTToolStripMenuItem1.Image = global::CTU_BARCODE_READER.Properties.Resources.manifest;
            this.mANIFESTToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mANIFESTToolStripMenuItem1.Name = "mANIFESTToolStripMenuItem1";
            this.mANIFESTToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.mANIFESTToolStripMenuItem1.Size = new System.Drawing.Size(137, 63);
            this.mANIFESTToolStripMenuItem1.Text = "MANIFEST";
            this.mANIFESTToolStripMenuItem1.Click += new System.EventHandler(this.mANIFESTToolStripMenuItem1_Click);
            // 
            // rEGISTRATIONToolStripMenuItem1
            // 
            this.rEGISTRATIONToolStripMenuItem1.Image = global::CTU_BARCODE_READER.Properties.Resources.registration;
            this.rEGISTRATIONToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rEGISTRATIONToolStripMenuItem1.Name = "rEGISTRATIONToolStripMenuItem1";
            this.rEGISTRATIONToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.rEGISTRATIONToolStripMenuItem1.Size = new System.Drawing.Size(135, 63);
            this.rEGISTRATIONToolStripMenuItem1.Text = "ADD USER";
            this.rEGISTRATIONToolStripMenuItem1.Click += new System.EventHandler(this.rEGISTRATIONToolStripMenuItem1_Click);
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONFIGURATIONToolStripMenuItem,
            this.sETUPToolStripMenuItem});
            this.sETTINGSToolStripMenuItem.Image = global::CTU_BARCODE_READER.Properties.Resources.setting;
            this.sETTINGSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(135, 63);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            // 
            // cONFIGURATIONToolStripMenuItem
            // 
            this.cONFIGURATIONToolStripMenuItem.Image = global::CTU_BARCODE_READER.Properties.Resources.config;
            this.cONFIGURATIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cONFIGURATIONToolStripMenuItem.Name = "cONFIGURATIONToolStripMenuItem";
            this.cONFIGURATIONToolStripMenuItem.Size = new System.Drawing.Size(231, 46);
            this.cONFIGURATIONToolStripMenuItem.Text = "CONFIGURATION";
            this.cONFIGURATIONToolStripMenuItem.Click += new System.EventHandler(this.cONFIGURATIONToolStripMenuItem_Click);
            // 
            // sETUPToolStripMenuItem
            // 
            this.sETUPToolStripMenuItem.Image = global::CTU_BARCODE_READER.Properties.Resources.setup;
            this.sETUPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sETUPToolStripMenuItem.Name = "sETUPToolStripMenuItem";
            this.sETUPToolStripMenuItem.Size = new System.Drawing.Size(231, 46);
            this.sETUPToolStripMenuItem.Text = "SET UP";
            this.sETUPToolStripMenuItem.Click += new System.EventHandler(this.sETUPToolStripMenuItem_Click);
            // 
            // lOGSToolStripMenuItem1
            // 
            this.lOGSToolStripMenuItem1.Image = global::CTU_BARCODE_READER.Properties.Resources.logs;
            this.lOGSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGSToolStripMenuItem1.Name = "lOGSToolStripMenuItem1";
            this.lOGSToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.lOGSToolStripMenuItem1.Size = new System.Drawing.Size(100, 63);
            this.lOGSToolStripMenuItem1.Text = "LOGS";
            this.lOGSToolStripMenuItem1.Click += new System.EventHandler(this.lOGSToolStripMenuItem1_Click);
            // 
            // sALESRECORDToolStripMenuItem
            // 
            this.sALESRECORDToolStripMenuItem.Image = global::CTU_BARCODE_READER.Properties.Resources.sales_ni;
            this.sALESRECORDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sALESRECORDToolStripMenuItem.Name = "sALESRECORDToolStripMenuItem";
            this.sALESRECORDToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.sALESRECORDToolStripMenuItem.Size = new System.Drawing.Size(106, 63);
            this.sALESRECORDToolStripMenuItem.Text = "SALES";
            this.sALESRECORDToolStripMenuItem.Click += new System.EventHandler(this.sALESRECORDToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripAccountid,
            this.toolStripStatusLabel5,
            this.toolStripName});
            this.statusStrip2.Location = new System.Drawing.Point(188, 707);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip2.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel3.Text = "ACCOUNT ID :";
            // 
            // toolStripAccountid
            // 
            this.toolStripAccountid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripAccountid.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripAccountid.Name = "toolStripAccountid";
            this.toolStripAccountid.Size = new System.Drawing.Size(503, 17);
            this.toolStripAccountid.Spring = true;
            this.toolStripAccountid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel5.Text = "NAME :";
            // 
            // toolStripName
            // 
            this.toolStripName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripName.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripName.Name = "toolStripName";
            this.toolStripName.Size = new System.Drawing.Size(503, 17);
            this.toolStripName.Spring = true;
            this.toolStripName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MAIN_FROM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "MAIN_FROM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MAIN_FROM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label animated1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem cONFIGURATIONToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sETUPToolStripMenuItem;
    public System.Windows.Forms.StatusStrip statusStrip2;
    public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    public System.Windows.Forms.ToolStripStatusLabel toolStripAccountid;
    public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    public System.Windows.Forms.ToolStripStatusLabel toolStripName;
    private System.Windows.Forms.Button btnlogout;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label lbldate;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txttime;
    public System.Windows.Forms.Label lblusertype;
    public System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
    public System.Windows.Forms.ToolStripMenuItem mANIFESTToolStripMenuItem1;
    public System.Windows.Forms.ToolStripMenuItem rEGISTRATIONToolStripMenuItem1;
    public System.Windows.Forms.ToolStripMenuItem lOGSToolStripMenuItem1;
    public System.Windows.Forms.ToolStripMenuItem sALESRECORDToolStripMenuItem;
    public System.Windows.Forms.ToolStripMenuItem cashierToolStripMenuItem;
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
}
