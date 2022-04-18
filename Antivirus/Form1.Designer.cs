
namespace Antivirus
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.updatesBtn = new System.Windows.Forms.Button();
            this.systemBtn = new System.Windows.Forms.Button();
            this.quarantineBtn = new System.Windows.Forms.Button();
            this.scannerBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(279, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem1
            // 
            this.browseToolStripMenuItem1.Name = "browseToolStripMenuItem1";
            this.browseToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.browseToolStripMenuItem1.Text = "Browse";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.updatesBtn);
            this.panel1.Controls.Add(this.systemBtn);
            this.panel1.Controls.Add(this.quarantineBtn);
            this.panel1.Controls.Add(this.scannerBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 623);
            this.panel1.TabIndex = 12;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutBtn.Location = new System.Drawing.Point(40, 400);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(208, 60);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About application";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // updatesBtn
            // 
            this.updatesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatesBtn.Location = new System.Drawing.Point(40, 317);
            this.updatesBtn.Name = "updatesBtn";
            this.updatesBtn.Size = new System.Drawing.Size(208, 60);
            this.updatesBtn.TabIndex = 5;
            this.updatesBtn.Text = "Updates";
            this.updatesBtn.UseVisualStyleBackColor = false;
            this.updatesBtn.Click += new System.EventHandler(this.updatesBtn_Click);
            // 
            // systemBtn
            // 
            this.systemBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.systemBtn.Location = new System.Drawing.Point(40, 228);
            this.systemBtn.Name = "systemBtn";
            this.systemBtn.Size = new System.Drawing.Size(208, 60);
            this.systemBtn.TabIndex = 4;
            this.systemBtn.Text = "System Information";
            this.systemBtn.UseVisualStyleBackColor = false;
            this.systemBtn.Click += new System.EventHandler(this.systemBtn_Click);
            // 
            // quarantineBtn
            // 
            this.quarantineBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quarantineBtn.Location = new System.Drawing.Point(40, 143);
            this.quarantineBtn.Name = "quarantineBtn";
            this.quarantineBtn.Size = new System.Drawing.Size(208, 60);
            this.quarantineBtn.TabIndex = 3;
            this.quarantineBtn.Text = "Quarantine";
            this.quarantineBtn.UseVisualStyleBackColor = false;
            this.quarantineBtn.Click += new System.EventHandler(this.quarantineBtn_Click);
            // 
            // scannerBtn
            // 
            this.scannerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scannerBtn.Location = new System.Drawing.Point(40, 55);
            this.scannerBtn.Name = "scannerBtn";
            this.scannerBtn.Size = new System.Drawing.Size(208, 60);
            this.scannerBtn.TabIndex = 0;
            this.scannerBtn.Text = "File Scanning";
            this.scannerBtn.UseVisualStyleBackColor = false;
            this.scannerBtn.Click += new System.EventHandler(this.scannerBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1023, 352);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(279, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 593);
            this.panel2.TabIndex = 15;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button updatesBtn;
        private System.Windows.Forms.Button systemBtn;
        private System.Windows.Forms.Button quarantineBtn;
        private System.Windows.Forms.Button scannerBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

