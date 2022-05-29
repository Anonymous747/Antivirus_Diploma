
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuarantineControl));
            this.quarantineBox = new System.Windows.Forms.ListBox();
            this.cleanListBtn = new System.Windows.Forms.Button();
            this.inQuarantineLbl = new System.Windows.Forms.Label();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.quarantineLabel = new System.Windows.Forms.Label();
            this.quarantineDescription = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // quarantineBox
            // 
            this.quarantineBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(36)))));
            this.quarantineBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.quarantineBox.FormattingEnabled = true;
            this.quarantineBox.ItemHeight = 20;
            this.quarantineBox.Location = new System.Drawing.Point(35, 206);
            this.quarantineBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quarantineBox.Name = "quarantineBox";
            this.quarantineBox.Size = new System.Drawing.Size(1085, 164);
            this.quarantineBox.TabIndex = 20;
            // 
            // cleanListBtn
            // 
            this.cleanListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.cleanListBtn.Location = new System.Drawing.Point(235, 426);
            this.cleanListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cleanListBtn.Name = "cleanListBtn";
            this.cleanListBtn.Size = new System.Drawing.Size(179, 56);
            this.cleanListBtn.TabIndex = 19;
            this.cleanListBtn.Text = "Clean the list";
            this.cleanListBtn.UseVisualStyleBackColor = true;
            this.cleanListBtn.Click += new System.EventHandler(this.cleanListBtn_Click);
            // 
            // inQuarantineLbl
            // 
            this.inQuarantineLbl.AutoSize = true;
            this.inQuarantineLbl.Location = new System.Drawing.Point(278, 546);
            this.inQuarantineLbl.Name = "inQuarantineLbl";
            this.inQuarantineLbl.Size = new System.Drawing.Size(136, 20);
            this.inQuarantineLbl.TabIndex = 15;
            this.inQuarantineLbl.Text = "Files in quarantine: ";
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.ForeColor = System.Drawing.Color.Red;
            this.removeAllBtn.Location = new System.Drawing.Point(461, 426);
            this.removeAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(233, 56);
            this.removeAllBtn.TabIndex = 16;
            this.removeAllBtn.Text = "Remove all";
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // quarantineLabel
            // 
            this.quarantineLabel.AutoSize = true;
            this.quarantineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quarantineLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quarantineLabel.Location = new System.Drawing.Point(450, 25);
            this.quarantineLabel.Name = "quarantineLabel";
            this.quarantineLabel.Size = new System.Drawing.Size(255, 54);
            this.quarantineLabel.TabIndex = 31;
            this.quarantineLabel.Text = "Quarantine";
            // 
            // quarantineDescription
            // 
            this.quarantineDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quarantineDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.quarantineDescription.Location = new System.Drawing.Point(35, 133);
            this.quarantineDescription.Name = "quarantineDescription";
            this.quarantineDescription.Size = new System.Drawing.Size(1085, 59);
            this.quarantineDescription.TabIndex = 32;
            this.quarantineDescription.Text = "Quarantine - is a place where storing of suspicious or virused files. You can cle" +
    "an the list or remove all files from the list";
            this.quarantineDescription.UseCompatibleTextRendering = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(240)))), ((int)(((byte)(46)))));
            this.refreshBtn.Location = new System.Drawing.Point(35, 426);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(148, 56);
            this.refreshBtn.TabIndex = 33;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(118, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 31);
            this.label8.TabIndex = 34;
            this.label8.Text = "My Antivirus";
            // 
            // QuarantineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.quarantineDescription);
            this.Controls.Add(this.quarantineLabel);
            this.Controls.Add(this.quarantineBox);
            this.Controls.Add(this.cleanListBtn);
            this.Controls.Add(this.inQuarantineLbl);
            this.Controls.Add(this.removeAllBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuarantineControl";
            this.Size = new System.Drawing.Size(1160, 762);
            this.Load += new System.EventHandler(this.QuarantineControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}
