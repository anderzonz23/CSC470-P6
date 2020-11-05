using P5;
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
    public partial class FormDashboard : Form
    {
        private FakeIssueRepository issueRepository = new FakeIssueRepository();

        public FormDashboard(int projectID)
        {
            InitializeComponent();
            this.CenterToParent();

            NumIssues.Text = issueRepository.GetTotalNumberOfIssues(projectID).ToString();
            
            foreach(string issueByDate in issueRepository.GetIssuesByMonth(projectID))
            {
                IssuesByMonthListBox.Items.Add(issueByDate);
            }

            foreach(string issueByDiscoverer in issueRepository.GetIssuesByDiscoverer(projectID))
            {
                IssuesByDiscovererListBox.Items.Add(issueByDiscoverer);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumIssues_Click(object sender, EventArgs e)
        {

        }
    }
}
