using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class Requirement
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Statement { get; set; }
        public int FeatureId { get; set; }

    }
}
