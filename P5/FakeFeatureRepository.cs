using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public const string EMPTY_TITLE_ERROR = "Title must have a value";
        public const string NOT_FOUND_ERROR = "Feature not found.";
        public const string INVALID_pROJECT_ID_ERROR = "Invalid Project Id for Feature.";

        private static List<Feature> features = new List<Feature>();

        public string Add(Feature feature)
        {
            // assign feature's ProjectId in the create feature form before it calls this method, based on the current selected project
            string newFeatureTitle = feature.Title.Trim();
            if (IsDuplicate(newFeatureTitle, feature.ProjectId))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if (newFeatureTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            feature.Id = GetNextId();
            features.Add(feature);
            return NO_ERROR;
        }

        public bool IsDuplicate(string title, int projectId)
        {
            bool isDuplicate = false;
            foreach (Feature feature in features)
            {
                if (title == feature.Title && projectId == feature.ProjectId )
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Feature f in features)
            {
                currentMaxId = f.Id;
            }
            return ++currentMaxId;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            return features;
        }

        public string Remove(Feature featureToRemove)
        {
            int index = 0;
            foreach (Feature feature in features)
            {
                if (feature.Id == featureToRemove.Id)
                {
                    features.RemoveAt(index);
                    return NOT_FOUND_ERROR;
                }
                index++;
            }

            return NO_ERROR;
        }

        public string Modify(Feature modifiedFeature)
        {
            string newFeatureTitle = modifiedFeature.Title.Trim();
            if (newFeatureTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if (IsDuplicate(newFeatureTitle, modifiedFeature.ProjectId))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            int index = 0;
            foreach (Feature temporaryFeature in features)
            {
                if (modifiedFeature.Id == temporaryFeature.Id)
                {
                    features[index] = modifiedFeature;
                    return NO_ERROR;
                }
                index++;
            }
            return NOT_FOUND_ERROR;
        }

        public Feature GetFeatureById(int featureId)
        {
            int index = 0;
            foreach (Feature temporaryFeature in features)
            {
                if (featureId == temporaryFeature.Id)
                {
                    return temporaryFeature;
                }
                index++;
            }

            Feature newFeature = new Feature();                            //forced to return a feature even if one does not exist with the given ID.
            newFeature.Title = NOT_FOUND_ERROR;      //so send a blank feature with the error message in the title.
            return newFeature;
        }

        public Feature GetFeatureByTitle(string title)
        {
            int index = 0;
            foreach (Feature temporaryFeature in features)
            {
                if (title == temporaryFeature.Title)                //there can be duplicate titles accross different projects.. should we return first one found or only search in current project?
                {
                    return temporaryFeature;
                }
                index++;
            }

            Feature newFeature = new Feature();                            //forced to return a feature even if one does not exist with the given ID.
            newFeature.Title = NOT_FOUND_ERROR;      //so send a blank feature with the error message in the title.
            return newFeature;

        }
    }
}
