using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Dsicovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future. Unless it involves Marty McFly.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        public const string DUPLICATE_ISSUE_TITLE_ERROR = "Issue title already exists.";
        public const string NO_ISSUE_FOUND_ERROR = "No issue found.";

        private static List<Issue> Issues = new List<Issue>();
        private List<string> IssuesByMonth = new List<string>();

        public FakeIssueRepository()
        {
            Issue defaultIssue = new Issue();
            DateTime dateTime = new DateTime(2020, 1, 1);
            defaultIssue.DiscoveryDate = dateTime;
            defaultIssue.Id = 1;
            defaultIssue.ProjectId = 1;
            defaultIssue.InitialDescription = "Default description for testing.";
            defaultIssue.Title = "Default Issue";

            Issues.Add(defaultIssue);
        }


        public string ValidateIssue(Issue issue)
        {
            return "";
        }

        public bool IsDuplicate(string title)
        {
            bool isDuplicate = false;
            foreach (Issue issue in Issues)
            {
                if (title == issue.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        public string Add(Issue issue)
        {
            string newIssueTitle = issue.Title.Trim();
            if (IsDuplicate(newIssueTitle))
            {
                return DUPLICATE_ISSUE_TITLE_ERROR;
            }
            if (newIssueTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if (issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.DiscoveryDate > DateTime.Now)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.Discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            issue.Id = GetNextId();
            Issues.Add(issue);
            return NO_ERROR;
        }
        public List<Issue> GetAll(int ProjectId)
        {
            return Issues;
        }
        public bool Remove(Issue issueToRemove)
        {
            int index = 0;
            foreach (Issue issue in Issues)
            {
                if (issue.Id == issueToRemove.Id)
                {
                    Issues.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
        public string Modify(Issue issue)
        {
            if (issue.Title.Trim() == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if (issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.DiscoveryDate > DateTime.Now)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.Discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            int index = 0;
            foreach (Issue temporaryIssue in Issues)
            {
                if (issue.Id == temporaryIssue.Id)
                {
                    Issues[index] = issue;
                    return NO_ERROR;
                }
                index++;
            }
            return NO_ISSUE_FOUND_ERROR;
        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int total = 0;
            foreach (Issue issue in Issues)
            {
                if (issue.ProjectId == ProjectId)
                {
                    total++;
                }
            }

            return total;
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            /*
            foreach (Issue issue in Issues)
            {
                if (issue.ProjectId == ProjectId)
                { 
                    string[] parts = IssuesByMonth[issue.DiscoveryDate.Month].Split(':');
                    parts[parts.Length - 1] = (Convert.ToInt32(parts[parts.Length - 1]) + 1).ToString();    // This incremements the integer inside the string
                    IssuesByMonth[issue.DiscoveryDate.Month] = string.Join(":", parts);
                }
            }
            */

            Issue tempIssue = Issues[0];
            return IssuesByMonth;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<string> IssuesByDiscoverer = new List<string>();
            bool exists = false;
           
            foreach (Issue issue in Issues)
            {
                if (issue.ProjectId == ProjectId)
                {
                 foreach (string discoverer in IssuesByDiscoverer)
                        if (discoverer.Contains(issue.Discoverer))
                        {
                            exists = true;
                            string[] parts = discoverer.Split(':');
                            parts[parts.Length - 1] = (Convert.ToInt32(parts[parts.Length - 1]) + 1).ToString();    // This incremements the integer inside the string
                            discoverer.Replace(discoverer, string.Join(":", parts));  
                        }
                 if(exists == false)
                    {
                        IssuesByDiscoverer.Add(issue.Discoverer + ":1");
                    }
                }
            }

            return IssuesByDiscoverer;
        }
        public Issue GetIssueById(int Id)
        {
            return Issues[Id];
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Issue i in Issues)
            {
                currentMaxId = i.Id;
            }
            return ++currentMaxId;
        }
    }
}
