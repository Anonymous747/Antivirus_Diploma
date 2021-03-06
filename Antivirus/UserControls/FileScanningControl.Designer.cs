
namespace Antivirus.UserControls
{
    partial class FileScanningControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileScanningControl));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.threatsGridView = new System.Windows.Forms.DataGridView();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.homePageBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.QuarantineBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LastUpdateValue = new System.Windows.Forms.Label();
            this.LastScanValue = new System.Windows.Forms.Label();
            this.TimeTakenNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ItemScannedNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ScanResultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.threatsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(285, 108);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(591, 120);
            this.listBox1.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SlateBlue;
            this.progressBar1.Location = new System.Drawing.Point(35, 257);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1089, 29);
            this.progressBar1.TabIndex = 18;
            // 
            // threatsGridView
            // 
            this.threatsGridView.AllowUserToOrderColumns = true;
            this.threatsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.threatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathColumn,
            this.DateColumn,
            this.ThreatColumn});
            this.threatsGridView.Location = new System.Drawing.Point(35, 434);
            this.threatsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threatsGridView.Name = "threatsGridView";
            this.threatsGridView.RowHeadersWidth = 51;
            this.threatsGridView.RowTemplate.Height = 24;
            this.threatsGridView.Size = new System.Drawing.Size(1089, 419);
            this.threatsGridView.TabIndex = 17;
            // 
            // PathColumn
            // 
            this.PathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PathColumn.HeaderText = "Path";
            this.PathColumn.MinimumWidth = 6;
            this.PathColumn.Name = "PathColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            // 
            // ThreatColumn
            // 
            this.ThreatColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThreatColumn.HeaderText = "Threat";
            this.ThreatColumn.MinimumWidth = 6;
            this.ThreatColumn.Name = "ThreatColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "MD5";
            // 
            // homePageBtn
            // 
            this.homePageBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homePageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(196)))), ((int)(((byte)(141)))));
            this.homePageBtn.Location = new System.Drawing.Point(35, 180);
            this.homePageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(230, 52);
            this.homePageBtn.TabIndex = 16;
            this.homePageBtn.Text = "Home Page";
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // QuarantineBtn
            // 
            this.QuarantineBtn.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuarantineBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(196)))), ((int)(((byte)(141)))));
            this.QuarantineBtn.Location = new System.Drawing.Point(35, 108);
            this.QuarantineBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuarantineBtn.Name = "QuarantineBtn";
            this.QuarantineBtn.Size = new System.Drawing.Size(230, 54);
            this.QuarantineBtn.TabIndex = 16;
            this.QuarantineBtn.Text = "Quarantine";
            this.QuarantineBtn.Click += new System.EventHandler(this.QuarantineBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.panel3.Controls.Add(this.LastUpdateValue);
            this.panel3.Controls.Add(this.LastScanValue);
            this.panel3.Controls.Add(this.TimeTakenNumber);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ItemScannedNumber);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ScanResultLabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(35, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 123);
            this.panel3.TabIndex = 23;
            // 
            // LastUpdateValue
            // 
            this.LastUpdateValue.AutoSize = true;
            this.LastUpdateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.LastUpdateValue.Location = new System.Drawing.Point(256, 78);
            this.LastUpdateValue.Name = "LastUpdateValue";
            this.LastUpdateValue.Size = new System.Drawing.Size(49, 20);
            this.LastUpdateValue.TabIndex = 10;
            this.LastUpdateValue.Text = "Today";
            // 
            // LastScanValue
            // 
            this.LastScanValue.AutoSize = true;
            this.LastScanValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.LastScanValue.Location = new System.Drawing.Point(236, 58);
            this.LastScanValue.Name = "LastScanValue";
            this.LastScanValue.Size = new System.Drawing.Size(49, 20);
            this.LastScanValue.TabIndex = 9;
            this.LastScanValue.Text = "Today";
            // 
            // TimeTakenNumber
            // 
            this.TimeTakenNumber.AutoSize = true;
            this.TimeTakenNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.TimeTakenNumber.Location = new System.Drawing.Point(476, 78);
            this.TimeTakenNumber.Name = "TimeTakenNumber";
            this.TimeTakenNumber.Size = new System.Drawing.Size(63, 20);
            this.TimeTakenNumber.TabIndex = 8;
            this.TimeTakenNumber.Text = "00:00:01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(384, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time Taken:";
            // 
            // ItemScannedNumber
            // 
            this.ItemScannedNumber.AutoSize = true;
            this.ItemScannedNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.ItemScannedNumber.Location = new System.Drawing.Point(499, 58);
            this.ItemScannedNumber.Name = "ItemScannedNumber";
            this.ItemScannedNumber.Size = new System.Drawing.Size(17, 20);
            this.ItemScannedNumber.TabIndex = 6;
            this.ItemScannedNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(384, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Items Scanned:";
            // 
            // ScanResulLabel
            // 
            this.ScanResultLabel.AutoSize = true;
            this.ScanResultLabel.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScanResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(196)))), ((int)(((byte)(141)))));
            this.ScanResultLabel.Location = new System.Drawing.Point(332, 15);
            this.ScanResultLabel.Name = "ScanResulLabel";
            this.ScanResultLabel.Size = new System.Drawing.Size(285, 26);
            this.ScanResultLabel.TabIndex = 4;
            this.ScanResultLabel.Text = "No Infections Detected!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(159, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Update:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last scan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(159, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Threat Result: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(118, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "WinDefender Total Security";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(196)))), ((int)(((byte)(141)))));
            this.button1.Location = new System.Drawing.Point(894, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 54);
            this.button1.TabIndex = 24;
            this.button1.Text = "Choose File";
            this.button1.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(196)))), ((int)(((byte)(141)))));
            this.button2.Location = new System.Drawing.Point(894, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Scan";
            this.button2.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // FileScanningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.threatsGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuarantineBtn);
            this.Controls.Add(this.homePageBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileScanningControl";
            this.Size = new System.Drawing.Size(1160, 762);
            ((System.ComponentModel.ISupportInitialize)(this.threatsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView threatsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreatColumn;
        private System.Windows.Forms.Button QuarantineBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ItemScannedNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ScanResultLabel;
        private System.Windows.Forms.Label TimeTakenNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LastUpdateValue;
        private System.Windows.Forms.Label LastScanValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
