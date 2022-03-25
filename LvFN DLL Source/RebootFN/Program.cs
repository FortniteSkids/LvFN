using System;
using System.Windows.Forms;

namespace RebootFN
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000213C File Offset: 0x0000033C
		[STAThread]
		private static void Main()
		{
			Application.SetHighDpiMode(1);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
