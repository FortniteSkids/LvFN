using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RebootFNPog
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not out yet!", "LvFn");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000207B File Offset: 0x0000027B
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("run.bat", "RebootFN");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000208E File Offset: 0x0000028E
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("Reboot", "RebootFN");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("install", "RebootFN");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B4 File Offset: 0x000002B4
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Everthing is made by Recon)", "LvFn");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C7 File Offset: 0x000002C7
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020CA File Offset: 0x000002CA
		private void button6_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/eMkdukvW7V");
		}
	}
}
