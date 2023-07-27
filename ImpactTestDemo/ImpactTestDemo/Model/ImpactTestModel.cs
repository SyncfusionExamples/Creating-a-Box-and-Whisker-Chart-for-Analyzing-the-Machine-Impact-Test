using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpactTestDemo
{
    public class ImpactTestModel
    {

        public double Machine { get; set; }

        public List<double> EnergyAbsorptionValues { get; set; }

        public ImpactTestModel(double machine, List<double> energyAbsorptionValues)
        {
            Machine = machine;
            EnergyAbsorptionValues = energyAbsorptionValues;
        }
    }
}
