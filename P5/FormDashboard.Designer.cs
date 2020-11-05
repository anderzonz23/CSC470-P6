namespace Builder
{
    partial class FormDashboard
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.IssuesByDiscLabel = new System.Windows.Forms.Label();
            this.IssuesByMonthLabel = new System.Windows.Forms.Label();
            this.TotalNumIssuesLabel = new System.Windows.Forms.Label();
            this.NumIssues = new System.Windows.Forms.Label();
            this.IssuesByMonthListBox = new System.Windows.Forms.ListBox();
            this.IssuesByDiscovererListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(196, 443);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IssuesByDiscLabel
            // 
            this.IssuesByDiscLabel.AutoSize = true;
            this.IssuesByDiscLabel.Location = new System.Drawing.Point(50, 249);
            this.IssuesByDiscLabel.Name = "IssuesByDiscLabel";
            this.IssuesByDiscLabel.Size = new System.Drawing.Size(105, 13);
            this.IssuesByDiscLabel.TabIndex = 3;
            this.IssuesByDiscLabel.Text = "Issues by Discoverer";
            this.IssuesByDiscLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IssuesByMonthLabel
            // 
            this.IssuesByMonthLabel.AutoSize = true;
            this.IssuesByMonthLabel.Location = new System.Drawing.Point(50, 64);
            this.IssuesByMonthLabel.Name = "IssuesByMonthLabel";
            this.IssuesByMonthLabel.Size = new System.Drawing.Size(84, 13);
            this.IssuesByMonthLabel.TabIndex = 4;
            this.IssuesByMonthLabel.Text = "Issues by Month";
            // 
            // TotalNumIssuesLabel
            // 
            this.TotalNumIssuesLabel.AutoSize = true;
            this.TotalNumIssuesLabel.Location = new System.Drawing.Point(50, 29);
            this.TotalNumIssuesLabel.Name = "TotalNumIssuesLabel";
            this.TotalNumIssuesLabel.Size = new System.Drawing.Size(119, 13);
            this.TotalNumIssuesLabel.TabIndex = 5;
            this.TotalNumIssuesLabel.Text = "Total Number of Issues:";
            // 
            // NumIssues
            // 
            this.NumIssues.AutoSize = true;
            this.NumIssues.Location = new System.Drawing.Point(165, 29);
            this.NumIssues.Name = "NumIssues";
            this.NumIssues.Size = new System.Drawing.Size(13, 13);
            this.NumIssues.TabIndex = 6;
            this.NumIssues.Text = "0";
            this.NumIssues.Click += new System.EventHandler(this.NumIssues_Click);
            // 
            // IssuesByMonthListBox
            // 
            this.IssuesByMonthListBox.FormattingEnabled = true;
            this.IssuesByMonthListBox.Location = new System.Drawing.Point(53, 80);
            this.IssuesByMonthListBox.Name = "IssuesByMonthListBox";
            this.IssuesByMonthListBox.Size = new System.Drawing.Size(203, 147);
            this.IssuesByMonthListBox.TabIndex = 7;
            // 
            // IssuesByDiscovererListBox
            // 
            this.IssuesByDiscovererListBox.FormattingEnabled = true;
            this.IssuesByDiscovererListBox.Location = new System.Drawing.Point(53, 265);
            this.IssuesByDiscovererListBox.Name = "IssuesByDiscovererListBox";
            this.IssuesByDiscovererListBox.Size = new System.Drawing.Size(203, 147);
            this.IssuesByDiscovererListBox.TabIndex = 8;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 506);
            this.Controls.Add(this.IssuesByDiscovererListBox);
            this.Controls.Add(this.IssuesByMonthListBox);
            this.Controls.Add(this.NumIssues);
            this.Controls.Add(this.TotalNumIssuesLabel);
            this.Controls.Add(this.IssuesByMonthLabel);
            this.Controls.Add(this.IssuesByDiscLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "FormDashboard";
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label IssuesByDiscLabel;
        private System.Windows.Forms.Label IssuesByMonthLabel;
        private System.Windows.Forms.Label TotalNumIssuesLabel;
        private System.Windows.Forms.Label NumIssues;
        private System.Windows.Forms.ListBox IssuesByMonthListBox;
        private System.Windows.Forms.ListBox IssuesByDiscovererListBox;
    }
}