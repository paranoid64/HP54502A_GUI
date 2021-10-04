/*
 * Created by SharpDevelop.
 * User: mlausch
 * Date: 06.02.2021
 * Time: 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HP54502A_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_plot_grat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_zoom = new System.Windows.Forms.ComboBox();
            this.lbl_zoom = new System.Windows.Forms.Label();
            this.ch_chan4 = new System.Windows.Forms.CheckBox();
            this.ch_chan3 = new System.Windows.Forms.CheckBox();
            this.ch_chan2 = new System.Windows.Forms.CheckBox();
            this.ch_chan1 = new System.Windows.Forms.CheckBox();
            this.cb_plot_line = new System.Windows.Forms.ComboBox();
            this.bnt_plot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_save_plot = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bnt_wai = new System.Windows.Forms.Button();
            this.bnt_sre = new System.Windows.Forms.Button();
            this.bnt_prt = new System.Windows.Forms.Button();
            this.bnt_lrn = new System.Windows.Forms.Button();
            this.bnt_ist = new System.Windows.Forms.Button();
            this.bnt_esr = new System.Windows.Forms.Button();
            this.bnt_ese = new System.Windows.Forms.Button();
            this.bnt_ser = new System.Windows.Forms.Button();
            this.bnt_tst = new System.Windows.Forms.Button();
            this.bnt_trg = new System.Windows.Forms.Button();
            this.bnt_sav = new System.Windows.Forms.Button();
            this.bnt_rst = new System.Windows.Forms.Button();
            this.bnt_rcl = new System.Windows.Forms.Button();
            this.bnt_opc = new System.Windows.Forms.Button();
            this.bnt_cls = new System.Windows.Forms.Button();
            this.bnt_idn = new System.Windows.Forms.Button();
            this.bnt_stb = new System.Windows.Forms.Button();
            this.bnt_syst_err = new System.Windows.Forms.Button();
            this.bnt_send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bnt_cal = new System.Windows.Forms.Button();
            this.bnt_test = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_beeper = new System.Windows.Forms.ComboBox();
            this.lbl_beep = new System.Windows.Forms.Label();
            this.cb_screen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ser = new System.Windows.Forms.TextBox();
            this.bnt_SN = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_save = new System.Windows.Forms.Label();
            this.lbl_recall = new System.Windows.Forms.Label();
            this.cb_save = new System.Windows.Forms.ComboBox();
            this.cb_recall = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.lbl_gpib = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.cb_connection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bnt_connection = new System.Windows.Forms.Button();
            this.lbl_device = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ch4_value = new System.Windows.Forms.Label();
            this.lbl_ch3_value = new System.Windows.Forms.Label();
            this.lbl_ch2_value = new System.Windows.Forms.Label();
            this.lbl_ch1_value = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bnt_f7 = new System.Windows.Forms.Button();
            this.bnt_f6 = new System.Windows.Forms.Button();
            this.bnt_f5 = new System.Windows.Forms.Button();
            this.bnt_f4 = new System.Windows.Forms.Button();
            this.bnt_f3 = new System.Windows.Forms.Button();
            this.bnt_f2 = new System.Windows.Forms.Button();
            this.bnt_f1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cb_coup_ch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_coup = new System.Windows.Forms.Label();
            this.cb_coup = new System.Windows.Forms.ComboBox();
            this.cb_graticule = new System.Windows.Forms.ComboBox();
            this.lbl_graticule = new System.Windows.Forms.Label();
            this.cb_menu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bnt_run_stop = new System.Windows.Forms.Button();
            this.bnt_single = new System.Windows.Forms.Button();
            this.bnt_clear = new System.Windows.Forms.Button();
            this.bntAutoscale = new System.Windows.Forms.Button();
            this.bnt_local = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bnt_meas_all = new System.Windows.Forms.Button();
            this.bnt_ns = new System.Windows.Forms.Button();
            this.bnt_frequenz = new System.Windows.Forms.Button();
            this.bnt_microfs = new System.Windows.Forms.Button();
            this.bnt_volt = new System.Windows.Forms.Button();
            this.bnt_ms_mV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_channel_meas = new System.Windows.Forms.ComboBox();
            this.bnt_sV = new System.Windows.Forms.Button();
            this.bnt_fine = new System.Windows.Forms.Button();
            this.bnt_clear_key = new System.Windows.Forms.Button();
            this.bnt_shift = new System.Windows.Forms.Button();
            this.bnt_minus = new System.Windows.Forms.Button();
            this.bnt_7 = new System.Windows.Forms.Button();
            this.bnt_dot = new System.Windows.Forms.Button();
            this.bnt_6 = new System.Windows.Forms.Button();
            this.bnt_0 = new System.Windows.Forms.Button();
            this.bnt_5 = new System.Windows.Forms.Button();
            this.bnt_1 = new System.Windows.Forms.Button();
            this.bnt_8 = new System.Windows.Forms.Button();
            this.bnt_2 = new System.Windows.Forms.Button();
            this.bnt_9 = new System.Windows.Forms.Button();
            this.bnt_3 = new System.Windows.Forms.Button();
            this.bnt_4 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lbl_tmarker = new System.Windows.Forms.Label();
            this.cb_tmarker = new System.Windows.Forms.ComboBox();
            this.lbl_vmarker = new System.Windows.Forms.Label();
            this.cb_vmarker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox10);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Size = new System.Drawing.Size(1037, 623);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 509);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.cb_plot_grat);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cb_zoom);
            this.groupBox6.Controls.Add(this.lbl_zoom);
            this.groupBox6.Controls.Add(this.ch_chan4);
            this.groupBox6.Controls.Add(this.ch_chan3);
            this.groupBox6.Controls.Add(this.ch_chan2);
            this.groupBox6.Controls.Add(this.ch_chan1);
            this.groupBox6.Controls.Add(this.cb_plot_line);
            this.groupBox6.Controls.Add(this.bnt_plot);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.bnt_save_plot);
            this.groupBox6.Location = new System.Drawing.Point(11, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(502, 127);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PLOT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(404, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Export PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_plot_grat
            // 
            this.cb_plot_grat.FormattingEnabled = true;
            this.cb_plot_grat.Location = new System.Drawing.Point(83, 77);
            this.cb_plot_grat.Name = "cb_plot_grat";
            this.cb_plot_grat.Size = new System.Drawing.Size(121, 21);
            this.cb_plot_grat.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "GRATICULE:";
            // 
            // cb_zoom
            // 
            this.cb_zoom.FormattingEnabled = true;
            this.cb_zoom.Location = new System.Drawing.Point(83, 47);
            this.cb_zoom.Name = "cb_zoom";
            this.cb_zoom.Size = new System.Drawing.Size(120, 21);
            this.cb_zoom.TabIndex = 15;
            // 
            // lbl_zoom
            // 
            this.lbl_zoom.AutoSize = true;
            this.lbl_zoom.Location = new System.Drawing.Point(7, 50);
            this.lbl_zoom.Name = "lbl_zoom";
            this.lbl_zoom.Size = new System.Drawing.Size(42, 13);
            this.lbl_zoom.TabIndex = 14;
            this.lbl_zoom.Text = "ZOOM:";
            // 
            // ch_chan4
            // 
            this.ch_chan4.AutoSize = true;
            this.ch_chan4.Location = new System.Drawing.Point(309, 44);
            this.ch_chan4.Name = "ch_chan4";
            this.ch_chan4.Size = new System.Drawing.Size(86, 17);
            this.ch_chan4.TabIndex = 13;
            this.ch_chan4.Text = "CHANNEL 4";
            this.ch_chan4.UseVisualStyleBackColor = true;
            // 
            // ch_chan3
            // 
            this.ch_chan3.AutoSize = true;
            this.ch_chan3.Location = new System.Drawing.Point(217, 44);
            this.ch_chan3.Name = "ch_chan3";
            this.ch_chan3.Size = new System.Drawing.Size(86, 17);
            this.ch_chan3.TabIndex = 12;
            this.ch_chan3.Text = "CHANNEL 3";
            this.ch_chan3.UseVisualStyleBackColor = true;
            // 
            // ch_chan2
            // 
            this.ch_chan2.AutoSize = true;
            this.ch_chan2.Location = new System.Drawing.Point(309, 19);
            this.ch_chan2.Name = "ch_chan2";
            this.ch_chan2.Size = new System.Drawing.Size(86, 17);
            this.ch_chan2.TabIndex = 11;
            this.ch_chan2.Text = "CHANNEL 2";
            this.ch_chan2.UseVisualStyleBackColor = true;
            // 
            // ch_chan1
            // 
            this.ch_chan1.AutoSize = true;
            this.ch_chan1.Location = new System.Drawing.Point(217, 19);
            this.ch_chan1.Name = "ch_chan1";
            this.ch_chan1.Size = new System.Drawing.Size(86, 17);
            this.ch_chan1.TabIndex = 10;
            this.ch_chan1.Text = "CHANNEL 1";
            this.ch_chan1.UseVisualStyleBackColor = true;
            // 
            // cb_plot_line
            // 
            this.cb_plot_line.FormattingEnabled = true;
            this.cb_plot_line.Location = new System.Drawing.Point(83, 20);
            this.cb_plot_line.Name = "cb_plot_line";
            this.cb_plot_line.Size = new System.Drawing.Size(119, 21);
            this.cb_plot_line.TabIndex = 9;
            // 
            // bnt_plot
            // 
            this.bnt_plot.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_plot.Location = new System.Drawing.Point(404, 13);
            this.bnt_plot.Name = "bnt_plot";
            this.bnt_plot.Size = new System.Drawing.Size(92, 26);
            this.bnt_plot.TabIndex = 2;
            this.bnt_plot.Text = "Hardcopy";
            this.bnt_plot.UseVisualStyleBackColor = false;
            this.bnt_plot.Click += new System.EventHandler(this.bnt_plot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FORMAT:";
            // 
            // bnt_save_plot
            // 
            this.bnt_save_plot.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_save_plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_save_plot.Location = new System.Drawing.Point(404, 45);
            this.bnt_save_plot.Name = "bnt_save_plot";
            this.bnt_save_plot.Size = new System.Drawing.Size(92, 23);
            this.bnt_save_plot.TabIndex = 7;
            this.bnt_save_plot.Text = "&Export IMG";
            this.bnt_save_plot.UseVisualStyleBackColor = false;
            this.bnt_save_plot.Click += new System.EventHandler(this.bnt_save_plot_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.bnt_wai);
            this.tabPage2.Controls.Add(this.bnt_sre);
            this.tabPage2.Controls.Add(this.bnt_prt);
            this.tabPage2.Controls.Add(this.bnt_lrn);
            this.tabPage2.Controls.Add(this.bnt_ist);
            this.tabPage2.Controls.Add(this.bnt_esr);
            this.tabPage2.Controls.Add(this.bnt_ese);
            this.tabPage2.Controls.Add(this.bnt_ser);
            this.tabPage2.Controls.Add(this.bnt_tst);
            this.tabPage2.Controls.Add(this.bnt_trg);
            this.tabPage2.Controls.Add(this.bnt_sav);
            this.tabPage2.Controls.Add(this.bnt_rst);
            this.tabPage2.Controls.Add(this.bnt_rcl);
            this.tabPage2.Controls.Add(this.bnt_opc);
            this.tabPage2.Controls.Add(this.bnt_cls);
            this.tabPage2.Controls.Add(this.bnt_idn);
            this.tabPage2.Controls.Add(this.bnt_stb);
            this.tabPage2.Controls.Add(this.bnt_syst_err);
            this.tabPage2.Controls.Add(this.bnt_send);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.txt_com);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // bnt_wai
            // 
            this.bnt_wai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_wai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_wai.Location = new System.Drawing.Point(434, 435);
            this.bnt_wai.Name = "bnt_wai";
            this.bnt_wai.Size = new System.Drawing.Size(78, 23);
            this.bnt_wai.TabIndex = 22;
            this.bnt_wai.Text = "*WAI";
            this.bnt_wai.UseVisualStyleBackColor = false;
            this.bnt_wai.Click += new System.EventHandler(this.bnt_wai_Click);
            // 
            // bnt_sre
            // 
            this.bnt_sre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_sre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_sre.Location = new System.Drawing.Point(350, 435);
            this.bnt_sre.Name = "bnt_sre";
            this.bnt_sre.Size = new System.Drawing.Size(78, 23);
            this.bnt_sre.TabIndex = 21;
            this.bnt_sre.Text = "*SRE";
            this.bnt_sre.UseVisualStyleBackColor = false;
            this.bnt_sre.Click += new System.EventHandler(this.bnt_sre_Click);
            // 
            // bnt_prt
            // 
            this.bnt_prt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_prt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_prt.Location = new System.Drawing.Point(266, 435);
            this.bnt_prt.Name = "bnt_prt";
            this.bnt_prt.Size = new System.Drawing.Size(78, 23);
            this.bnt_prt.TabIndex = 20;
            this.bnt_prt.Text = "*PRE";
            this.bnt_prt.UseVisualStyleBackColor = false;
            this.bnt_prt.Click += new System.EventHandler(this.bnt_prt_Click);
            // 
            // bnt_lrn
            // 
            this.bnt_lrn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_lrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_lrn.Location = new System.Drawing.Point(182, 435);
            this.bnt_lrn.Name = "bnt_lrn";
            this.bnt_lrn.Size = new System.Drawing.Size(78, 23);
            this.bnt_lrn.TabIndex = 19;
            this.bnt_lrn.Text = "*LRN?";
            this.bnt_lrn.UseVisualStyleBackColor = false;
            this.bnt_lrn.Click += new System.EventHandler(this.bnt_lrn_Click);
            // 
            // bnt_ist
            // 
            this.bnt_ist.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_ist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ist.Location = new System.Drawing.Point(98, 435);
            this.bnt_ist.Name = "bnt_ist";
            this.bnt_ist.Size = new System.Drawing.Size(78, 23);
            this.bnt_ist.TabIndex = 18;
            this.bnt_ist.Text = "*IST?";
            this.bnt_ist.UseVisualStyleBackColor = false;
            this.bnt_ist.Click += new System.EventHandler(this.bnt_ist_Click);
            // 
            // bnt_esr
            // 
            this.bnt_esr.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_esr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_esr.Location = new System.Drawing.Point(14, 435);
            this.bnt_esr.Name = "bnt_esr";
            this.bnt_esr.Size = new System.Drawing.Size(78, 23);
            this.bnt_esr.TabIndex = 17;
            this.bnt_esr.Text = "*ESR?";
            this.bnt_esr.UseVisualStyleBackColor = false;
            this.bnt_esr.Click += new System.EventHandler(this.bnt_esr_Click);
            // 
            // bnt_ese
            // 
            this.bnt_ese.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_ese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ese.Location = new System.Drawing.Point(434, 406);
            this.bnt_ese.Name = "bnt_ese";
            this.bnt_ese.Size = new System.Drawing.Size(78, 23);
            this.bnt_ese.TabIndex = 16;
            this.bnt_ese.Text = "*ESE";
            this.bnt_ese.UseVisualStyleBackColor = false;
            this.bnt_ese.Click += new System.EventHandler(this.bnt_ese_Click);
            // 
            // bnt_ser
            // 
            this.bnt_ser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_ser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ser.Location = new System.Drawing.Point(350, 406);
            this.bnt_ser.Name = "bnt_ser";
            this.bnt_ser.Size = new System.Drawing.Size(78, 23);
            this.bnt_ser.TabIndex = 15;
            this.bnt_ser.Text = ":SER";
            this.bnt_ser.UseVisualStyleBackColor = false;
            this.bnt_ser.Click += new System.EventHandler(this.bnt_ser_Click);
            // 
            // bnt_tst
            // 
            this.bnt_tst.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_tst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_tst.Location = new System.Drawing.Point(266, 406);
            this.bnt_tst.Name = "bnt_tst";
            this.bnt_tst.Size = new System.Drawing.Size(78, 23);
            this.bnt_tst.TabIndex = 14;
            this.bnt_tst.Text = "*TST?";
            this.bnt_tst.UseVisualStyleBackColor = false;
            this.bnt_tst.Click += new System.EventHandler(this.bnt_tst_Click);
            // 
            // bnt_trg
            // 
            this.bnt_trg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_trg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_trg.Location = new System.Drawing.Point(182, 406);
            this.bnt_trg.Name = "bnt_trg";
            this.bnt_trg.Size = new System.Drawing.Size(78, 23);
            this.bnt_trg.TabIndex = 13;
            this.bnt_trg.Text = "*TRG";
            this.bnt_trg.UseVisualStyleBackColor = false;
            this.bnt_trg.Click += new System.EventHandler(this.bnt_trg_Click);
            // 
            // bnt_sav
            // 
            this.bnt_sav.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_sav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_sav.Location = new System.Drawing.Point(98, 406);
            this.bnt_sav.Name = "bnt_sav";
            this.bnt_sav.Size = new System.Drawing.Size(78, 23);
            this.bnt_sav.TabIndex = 12;
            this.bnt_sav.Text = "*SAV";
            this.bnt_sav.UseVisualStyleBackColor = false;
            this.bnt_sav.Click += new System.EventHandler(this.bnt_sav_Click);
            // 
            // bnt_rst
            // 
            this.bnt_rst.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_rst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_rst.Location = new System.Drawing.Point(14, 406);
            this.bnt_rst.Name = "bnt_rst";
            this.bnt_rst.Size = new System.Drawing.Size(78, 23);
            this.bnt_rst.TabIndex = 11;
            this.bnt_rst.Text = "*RST";
            this.bnt_rst.UseVisualStyleBackColor = false;
            this.bnt_rst.Click += new System.EventHandler(this.bnt_rst_Click);
            // 
            // bnt_rcl
            // 
            this.bnt_rcl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_rcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_rcl.Location = new System.Drawing.Point(434, 377);
            this.bnt_rcl.Name = "bnt_rcl";
            this.bnt_rcl.Size = new System.Drawing.Size(78, 23);
            this.bnt_rcl.TabIndex = 10;
            this.bnt_rcl.Text = "*RCL";
            this.bnt_rcl.UseVisualStyleBackColor = false;
            this.bnt_rcl.Click += new System.EventHandler(this.bnt_rcl_Click);
            // 
            // bnt_opc
            // 
            this.bnt_opc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_opc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_opc.Location = new System.Drawing.Point(350, 377);
            this.bnt_opc.Name = "bnt_opc";
            this.bnt_opc.Size = new System.Drawing.Size(78, 23);
            this.bnt_opc.TabIndex = 9;
            this.bnt_opc.Text = "*OPC?";
            this.bnt_opc.UseVisualStyleBackColor = false;
            this.bnt_opc.Click += new System.EventHandler(this.bnt_opc_Click);
            // 
            // bnt_cls
            // 
            this.bnt_cls.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cls.Location = new System.Drawing.Point(266, 377);
            this.bnt_cls.Name = "bnt_cls";
            this.bnt_cls.Size = new System.Drawing.Size(78, 23);
            this.bnt_cls.TabIndex = 8;
            this.bnt_cls.Text = "*CLS";
            this.bnt_cls.UseVisualStyleBackColor = false;
            this.bnt_cls.Click += new System.EventHandler(this.bnt_cls_Click);
            // 
            // bnt_idn
            // 
            this.bnt_idn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_idn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_idn.Location = new System.Drawing.Point(182, 377);
            this.bnt_idn.Name = "bnt_idn";
            this.bnt_idn.Size = new System.Drawing.Size(78, 23);
            this.bnt_idn.TabIndex = 7;
            this.bnt_idn.Text = "*IDN?";
            this.bnt_idn.UseVisualStyleBackColor = false;
            this.bnt_idn.Click += new System.EventHandler(this.bnt_idn_Click);
            // 
            // bnt_stb
            // 
            this.bnt_stb.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_stb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_stb.Location = new System.Drawing.Point(98, 377);
            this.bnt_stb.Name = "bnt_stb";
            this.bnt_stb.Size = new System.Drawing.Size(78, 23);
            this.bnt_stb.TabIndex = 6;
            this.bnt_stb.Text = "*STB?";
            this.bnt_stb.UseVisualStyleBackColor = false;
            this.bnt_stb.Click += new System.EventHandler(this.bnt_stb_Click);
            // 
            // bnt_syst_err
            // 
            this.bnt_syst_err.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_syst_err.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_syst_err.Location = new System.Drawing.Point(14, 377);
            this.bnt_syst_err.Name = "bnt_syst_err";
            this.bnt_syst_err.Size = new System.Drawing.Size(78, 23);
            this.bnt_syst_err.TabIndex = 5;
            this.bnt_syst_err.Text = "SYST:ERR?";
            this.bnt_syst_err.UseVisualStyleBackColor = false;
            this.bnt_syst_err.Click += new System.EventHandler(this.bnt_syst_err_Click);
            // 
            // bnt_send
            // 
            this.bnt_send.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_send.Location = new System.Drawing.Point(399, 345);
            this.bnt_send.Name = "bnt_send";
            this.bnt_send.Size = new System.Drawing.Size(116, 23);
            this.bnt_send.TabIndex = 3;
            this.bnt_send.Text = "Senden";
            this.bnt_send.UseVisualStyleBackColor = false;
            this.bnt_send.Click += new System.EventHandler(this.Bnt_sendClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.YellowGreen;
            this.richTextBox1.Location = new System.Drawing.Point(14, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(500, 321);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txt_com
            // 
            this.txt_com.Location = new System.Drawing.Point(14, 347);
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(378, 20);
            this.txt_com.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Controls.Add(this.bnt_cal);
            this.tabPage3.Controls.Add(this.bnt_test);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Option";
            // 
            // bnt_cal
            // 
            this.bnt_cal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_cal.Location = new System.Drawing.Point(12, 340);
            this.bnt_cal.Name = "bnt_cal";
            this.bnt_cal.Size = new System.Drawing.Size(108, 24);
            this.bnt_cal.TabIndex = 2;
            this.bnt_cal.Text = "Calibrate";
            this.bnt_cal.UseVisualStyleBackColor = false;
            this.bnt_cal.Click += new System.EventHandler(this.Bnt_calClick);
            // 
            // bnt_test
            // 
            this.bnt_test.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_test.Location = new System.Drawing.Point(12, 370);
            this.bnt_test.Name = "bnt_test";
            this.bnt_test.Size = new System.Drawing.Size(108, 23);
            this.bnt_test.TabIndex = 1;
            this.bnt_test.Text = "Test";
            this.bnt_test.UseVisualStyleBackColor = false;
            this.bnt_test.Click += new System.EventHandler(this.Bnt_testClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_beeper);
            this.groupBox4.Controls.Add(this.lbl_beep);
            this.groupBox4.Controls.Add(this.cb_screen);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(255, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 90);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Allgemein";
            // 
            // cb_beeper
            // 
            this.cb_beeper.FormattingEnabled = true;
            this.cb_beeper.Location = new System.Drawing.Point(76, 24);
            this.cb_beeper.Name = "cb_beeper";
            this.cb_beeper.Size = new System.Drawing.Size(181, 21);
            this.cb_beeper.TabIndex = 6;
            // 
            // lbl_beep
            // 
            this.lbl_beep.Location = new System.Drawing.Point(5, 27);
            this.lbl_beep.Name = "lbl_beep";
            this.lbl_beep.Size = new System.Drawing.Size(100, 23);
            this.lbl_beep.TabIndex = 5;
            this.lbl_beep.Text = "BEEPER";
            // 
            // cb_screen
            // 
            this.cb_screen.FormattingEnabled = true;
            this.cb_screen.Location = new System.Drawing.Point(76, 51);
            this.cb_screen.Name = "cb_screen";
            this.cb_screen.Size = new System.Drawing.Size(181, 21);
            this.cb_screen.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SCREEN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_ser);
            this.groupBox1.Controls.Add(this.bnt_SN);
            this.groupBox1.Location = new System.Drawing.Point(6, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seriennummer";
            // 
            // txt_ser
            // 
            this.txt_ser.Location = new System.Drawing.Point(6, 19);
            this.txt_ser.Name = "txt_ser";
            this.txt_ser.Size = new System.Drawing.Size(166, 20);
            this.txt_ser.TabIndex = 1;
            // 
            // bnt_SN
            // 
            this.bnt_SN.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_SN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_SN.Location = new System.Drawing.Point(178, 17);
            this.bnt_SN.Name = "bnt_SN";
            this.bnt_SN.Size = new System.Drawing.Size(108, 23);
            this.bnt_SN.TabIndex = 0;
            this.bnt_SN.Text = "Ändern";
            this.bnt_SN.UseVisualStyleBackColor = false;
            this.bnt_SN.Click += new System.EventHandler(this.Bnt_SN_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.lbl_save);
            this.groupBox7.Controls.Add(this.lbl_recall);
            this.groupBox7.Controls.Add(this.cb_save);
            this.groupBox7.Controls.Add(this.cb_recall);
            this.groupBox7.Location = new System.Drawing.Point(12, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(235, 90);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Programm";
            // 
            // lbl_save
            // 
            this.lbl_save.Location = new System.Drawing.Point(6, 54);
            this.lbl_save.Name = "lbl_save";
            this.lbl_save.Size = new System.Drawing.Size(53, 23);
            this.lbl_save.TabIndex = 8;
            this.lbl_save.Text = "SAVE";
            // 
            // lbl_recall
            // 
            this.lbl_recall.Location = new System.Drawing.Point(6, 27);
            this.lbl_recall.Name = "lbl_recall";
            this.lbl_recall.Size = new System.Drawing.Size(53, 23);
            this.lbl_recall.TabIndex = 7;
            this.lbl_recall.Text = "RECALL";
            // 
            // cb_save
            // 
            this.cb_save.FormattingEnabled = true;
            this.cb_save.Location = new System.Drawing.Point(65, 54);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(151, 21);
            this.cb_save.TabIndex = 6;
            // 
            // cb_recall
            // 
            this.cb_recall.FormattingEnabled = true;
            this.cb_recall.Location = new System.Drawing.Point(65, 24);
            this.cb_recall.Name = "cb_recall";
            this.cb_recall.Size = new System.Drawing.Size(151, 21);
            this.cb_recall.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.lbl_hp);
            this.groupBox3.Controls.Add(this.lbl_gpib);
            this.groupBox3.Controls.Add(this.pic_status);
            this.groupBox3.Controls.Add(this.cb_connection);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.bnt_connection);
            this.groupBox3.Controls.Add(this.lbl_device);
            this.groupBox3.Location = new System.Drawing.Point(7, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 92);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HP-IB";
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Location = new System.Drawing.Point(170, 70);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(35, 13);
            this.lbl_hp.TabIndex = 4;
            this.lbl_hp.Text = "lbl_hp";
            // 
            // lbl_gpib
            // 
            this.lbl_gpib.AutoSize = true;
            this.lbl_gpib.Location = new System.Drawing.Point(170, 49);
            this.lbl_gpib.Name = "lbl_gpib";
            this.lbl_gpib.Size = new System.Drawing.Size(43, 13);
            this.lbl_gpib.TabIndex = 3;
            this.lbl_gpib.Text = "lbl_gpib";
            // 
            // pic_status
            // 
            this.pic_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_status.Image = global::HP54502A_GUI.Properties.Resources.connect;
            this.pic_status.Location = new System.Drawing.Point(9, 19);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(64, 64);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_status.TabIndex = 2;
            this.pic_status.TabStop = false;
            // 
            // cb_connection
            // 
            this.cb_connection.FormattingEnabled = true;
            this.cb_connection.Location = new System.Drawing.Point(99, 19);
            this.cb_connection.Name = "cb_connection";
            this.cb_connection.Size = new System.Drawing.Size(196, 21);
            this.cb_connection.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "HP-Model:";
            // 
            // bnt_connection
            // 
            this.bnt_connection.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_connection.Location = new System.Drawing.Point(313, 17);
            this.bnt_connection.Name = "bnt_connection";
            this.bnt_connection.Size = new System.Drawing.Size(75, 23);
            this.bnt_connection.TabIndex = 1;
            this.bnt_connection.Text = "Verbinden";
            this.bnt_connection.UseVisualStyleBackColor = false;
            this.bnt_connection.Click += new System.EventHandler(this.bnt_connection_Click);
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Location = new System.Drawing.Point(96, 49);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(67, 13);
            this.lbl_device.TabIndex = 0;
            this.lbl_device.Text = "GPIB Model:";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox10.Controls.Add(this.tableLayoutPanel1);
            this.groupBox10.Location = new System.Drawing.Point(11, 293);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(461, 143);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "VALUES";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.395973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.60403F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_ch4_value, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ch3_value, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ch2_value, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ch1_value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 118);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbl_ch4_value
            // 
            this.lbl_ch4_value.AutoSize = true;
            this.lbl_ch4_value.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_ch4_value.Location = new System.Drawing.Point(45, 90);
            this.lbl_ch4_value.Name = "lbl_ch4_value";
            this.lbl_ch4_value.Size = new System.Drawing.Size(31, 13);
            this.lbl_ch4_value.TabIndex = 7;
            this.lbl_ch4_value.Text = "CH4:";
            // 
            // lbl_ch3_value
            // 
            this.lbl_ch3_value.AutoSize = true;
            this.lbl_ch3_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ch3_value.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ch3_value.Location = new System.Drawing.Point(45, 60);
            this.lbl_ch3_value.Name = "lbl_ch3_value";
            this.lbl_ch3_value.Size = new System.Drawing.Size(31, 13);
            this.lbl_ch3_value.TabIndex = 6;
            this.lbl_ch3_value.Text = "CH3:";
            // 
            // lbl_ch2_value
            // 
            this.lbl_ch2_value.AutoSize = true;
            this.lbl_ch2_value.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_ch2_value.Location = new System.Drawing.Point(45, 30);
            this.lbl_ch2_value.Name = "lbl_ch2_value";
            this.lbl_ch2_value.Size = new System.Drawing.Size(31, 13);
            this.lbl_ch2_value.TabIndex = 5;
            this.lbl_ch2_value.Text = "CH2:";
            // 
            // lbl_ch1_value
            // 
            this.lbl_ch1_value.AutoSize = true;
            this.lbl_ch1_value.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_ch1_value.Location = new System.Drawing.Point(45, 0);
            this.lbl_ch1_value.Name = "lbl_ch1_value";
            this.lbl_ch1_value.Size = new System.Drawing.Size(31, 13);
            this.lbl_ch1_value.TabIndex = 4;
            this.lbl_ch1_value.Text = "CH1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "CH4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CH3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Magenta;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "CH2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CH1:";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Controls.Add(this.bnt_f7);
            this.groupBox8.Controls.Add(this.bnt_f6);
            this.groupBox8.Controls.Add(this.bnt_f5);
            this.groupBox8.Controls.Add(this.bnt_f4);
            this.groupBox8.Controls.Add(this.bnt_f3);
            this.groupBox8.Controls.Add(this.bnt_f2);
            this.groupBox8.Controls.Add(this.bnt_f1);
            this.groupBox8.Location = new System.Drawing.Point(11, 60);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(82, 224);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Funktion";
            // 
            // bnt_f7
            // 
            this.bnt_f7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f7.Location = new System.Drawing.Point(10, 193);
            this.bnt_f7.Name = "bnt_f7";
            this.bnt_f7.Size = new System.Drawing.Size(56, 23);
            this.bnt_f7.TabIndex = 6;
            this.bnt_f7.Text = "F7";
            this.bnt_f7.UseVisualStyleBackColor = false;
            this.bnt_f7.Click += new System.EventHandler(this.bnt_f7_Click);
            // 
            // bnt_f6
            // 
            this.bnt_f6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f6.Location = new System.Drawing.Point(10, 164);
            this.bnt_f6.Name = "bnt_f6";
            this.bnt_f6.Size = new System.Drawing.Size(56, 23);
            this.bnt_f6.TabIndex = 5;
            this.bnt_f6.Text = "F6";
            this.bnt_f6.UseVisualStyleBackColor = false;
            this.bnt_f6.Click += new System.EventHandler(this.bnt_f6_Click);
            // 
            // bnt_f5
            // 
            this.bnt_f5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f5.Location = new System.Drawing.Point(10, 135);
            this.bnt_f5.Name = "bnt_f5";
            this.bnt_f5.Size = new System.Drawing.Size(56, 23);
            this.bnt_f5.TabIndex = 4;
            this.bnt_f5.Text = "F5";
            this.bnt_f5.UseVisualStyleBackColor = false;
            this.bnt_f5.Click += new System.EventHandler(this.bnt_f5_Click);
            // 
            // bnt_f4
            // 
            this.bnt_f4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f4.Location = new System.Drawing.Point(10, 106);
            this.bnt_f4.Name = "bnt_f4";
            this.bnt_f4.Size = new System.Drawing.Size(56, 23);
            this.bnt_f4.TabIndex = 3;
            this.bnt_f4.Text = "F4";
            this.bnt_f4.UseVisualStyleBackColor = false;
            this.bnt_f4.Click += new System.EventHandler(this.bnt_f4_Click);
            // 
            // bnt_f3
            // 
            this.bnt_f3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f3.Location = new System.Drawing.Point(10, 77);
            this.bnt_f3.Name = "bnt_f3";
            this.bnt_f3.Size = new System.Drawing.Size(56, 23);
            this.bnt_f3.TabIndex = 2;
            this.bnt_f3.Text = "F3";
            this.bnt_f3.UseVisualStyleBackColor = false;
            this.bnt_f3.Click += new System.EventHandler(this.bnt_f3_Click);
            // 
            // bnt_f2
            // 
            this.bnt_f2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f2.Location = new System.Drawing.Point(10, 48);
            this.bnt_f2.Name = "bnt_f2";
            this.bnt_f2.Size = new System.Drawing.Size(56, 23);
            this.bnt_f2.TabIndex = 1;
            this.bnt_f2.Text = "F2";
            this.bnt_f2.UseVisualStyleBackColor = false;
            this.bnt_f2.Click += new System.EventHandler(this.bnt_f2_Click);
            // 
            // bnt_f1
            // 
            this.bnt_f1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_f1.Location = new System.Drawing.Point(10, 19);
            this.bnt_f1.Name = "bnt_f1";
            this.bnt_f1.Size = new System.Drawing.Size(56, 23);
            this.bnt_f1.TabIndex = 0;
            this.bnt_f1.Text = "F1";
            this.bnt_f1.UseVisualStyleBackColor = false;
            this.bnt_f1.Click += new System.EventHandler(this.bnt_f1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.cb_graticule);
            this.groupBox2.Controls.Add(this.lbl_graticule);
            this.groupBox2.Controls.Add(this.cb_menu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(100, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SET";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Location = new System.Drawing.Point(165, 135);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(201, 78);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "RANGE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "CH 1 -40V CH2 -4 VOLT";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cb_coup_ch);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.lbl_coup);
            this.groupBox9.Controls.Add(this.cb_coup);
            this.groupBox9.Location = new System.Drawing.Point(165, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 97);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "COUP";
            // 
            // cb_coup_ch
            // 
            this.cb_coup_ch.FormattingEnabled = true;
            this.cb_coup_ch.Location = new System.Drawing.Point(79, 20);
            this.cb_coup_ch.Name = "cb_coup_ch";
            this.cb_coup_ch.Size = new System.Drawing.Size(113, 21);
            this.cb_coup_ch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHANNEL:";
            // 
            // lbl_coup
            // 
            this.lbl_coup.AutoSize = true;
            this.lbl_coup.Location = new System.Drawing.Point(6, 50);
            this.lbl_coup.Name = "lbl_coup";
            this.lbl_coup.Size = new System.Drawing.Size(44, 13);
            this.lbl_coup.TabIndex = 3;
            this.lbl_coup.Text = "DC/AC:";
            // 
            // cb_coup
            // 
            this.cb_coup.FormattingEnabled = true;
            this.cb_coup.Location = new System.Drawing.Point(79, 47);
            this.cb_coup.Name = "cb_coup";
            this.cb_coup.Size = new System.Drawing.Size(113, 21);
            this.cb_coup.TabIndex = 4;
            // 
            // cb_graticule
            // 
            this.cb_graticule.FormattingEnabled = true;
            this.cb_graticule.Location = new System.Drawing.Point(10, 85);
            this.cb_graticule.Name = "cb_graticule";
            this.cb_graticule.Size = new System.Drawing.Size(135, 21);
            this.cb_graticule.TabIndex = 6;
            // 
            // lbl_graticule
            // 
            this.lbl_graticule.AutoSize = true;
            this.lbl_graticule.Location = new System.Drawing.Point(9, 69);
            this.lbl_graticule.Name = "lbl_graticule";
            this.lbl_graticule.Size = new System.Drawing.Size(71, 13);
            this.lbl_graticule.TabIndex = 5;
            this.lbl_graticule.Text = "GRATICULE:";
            // 
            // cb_menu
            // 
            this.cb_menu.FormattingEnabled = true;
            this.cb_menu.Location = new System.Drawing.Point(10, 39);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(135, 21);
            this.cb_menu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENÜ:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.bnt_run_stop);
            this.flowLayoutPanel1.Controls.Add(this.bnt_single);
            this.flowLayoutPanel1.Controls.Add(this.bnt_clear);
            this.flowLayoutPanel1.Controls.Add(this.bntAutoscale);
            this.flowLayoutPanel1.Controls.Add(this.bnt_local);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 29);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // bnt_run_stop
            // 
            this.bnt_run_stop.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_run_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_run_stop.ForeColor = System.Drawing.Color.Black;
            this.bnt_run_stop.Location = new System.Drawing.Point(3, 3);
            this.bnt_run_stop.Name = "bnt_run_stop";
            this.bnt_run_stop.Size = new System.Drawing.Size(85, 23);
            this.bnt_run_stop.TabIndex = 12;
            this.bnt_run_stop.Text = "RUN/STOP";
            this.bnt_run_stop.UseVisualStyleBackColor = false;
            this.bnt_run_stop.Click += new System.EventHandler(this.bnt_run_stop_Click);
            // 
            // bnt_single
            // 
            this.bnt_single.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_single.ForeColor = System.Drawing.Color.Black;
            this.bnt_single.Location = new System.Drawing.Point(94, 3);
            this.bnt_single.Name = "bnt_single";
            this.bnt_single.Size = new System.Drawing.Size(85, 23);
            this.bnt_single.TabIndex = 14;
            this.bnt_single.Text = "SINGLE";
            this.bnt_single.UseVisualStyleBackColor = false;
            this.bnt_single.Click += new System.EventHandler(this.bnt_single_Click);
            // 
            // bnt_clear
            // 
            this.bnt_clear.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_clear.ForeColor = System.Drawing.Color.Black;
            this.bnt_clear.Location = new System.Drawing.Point(185, 3);
            this.bnt_clear.Name = "bnt_clear";
            this.bnt_clear.Size = new System.Drawing.Size(85, 23);
            this.bnt_clear.TabIndex = 13;
            this.bnt_clear.Text = "CLEAR";
            this.bnt_clear.UseVisualStyleBackColor = false;
            this.bnt_clear.Click += new System.EventHandler(this.bnt_clear_Click);
            // 
            // bntAutoscale
            // 
            this.bntAutoscale.BackColor = System.Drawing.Color.SandyBrown;
            this.bntAutoscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAutoscale.ForeColor = System.Drawing.Color.Black;
            this.bntAutoscale.Location = new System.Drawing.Point(276, 3);
            this.bntAutoscale.Name = "bntAutoscale";
            this.bntAutoscale.Size = new System.Drawing.Size(85, 23);
            this.bntAutoscale.TabIndex = 4;
            this.bntAutoscale.Text = "AUTOSCALE";
            this.bntAutoscale.UseVisualStyleBackColor = false;
            this.bntAutoscale.Click += new System.EventHandler(this.BntAutoscaleClick);
            // 
            // bnt_local
            // 
            this.bnt_local.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_local.ForeColor = System.Drawing.Color.Black;
            this.bnt_local.Location = new System.Drawing.Point(367, 3);
            this.bnt_local.Name = "bnt_local";
            this.bnt_local.Size = new System.Drawing.Size(85, 23);
            this.bnt_local.TabIndex = 15;
            this.bnt_local.Text = "LOCAL";
            this.bnt_local.UseVisualStyleBackColor = false;
            this.bnt_local.Click += new System.EventHandler(this.bnt_local_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.bnt_meas_all);
            this.groupBox5.Controls.Add(this.bnt_ns);
            this.groupBox5.Controls.Add(this.bnt_frequenz);
            this.groupBox5.Controls.Add(this.bnt_microfs);
            this.groupBox5.Controls.Add(this.bnt_volt);
            this.groupBox5.Controls.Add(this.bnt_ms_mV);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cb_channel_meas);
            this.groupBox5.Controls.Add(this.bnt_sV);
            this.groupBox5.Controls.Add(this.bnt_fine);
            this.groupBox5.Controls.Add(this.bnt_clear_key);
            this.groupBox5.Controls.Add(this.bnt_shift);
            this.groupBox5.Controls.Add(this.bnt_minus);
            this.groupBox5.Controls.Add(this.bnt_7);
            this.groupBox5.Controls.Add(this.bnt_dot);
            this.groupBox5.Controls.Add(this.bnt_6);
            this.groupBox5.Controls.Add(this.bnt_0);
            this.groupBox5.Controls.Add(this.bnt_5);
            this.groupBox5.Controls.Add(this.bnt_1);
            this.groupBox5.Controls.Add(this.bnt_8);
            this.groupBox5.Controls.Add(this.bnt_2);
            this.groupBox5.Controls.Add(this.bnt_9);
            this.groupBox5.Controls.Add(this.bnt_3);
            this.groupBox5.Controls.Add(this.bnt_4);
            this.groupBox5.Location = new System.Drawing.Point(11, 445);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 165);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ENTRY";
            // 
            // bnt_meas_all
            // 
            this.bnt_meas_all.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_meas_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_meas_all.Location = new System.Drawing.Point(254, 108);
            this.bnt_meas_all.Name = "bnt_meas_all";
            this.bnt_meas_all.Size = new System.Drawing.Size(98, 23);
            this.bnt_meas_all.TabIndex = 6;
            this.bnt_meas_all.Text = "VOLT + FREQ";
            this.bnt_meas_all.UseVisualStyleBackColor = false;
            this.bnt_meas_all.Click += new System.EventHandler(this.bnt_meas_all_Click);
            // 
            // bnt_ns
            // 
            this.bnt_ns.BackColor = System.Drawing.Color.OldLace;
            this.bnt_ns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ns.Location = new System.Drawing.Point(157, 108);
            this.bnt_ns.Name = "bnt_ns";
            this.bnt_ns.Size = new System.Drawing.Size(77, 23);
            this.bnt_ns.TabIndex = 18;
            this.bnt_ns.Text = "ns";
            this.bnt_ns.UseVisualStyleBackColor = false;
            this.bnt_ns.Click += new System.EventHandler(this.bnt_ns_Click);
            // 
            // bnt_frequenz
            // 
            this.bnt_frequenz.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_frequenz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_frequenz.Location = new System.Drawing.Point(254, 79);
            this.bnt_frequenz.Name = "bnt_frequenz";
            this.bnt_frequenz.Size = new System.Drawing.Size(98, 23);
            this.bnt_frequenz.TabIndex = 5;
            this.bnt_frequenz.Text = "FREQUENZ";
            this.bnt_frequenz.UseVisualStyleBackColor = false;
            this.bnt_frequenz.Click += new System.EventHandler(this.bnt_frequenz_Click);
            // 
            // bnt_microfs
            // 
            this.bnt_microfs.BackColor = System.Drawing.Color.OldLace;
            this.bnt_microfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_microfs.Location = new System.Drawing.Point(157, 79);
            this.bnt_microfs.Name = "bnt_microfs";
            this.bnt_microfs.Size = new System.Drawing.Size(77, 23);
            this.bnt_microfs.TabIndex = 17;
            this.bnt_microfs.Text = "µs";
            this.bnt_microfs.UseVisualStyleBackColor = false;
            this.bnt_microfs.Click += new System.EventHandler(this.bnt_microfs_Click);
            // 
            // bnt_volt
            // 
            this.bnt_volt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bnt_volt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_volt.Location = new System.Drawing.Point(254, 50);
            this.bnt_volt.Name = "bnt_volt";
            this.bnt_volt.Size = new System.Drawing.Size(98, 23);
            this.bnt_volt.TabIndex = 2;
            this.bnt_volt.Text = "VOLT";
            this.bnt_volt.UseVisualStyleBackColor = false;
            this.bnt_volt.Click += new System.EventHandler(this.bnt_volt_Click);
            // 
            // bnt_ms_mV
            // 
            this.bnt_ms_mV.BackColor = System.Drawing.Color.OldLace;
            this.bnt_ms_mV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_ms_mV.Location = new System.Drawing.Point(157, 50);
            this.bnt_ms_mV.Name = "bnt_ms_mV";
            this.bnt_ms_mV.Size = new System.Drawing.Size(77, 23);
            this.bnt_ms_mV.TabIndex = 16;
            this.bnt_ms_mV.Text = "ms mV";
            this.bnt_ms_mV.UseVisualStyleBackColor = false;
            this.bnt_ms_mV.Click += new System.EventHandler(this.bnt_ms_mV_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CHANNEL:";
            // 
            // cb_channel_meas
            // 
            this.cb_channel_meas.FormattingEnabled = true;
            this.cb_channel_meas.Location = new System.Drawing.Point(318, 23);
            this.cb_channel_meas.Name = "cb_channel_meas";
            this.cb_channel_meas.Size = new System.Drawing.Size(128, 21);
            this.cb_channel_meas.TabIndex = 1;
            // 
            // bnt_sV
            // 
            this.bnt_sV.BackColor = System.Drawing.Color.OldLace;
            this.bnt_sV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_sV.Location = new System.Drawing.Point(157, 21);
            this.bnt_sV.Name = "bnt_sV";
            this.bnt_sV.Size = new System.Drawing.Size(77, 23);
            this.bnt_sV.TabIndex = 15;
            this.bnt_sV.Text = "s V";
            this.bnt_sV.UseVisualStyleBackColor = false;
            this.bnt_sV.Click += new System.EventHandler(this.bnt_sV_Click);
            // 
            // bnt_fine
            // 
            this.bnt_fine.BackColor = System.Drawing.Color.OldLace;
            this.bnt_fine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_fine.Location = new System.Drawing.Point(157, 137);
            this.bnt_fine.Name = "bnt_fine";
            this.bnt_fine.Size = new System.Drawing.Size(77, 23);
            this.bnt_fine.TabIndex = 14;
            this.bnt_fine.Text = "FINE";
            this.bnt_fine.UseVisualStyleBackColor = false;
            this.bnt_fine.Click += new System.EventHandler(this.bnt_fine_Click);
            // 
            // bnt_clear_key
            // 
            this.bnt_clear_key.BackColor = System.Drawing.Color.OldLace;
            this.bnt_clear_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_clear_key.Location = new System.Drawing.Point(88, 136);
            this.bnt_clear_key.Name = "bnt_clear_key";
            this.bnt_clear_key.Size = new System.Drawing.Size(63, 23);
            this.bnt_clear_key.TabIndex = 13;
            this.bnt_clear_key.Text = "CLEAR";
            this.bnt_clear_key.UseVisualStyleBackColor = false;
            this.bnt_clear_key.Click += new System.EventHandler(this.bnt_clear_key_Click);
            // 
            // bnt_shift
            // 
            this.bnt_shift.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bnt_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_shift.Location = new System.Drawing.Point(13, 136);
            this.bnt_shift.Name = "bnt_shift";
            this.bnt_shift.Size = new System.Drawing.Size(69, 23);
            this.bnt_shift.TabIndex = 12;
            this.bnt_shift.Text = "SHIFT";
            this.bnt_shift.UseVisualStyleBackColor = false;
            this.bnt_shift.Click += new System.EventHandler(this.bnt_shift_Click);
            // 
            // bnt_minus
            // 
            this.bnt_minus.BackColor = System.Drawing.Color.OldLace;
            this.bnt_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_minus.Location = new System.Drawing.Point(109, 107);
            this.bnt_minus.Name = "bnt_minus";
            this.bnt_minus.Size = new System.Drawing.Size(42, 23);
            this.bnt_minus.TabIndex = 11;
            this.bnt_minus.Text = "-";
            this.bnt_minus.UseVisualStyleBackColor = false;
            this.bnt_minus.Click += new System.EventHandler(this.bnt_minus_Click);
            // 
            // bnt_7
            // 
            this.bnt_7.BackColor = System.Drawing.Color.OldLace;
            this.bnt_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_7.Location = new System.Drawing.Point(13, 21);
            this.bnt_7.Name = "bnt_7";
            this.bnt_7.Size = new System.Drawing.Size(42, 23);
            this.bnt_7.TabIndex = 0;
            this.bnt_7.Text = "7";
            this.bnt_7.UseVisualStyleBackColor = false;
            this.bnt_7.Click += new System.EventHandler(this.Bnt_7Click);
            // 
            // bnt_dot
            // 
            this.bnt_dot.BackColor = System.Drawing.Color.OldLace;
            this.bnt_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_dot.Location = new System.Drawing.Point(61, 107);
            this.bnt_dot.Name = "bnt_dot";
            this.bnt_dot.Size = new System.Drawing.Size(42, 23);
            this.bnt_dot.TabIndex = 10;
            this.bnt_dot.Text = ".";
            this.bnt_dot.UseVisualStyleBackColor = false;
            this.bnt_dot.Click += new System.EventHandler(this.bnt_dot_Click);
            // 
            // bnt_6
            // 
            this.bnt_6.BackColor = System.Drawing.Color.OldLace;
            this.bnt_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_6.Location = new System.Drawing.Point(109, 50);
            this.bnt_6.Name = "bnt_6";
            this.bnt_6.Size = new System.Drawing.Size(42, 23);
            this.bnt_6.TabIndex = 1;
            this.bnt_6.Text = "6";
            this.bnt_6.UseVisualStyleBackColor = false;
            this.bnt_6.Click += new System.EventHandler(this.Bnt_6Click);
            // 
            // bnt_0
            // 
            this.bnt_0.BackColor = System.Drawing.Color.OldLace;
            this.bnt_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_0.Location = new System.Drawing.Point(13, 107);
            this.bnt_0.Name = "bnt_0";
            this.bnt_0.Size = new System.Drawing.Size(42, 23);
            this.bnt_0.TabIndex = 9;
            this.bnt_0.Text = "0";
            this.bnt_0.UseVisualStyleBackColor = false;
            this.bnt_0.Click += new System.EventHandler(this.Bnt_0Click);
            // 
            // bnt_5
            // 
            this.bnt_5.BackColor = System.Drawing.Color.OldLace;
            this.bnt_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_5.Location = new System.Drawing.Point(61, 50);
            this.bnt_5.Name = "bnt_5";
            this.bnt_5.Size = new System.Drawing.Size(42, 23);
            this.bnt_5.TabIndex = 2;
            this.bnt_5.Text = "5";
            this.bnt_5.UseVisualStyleBackColor = false;
            this.bnt_5.Click += new System.EventHandler(this.Bnt_5Click);
            // 
            // bnt_1
            // 
            this.bnt_1.BackColor = System.Drawing.Color.OldLace;
            this.bnt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_1.Location = new System.Drawing.Point(13, 79);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(42, 23);
            this.bnt_1.TabIndex = 8;
            this.bnt_1.Text = "1";
            this.bnt_1.UseVisualStyleBackColor = false;
            this.bnt_1.Click += new System.EventHandler(this.Bnt_1Click);
            // 
            // bnt_8
            // 
            this.bnt_8.BackColor = System.Drawing.Color.OldLace;
            this.bnt_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_8.Location = new System.Drawing.Point(61, 21);
            this.bnt_8.Name = "bnt_8";
            this.bnt_8.Size = new System.Drawing.Size(42, 23);
            this.bnt_8.TabIndex = 3;
            this.bnt_8.Text = "8";
            this.bnt_8.UseVisualStyleBackColor = false;
            this.bnt_8.Click += new System.EventHandler(this.Bnt_8Click);
            // 
            // bnt_2
            // 
            this.bnt_2.BackColor = System.Drawing.Color.OldLace;
            this.bnt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_2.Location = new System.Drawing.Point(61, 79);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(42, 23);
            this.bnt_2.TabIndex = 7;
            this.bnt_2.Text = "2";
            this.bnt_2.UseVisualStyleBackColor = false;
            this.bnt_2.Click += new System.EventHandler(this.Bnt_2Click);
            // 
            // bnt_9
            // 
            this.bnt_9.BackColor = System.Drawing.Color.OldLace;
            this.bnt_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_9.Location = new System.Drawing.Point(109, 21);
            this.bnt_9.Name = "bnt_9";
            this.bnt_9.Size = new System.Drawing.Size(42, 23);
            this.bnt_9.TabIndex = 4;
            this.bnt_9.Text = "9";
            this.bnt_9.UseVisualStyleBackColor = false;
            this.bnt_9.Click += new System.EventHandler(this.Bnt_9Click);
            // 
            // bnt_3
            // 
            this.bnt_3.BackColor = System.Drawing.Color.OldLace;
            this.bnt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_3.Location = new System.Drawing.Point(109, 79);
            this.bnt_3.Name = "bnt_3";
            this.bnt_3.Size = new System.Drawing.Size(42, 23);
            this.bnt_3.TabIndex = 6;
            this.bnt_3.Text = "3";
            this.bnt_3.UseVisualStyleBackColor = false;
            this.bnt_3.Click += new System.EventHandler(this.Bnt_3Click);
            // 
            // bnt_4
            // 
            this.bnt_4.BackColor = System.Drawing.Color.OldLace;
            this.bnt_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_4.Location = new System.Drawing.Point(13, 50);
            this.bnt_4.Name = "bnt_4";
            this.bnt_4.Size = new System.Drawing.Size(42, 23);
            this.bnt_4.TabIndex = 5;
            this.bnt_4.Text = "4";
            this.bnt_4.UseVisualStyleBackColor = false;
            this.bnt_4.Click += new System.EventHandler(this.Bnt_4Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(51, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(185, 29);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "HP54502A GUI";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::HP54502A_GUI.Properties.Resources.Icon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::HP54502A_GUI.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(1003, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(15, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cb_vmarker);
            this.groupBox12.Controls.Add(this.lbl_vmarker);
            this.groupBox12.Controls.Add(this.cb_tmarker);
            this.groupBox12.Controls.Add(this.lbl_tmarker);
            this.groupBox12.Location = new System.Drawing.Point(12, 112);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(235, 81);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Marker";
            // 
            // lbl_tmarker
            // 
            this.lbl_tmarker.AutoSize = true;
            this.lbl_tmarker.Location = new System.Drawing.Point(5, 27);
            this.lbl_tmarker.Name = "lbl_tmarker";
            this.lbl_tmarker.Size = new System.Drawing.Size(63, 13);
            this.lbl_tmarker.TabIndex = 0;
            this.lbl_tmarker.Text = "TMARKER:";
            // 
            // cb_tmarker
            // 
            this.cb_tmarker.FormattingEnabled = true;
            this.cb_tmarker.Location = new System.Drawing.Point(74, 24);
            this.cb_tmarker.Name = "cb_tmarker";
            this.cb_tmarker.Size = new System.Drawing.Size(142, 21);
            this.cb_tmarker.TabIndex = 1;
            // 
            // lbl_vmarker
            // 
            this.lbl_vmarker.AutoSize = true;
            this.lbl_vmarker.Location = new System.Drawing.Point(5, 54);
            this.lbl_vmarker.Name = "lbl_vmarker";
            this.lbl_vmarker.Size = new System.Drawing.Size(63, 13);
            this.lbl_vmarker.TabIndex = 2;
            this.lbl_vmarker.Text = "VMARKER:";
            // 
            // cb_vmarker
            // 
            this.cb_vmarker.FormattingEnabled = true;
            this.cb_vmarker.Location = new System.Drawing.Point(74, 51);
            this.cb_vmarker.Name = "cb_vmarker";
            this.cb_vmarker.Size = new System.Drawing.Size(142, 21);
            this.cb_vmarker.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1038, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HP54502A_GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_connection;
        private System.Windows.Forms.Button bnt_connection;
        private System.Windows.Forms.Button bntAutoscale;
        private System.Windows.Forms.Button bnt_run_stop;
        private System.Windows.Forms.Button bnt_minus;
        private System.Windows.Forms.Button bnt_dot;
        private System.Windows.Forms.Button bnt_0;
        private System.Windows.Forms.Button bnt_1;
        private System.Windows.Forms.Button bnt_2;
        private System.Windows.Forms.Button bnt_3;
        private System.Windows.Forms.Button bnt_4;
        private System.Windows.Forms.Button bnt_9;
        private System.Windows.Forms.Button bnt_8;
        private System.Windows.Forms.Button bnt_5;
        private System.Windows.Forms.Button bnt_6;
        private System.Windows.Forms.Button bnt_7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_coup;
        private System.Windows.Forms.Label lbl_coup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_device;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_gpib;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_plot_line;
        private System.Windows.Forms.Button bnt_plot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_save_plot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bnt_send;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ser;
        private System.Windows.Forms.Button bnt_SN;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bnt_test;
        private System.Windows.Forms.Button bnt_cal;
        private System.Windows.Forms.ComboBox cb_screen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_save;
        private System.Windows.Forms.ComboBox cb_beeper;
        private System.Windows.Forms.Label lbl_beep;
        private System.Windows.Forms.Label lbl_recall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_menu;
        private System.Windows.Forms.ComboBox cb_save;
        private System.Windows.Forms.ComboBox cb_recall;
        private System.Windows.Forms.CheckBox ch_chan4;
        private System.Windows.Forms.CheckBox ch_chan3;
        private System.Windows.Forms.CheckBox ch_chan2;
        private System.Windows.Forms.CheckBox ch_chan1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bnt_clear;
        private System.Windows.Forms.ComboBox cb_graticule;
        private System.Windows.Forms.Label lbl_graticule;
        private System.Windows.Forms.Button bnt_shift;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button bnt_f7;
        private System.Windows.Forms.Button bnt_f6;
        private System.Windows.Forms.Button bnt_f5;
        private System.Windows.Forms.Button bnt_f4;
        private System.Windows.Forms.Button bnt_f3;
        private System.Windows.Forms.Button bnt_f2;
        private System.Windows.Forms.Button bnt_f1;
        private System.Windows.Forms.Button bnt_single;
        private System.Windows.Forms.Button bnt_local;
        private System.Windows.Forms.Button bnt_clear_key;
        private System.Windows.Forms.Button bnt_fine;
        private System.Windows.Forms.Button bnt_sV;
        private System.Windows.Forms.Button bnt_ms_mV;
        private System.Windows.Forms.Button bnt_microfs;
        private System.Windows.Forms.Button bnt_ns;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cb_coup_ch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ch4_value;
        private System.Windows.Forms.Label lbl_ch3_value;
        private System.Windows.Forms.Label lbl_ch2_value;
        private System.Windows.Forms.Label lbl_ch1_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_channel_meas;
        private System.Windows.Forms.Button bnt_volt;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bnt_frequenz;
        private System.Windows.Forms.Button bnt_meas_all;
        private System.Windows.Forms.Button bnt_rcl;
        private System.Windows.Forms.Button bnt_opc;
        private System.Windows.Forms.Button bnt_cls;
        private System.Windows.Forms.Button bnt_idn;
        private System.Windows.Forms.Button bnt_stb;
        private System.Windows.Forms.Button bnt_syst_err;
        private System.Windows.Forms.Button bnt_ese;
        private System.Windows.Forms.Button bnt_ser;
        private System.Windows.Forms.Button bnt_tst;
        private System.Windows.Forms.Button bnt_trg;
        private System.Windows.Forms.Button bnt_sav;
        private System.Windows.Forms.Button bnt_rst;
        private System.Windows.Forms.Button bnt_wai;
        private System.Windows.Forms.Button bnt_sre;
        private System.Windows.Forms.Button bnt_prt;
        private System.Windows.Forms.Button bnt_lrn;
        private System.Windows.Forms.Button bnt_ist;
        private System.Windows.Forms.Button bnt_esr;
        private System.Windows.Forms.ComboBox cb_zoom;
        private System.Windows.Forms.Label lbl_zoom;
        private System.Windows.Forms.ComboBox cb_plot_grat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox cb_tmarker;
        private System.Windows.Forms.Label lbl_tmarker;
        private System.Windows.Forms.ComboBox cb_vmarker;
        private System.Windows.Forms.Label lbl_vmarker;
    }
}
