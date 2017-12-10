using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckEUCJPWithLinux
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsSupported)
			{
				// Enabling Windows XP visual effects before any controls are created
				Application.EnableVisualStyles();
			}
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
