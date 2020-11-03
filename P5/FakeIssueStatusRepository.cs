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
        void Add(int Id, string value)
        {

        }
        List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }
        int GetIdByStatus(string value)
        {
            return 0;
        }
        string GetValueById(int Id)
        {
            return "";
        }

    }
}
