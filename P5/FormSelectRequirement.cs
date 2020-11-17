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
    public partial class FormSelectRequirement : Form
    {
        FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        int currentProjectId;

        public FormSelectRequirement(int projectId)
        {
            InitializeComponent();
            foreach (Feature feature in featureRepository.GetAll(projectId))
            {
                FeatureComboBox.Items.Add(feature.Title);
            }
            currentProjectId = projectId;
        }


    }
}
