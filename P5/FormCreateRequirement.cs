using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P5;

namespace Builder
{
    public partial class FormCreateRequirement : Form
    {
        FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
        int currentProjectId;

        public FormCreateRequirement(int projectId)
        {
            InitializeComponent();
            foreach (Feature feature in featureRepository.GetAll(projectId))
            {
                FeatureComboBox.Items.Add(feature.Title);
            }
            currentProjectId = projectId;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FeatureComboBox.Text.Equals(""))
            {
                CreateRequirementButton.Enabled = true;
                StatementTextBox.Enabled = true;
            }
        }

        private void CreateRequirementButton_Click(object sender, EventArgs e)
        {
            Feature feature = featureRepository.GetFeatureByTitle(this.FeatureComboBox.GetItemText(FeatureComboBox.SelectedItem), currentProjectId);
            Requirement requirement = new Requirement();
            requirement.FeatureId = feature.Id;
            requirement.ProjectId = currentProjectId;
            requirement.Statement = StatementTextBox.Text;
            string result = requirementRepository.Add(requirement);

            if (!result.Equals(""))
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                this.Close();
            }
        }

        private void StatementTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeatureLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
