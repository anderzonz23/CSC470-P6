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
    public partial class FormModifyRequirement : Form
    {
        FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
        Requirement requirement;
        Feature currentlyAttachedFeature;

        public FormModifyRequirement(int requirementId)
        {
            InitializeComponent();
            requirement = requirementRepository.GetRequirementById(requirementId);
            currentlyAttachedFeature = featureRepository.GetFeatureById(requirement.FeatureId); // Gets added as default. 

            foreach(Feature feature in featureRepository.GetAll(requirement.ProjectId))
            {
                FeatureComboBox.Items.Add(feature.Title);
            }

            FeatureComboBox.SelectedItem = featureRepository.GetFeatureById(requirement.FeatureId).Title;
            StatementTextBox.Text = requirement.Statement;

            
        }

        private void FeatureLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateRequirementButton_Click(object sender, EventArgs e)
        {
            Requirement newRequirement = new Requirement();
            newRequirement.FeatureId = featureRepository.GetFeatureByTitle(FeatureComboBox.GetItemText(FeatureComboBox.SelectedItem), requirement.ProjectId).Id;
            newRequirement.ProjectId = requirement.ProjectId;
            newRequirement.Statement = StatementTextBox.Text;
            newRequirement.Id = requirement.Id;
            
            string result = requirementRepository.Modify(newRequirement);

            if (!result.Equals(""))
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
