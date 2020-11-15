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
    public partial class FormSelectFeature : Form
    {
        FakeFeatureRepository featureRepository = new FakeFeatureRepository();
        FormSelectProject selectedProject = new FormSelectProject();
        List<Feature> featureList = new List<Feature>();
        

        public FormSelectFeature()
        {
            InitializeComponent();
            featureList = featureRepository.GetAll(selectedProject._SelectedProjectId);
            foreach (Feature feature in featureList)
            {
                DataColumn column = new DataColumn();
                DataRow row = new DataRow();
                column.ColumnName = "Id";
                column.ReadOnly = true;

                dataSet1.Tables.
            }
        }

        private void SelectFeatureButton_Click(object sender, EventArgs e)
        {

            FormModifyFeature formSelectFeature = new FormModifyFeature();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
