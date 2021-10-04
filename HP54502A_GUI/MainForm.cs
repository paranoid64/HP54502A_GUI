/*
 * Created by SharpDevelop.
 * User: mlausch
 * Date: 06.02.2021
 * Time: 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

//:CHAN1:RANG 5V;*OPC?

//Anzahl der punkte
//COMMAND >:WAV: POINTS ?; *OPC ?
//RESULT :> 500



//Overshoot
//:MEAS:OVER?

//:MEAS:PER?


//COMMAND >:MEAS:SOUR CHAN2
//NO RETURN!

//COMMAND >:MEAS:CURSOR? START
//RESULT:> -4.00000E-04,-1.50000E+00
//time ,voltage




namespace HP54502A_GUI {
	public partial class MainForm : Form {
		private Ivi.Visa.Interop.ResourceManager rm;
		private Ivi.Visa.Interop.IMessage msg;
		private string connection = "";
		private Bitmap DrawPlot;
		public Point downPoint = Point.Empty;
		private readonly int plot_h = 326;
		private readonly int plot_w = 500;
		private int plot_z = 1;

		protected override void OnLoad(EventArgs e) {
			if (FormBorderStyle == FormBorderStyle.None) {
				MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
				MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
				MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
			}
			base.OnLoad(e);
		}

		private void AppFormBase_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left)
				downPoint = new Point(e.X, e.Y);
		}
		private void AppFormBase_MouseMove(object sender, MouseEventArgs e) {
			if (downPoint != Point.Empty)
				Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
		}
		private void AppFormBase_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left)
				downPoint = Point.Empty;
		}

		protected override void OnPaint(PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
		}

		void find_instr() {
			try {
				rm = new Ivi.Visa.Interop.ResourceManager();
				string[] adrsList = rm.FindRsrc("?*::INSTR");
				foreach (string s in adrsList) {
					cb_connection.Items.Add(s);
				}
			}
			catch (Exception e) {
				Log.Filelog(e.Message);
			}
		}

		void devlock() {
			if (msg != null) {
				msg.LockRsrc(Ivi.Visa.Interop.AccessMode.EXCLUSIVE_LOCK, 2000, "");
			}
		}

		void devunlock() {
			if (msg != null) {
				msg.UnlockRsrc();
			}
		}

		void Plot_Channel(string ch) {
			initHPBI();
			if (msg != null) {
				msg.Clear();

				msg.WriteString(":ACQ:TYPE NORMAL;COUN 1;POIN 500;*OPC?");
				Log.Screenlog(":ACQ: TYPE NORMAL; COUN 1;POIN 500; *OPC ?", true);
				Thread.Sleep(100);
				Log.Screenlog(msg.ReadString(256), false);

				msg.WriteString(":DIG " + ch + ";*OPC?");
				Log.Screenlog(":DIG " + ch + ";*OPC?", true);
				Thread.Sleep(100);
				Log.Screenlog(msg.ReadString(256), false);

				msg.WriteString("WAV:PRE?");
				Log.Screenlog("WAV:PRE?", true);
				Thread.Sleep(100);
				Log.Screenlog(msg.ReadString(256), false);

				msg.WriteString(":SYST:HEAD OFF;:EOI ON;*OPC?");
				Log.Screenlog(":SYST:HEAD OFF;:EOI ON;*OPC?", true);
				Thread.Sleep(100);
				Log.Screenlog(msg.ReadString(256), false);


				//T/VMARKER LINE
				msg.WriteString(":DISP:VMAR?");
				Log.Screenlog(":DISP:VMAR?", true);
				Thread.Sleep(100);
				string vmar = msg.ReadString(10);
				Log.Screenlog(vmar, false);
				vmar = vmar.Replace(System.Environment.NewLine, "");

				msg.WriteString(":DISP:TMAR?");
				Log.Screenlog(":DISP:TMAR?", true);
				Thread.Sleep(100);
				string tmar = msg.ReadString(10);
				Log.Screenlog(tmar, false);
				tmar = tmar.Replace(System.Environment.NewLine, "");

				msg.WriteString(":MEAS:SOUR " + ch);
				Log.Screenlog(":MEAS:SOUR " + ch, true);
				Thread.Sleep(100);
				
				
				
				if (int.Parse(vmar) == 1 && int.Parse(tmar) == 1) {

					//COMMAND >:MEAS:CURSOR? START
					//RESULT:> -4.00000E-04,-1.50000E+00
					//time ,voltage

					// RESULT:>-4.00000E-04   =  -400.000us 
					try {
						msg.WriteString(":MEAS:CURSOR? START");
						Log.Screenlog(":MEAS:CURSOR? START", true);
						Thread.Sleep(100);
						String val = msg.ReadString(256);
						Log.Screenlog(val, false);

						string[] subs = Regex.Split(val, ",");
						//MessageBox.Show(HPIB.dec(subs[0], 1000000, "us").ToString());
						//MessageBox.Show(HPIB.dec(subs[1], 0, "V").ToString());

						MessageBox.Show(HPIB.Volt(subs[1]));

					} catch (Exception ex) {
						Log.Screenlog("MEAS:CURSOR: "+ex.Message, false);
					}


				}


				msg.WriteString(":WAV:SOUR " + ch + ";FORM ASCII;*OPC?");
				Log.Screenlog(":WAV:SOUR " + ch + ";FORM ASCII;*OPC?", true);
				Thread.Sleep(100);
				Log.Screenlog(msg.ReadString(256), false);

				msg.WriteString(":WAV:DATA?");
				Log.Screenlog(":WAV:DATA?", true);
				Thread.Sleep(100);

				string s = msg.ReadString(5000);
				s = s.Replace(System.Environment.NewLine, "");
				Log.Screenlog(s, false);

				string[] points = Regex.Split(s, ",");
				int len, lastx = 0, lasty = 0;

				len = points.Length;
				//s = cb_plot_line.SelectedItem.ToString();

				for (int i = 0; i < len; i++) {
					int y = int.Parse(points[i]) / 100;

					if (lastx == 0 && lasty == 0) {
						Log.Screenlog(y.ToString(), false);
						lastx = i;
						lasty = y;
					}

					if (string.IsNullOrEmpty(cb_plot_line.Text) == false) {
						if (cb_plot_line.SelectedItem.ToString() == "Dots") {
							try {
								pictureBox1.Image = PlotGrapics.Plot(DrawPlot, i, y, plot_h, ch, plot_z);
							} catch (Exception ex) {
								Log.Filelog("PLOT DOT:" + ex.Message);
							}
						}
						else {
							pictureBox1.Image = PlotGrapics.Plot_Line(DrawPlot, i, y, lasty, lastx, plot_h, ch, plot_z);
							lastx = i;
							lasty = y;
						}
					}


				}
			}
			HPIB_close();
		}

		void plot_data() {
			if (ch_chan1.Checked) {
				Plot_Channel("CHAN1");
			}
			if (ch_chan2.Checked) {
				Plot_Channel("CHAN2");
			}
			if (ch_chan3.Checked) {
				Plot_Channel("CHAN3");
			}
			if (ch_chan4.Checked) {
				Plot_Channel("CHAN4");
			}
		}

		void Clear_Meas(string ch) {
			switch (ch) {
				case "CHAN1":
					lbl_ch1_value.Text = "";
					break;
				case "CHAN2":
					lbl_ch2_value.Text = "";
					break;
				case "CHAN3":
					lbl_ch3_value.Text = "";
					break;
				case "CHAN4":
					lbl_ch4_value.Text = "";
					break;
			}
		}

		void Add_Meas_Value(string ch, string v, string type) { // Type VPP, VMIN, VMAX ,...

			if (v == "+9.99999E+37\n") {
				MessageBox.Show("Messung " + type + " auf " + ch + " ungültig (+9.99999E+37)");
			}
			else {

				v = v.Replace(System.Environment.NewLine, "");
				switch (type) {
					case "VPP":
					case "VMIN":
					case "VMAX":
						v = type + ": " + HPIB.dec(v, 1000, "mV").ToString() + " mV ";
						//MessageBox.Show(HPIB.Volt(v));
						break;
					case "FREQ":
						v = type + ": " + HPIB.dec(v, 0, "Hz").ToString() + " Hz ";
						break;
				}

				switch (ch) {
					case "CHAN1":
						lbl_ch1_value.Text += v;
						break;
					case "CHAN2":
						lbl_ch2_value.Text += v;
						break;
					case "CHAN3":
						lbl_ch3_value.Text += v;
						break;
					case "CHAN4":
						lbl_ch4_value.Text += v;
						break;
				}
			}
		}

		void Meas(string meas) {

			try {
				initHPBI();
				if (msg != null) {
					msg.Clear();

					string ch = null, rd;

					if (string.IsNullOrEmpty(cb_channel_meas.Text) == false) {
						ch = cb_channel_meas.SelectedItem.ToString();
						Clear_Meas(ch);
						msg.WriteString(":MEAS:SOURCE " + ch + ";*OPC?");
						Log.Screenlog(":MEAS:SOURCE " + ch + ";*OPC?", true);
						Thread.Sleep(100);
						Log.Screenlog(msg.ReadString(256), false);
					}

					if (meas == "VOLT" || meas == "ALL") {

						msg.WriteString(":SYST:HEAD OFF;*OPC?");
						Log.Screenlog(":SYST:HEAD OFF;*OPC?", true);
						Thread.Sleep(100);
						Log.Screenlog(msg.ReadString(256), false);

						msg.WriteString(":DISP:TMAR?");
						Log.Screenlog(":DISP:TMAR?", true);
						rd = msg.ReadString(6);
						if (rd != "1\n") {
							msg.WriteString(":DISP:TMAR ON");
							Log.Screenlog(":DISP:TMAR ON", true);
						}

						devlock();
						msg.WriteString(":MEAS:VPP?");
						Log.Screenlog(":MEAS:VPP?", true);
						devunlock();
						rd = msg.ReadString(256);
						Log.Screenlog(rd, false);
						Add_Meas_Value(ch, rd, "VPP");

						devlock();
						msg.WriteString(":MEAS:VMIN?");
						Log.Screenlog(":MEAS:VMIN?", true);
						devunlock();
						rd = msg.ReadString(256);
						Log.Screenlog(rd, false);
						Add_Meas_Value(ch, rd, "VMIN");

						devlock();
						msg.WriteString(":MEAS:VMAX?");
						Log.Screenlog(":MEAS:VMAX?", true);
						devunlock();
						rd = msg.ReadString(256);
						Log.Screenlog(rd, false);
						Add_Meas_Value(ch, rd, "VMAX");
					}

					if (meas == "FREQ" || meas == "ALL") {
						devlock();
						msg.WriteString(":MEAS:FREQ?");
						Log.Screenlog(":MEAS:FREQ?", true);
						devunlock();
						rd = msg.ReadString(256);
						Log.Screenlog(rd, false);
						Add_Meas_Value(ch, rd, "FREQ");
					}

				}
				HPIB_close();
			}
			catch (Exception ex) {
				Log.Filelog("MEAS:" + ex.Message);
				Log.Screenlog("MEAS:" + ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

		void initHPBI() {
			try {
				rm = new Ivi.Visa.Interop.ResourceManager();

				Ivi.Visa.Interop.IVisaSession vi;
				vi = rm.Open(connection, Ivi.Visa.Interop.AccessMode.NO_LOCK, 2000, "");
				msg = (Ivi.Visa.Interop.IMessage)vi;

				//Ivi.Visa.Interop.IEventManager evm;
				//evm = (Ivi.Visa.Interop.IEventManager)msg;
				//evm.MaximumQueueLength= 16;
				//evm.DisableEvent(Ivi.Visa.Interop.EventType.EVENT_SERVICE_REQ, Ivi.Visa.Interop.EventMechanism.EVENT_HNDLR, 0);

				msg.TerminationCharacter = 10;// Char 13 CR, 10 LF
				msg.TerminationCharacterEnabled = true;
				msg.SendEndEnabled = true;

				Ivi.Visa.Interop.IGpib gpib;
				Ivi.Visa.Interop.ISerial seri;
				Ivi.Visa.Interop.ITcpipInstr tcp;
				Ivi.Visa.Interop.IUsb usb;

				switch (msg.HardwareInterfaceType) {
					case 1://GPIB
						gpib = (Ivi.Visa.Interop.IGpib)msg;
						gpib.RepeatAddressingEnabled = true;
						gpib.UnaddressingEnabled = false;
						gpib.Timeout = 10000;
						if (lbl_gpib.Text.Length <= 0) {
							Log.Screenlog(gpib.HardwareInterfaceName + "\n" + gpib.HardwareInterfaceNumber, false);
							Log.Screenlog(gpib.SoftwareManufacturerName + "\n" + gpib.ResourceName, false);
							lbl_gpib.Text = gpib.HardwareInterfaceName + " " + gpib.SoftwareManufacturerName;
						}

						if (lbl_hp.Text.Length > 0) {
							pic_status.BackColor = Color.Green;
						}
						else {
							pic_status.BackColor = Color.LightGoldenrodYellow;
						}
						break;
					case 4://ASRL
						seri = (Ivi.Visa.Interop.ISerial)msg;
						seri.BaudRate = 19200;
						seri.DataBits = 8;
						seri.StopBits = Ivi.Visa.Interop.SerialStopBits.ASRL_STOP_TWO;
						seri.Parity = Ivi.Visa.Interop.SerialParity.ASRL_PAR_NONE;
						seri.FlowControl = Ivi.Visa.Interop.SerialFlowControl.ASRL_FLOW_XON_XOFF;
						break;
					case 6://LAN
						tcp = (Ivi.Visa.Interop.ITcpipInstr)msg;
						break;
					case 7://USB
						usb = (Ivi.Visa.Interop.IUsb)msg;
						break;
				}
			}
			catch (Exception e) {
				Log.Filelog("INIT:" + e.Message);
				Log.Screenlog("INIT:" + e.Message, false);
				pic_status.BackColor = Color.Red;
			}

		}

		/// <summary>
		/// stellt Verbindung her und Sendet ein befehl ab.
		/// </summary>
		void Command(string com, bool nl) {
			try {
				initHPBI();

				if (msg != null) {
					msg.Clear();
					msg.WriteString("*CLS");
					//msg.Timeout = 20000;
					msg.WriteString(com);
					Log.Screenlog(com, true);
					Thread.Sleep(100);
					Log.Screenlog(msg.ReadString(50), false);
				}

				HPIB_close();
			}
			catch (Exception e) {
				Log.Filelog("COMMAND:" + e.Message);
				Log.Screenlog("COMMAND:" + e.Message, false);
			}
		}

		private void HPIB_close() {
			try {
				if (msg != null) {
					msg.Close();
					msg = null;
				}
			}
			catch (Exception e) {
				Log.Filelog(e.Message);
				Log.Screenlog(e.Message, false);
			}

			try {
				if (msg != null) {
					System.Runtime.InteropServices.Marshal.ReleaseComObject(msg);
				}
			}
			catch (Exception e) {
				Log.Filelog(e.Message);
				Log.Screenlog(e.Message, false);
			}

			try {
				if (rm != null) {
					System.Runtime.InteropServices.Marshal.ReleaseComObject(rm);
				}
			}
			catch (Exception e) {
				Log.Filelog(e.Message);
				Log.Screenlog(e.Message, false);
			}
		}

		public string MSG {
			get { return richTextBox1.Text.ToString(); }
			set {
				richTextBox1.Text = value;

				if (richTextBox1.Lines.Length > 500) {
					richTextBox1.ReadOnly = false;
					richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(1));
					richTextBox1.SelectedText = "";
					richTextBox1.ReadOnly = true;
				}
				richTextBox1.SelectionStart = richTextBox1.Text.Length;
				richTextBox1.ScrollToCaret();
			}
		}

		public static MainForm _Form1;
		public MainForm() {
			InitializeComponent();

			_Form1 = this;

			lbl_gpib.Text = "";
			lbl_hp.Text = "";

			lbl_ch1_value.Text = "";
			lbl_ch2_value.Text = "";
			lbl_ch3_value.Text = "";
			lbl_ch4_value.Text = "";

			tabPage1.Text = "Plot";
			tabPage2.Text = "Console";
			tabPage3.Text = "Option";

			//CB_RECALL Fill DropDown Values
			for (int i = 0; i < 5; i++) {
				if (i == 0) {
					cb_recall.Items.Add("");
				}
				else {
					cb_recall.Items.Add(i);
				}
			}
			cb_recall.DropDownStyle = ComboBoxStyle.DropDownList;

			//CB_SAVE Fill DropDown Values
			for (int i = 0; i < 5; i++) {
				if (i == 0) {
					cb_save.Items.Add("");
				}
				else {
					cb_save.Items.Add(i);
				}
			}
			cb_save.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_tmarker.Items.Add("");
			cb_tmarker.Items.Add("ON");
			cb_tmarker.Items.Add("OFF");
			cb_tmarker.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_vmarker.Items.Add("");
			cb_vmarker.Items.Add("ON");
			cb_vmarker.Items.Add("OFF");
			cb_vmarker.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_graticule.Items.Add("");
			cb_graticule.Items.Add("OFF");
			cb_graticule.Items.Add("GRID");
			cb_graticule.Items.Add("AXES");
			cb_graticule.Items.Add("FRAME");
			cb_graticule.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_menu.Items.Add("");
			cb_menu.Items.Add("MENU");
			cb_menu.Items.Add("TIMEBASE");
			cb_menu.Items.Add("CHAN");
			cb_menu.Items.Add("TRIGER");
			cb_menu.Items.Add("DISPLAY");
			cb_menu.Items.Add("DELTA");
			cb_menu.Items.Add("WFORM");
			cb_menu.Items.Add("SAVE");
			cb_menu.Items.Add("MEASURE");
			cb_menu.Items.Add("UTILITY");
			cb_menu.Items.Add("SHOW");
			cb_menu.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_beeper.Items.Add("");
			cb_beeper.Items.Add("Beeper");
			cb_beeper.Items.Add("Beeper ON");
			cb_beeper.Items.Add("Beeper OFF");
			cb_beeper.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_screen.Items.Add("");
			cb_screen.Items.Add("SCREEN");
			cb_screen.Items.Add("SCREEN ON");
			cb_screen.Items.Add("SCREEN OFF");
			cb_screen.Items.Add("TEXT BLANK");
			cb_screen.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_coup.Items.Add("DC");
			cb_coup.Items.Add("AC");
			cb_coup.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_channel_meas.Items.Add("CHAN1");
			cb_channel_meas.Items.Add("CHAN2");
			cb_channel_meas.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_coup_ch.Items.Add("CHAN1");
			cb_coup_ch.Items.Add("CHAN2");
			cb_coup_ch.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_channel_meas.SelectedIndex = 0;
			cb_coup_ch.SelectedIndex = 0;

			ch_chan3.Enabled = false;
			ch_chan4.Enabled = false;

			cb_plot_line.Items.Add("Dots");
			cb_plot_line.Items.Add("Lines");
			cb_plot_line.SelectedIndex = 1;
			cb_plot_line.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_zoom.Items.Add("1x");
			cb_zoom.Items.Add("2x");
			cb_zoom.Items.Add("3x");
			cb_zoom.Items.Add("4x");
			cb_zoom.SelectedIndex = 0;
			cb_zoom.DropDownStyle = ComboBoxStyle.DropDownList;

			cb_plot_grat.Items.Add("");
			cb_plot_grat.Items.Add("GRID");
			cb_plot_grat.Items.Add("AXES");
			cb_plot_grat.SelectedIndex = 1;
			cb_plot_grat.DropDownStyle = ComboBoxStyle.DropDownList;

			this.cb_beeper.SelectedIndexChanged += new System.EventHandler(cb_beeper_SelectedIndexChanged);
			this.cb_menu.SelectedIndexChanged += new System.EventHandler(cb_menu_SelectedIndexChanged);
			this.cb_recall.SelectedIndexChanged += new System.EventHandler(cb_recall_SelectedIndexChanged);
			this.cb_save.SelectedIndexChanged += new System.EventHandler(cb_save_SelectedIndexChanged);
			this.cb_screen.SelectedIndexChanged += new System.EventHandler(cb_screen_SelectedIndexChanged);
			this.cb_graticule.SelectedIndexChanged += new System.EventHandler(cb_graticule_SelectedIndexChanged);
			this.cb_coup.SelectedIndexChanged += new System.EventHandler(cb_coup_SelectedIndexChanged);
			this.cb_tmarker.SelectedIndexChanged += new System.EventHandler(cb_tmarker_SelectedIndexChanged);
			this.cb_vmarker.SelectedIndexChanged += new System.EventHandler(cb_vmarker_SelectedIndexChanged);

			this.bnt_0.Click += new System.EventHandler(this.Bnt_0Click);
			this.bnt_1.Click += new System.EventHandler(this.Bnt_1Click);
			this.bnt_2.Click += new System.EventHandler(this.Bnt_2Click);
			this.bnt_3.Click += new System.EventHandler(this.Bnt_3Click);
			this.bnt_4.Click += new System.EventHandler(this.Bnt_4Click);
			this.bnt_5.Click += new System.EventHandler(this.Bnt_5Click);
			this.bnt_6.Click += new System.EventHandler(this.Bnt_6Click);
			this.bnt_7.Click += new System.EventHandler(this.Bnt_7Click);
			this.bnt_8.Click += new System.EventHandler(this.Bnt_8Click);
			this.bnt_9.Click += new System.EventHandler(this.Bnt_9Click);

			DrawPlot = new Bitmap(plot_w * plot_z, plot_h * plot_z);
			pictureBox1.Image = DrawPlot;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			richTextBox1.ReadOnly = true;
			find_instr();
		}

		void cb_coup_SelectedIndexChanged(object sender, System.EventArgs e) {

			try {
				if (msg != null) {
					if (string.IsNullOrEmpty(cb_coup.Text) == false || string.IsNullOrEmpty(cb_coup_ch.Text) == false) {
						string s = cb_coup.SelectedItem.ToString();
						string c = cb_coup_ch.SelectedItem.ToString();

						initHPBI();
						msg.WriteString(":" + c + ":COUP " + s);
						Log.Screenlog(":" + c + ":COUP " + s, true);
						HPIB_close();
					}
				}
				else {
					pic_status.BackColor = Color.Red;
				}
			} catch (Exception ex) {
				Log.Filelog("COUP:" + ex.Message);
			}
		}

		void cb_beeper_SelectedIndexChanged(object sender, System.EventArgs e) {
			string s = cb_beeper.SelectedItem.ToString();
			switch (s) {
				case "":
					break;
				case "Beeper":
					Command("Beep?", true);
					break;
				case "Beeper ON":
					Command(":BEEP 1;*OPC?", true);
					break;
				case "Beeper OFF":
					Command(":BEEP 0;*OPC?", true);
					break;
			}
		}

		void cb_tmarker_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (string.IsNullOrEmpty(cb_tmarker.Text) == false) {
				string s = cb_tmarker.SelectedItem.ToString();
				Command(":DISP:TMAR " + s + ";*OPC?", true);
			}
		}

		void cb_vmarker_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (string.IsNullOrEmpty(cb_vmarker.Text) == false) {
				string s = cb_vmarker.SelectedItem.ToString();
				Command(":DISP:vMAR " + s + ";*OPC?", true);
			}
		}



		void cb_recall_SelectedIndexChanged(object sender, System.EventArgs e){
			if (string.IsNullOrEmpty(cb_recall.Text) == false){
				string s = cb_recall.SelectedItem.ToString();
				Command("*RCL " + s + ";*OPC?", true);
			}
		}

		void cb_save_SelectedIndexChanged(object sender, System.EventArgs e){
			if (string.IsNullOrEmpty(cb_save.Text) == false){
				string s = cb_save.SelectedItem.ToString();
				Command("*SAV " + s + ";*OPC?", true);
			}
		}

		void cb_screen_SelectedIndexChanged(object sender, System.EventArgs e){
			try {
				if (string.IsNullOrEmpty(cb_screen.Text) == false) {
					string s = cb_screen.SelectedItem.ToString();
					switch (s) {
						case "":
							break;
						case "SCREEN":
							Command(":DISP:SCR?", true);
							break;
						case "SCREEN ON":
							Command(":DISP:SCR 1;*OPC?", true);
							break;
						case "SCREEN OFF":
							Command(":DISP:SCR 0;*OPC?", true);
							break;
						case "TEXT BLANK":
							Command(":DISP:TEXT BLAN;*OPC?", true);
							break;
					}
				}
			} catch (Exception ex){
				Log.Filelog(ex.Message);
				Log.Screenlog(ex.Message, false);
			}
		}

		void cb_graticule_SelectedIndexChanged(object sender, System.EventArgs e){
			try{
				string s = cb_graticule.SelectedItem.ToString();
				switch (s) {
					case "":
						//nichts
						break;
					case "OFF":
						Command(":DISP:GRAT OFF;*OPC?", true);
						break;
					case "GRID":
						Command(":DISP:GRAT GRID;*OPC?", true);
						break;
					case "AXES":
						Command(":DISP:GRAT AXES;*OPC?", true);
						break;
					case "FRAME":
						Command(":DISP:GRAT FRAME;*OPC?", true);
						break;
				}
			} catch (Exception ex) {
				Log.Filelog(ex.Message);
				Log.Screenlog(ex.Message, false);
			}
		}

		void cb_menu_SelectedIndexChanged(object sender, System.EventArgs e) {
			string s = cb_menu.SelectedItem.ToString();
			switch (s) {
				case "":
					//nichts
					break;
				case "TIMEBASE":
					Command(":MENU TIM;*OPC?", true);
					break;
				case "CHAN":
					Command(":MENU CHAN;*OPC?", true);
					break;
				case "TRIGER":
					Command(":MENU TRIG;*OPC?", true);
					break;
				case "DISPLAY":
					Command(":MENU DISP;*OPC?", true);
					break;
				case "DELTA":
					Command(":MENU DELT;*OPC?", true);
					break;
				case "WFORM":
					Command(":MENU MATH;*OPC?", true);
					break;
				case "MEASURE":
					Command(":MENU MEAS;*OPC?", true);
					break;
				case "SAVE":
					Command(":MENU SAVE;*OPC?", true);
					break;
				case "UTILITY":
					Command(":MENU UTIL;*OPC?", true);
					break;
				case "SHOW":
					Command(":MENU SHOW;*OPC?", true);
					break;
				default:
					Command(":MENU?", true);
					break;
			}
		}

		void Bnt_0Click(object sender, EventArgs e) {
			Command(":SYST:KEY 26;*OPC?", true);
		}

		void Bnt_1Click(object sender, EventArgs e) {
			Command(":SYST:KEY 27;*OPC?", true);
		}

		void Bnt_2Click(object sender, EventArgs e) {
			Command(":SYST:KEY 28;*OPC?", true);
		}

		void Bnt_3Click(object sender, EventArgs e) {
			Command(":SYST:KEY 29;*OPC?", true);
		}

		void Bnt_4Click(object sender, EventArgs e) {
			Command(":SYST:KEY 30;*OPC?", true);
		}

		void Bnt_5Click(object sender, EventArgs e) {
			Command(":SYST:KEY 31;*OPC?", true);
		}

		void Bnt_6Click(object sender, EventArgs e) {
			Command(":SYST:KEY 32;*OPC?", true);
		}

		void Bnt_7Click(object sender, EventArgs e) {
			Command(":SYST:KEY 33;*OPC?", true);
		}

		void Bnt_8Click(object sender, EventArgs e) {
			Command(":SYST:KEY 34;*OPC?", true);
		}

		void Bnt_9Click(object sender, EventArgs e) {
			Command(":SYST:KEY 35;*OPC?", true);
		}

		void Bnt_sendClick(object sender, EventArgs e) {
			string s = txt_com.Text;
			if (string.IsNullOrEmpty(s) == false) {
				Command(s, true);
			}
		}

		void Bnt_testClick(object sender, EventArgs e) {
			Command("*TST?;*OPC?", true);
		}

		void BntAutoscaleClick(object sender, EventArgs e) {
			Command(":AUT;*OPC?", true);
		}

		void Bnt_calClick(object sender, EventArgs e) {
			Command(":CAL:TNULL 1,2;*OPC?", true);
		}

		private void Bnt_SN_Click(object sender, EventArgs e){
			string s = txt_ser.Text;
			if (string.IsNullOrEmpty(s) == false){
				Command(":SER" + "\"" + s + "\";*OPC?", true);
			}
		}

        private void bnt_dot_Click(object sender, EventArgs e){
			Command(":SYST:KEY 25;*OPC?", true);
		}

        private void bnt_minus_Click(object sender, EventArgs e){
			Command(":SYST:KEY 24;*OPC?", true);
		}

        private void bnt_run_stop_Click(object sender, EventArgs e) {
			Command(":SYST:KEY 36;*OPC?", true);
		}

		private void bnt_shift_Click(object sender, EventArgs e){
			Command(":SYST:KEY 23;*OPC?", true);
		}

		private void bnt_f1_Click(object sender, EventArgs e){
			Command(":SYST:KEY 10;*OPC?", true);
		}

		private void bnt_f2_Click(object sender, EventArgs e){
			Command(":SYST:KEY 11;*OPC?", true);
		}

		private void bnt_f3_Click(object sender, EventArgs e){
			Command(":SYST:KEY 12;*OPC?", true);
		}

		private void bnt_f4_Click(object sender, EventArgs e){
			Command(":SYST:KEY 13;*OPC?", true);
		}

		private void bnt_f5_Click(object sender, EventArgs e){
			Command(":SYST:KEY 14;*OPC?", true);
		}

		private void bnt_f6_Click(object sender, EventArgs e){
			Command(":SYST:KEY 15;*OPC?", true);
		}

		private void bnt_f7_Click(object sender, EventArgs e){
			Command(":SYST:KEY 16;*OPC?", true);
		}

		private void bnt_single_Click(object sender, EventArgs e){
			Command(":SYST:KEY 37;*OPC?", true);
		}

		private void bnt_local_Click(object sender, EventArgs e){
			Command(":SYST:KEY 39;*OPC?", true);
		}

		private void bnt_clear_key_Click(object sender, EventArgs e){
			Command(":SYST:KEY 22;*OPC?", true);
		}

		private void bnt_fine_Click(object sender, EventArgs e){
			Command(":SYST:KEY 17;*OPC?", true);
		}

		private void bnt_connection_Click(object sender, EventArgs e) {
			try{
				if (string.IsNullOrEmpty(cb_connection.Text) == false){
					string s = cb_connection.SelectedItem.ToString();
					connection = s;

					initHPBI();
					if (msg != null){

						msg.WriteString("*RST;*OPC?");
						Log.Screenlog("*RST;*OPC?", true);

						msg.WriteString("*IDN?");
						Log.Screenlog("*IDN?", true);

						s = msg.ReadString(256);
						Log.Screenlog(s, false);

						if (s.Length > 0) {
							String[] t = s.Split(',');
							string device = t[1];

							switch (device) {
								case "54502A": //2 CH
								case "54510A": //2 CH
									Log.Screenlog("found 2CH device "+device, false);
									break;
								default:
								case "54501A": //4 CH
								case "54503A":
									Log.Screenlog("found 4CH device " + device, false);
									cb_channel_meas.Items.Add("CHAN1");
									cb_channel_meas.Items.Add("CHAN2");
									cb_coup_ch.Items.Add("CHAN2");
									cb_coup_ch.Items.Add("CHAN2");
									ch_chan3.Enabled = true;
									ch_chan4.Enabled = true;
									break;
							}
							pic_status.BackColor = Color.Green;
							lbl_hp.Text = s;
						}
						
					}
					HPIB_close();
				}
				else {
					pic_status.BackColor = Color.Red;
				}
			}
			catch (Exception ex){
				Log.Filelog("CONNECT:"+ex.Message);
				Log.Screenlog("CONNECT:" + ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

        private void bnt_save_plot_Click(object sender, EventArgs e) {
			try{
				SaveFileDialog SD1 = new SaveFileDialog();
				SD1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
				SD1.RestoreDirectory = true;
				SD1.Title = "Plot Speichern";
				SD1.DefaultExt = "png";
				SD1.FileName = "plot.png";
				SD1.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp";
				SD1.FilterIndex = 1;
				SD1.CheckPathExists = true;

				if (SD1.ShowDialog() == DialogResult.OK){
					try{
						switch (SD1.FilterIndex){
							case 1:
								DrawPlot.Save(SD1.FileName, System.Drawing.Imaging.ImageFormat.Png);
								break;
							case 2:
								DrawPlot.Save(SD1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
								break;
							case 3:
								DrawPlot.Save(SD1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
								break;
						}
						Log.Screenlog("SAVE" + SD1.FileName.ToString(), true);
					}
					catch (Exception ex){
						Log.Filelog("HARDCOPY SAVE:" + ex.Message);
						Log.Screenlog(ex.Message, false);
						pic_status.BackColor = Color.Red;
					}
				}
			}
			catch (Exception ex){
				Log.Filelog("HARDCOPY SAVE:"+ex.Message);
				Log.Screenlog(ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

        private void bnt_plot_Click(object sender, EventArgs e){
			try {
				if (string.IsNullOrEmpty(cb_zoom.Text) == false) {
					string s = Regex.Match(cb_zoom.SelectedItem.ToString(), @"\d+").Value;//2x zu 2
					plot_z = int.Parse(s);
					DrawPlot = new Bitmap(plot_w * plot_z, plot_h * plot_z);
					DrawPlot = PlotGrapics.ClearImage(DrawPlot);
					DrawPlot = PlotGrapics.Draw_grid(DrawPlot, plot_w, plot_h, plot_z, cb_plot_grat.Text);
					plot_data();
				}
            } catch (Exception ex){
				Log.Filelog("HARDCOPY:" + ex.Message);
				Log.Screenlog("HARDCOPY:" + ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

        private void pictureBox2_Click(object sender, EventArgs e){
			if (MessageBox.Show("Wollen Sie das Programm beenden?", this.lbl_title.Text, MessageBoxButtons.YesNo) == DialogResult.Yes){
				Application.Exit();
			}
		}

        private void MainForm_Load(object sender, EventArgs e){
			DrawPlot = PlotGrapics.Draw_grid(DrawPlot, plot_w, plot_h,plot_z,cb_plot_grat.Text);
			pictureBox1.Image = DrawPlot;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

        private void bnt_clear_Click(object sender, EventArgs e){
			try {
				initHPBI();
				if (msg != null){
					msg.Clear();
					msg.WriteString("*CLS;*OPC?");
					Log.Screenlog("*CLS;*OPC?", false);
					Log.Screenlog(msg.ReadString(10), false);
				}
				HPIB_close();
			}
			catch (Exception ex){
				Log.Filelog("CLEAR:"+ex.Message);
				Log.Screenlog("CLEAR:"+ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

        private void bnt_sV_Click(object sender, EventArgs e) {
			Command(":SYST:KEY 18;*OPC?", true);
		}

        private void bnt_ms_mV_Click(object sender, EventArgs e) {
			Command(":SYST:KEY 19;*OPC?", true);
		}

        private void bnt_microfs_Click(object sender, EventArgs e) {
			Command(":SYST:KEY 20;*OPC?", true);
		}

        private void bnt_ns_Click(object sender, EventArgs e) {
			Command(":SYST:KEY 21;*OPC?", true);
		}

        private void bnt_frequenz_Click(object sender, EventArgs e) {
			Meas("FREQ");
		}

        private void bnt_volt_Click(object sender, EventArgs e) {
			Meas("VOLT");
		}

        private void bnt_meas_all_Click(object sender, EventArgs e) {
			Meas("ALL");
		}

        private void bnt_rcl_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*RCL");
		}

        private void bnt_opc_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*OPC ?");
		}

        private void bnt_cls_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*CLS");
		}

        private void bnt_idn_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*IDN?");
		}

        private void bnt_stb_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*STB?");
		}

        private void bnt_syst_err_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "SYST:ERR?");
		}

        private void bnt_rst_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*RST");
		}

        private void bnt_sav_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*SAV");
		}

        private void bnt_trg_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*TRG");
		}

        private void bnt_tst_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*TST?");
		}

        private void bnt_ser_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, ":SER");
		}

        private void bnt_ese_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*ESE");
		}

        private void bnt_esr_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*ESR?");
		}

        private void bnt_ist_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*IST?");
		}

        private void bnt_lrn_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*LRN?");
		}

        private void bnt_prt_Click(object sender, EventArgs e) {
			txt_com.Text = HPIB.add_command(txt_com.Text, "*PRE");
		}

        private void button1_Click(object sender, EventArgs e) {
			try {
				SaveFileDialog SD2 = new SaveFileDialog();
                SD2.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
				SD2.RestoreDirectory = true;
				SD2.Title = "PDF EXPORT";
				SD2.DefaultExt = "PDF";
				SD2.FileName = DateTime.Now.ToString("yyyyMMdd") + ".pdf";
				SD2.Filter = "PDF|*.pdf";
				SD2.FilterIndex = 0;
				SD2.CheckPathExists = true;
				if (SD2.ShowDialog() == DialogResult.OK) {
					try {
						string filename = SD2.FileName;
						HPIB.Pdf_export(lbl_hp.Text, DrawPlot, lbl_ch1_value.Text, lbl_ch2_value.Text, lbl_ch3_value.Text, lbl_ch4_value.Text,filename);
						Log.Screenlog("PDF: " + filename, false);
					}
					catch (Exception ex) {
						Log.Filelog("PDF EXPORT:" + ex.Message);
						Log.Screenlog("PDF EXPORT:" + ex.Message, false);
						pic_status.BackColor = Color.Red;
					}
				}
			}
			catch (Exception ex) {
				Log.Filelog("PDF EXPORT:" + ex.Message);
				Log.Screenlog("PDF EXPORT:" + ex.Message, false);
				pic_status.BackColor = Color.Red;
			}
		}

        private void bnt_sre_Click(object sender, EventArgs e) {
			txt_com.Text = "*SRE";
        }

        private void bnt_wai_Click(object sender, EventArgs e) {
			txt_com.Text = "*WAI";
        }
    }
}