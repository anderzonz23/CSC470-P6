using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormModifyFeature : Form
    {
        FakeFeature featureRepository = new FakeFeatureRepository();
        Feature feature = new Feature();

        public FormModifyFeature()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyFeatureButton_Click(object sender, EventArgs e)
        {
            feature.Title = TitleTextBox.Text;

            if (!featureRepository.Add(feature).Equals(""))
            {
                MessageBox.Show(featureRepository.Add(feature), "Attention");
            }
            else
            {
                this.Close();
            }
        }
    }
}
