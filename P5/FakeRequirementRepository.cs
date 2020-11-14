using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND = "Requirement does not exist";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        private static List<Requirement> requirements = new List<Requirement>();

        public string Add(Requirement requirement)
        {
            // assign feature's ProjectId in the create feature form before it calls this method, based on the current selected project
            if(requirement.FeatureId == 0)
            {
                return MISSING_FEATUREID_ERROR;                     //the first ID is 1, and default value is 0 which would indicate a legitimate feature has not been selected
            }
            if (requirement.ProjectId == 0)
            {
                return MISSING_PROJECTID_ERROR;                                  //the first project's ID is 1, and default value is 0 which would indicate a legitimate project has not been selected
            }                                                                    //however there is nowhere to select a project in the form in P7.pdf, so wouldn't we just assign it to the current project?
            string newRequirementStatement = requirement.Statement.Trim();
            if (IsDuplicate(newRequirementStatement, requirement.ProjectId))
            {
                return DUPLICATE_STATEMENT_ERROR;
            }
            if (newRequirementStatement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            requirement.Id = GetNextId();
            requirements.Add(requirement);
            return NO_ERROR;
        }

        public bool IsDuplicate(string statement, int projectId)
        {
            bool isDuplicate = false;
            foreach (Requirement requirement in requirements)
            {
                if (statement == requirement.Statement && projectId == requirement.ProjectId)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Requirement r in requirements)
            {
                currentMaxId = r.Id;
            }
            return ++currentMaxId;
        }

        public string Modify(Requirement modifiedRequirement)
        {
            if (modifiedRequirement.FeatureId == 0)
            {
                return MISSING_FEATUREID_ERROR;                     //the first ID is 1, and default value is 0 which would indicate a legitimate feature has not been selected
            }
            if (modifiedRequirement.ProjectId == 0)
            {
                return MISSING_PROJECTID_ERROR;                                  //the first project's ID is 1, and default value is 0 which would indicate a legitimate project has not been selected
            }                                                                    //however there is nowhere to select a project in the form in P7.pdf, so wouldn't we just assign it to the current project?
            string newStatementTitle = modifiedRequirement.Statement.Trim();
            if (newStatementTitle == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            if (IsDuplicate(newStatementTitle, modifiedRequirement.ProjectId))
            {
                return DUPLICATE_STATEMENT_ERROR;
            }
            int index = 0;
            foreach (Requirement temporaryRequirement in requirements)
            {
                if (modifiedRequirement.Id == temporaryRequirement.Id)
                {
                    requirements[index] = modifiedRequirement;
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND;
        }

        public List<Requirement> GetAll(int ProjectId)
        {                                                                           //returns all requirements in current project
            int index = 0;
            List<Requirement> currentProjectRequirements = new List<Requirement>();
            foreach (Requirement requirement in requirements)
            {
                if (requirement.ProjectId == ProjectId)
                {
                    currentProjectRequirements.Add(requirement);
                    index++;
                }

            }
            return currentProjectRequirements;
        }

        public Requirement GetRequirementById(int requirementId)
        {
            int index = 0;
            foreach (Requirement temporaryRequirement in requirements)
            {
                if (requirementId == temporaryRequirement.Id)
                {
                    return temporaryRequirement;
                }
                index++;
            }

            Requirement errorRequirement = new Requirement();                            //forced to return a requirement even if one does not exist with the given ID.
            errorRequirement.Statement = REQUIREMENT_NOT_FOUND;      //so send a blank requirement with the error message in the statement.
            return errorRequirement;
        }

        public int CountByFeatureId(int featureId)
        {                                                       //the functionality of this method isn't specified, but I assume it wants the number of requirements assigned to the given features
            int count = 0;

            foreach (Requirement requirement in requirements)
            {
                if (requirement.FeatureId == featureId)
                {
                    count++;
                }

            }

            return count;
        }

        public string Remove(Requirement requirementToRemove)
        {
            int index = 0;
            foreach (Requirement requirement in requirements)
            {
                if (requirement.Id == requirementToRemove.Id)
                {
                    requirement.RemoveAt(index);
                    return REQUIREMENT_NOT_FOUND;
                }
                index++;
            }

            return NO_ERROR;
        }
        public void RemoveByFeatureId(int featureId)
        {
            foreach (Requirement requirement in requirements)
            {
                if (requirement.FeatureId == featureId)
                {
                    Remove(requirement);
                }

            }
        }
    }
}
