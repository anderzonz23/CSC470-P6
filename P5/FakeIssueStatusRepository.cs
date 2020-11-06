using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        public const string NO_ISSUESTATUS_FOUND = "No IssueStatus was found based on the input given.";
        private static List<IssueStatus> IssueStatuses = new List<IssueStatus>();
        public void Add(int Id, string value)
        {
            IssueStatus NewIssueStatus = new IssueStatus();
            NewIssueStatus.Id = Id;
            NewIssueStatus.Value = value;
            IssueStatuses.Add(NewIssueStatus);
        }
        public List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            foreach(IssueStatus i in IssueStatuses)
            {
                if (i.Value == value)
                    return i.Id;
            }

            return -1;      //error, no status found
        }
        public string GetValueById(int Id)
        {
            foreach (IssueStatus i in IssueStatuses)
            {
                if (i.Id == Id)
                    return i.Value;
            }

            return NO_ISSUESTATUS_FOUND;
        }

    }
}
