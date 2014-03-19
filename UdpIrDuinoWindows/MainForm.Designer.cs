/*
 * Created by SharpDevelop.
 * User: infomaniac50
 * Date: 12/14/2013
 * Time: 4:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UdpIrDuino
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtBits = new System.Windows.Forms.TextBox();
			this.txtEx1 = new System.Windows.Forms.TextBox();
			this.txtEx2 = new System.Windows.Forms.TextBox();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.btnSendCode = new System.Windows.Forms.Button();
			this.txtBase2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBase16 = new System.Windows.Forms.TextBox();
			this.txtBase10 = new System.Windows.Forms.TextBox();
			this.txtBase8 = new System.Windows.Forms.TextBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBits
			// 
			this.txtBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBits.Location = new System.Drawing.Point(46, 39);
			this.txtBits.Name = "txtBits";
			this.txtBits.Size = new System.Drawing.Size(201, 20);
			this.txtBits.TabIndex = 1;
			// 
			// txtEx1
			// 
			this.txtEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEx1.Location = new System.Drawing.Point(46, 65);
			this.txtEx1.Name = "txtEx1";
			this.txtEx1.Size = new System.Drawing.Size(201, 20);
			this.txtEx1.TabIndex = 2;
			// 
			// txtEx2
			// 
			this.txtEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEx2.Location = new System.Drawing.Point(46, 91);
			this.txtEx2.Name = "txtEx2";
			this.txtEx2.Size = new System.Drawing.Size(201, 20);
			this.txtEx2.TabIndex = 3;
			// 
			// txtValue
			// 
			this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtValue.Location = new System.Drawing.Point(46, 117);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(201, 20);
			this.txtValue.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "EX1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "EX2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Bits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Value";
			// 
			// cmbType
			// 
			this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(46, 13);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(201, 21);
			this.cmbType.TabIndex = 0;
			// 
			// btnSendCode
			// 
			this.btnSendCode.Enabled = false;
			this.btnSendCode.Location = new System.Drawing.Point(87, 19);
			this.btnSendCode.Name = "btnSendCode";
			this.btnSendCode.Size = new System.Drawing.Size(75, 23);
			this.btnSendCode.TabIndex = 5;
			this.btnSendCode.Text = "Send";
			this.btnSendCode.UseVisualStyleBackColor = true;
			// 
			// txtBase2
			// 
			this.txtBase2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBase2.Location = new System.Drawing.Point(46, 19);
			this.txtBase2.Name = "txtBase2";
			this.txtBase2.Size = new System.Drawing.Size(201, 20);
			this.txtBase2.TabIndex = 16;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtBase16);
			this.groupBox1.Controls.Add(this.txtBase10);
			this.groupBox1.Controls.Add(this.txtBase8);
			this.groupBox1.Controls.Add(this.txtBase2);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 128);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Base Conversion";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 100);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "16";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "10";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "8";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "2";
			// 
			// txtBase16
			// 
			this.txtBase16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBase16.Location = new System.Drawing.Point(46, 97);
			this.txtBase16.Name = "txtBase16";
			this.txtBase16.Size = new System.Drawing.Size(201, 20);
			this.txtBase16.TabIndex = 19;
			// 
			// txtBase10
			// 
			this.txtBase10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBase10.Location = new System.Drawing.Point(46, 71);
			this.txtBase10.Name = "txtBase10";
			this.txtBase10.Size = new System.Drawing.Size(201, 20);
			this.txtBase10.TabIndex = 18;
			// 
			// txtBase8
			// 
			this.txtBase8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtBase8.Location = new System.Drawing.Point(46, 45);
			this.txtBase8.Name = "txtBase8";
			this.txtBase8.Size = new System.Drawing.Size(201, 20);
			this.txtBase8.TabIndex = 17;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Enabled = false;
			this.btnDisconnect.Location = new System.Drawing.Point(6, 48);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 19;
			this.btnDisconnect.TabStop = false;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(6, 19);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 20;
			this.btnConnect.TabStop = false;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox3);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox2);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(277, 383);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(277, 407);
			this.toolStripContainer1.TabIndex = 21;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnConnect);
			this.groupBox3.Controls.Add(this.btnDisconnect);
			this.groupBox3.Controls.Add(this.btnSendCode);
			this.groupBox3.Location = new System.Drawing.Point(97, 293);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(168, 78);
			this.groupBox3.TabIndex = 22;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ethernet Control";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cmbType);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtValue);
			this.groupBox2.Controls.Add(this.txtBits);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtEx2);
			this.groupBox2.Controls.Add(this.txtEx1);
			this.groupBox2.Location = new System.Drawing.Point(12, 137);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 150);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "IR Code";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(277, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.stayOnTopToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// stayOnTopToolStripMenuItem
			// 
			this.stayOnTopToolStripMenuItem.CheckOnClick = true;
			this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
			this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.stayOnTopToolStripMenuItem.Text = "Stay On Top";
			this.stayOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.StayOnTopToolStripMenuItemCheckedChanged);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnSendCode;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 407);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(275, 340);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "IrDuino";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.TextBox txtBase8;
		private System.Windows.Forms.TextBox txtBase10;
		private System.Windows.Forms.TextBox txtBase16;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBase2;
		private System.Windows.Forms.Button btnSendCode;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.TextBox txtEx2;
		private System.Windows.Forms.TextBox txtEx1;
		private System.Windows.Forms.TextBox txtBits;
	}
}
