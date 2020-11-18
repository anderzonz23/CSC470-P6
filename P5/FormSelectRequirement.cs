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
        FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
        List<Requirement> requirementList;
        int currentProjectId;
        int currentFeatureId;

        public FormSelectRequirement(int projectId)
        {
            InitializeComponent();
            foreach (Feature feature in featureRepository.GetAll(projectId))
            {
                FeatureComboBox.Items.Add(feature.Title);
            }
            currentProjectId = projectId;


           
        }

        public void SetTable()
        {
            DataSet data = new DataSet("RequirementsDataSet");
            DataTable dataTable2 = new DataTable("RequirementsDataTable");
            DataRow dataRow2;

            InitializeComponent();
            requirementList = requirementRepository.GetAll(currentProjectId);

            // Setup the table to insert the features into so we can select from them. 
            DataColumn idDataColumn = new DataColumn();
            idDataColumn.DataType = System.Type.GetType("System.Int32");
            idDataColumn.ColumnName = "Id";

            DataColumn titleDataColumn = new DataColumn();
            titleDataColumn.ColumnName = "Requirement";
            titleDataColumn.DataType = System.Type.GetType("System.String");

            dataTable2.Columns.Add(idDataColumn);
            dataTable2.Columns.Add(titleDataColumn);

            foreach (Requirement requirement in requirementList)
            {
                // If the project id's match.
                if (currentProjectId == requirement.ProjectId && currentFeatureId == requirement.FeatureId)
                {
                    // Make a new row, add it. 
                    dataRow2 = dataTable2.NewRow();
                    dataRow2["Id"] = requirement.Id;
                    dataRow2["Requirement"] = requirement.Statement;
                    dataTable2.Rows.Add(dataRow2);
                }
            }

            dataGridView1.DataSource = dataTable2;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ReadOnly = true;
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {

        }

        private void FeatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Feature testFeature = new Feature();
            testFeature = featureRepository.GetFeatureByTitle(FeatureComboBox.Text, currentProjectId);
            currentFeatureId = testFeature.Id;
            SetTable();

        }
    }
}
