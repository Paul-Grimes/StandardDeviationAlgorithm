using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceAlgorithm
{
    class Variance
    {
        public static int simple_variance(int[] values)
        {
            float total = 0;
            float totaledSquared = 0;
            float counter = 0;
           

            foreach (int value in values)
            {
                counter ++;
                total += value;
                totaledSquared += value * value;
            }

            return Convert.ToInt32((totaledSquared - ((total * total) / counter)) / (counter - 1));
        }
    }
}
