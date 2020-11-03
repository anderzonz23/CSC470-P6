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
        private List<string> IssuesByMonth = ["2020 - 1:0", "2020 - 2:0", "2020 - 3:0", "2020 - 4:0", "2020 - 5:0", "2020 - 6:0", "2020 - 7:0", "2020 - 8:0", "2020 - 9:0", "2020 - 10:0", "2020 - 11:0", "2020 - 12:0" ];

        public string ValidateIssue(Issue issue)
        {

            return "";
        }

        public bool IsDuplicate(string title)
        {
            bool isDuplicate = false;
            foreach (Issue i in Issues)
            {
                if (title == i.Title)
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
        public bool Remove(Issue issue)
        {
            int index = 0;
            foreach (Issue i in Issues)
            {
                if (i.Id == issue.Id)
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
            foreach (Issue i in Issues)
            {
                if (issue.Id == i.Id)
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
            int index = 0;
            int total = 0;
            foreach (Issue i in Issues)
            {
                if (i.ProjectId == ProjectId)
                {
                    total++;
                }
                index++;
            }

            return total;
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            int index = 0;
            
            foreach (Issue i in Issues)
            {
                if (i.ProjectId == ProjectId)
                { 
                    string[] parts = IssuesByMonth[i.DiscoveryDate.Month].Split(':');
                    parts[parts.Length - 1] = (Convert.ToInt32(parts[parts.Length - 1]) + 1).ToString();    // This incremements the integer inside the string
                    IssuesByMonth[i.DiscoveryDate.Month] = string.Join(":", parts);

                }
                index++;
            }

            return IssuesByMonth;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<string> IssuesByDiscoverer = new List<string>();
            int index = 0;
            bool exists = false;
           
            foreach (Issue i in Issues)
            {
                if (i.ProjectId == ProjectId)
                {
                 foreach (string s in IssuesByDiscoverer)
                        if (s.Contains(i.Discoverer))
                        {
                            exists = true;
                            string[] parts = s.Split(':');
                            parts[parts.Length - 1] = (Convert.ToInt32(parts[parts.Length - 1]) + 1).ToString();    // This incremements the integer inside the string
                            s.Replace(s, string.Join(":", parts));  
                        }
                 if(exists == false)
                    {
                        IssuesByDiscoverer.Add(i.Discoverer + ":1");
                    }


                }
                index++;
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
