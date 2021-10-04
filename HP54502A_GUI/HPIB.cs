using System;
using System.Drawing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Globalization;

namespace HP54502A_GUI {
	class HPIB {

		// return V or mV
		// ,-1.50000E+00 = 1,50000 V
		// ,-1.04000E+00 = 1.04000 V
		// ,-8.50000E-01 = -850.000mV
		// ,-3.75000E-02 = - 37,500mv;


		public static string Volt(string value){
			
			string s = value.Substring(value.IndexOf('E') + 1);
			decimal num = decimal.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture);

			string v = " V";

			//multiplicator
			Match match = Regex.Match(s, "([0-9]+)");
			s = match.ToString().TrimStart('0');
			if (s.Length<=0) {
				s = "0";
			}


			switch (int.Parse(s)) {
				case 0:
					num = Decimal.Round(num , 3);
					v = " V";
					break;
				case 1:
					num = Decimal.Round(num * 1000, 3);
					v = " mV";
					break;
				case 2:
					num = Decimal.Round(num * 1000, 3);
					v = " mV";
					break;
			}
			return num.ToString() + v;
		}

		//
		/*
		public static string Volt(string value) {

			string s = value.Substring(value.IndexOf('E') + 1);
			decimal num = decimal.Parse(value, NumberStyles.Any, CultureInfo.InvariantCulture);

			string v = " V";

			//multiplicator
			Match match = Regex.Match(s, "([0-9]+)");
			s = match.ToString().TrimStart('0');
			if (s.Length <= 0) {
				s = "0";
			}


			switch (int.Parse(s)) {
				case 0:
					num = Decimal.Round(num, 3);
					v = "µs";
					break;
				case 1:
					num = Decimal.Round(num * 1000, 3);
					v = " ns";
					break;
			}
			return num.ToString() + v;
		}
		*/


		// exponentielle  
		// Sucht im String +7.68750E-01 -> 768,750; 
		//-4.00000E-04,-1.02750E+00
		public static decimal dec(string v, int div, string p) {
			decimal d = Decimal.Parse(v, System.Globalization.NumberStyles.Any);
			d = Decimal.Parse(v.Replace('.', ','), System.Globalization.NumberStyles.Float);

			if (p == "Hz") {
				d = Decimal.Round(d, 3);
			}

			if (p == "mV") {
				d = Decimal.Round(d * div, 3);
			}

			if (p == "us") { // NS / US nanosiemens and microsiemens 
				d = Decimal.Round(d * div, 3);
			}
			return d;
		}


		public static string add_command(string s, string com) {
			if (s.Length > 0) {
				s = s + ";" + com;
			}
			else {
				s = com;
			}
			return s;
		}

		public static void Pdf_export(string device, Bitmap bmp, string ch1, string ch2, string ch3, string ch4, string filename) {
			try {
				PdfDocument pdf = new PdfDocument();
				pdf.Info.Title = "HP54502A GUI";
				pdf.Info.Author = "Marcus Lausch";
				pdf.Info.Subject = "HP54502A GUI";
				pdf.Info.Keywords = "HP54502A";
				pdf.Info.CreationDate = DateTime.Now;
				pdf.Info.Creator = "www.lama-creation.de";

				if (device.Length < 1) {
					device = "HP54502A GUI";
				}
				else {
					String[] t = device.Split(',');
					device = t[0] + " " + t[1];
				}

				int a4_Boarder = 40;

				// Create an empty page
				PdfPage page = pdf.AddPage();

				// Get an XGraphics object for drawing
				XGraphics gfx = XGraphics.FromPdfPage(page);

				// Create font
				XFont H1 = new XFont("Verdana", 20, XFontStyle.Bold);
				XFont b = new XFont("Verdana", 12, XFontStyle.Bold);
				XFont p = new XFont("Verdana", 10, XFontStyle.Regular);

				// Draw Headline
				gfx.DrawString(device, H1, XBrushes.DimGray, new XRect(a4_Boarder, a4_Boarder, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);

				//Draw Plot Bitmap
				Image img = bmp; // this is the image
				img = PlotGrapics.ResizeImage(img, 700, 526);
				MemoryStream strm = new MemoryStream();
				img.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
				XImage plotimg = XImage.FromStream(strm);
				gfx.DrawImage(plotimg, a4_Boarder, 90);


				//Measure Text
				int mh = 520;

				if (ch1.Length > 0) {
					gfx.DrawString("CH1:", b, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 14;
					gfx.DrawString(ch1, p, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 20;
				}

				if (ch2.Length > 0) {
					gfx.DrawString("CH2:", b, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 14;
					gfx.DrawString(ch2, p, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 20;
				}


				if (ch3.Length > 0) {
					gfx.DrawString("CH3:", b, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 14;
					gfx.DrawString(ch3, p, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 20;
				}

				if (ch4.Length > 0) {
					gfx.DrawString("CH4:", b, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 14;
					gfx.DrawString(ch4, p, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);
					mh += 20;
				}

				gfx.DrawString(DateTime.Now.ToString("dd.MM.yyyy HH:mm"), b, XBrushes.Black, new XRect(a4_Boarder, mh, page.Width - a4_Boarder, page.Height - a4_Boarder), XStringFormats.TopLeft);

				// Save the document...
				try {
					pdf.Save(filename);
				} catch (Exception ex) {
					Log.Filelog("HPIB PDF SAVE:" + ex.Message);
					Log.Screenlog("HPIB PDF SAVE:" + ex.Message, false);
					Log.Filelog("HPIB PDF SAVE:" + filename);
					Log.Screenlog("HPIB PDF SAVE:" + filename, false);

				}
				
			} catch (Exception ex) {
				Log.Filelog("HPIB PDF BUILD:"+ex.Message);
				Log.Screenlog("HPIB PDF BUILD:" + ex.Message, false);
			}

		}
	}
}
