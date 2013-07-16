using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviationAlgorithm
{
    class StandardDeviation
    {
        public static double SimpleStandardDeviation(double[] values)
        {
            return Math.Sqrt(VarianceAlgorithm.Variance.simple_variance(values));
        }
    }
}
