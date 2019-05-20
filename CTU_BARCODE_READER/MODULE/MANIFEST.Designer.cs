
partial class MANIFEST
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cANCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblcurrntbal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblfare = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblvat = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcaptain = new System.Windows.Forms.TextBox();
            this.cmbport = new System.Windows.Forms.ComboBox();
            this.dtpdepttime = new System.Windows.Forms.DateTimePicker();
            this.dtparrivalime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbltrans = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbportfrom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearchname = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(330, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cANCELToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // cANCELToolStripMenuItem
            // 
            this.cANCELToolStripMenuItem.Name = "cANCELToolStripMenuItem";
            this.cANCELToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cANCELToolStripMenuItem.Text = "CANCEL";
            this.cANCELToolStripMenuItem.Click += new System.EventHandler(this.cANCELToolStripMenuItem_Click);
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
            this.panel1.Size = new System.Drawing.Size(1101, 28);
            this.panel1.TabIndex = 5;
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
            this.btnclose.Location = new System.Drawing.Point(1062, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(39, 28);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "x";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANIFEST ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(330, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 83;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblcurrntbal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblfare);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblbalance);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 74);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BALANCE  AND FARE";
            // 
            // lblcurrntbal
            // 
            this.lblcurrntbal.AutoSize = true;
            this.lblcurrntbal.BackColor = System.Drawing.Color.White;
            this.lblcurrntbal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrntbal.Location = new System.Drawing.Point(209, 40);
            this.lblcurrntbal.Name = "lblcurrntbal";
            this.lblcurrntbal.Size = new System.Drawing.Size(64, 23);
            this.lblcurrntbal.TabIndex = 51;
            this.lblcurrntbal.Text = "00.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(211, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 50;
            this.label11.Text = "BALANCE";
            // 
            // lblfare
            // 
            this.lblfare.AutoSize = true;
            this.lblfare.BackColor = System.Drawing.Color.White;
            this.lblfare.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfare.Location = new System.Drawing.Point(121, 40);
            this.lblfare.Name = "lblfare";
            this.lblfare.Size = new System.Drawing.Size(64, 23);
            this.lblfare.TabIndex = 49;
            this.lblfare.Text = "00.00";
            this.lblfare.TextChanged += new System.EventHandler(this.lblfare_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "FARE";
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.BackColor = System.Drawing.Color.White;
            this.lblbalance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance.Location = new System.Drawing.Point(7, 40);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(64, 23);
            this.lblbalance.TabIndex = 47;
            this.lblbalance.Text = "00.00";
            this.lblbalance.TextChanged += new System.EventHandler(this.lblbalance_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 14);
            this.label18.TabIndex = 46;
            this.label18.Text = "CURRENT BAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblvat);
            this.groupBox2.Controls.Add(this.lblcat);
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Controls.Add(this.lblage);
            this.groupBox2.Controls.Add(this.lblname);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 177);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMMUTERS DETAILS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(71, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.Location = new System.Drawing.Point(139, 156);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(38, 16);
            this.lblvat.TabIndex = 51;
            this.lblvat.Text = "-----";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(15, 155);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(38, 16);
            this.lblcat.TabIndex = 50;
            this.lblcat.Text = "-----";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(15, 131);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(38, 16);
            this.lbladdress.TabIndex = 49;
            this.lbladdress.Text = "-----";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(139, 131);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(38, 16);
            this.lblage.TabIndex = 48;
            this.lblage.Text = "-----";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(15, 108);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 16);
            this.lblname.TabIndex = 47;
            this.lblname.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 52;
            this.label2.Text = "FERRY NAME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "CAPTAIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 14);
            this.label4.TabIndex = 54;
            this.label4.Text = "DEPARTURE TIME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "ARRIVAL TIME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 14);
            this.label6.TabIndex = 56;
            this.label6.Text = "CAPACITY:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "PORT TO:";
            // 
            // txtcaptain
            // 
            this.txtcaptain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcaptain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaptain.Location = new System.Drawing.Point(139, 43);
            this.txtcaptain.Name = "txtcaptain";
            this.txtcaptain.Size = new System.Drawing.Size(167, 22);
            this.txtcaptain.TabIndex = 59;
            this.txtcaptain.TextChanged += new System.EventHandler(this.txtcaptain_TextChanged);
            // 
            // cmbport
            // 
            this.cmbport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbport.FormattingEnabled = true;
            this.cmbport.Location = new System.Drawing.Point(140, 208);
            this.cmbport.Name = "cmbport";
            this.cmbport.Size = new System.Drawing.Size(167, 24);
            this.cmbport.TabIndex = 76;
            // 
            // dtpdepttime
            // 
            this.dtpdepttime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdepttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpdepttime.Location = new System.Drawing.Point(140, 119);
            this.dtpdepttime.Name = "dtpdepttime";
            this.dtpdepttime.Size = new System.Drawing.Size(167, 22);
            this.dtpdepttime.TabIndex = 77;
            // 
            // dtparrivalime
            // 
            this.dtparrivalime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtparrivalime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtparrivalime.Location = new System.Drawing.Point(140, 150);
            this.dtparrivalime.Name = "dtparrivalime";
            this.dtparrivalime.Size = new System.Drawing.Size(167, 22);
            this.dtparrivalime.TabIndex = 78;
            this.dtparrivalime.ValueChanged += new System.EventHandler(this.dtparrivalime_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbltrans
            // 
            this.lbltrans.AutoSize = true;
            this.lbltrans.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrans.ForeColor = System.Drawing.Color.Black;
            this.lbltrans.Location = new System.Drawing.Point(959, 32);
            this.lbltrans.Name = "lbltrans";
            this.lbltrans.Size = new System.Drawing.Size(130, 23);
            this.lbltrans.TabIndex = 80;
            this.lbltrans.Text = "0000000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(757, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 23);
            this.label10.TabIndex = 81;
            this.label10.Text = "TRANSACTION NO:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslstatus
            // 
            this.tslstatus.ForeColor = System.Drawing.Color.Red;
            this.tslstatus.Name = "tslstatus";
            this.tslstatus.Size = new System.Drawing.Size(59, 17);
            this.tslstatus.Text = "Reading...";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 5000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.cmbportfrom);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtcapacity);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dtparrivalime);
            this.groupBox5.Controls.Add(this.txtcaptain);
            this.groupBox5.Controls.Add(this.dtpdepttime);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.cmbport);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 286);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 268);
            this.groupBox5.TabIndex = 83;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FERRY DETAILS";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 81;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbportfrom
            // 
            this.cmbportfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbportfrom.FormattingEnabled = true;
            this.cmbportfrom.Location = new System.Drawing.Point(140, 178);
            this.cmbportfrom.Name = "cmbportfrom";
            this.cmbportfrom.Size = new System.Drawing.Size(167, 24);
            this.cmbportfrom.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 14);
            this.label9.TabIndex = 79;
            this.label9.Text = "PORT FROM: ";
            // 
            // txtcapacity
            // 
            this.txtcapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcapacity.Enabled = false;
            this.txtcapacity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacity.Location = new System.Drawing.Point(140, 91);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(167, 22);
            this.txtcapacity.TabIndex = 60;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CTU_BARCODE_READER.Properties.Resources.button_blue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(140, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 24);
            this.button4.TabIndex = 73;
            this.button4.Text = "START TRANSATION";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CTU_BARCODE_READER.Properties.Resources.button_blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(922, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 24);
            this.button2.TabIndex = 79;
            this.button2.Text = "READY FOR BOARDING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearchname
            // 
            this.txtsearchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchname.Location = new System.Drawing.Point(330, 59);
            this.txtsearchname.Name = "txtsearchname";
            this.txtsearchname.Size = new System.Drawing.Size(244, 22);
            this.txtsearchname.TabIndex = 84;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(580, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 21);
            this.button5.TabIndex = 85;
            this.button5.Text = "SEARCH COMMUTERS";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(464, 532);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 22);
            this.textBox2.TabIndex = 82;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 14);
            this.label12.TabIndex = 81;
            this.label12.Text = "NO OF COMMUTERS:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(139, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 18);
            this.checkBox1.TabIndex = 86;
            this.checkBox1.Text = "OTHER CAPTAIN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MANIFEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 574);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtsearchname);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbltrans);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MANIFEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANIFEST";
            this.Load += new System.EventHandler(this.MANIFEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lblcat;
    private System.Windows.Forms.Label lbladdress;
    private System.Windows.Forms.Label lblage;
    private System.Windows.Forms.Label lblname;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lblvat;
    private System.Windows.Forms.Label lblfare;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblbalance;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtcaptain;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.ComboBox cmbport;
    private System.Windows.Forms.DateTimePicker dtpdepttime;
    private System.Windows.Forms.DateTimePicker dtparrivalime;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Timer timer3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lbltrans;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tslstatus;
    private System.Windows.Forms.Timer timer4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Timer timer5;
    private System.Windows.Forms.Button btnclose;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label lblcurrntbal;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem cANCELToolStripMenuItem;
    private System.Windows.Forms.ComboBox cmbportfrom;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.TextBox txtsearchname;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox txtcapacity;
    private System.Windows.Forms.CheckBox checkBox1;
}
