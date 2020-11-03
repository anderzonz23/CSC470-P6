using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> IssueStatuses = new List<IssueStatus>();
        public void Add(int Id, string value)
        {

        }
        public List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            return 0;
        }
        public string GetValueById(int Id)
        {
            return "";
        }

    }
}
