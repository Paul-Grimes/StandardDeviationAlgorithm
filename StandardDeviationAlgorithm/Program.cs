using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = { 34.7, 23.6, 28.5, 37.8, 35.4, 28.6, 37.3, 48.9, 24.0 };

            Console.WriteLine(StandardDeviation.SimpleStandardDeviation(myArray));

        }
    }
}
