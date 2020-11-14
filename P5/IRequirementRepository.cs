using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetAll(int ProjectId);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        int CountByFeatureId(int featureId);
        void RemoveByFeatureId(int featureId);
        Requirement GetRequirementById(int requirementId);
    }
}
