namespace RebootFNPog
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000020D8 File Offset: 0x000002D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002110 File Offset: 0x00000310
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RebootFNPog.Form1));
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(187, 80);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(169, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new global::System.Drawing.Point(388, 80);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(169, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "Start sever";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new global::System.Drawing.Point(12, 197);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(96, 37);
			this.button3.TabIndex = 2;
			this.button3.Text = "Install";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new global::System.Drawing.Point(114, 197);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(96, 37);
			this.button4.TabIndex = 3;
			this.button4.Text = "Custom skins";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new global::System.Drawing.Point(216, 197);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(96, 37);
			this.button5.TabIndex = 4;
			this.button5.Text = "Credits";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.BackColor = global::System.Drawing.Color.Fuchsia;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new global::System.Drawing.Point(318, 197);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(96, 37);
			this.button6.TabIndex = 5;
			this.button6.Text = "Discord";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Purple;
			base.ClientSize = new global::System.Drawing.Size(769, 246);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			this.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "LvFn";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button6;
	}
}
