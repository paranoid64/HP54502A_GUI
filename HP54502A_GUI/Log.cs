/*
 * Created by SharpDevelop.
 * User: mlausch
 * Date: 10.02.2021
 * Time: 07:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace HP54502A_GUI {
    class Log{

		public static void Filelog(string Message){

            try{
				if (Message.Length > 0){
					string filename = DateTime.Now.ToString("yyyyMMdd") + ".log";
					string path = AppDomain.CurrentDomain.BaseDirectory;

					if (!Directory.Exists(path + @"log\")) {
						DirectoryInfo di = Directory.CreateDirectory(path + @"log\");
					}

					string location = path + @"log\" + filename;

					if (!File.Exists(location)){
						File.Create(location);
					}

					// Create a FileStream with mode CreateNew  
					FileStream stream = new FileStream(location, FileMode.Append);

					using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8)) {
						streamWriter.WriteLine(Message);
						streamWriter.Close();
					}
				}
            } catch {
				
            }
		}

		public static void Screenlog(string Message, bool command){
			try{
				if (Message.Length > 0){
					Message = Message.Replace(System.Environment.NewLine, "");
					if (command){
						MainForm._Form1.MSG += "COMMAND>" + Message + "\n";
					}
					else{
						MainForm._Form1.MSG += "RESULT:>" + Message + "\n";
					}
				}
				else {
					MainForm._Form1.MSG += "Empty";
				}
			}
			catch (Exception e){
				Log.Filelog(e.Message);
			}
		}

	}
}