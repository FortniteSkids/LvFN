using System;
using System.Windows.Forms;

namespace RebootFNPog
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000263F File Offset: 0x0000083F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
