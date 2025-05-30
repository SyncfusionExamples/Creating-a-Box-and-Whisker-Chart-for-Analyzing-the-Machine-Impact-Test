using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpactTestDemo
{
    public class ImpactTestModel
    {

        public string MachineName { get; set; }

        public List<double> AbsorbedEnergy { get; set; }

        public ImpactTestModel(string machineName, List<double> absorbedEnergy)
        {
            MachineName = machineName;
            AbsorbedEnergy = absorbedEnergy;
        }
    }
}
