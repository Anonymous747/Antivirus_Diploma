
namespace Antivirus.UserControls
{
    partial class QuarantineControl
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
            this.quarantineBox = new System.Windows.Forms.ListBox();
            this.cleanListBtn = new System.Windows.Forms.Button();
            this.inQuarantineLbl = new System.Windows.Forms.Label();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.quarantineLabel = new System.Windows.Forms.Label();
            this.quarantineDescription = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quarantineBox
            // 
            this.quarantineBox.FormattingEnabled = true;
            this.quarantineBox.ItemHeight = 16;
            this.quarantineBox.Location = new System.Drawing.Point(34, 129);
            this.quarantineBox.Name = "quarantineBox";
            this.quarantineBox.Size = new System.Drawing.Size(620, 132);
            this.quarantineBox.TabIndex = 20;
            // 
            // cleanListBtn
            // 
            this.cleanListBtn.Location = new System.Drawing.Point(132, 267);
            this.cleanListBtn.Name = "cleanListBtn";
            this.cleanListBtn.Size = new System.Drawing.Size(179, 45);
            this.cleanListBtn.TabIndex = 19;
            this.cleanListBtn.Text = "Clean the list";
            this.cleanListBtn.UseVisualStyleBackColor = true;
            this.cleanListBtn.Click += new System.EventHandler(this.cleanListBtn_Click);
            // 
            // inQuarantineLbl
            // 
            this.inQuarantineLbl.AutoSize = true;
            this.inQuarantineLbl.Location = new System.Drawing.Point(31, 347);
            this.inQuarantineLbl.Name = "inQuarantineLbl";
            this.inQuarantineLbl.Size = new System.Drawing.Size(132, 17);
            this.inQuarantineLbl.TabIndex = 15;
            this.inQuarantineLbl.Text = "Files in quarantine: ";
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.Location = new System.Drawing.Point(331, 267);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(233, 45);
            this.removeAllBtn.TabIndex = 16;
            this.removeAllBtn.Text = "Remove all";
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // quarantineLabel
            // 
            this.quarantineLabel.AutoSize = true;
            this.quarantineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quarantineLabel.Location = new System.Drawing.Point(24, 0);
            this.quarantineLabel.Name = "quarantineLabel";
            this.quarantineLabel.Size = new System.Drawing.Size(262, 55);
            this.quarantineLabel.TabIndex = 31;
            this.quarantineLabel.Text = "Quarantine";
            // 
            // quarantineDescription
            // 
            this.quarantineDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quarantineDescription.Location = new System.Drawing.Point(68, 64);
            this.quarantineDescription.Name = "quarantineDescription";
            this.quarantineDescription.Size = new System.Drawing.Size(586, 44);
            this.quarantineDescription.TabIndex = 32;
            this.quarantineDescription.Text = "Quarantine - is a place where storing of suspicious or virused files. You can cle" +
    "an the list or remove all files from the list";
            this.quarantineDescription.UseCompatibleTextRendering = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(34, 267);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(79, 45);
            this.refreshBtn.TabIndex = 33;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // QuarantineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.quarantineDescription);
            this.Controls.Add(this.quarantineLabel);
            this.Controls.Add(this.quarantineBox);
            this.Controls.Add(this.cleanListBtn);
            this.Controls.Add(this.inQuarantineLbl);
            this.Controls.Add(this.removeAllBtn);
            this.Name = "QuarantineControl";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.QuarantineControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quarantineBox;
        private System.Windows.Forms.Button cleanListBtn;
        private System.Windows.Forms.Label inQuarantineLbl;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.Label quarantineLabel;
        private System.Windows.Forms.Label quarantineDescription;
        private System.Windows.Forms.Button refreshBtn;
    }
}
