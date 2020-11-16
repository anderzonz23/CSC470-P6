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
    public partial class FormCreateFeature : Form
    {
        FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        Feature feature = new Feature();

        public FormCreateFeature()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateFeatureButton_Click(object sender, EventArgs e)
        {
            feature.Title = TitleTextBox.Text;

            string result = featureRepository.Add(feature);

            if(!result.Equals(""))
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

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
