namespace Builder
{
    partial class FormSelectRequirement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectRequirementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FeatureComboBox = new System.Windows.Forms.ComboBox();
            this.RequirementsLabel = new System.Windows.Forms.Label();
            this.FeatureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(657, 328);
            this.dataGridView1.TabIndex = 6;
            // 
            // SelectRequirementButton
            // 
            this.SelectRequirementButton.Location = new System.Drawing.Point(630, 410);
            this.SelectRequirementButton.Name = "SelectRequirementButton";
            this.SelectRequirementButton.Size = new System.Drawing.Size(123, 23);
            this.SelectRequirementButton.TabIndex = 5;
            this.SelectRequirementButton.Text = "Select Requirement";
            this.SelectRequirementButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(496, 410);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // FeatureComboBox
            // 
            this.FeatureComboBox.FormattingEnabled = true;
            this.FeatureComboBox.Location = new System.Drawing.Point(95, 25);
            this.FeatureComboBox.Name = "FeatureComboBox";
            this.FeatureComboBox.Size = new System.Drawing.Size(658, 21);
            this.FeatureComboBox.TabIndex = 13;
            this.FeatureComboBox.SelectedIndexChanged += new System.EventHandler(this.FeatureComboBox_SelectedIndexChanged);
            // 
            // RequirementsLabel
            // 
            this.RequirementsLabel.AutoSize = true;
            this.RequirementsLabel.Location = new System.Drawing.Point(15, 55);
            this.RequirementsLabel.Name = "RequirementsLabel";
            this.RequirementsLabel.Size = new System.Drawing.Size(75, 13);
            this.RequirementsLabel.TabIndex = 12;
            this.RequirementsLabel.Text = "Requirements:";
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(43, 28);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(46, 13);
            this.FeatureLabel.TabIndex = 11;
            this.FeatureLabel.Text = "Feature:";
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeatureComboBox);
            this.Controls.Add(this.RequirementsLabel);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectRequirementButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectRequirementButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox FeatureComboBox;
        private System.Windows.Forms.Label RequirementsLabel;
        private System.Windows.Forms.Label FeatureLabel;
    }
}