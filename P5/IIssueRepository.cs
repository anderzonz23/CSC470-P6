using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    interface IIssueRepository
    {
        string Add(Issue issue);
        List<Issue> GetAll(int ProjectId);
        bool Remove(Issue issue);
        string Modify(Issue issue);
        int GetTotalNumberOfIssues(int ProjectId);
        List<string> GetIssuesByMonth(int ProjectId);
        List<string> GetIssuesByDiscoverer(int ProjectId);
        Issue GetIssueById(int Id);

    }
}
