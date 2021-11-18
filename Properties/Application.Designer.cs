using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace Grading_System
{
	namespace My
	{
		
		
		public partial class MyApplication : global::Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{
			[STAThread]
			static void Main()
			{
				(new MyApplication()).Run(new string[] {});
			}
			
			[global::System.Diagnostics.DebuggerStepThrough()]public MyApplication() : base(global::Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				
				
				
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = global::Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}
			
			[global::System.Diagnostics.DebuggerStepThroughAttribute()]protected override void OnCreateMainForm()
			{
				this.MainForm = global::Grading_System.Form1.Default;
			}
		}
	}
	
}
