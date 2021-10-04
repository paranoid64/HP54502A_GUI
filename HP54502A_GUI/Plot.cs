using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace HP54502A_GUI {
	class PlotGrapics {
		public static Bitmap ClearImage(Bitmap DrawPlot) {
			Graphics g = Graphics.FromImage(DrawPlot);
			g.Clear(Color.Black);
			return DrawPlot;
		}

		public static Bitmap Draw_grid(Bitmap DrawPlot, int w, int h, int z, string v) {

			if (v.Length > 0) { // Grid angefordert

				w *= z;
				h *= z;

				Graphics gs = Graphics.FromImage(DrawPlot);
				Brush br1 = new SolidBrush(Color.ForestGreen);
				Pen p1 = new Pen(br1);


				//Außenrahmen
				if (v == "GRID" || v == "AXES") {
					Rectangle rect = new Rectangle(0, 0, w - 1, h - 1);
					gs.DrawRectangle(p1, rect);
				}


				//Kreut
				if (v == "GRID" || v == "AXES") {
					gs.DrawLine(p1, new Point(w / 2, 0), new Point(w / 2, h));
					gs.DrawLine(p1, new Point(0, h / 2), new Point(w, h / 2));
				}

				//dot GRID
				if (v == "GRID") {

					int lh = (h / 2) / 4;
					int lw = w / 10;

					Pen p2 = new Pen(Color.ForestGreen, 1) {
						DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
					};

					int nh = lh;
					int nm = h / 2;

					int nw = lw;

					int xp = nm + lh;
					int xn = nm - lh;

					for (int i = 0; i < 9; i++) {
						if (i < 3) {
							gs.DrawLine(p2, new Point(0, xp), new Point(w, xp));
							gs.DrawLine(p2, new Point(0, xn), new Point(w, xn));
							xp += lh + 1;
							xn -= lh + 1;
						}

						gs.DrawLine(p2, new Point(nw, 0), new Point(nw, h));
						nw += lw;
					}
					p2.Dispose();
				}

				gs.Dispose();
				p1.Dispose();

				br1.Dispose();

			}
			return DrawPlot;
		}


		public static Bitmap Plot(Bitmap DrawPlot, int x, int y, int h, string ch, int z) {
			Graphics g;
			Brush _pen;
			switch (ch) {
				case "CHAN1":
					_pen = Brushes.Cyan;
					break;
				case "CHAN2":
					_pen = Brushes.Magenta;
					break;
				case "CHAN3":
					_pen = Brushes.Blue;
					break;
				case "CHAN4":
					_pen = Brushes.Yellow;
					break;
				default:
					_pen = Brushes.Cyan;
					break;
			}

			g = Graphics.FromImage(DrawPlot);

			h *= z;
			x *= z;
			y *= z;

			g.FillRectangle(_pen, x, h - y, 1, 1);
			g.DrawImage(DrawPlot, 0, 0);
			return DrawPlot;
		}

		public static Bitmap Plot_Line(Bitmap DrawPlot, int x, int y, int lasty, int lastx, int h, string ch, int z) {
			Graphics g;
			g = Graphics.FromImage(DrawPlot);
			//g.CompositingMode = CompositingMode.SourceOver;
			h *= z;
			x *= z;
			y *= z;
			lastx *= z;
			lasty *= z;

			//lasty += 2;
			//y += 2; 


			PointF point1 = new Point(x, h - y);
			PointF point2 = new Point(lastx, h - lasty);

			Pen _pen;

			switch (ch) {
				case "CHAN1":
					_pen = new Pen(Color.Cyan);
					break;
				case "CHAN2":
					_pen = new Pen(Color.Magenta);
					break;
				case "CHAN3":
					_pen = new Pen(Color.Blue);
					break;
				case "CHAN4":
					_pen = new Pen(Color.Yellow);
					break;
				default:
					_pen = new Pen(Color.Cyan);
					break;
			}

			g.DrawLine(_pen, point1, point2);
			g.DrawImage(DrawPlot, 0, 0);
			return DrawPlot;
		}

		public static Bitmap ResizeImage(Image image, int width, int height) {
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage)) {
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes()) {
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}


	}
}
