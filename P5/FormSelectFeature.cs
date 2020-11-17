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
        List<Feature> featureList;
        public int featureId;


        public FormSelectFeature(int projectId)
        {
            
            DataSet data = new DataSet("FeaturesDataSet");
            DataTable dataTable = new DataTable("FeaturesDataTable");
            DataRow dataRow;

            InitializeComponent();
            featureList = featureRepository.GetAll(projectId);

            // Setup the table to insert the features into so we can select from them. 
            DataColumn idDataColumn = new DataColumn();
            idDataColumn.DataType = System.Type.GetType("System.Int32");
            idDataColumn.ColumnName = "Id";

            DataColumn titleDataColumn = new DataColumn();
            titleDataColumn.ColumnName = "Feature";
            titleDataColumn.DataType = System.Type.GetType("System.String");

            dataTable.Columns.Add(idDataColumn);
            dataTable.Columns.Add(titleDataColumn);
            
            foreach (Feature feature in featureList)
            {
                // If the project id's match.
                if (projectId == feature.ProjectId)
                {
                    // Make a new row, add it. 
                    dataRow = dataTable.NewRow();
                    dataRow["Id"] = feature.Id;
                    dataRow["Feature"] = feature.Title;
                    dataTable.Rows.Add(dataRow);
                }
            }
            
            dataGridView1.DataSource = dataTable;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.ReadOnly = true;
        }

        private void SelectFeatureButton_Click(object sender, EventArgs e)
        {
            featureId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            featureId = -1;
            this.Close();
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
