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
        

        public FormCreateRequirement()
        {
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            FormSelectProject selectedProject = new FormSelectProject();


            InitializeComponent();
            foreach (Feature feature in featureRepository.GetAll(selectedProject._SelectedProjectId))
            {
                FeatureComboBox.Items.Add(feature.Title);
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
