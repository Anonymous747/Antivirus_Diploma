
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.threatsGridView = new System.Windows.Forms.DataGridView();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scanBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.threatsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(66, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 132);
            this.listBox1.TabIndex = 20;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(66, 205);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(291, 92);
            this.selectFileBtn.TabIndex = 19;
            this.selectFileBtn.Text = "Choose file";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(66, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(620, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // threatsGridView
            // 
            this.threatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathColumn,
            this.DateColumn,
            this.ThreatColumn});
            this.threatsGridView.Location = new System.Drawing.Point(66, 377);
            this.threatsGridView.Name = "threatsGridView";
            this.threatsGridView.RowHeadersWidth = 51;
            this.threatsGridView.RowTemplate.Height = 24;
            this.threatsGridView.Size = new System.Drawing.Size(620, 199);
            this.threatsGridView.TabIndex = 17;
            // 
            // PathColumn
            // 
            this.PathColumn.HeaderText = "Path";
            this.PathColumn.MinimumWidth = 6;
            this.PathColumn.Name = "PathColumn";
            this.PathColumn.Width = 150;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 150;
            // 
            // ThreatColumn
            // 
            this.ThreatColumn.HeaderText = "Threat";
            this.ThreatColumn.MinimumWidth = 6;
            this.ThreatColumn.Name = "ThreatColumn";
            this.ThreatColumn.Width = 150;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(63, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 17);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status: N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "MD5";
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(406, 205);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(280, 92);
            this.scanBtn.TabIndex = 16;
            this.scanBtn.Text = "Scan";
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // FileScanningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.threatsGridView);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scanBtn);
            this.Name = "FileScanningControl";
            this.Size = new System.Drawing.Size(752, 693);
            this.Load += new System.EventHandler(this.FileScanningControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threatsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView threatsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreatColumn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scanBtn;
    }
}
