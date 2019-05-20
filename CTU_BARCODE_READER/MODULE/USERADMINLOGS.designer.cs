
partial class USERADMINLOGS
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
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USERADMINLOGS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblcom = new System.Windows.Forms.Label();
            this.txtcomsearch = new System.Windows.Forms.TextBox();
            this.lblmanifest = new System.Windows.Forms.Label();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.cmbsearchmanifest = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 26);
            this.panel2.TabIndex = 19;
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(161, 33);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(198, 23);
            this.txtuser.TabIndex = 21;
            this.txtuser.TextChanged += new System.EventHandler(this.txtsearchaction_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 392);
            this.dataGridView1.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWREPORTToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
            // 
            // vIEWREPORTToolStripMenuItem
            // 
            this.vIEWREPORTToolStripMenuItem.Name = "vIEWREPORTToolStripMenuItem";
            this.vIEWREPORTToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.vIEWREPORTToolStripMenuItem.Text = "VIEW REPORT";
            this.vIEWREPORTToolStripMenuItem.Click += new System.EventHandler(this.vIEWREPORTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "LOGS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 26);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnclose.Location = new System.Drawing.Point(810, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 26);
            this.btnclose.TabIndex = 46;
            this.btnclose.Text = "x";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(363, 36);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(146, 16);
            this.lbluser.TabIndex = 22;
            this.lbluser.Text = "Search User Name Here";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(9, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 20);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USER LOGS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(9, 61);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 20);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "COMMUTERS LOGS";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(9, 89);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 20);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "MANIFEST LOGS";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblcom
            // 
            this.lblcom.AutoSize = true;
            this.lblcom.BackColor = System.Drawing.Color.Transparent;
            this.lblcom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcom.ForeColor = System.Drawing.Color.Black;
            this.lblcom.Location = new System.Drawing.Point(363, 63);
            this.lblcom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcom.Name = "lblcom";
            this.lblcom.Size = new System.Drawing.Size(186, 16);
            this.lblcom.TabIndex = 31;
            this.lblcom.Text = "Search Commuters Name Here";
            // 
            // txtcomsearch
            // 
            this.txtcomsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomsearch.Location = new System.Drawing.Point(161, 60);
            this.txtcomsearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcomsearch.Name = "txtcomsearch";
            this.txtcomsearch.Size = new System.Drawing.Size(198, 23);
            this.txtcomsearch.TabIndex = 30;
            this.txtcomsearch.TextChanged += new System.EventHandler(this.txtcomsearch_TextChanged);
            // 
            // lblmanifest
            // 
            this.lblmanifest.AutoSize = true;
            this.lblmanifest.BackColor = System.Drawing.Color.Transparent;
            this.lblmanifest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanifest.ForeColor = System.Drawing.Color.Black;
            this.lblmanifest.Location = new System.Drawing.Point(159, 91);
            this.lblmanifest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmanifest.Name = "lblmanifest";
            this.lblmanifest.Size = new System.Drawing.Size(59, 16);
            this.lblmanifest.TabIndex = 32;
            this.lblmanifest.Text = "Filter By:";
            // 
            // cmbfilter
            // 
            this.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Items.AddRange(new object[] {
            "DATE",
            "CATEGORY",
            "FERRY",
            "CAPTAIN"});
            this.cmbfilter.Location = new System.Drawing.Point(222, 87);
            this.cmbfilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(137, 24);
            this.cmbfilter.TabIndex = 33;
            this.cmbfilter.TextChanged += new System.EventHandler(this.cmbfilter_TextChanged);
            // 
            // dtpfrom
            // 
            this.dtpfrom.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(405, 88);
            this.dtpfrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(156, 23);
            this.dtpfrom.TabIndex = 34;
            // 
            // dtpto
            // 
            this.dtpto.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(405, 113);
            this.dtpto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(156, 23);
            this.dtpto.TabIndex = 35;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.BackColor = System.Drawing.Color.Transparent;
            this.lblfrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.Black;
            this.lblfrom.Location = new System.Drawing.Point(361, 91);
            this.lblfrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(43, 16);
            this.lblfrom.TabIndex = 36;
            this.lblfrom.Text = "From:";
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.Black;
            this.lblto.Location = new System.Drawing.Point(376, 116);
            this.lblto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(28, 16);
            this.lblto.TabIndex = 37;
            this.lblto.Text = "To:";
            // 
            // cmbsearchmanifest
            // 
            this.cmbsearchmanifest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsearchmanifest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearchmanifest.FormattingEnabled = true;
            this.cmbsearchmanifest.Items.AddRange(new object[] {
            "DATE",
            "CATEGORY",
            "FERRY",
            "CAPTAIN"});
            this.cmbsearchmanifest.Location = new System.Drawing.Point(363, 88);
            this.cmbsearchmanifest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbsearchmanifest.Name = "cmbsearchmanifest";
            this.cmbsearchmanifest.Size = new System.Drawing.Size(198, 24);
            this.cmbsearchmanifest.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(575, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USERADMINLOGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsearchmanifest);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.lblmanifest);
            this.Controls.Add(this.lblcom);
            this.Controls.Add(this.txtcomsearch);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USERADMINLOGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtuser;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lbluser;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.Label lblcom;
    private System.Windows.Forms.TextBox txtcomsearch;
    private System.Windows.Forms.Label lblmanifest;
    private System.Windows.Forms.ComboBox cmbfilter;
    private System.Windows.Forms.DateTimePicker dtpfrom;
    private System.Windows.Forms.DateTimePicker dtpto;
    private System.Windows.Forms.Label lblfrom;
    private System.Windows.Forms.Label lblto;
    private System.Windows.Forms.ComboBox cmbsearchmanifest;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem vIEWREPORTToolStripMenuItem;
    private System.Windows.Forms.Button btnclose;
    private System.Windows.Forms.Button button1;
}