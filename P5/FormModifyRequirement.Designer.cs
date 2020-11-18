namespace Builder
{
    partial class FormModifyRequirement
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
            this.FeatureComboBox = new System.Windows.Forms.ComboBox();
            this.StatementTextBox = new System.Windows.Forms.TextBox();
            this.StatementLabel = new System.Windows.Forms.Label();
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.CreateRequirementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeatureComboBox
            // 
            this.FeatureComboBox.FormattingEnabled = true;
            this.FeatureComboBox.Location = new System.Drawing.Point(149, 42);
            this.FeatureComboBox.Name = "FeatureComboBox";
            this.FeatureComboBox.Size = new System.Drawing.Size(523, 21);
            this.FeatureComboBox.TabIndex = 16;
            this.FeatureComboBox.SelectedIndexChanged += new System.EventHandler(this.FeatureComboBox_SelectedIndexChanged);
            // 
            // StatementTextBox
            // 
            this.StatementTextBox.Location = new System.Drawing.Point(148, 84);
            this.StatementTextBox.Multiline = true;
            this.StatementTextBox.Name = "StatementTextBox";
            this.StatementTextBox.Size = new System.Drawing.Size(524, 295);
            this.StatementTextBox.TabIndex = 15;
            // 
            // StatementLabel
            // 
            this.StatementLabel.AutoSize = true;
            this.StatementLabel.Location = new System.Drawing.Point(84, 87);
            this.StatementLabel.Name = "StatementLabel";
            this.StatementLabel.Size = new System.Drawing.Size(58, 13);
            this.StatementLabel.TabIndex = 14;
            this.StatementLabel.Text = "Statement:";
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(97, 45);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(46, 13);
            this.FeatureLabel.TabIndex = 13;
            this.FeatureLabel.Text = "Feature:";
            this.FeatureLabel.Click += new System.EventHandler(this.FeatureLabel_Click);
            // 
            // CreateRequirementButton
            // 
            this.CreateRequirementButton.Location = new System.Drawing.Point(511, 385);
            this.CreateRequirementButton.Name = "CreateRequirementButton";
            this.CreateRequirementButton.Size = new System.Drawing.Size(161, 23);
            this.CreateRequirementButton.TabIndex = 12;
            this.CreateRequirementButton.Text = "Modify Requirement";
            this.CreateRequirementButton.UseVisualStyleBackColor = true;
            this.CreateRequirementButton.Click += new System.EventHandler(this.CreateRequirementButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(330, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(161, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormModifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeatureComboBox);
            this.Controls.Add(this.StatementTextBox);
            this.Controls.Add(this.StatementLabel);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.CreateRequirementButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "FormModifyRequirement";
            this.Text = "Modify Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FeatureComboBox;
        private System.Windows.Forms.TextBox StatementTextBox;
        private System.Windows.Forms.Label StatementLabel;
        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Button CreateRequirementButton;
        private System.Windows.Forms.Button CancelButton;
    }
}