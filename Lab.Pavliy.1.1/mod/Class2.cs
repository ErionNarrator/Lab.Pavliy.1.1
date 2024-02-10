using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pavliy._1._1.mod
{
    public class Linear : Root
    {
        private double _coefficientB;
        private double _coefficientC;

        public Linear(double coefficientB, double coefficientC)
        {
            _coefficientB = coefficientB;
            _coefficientC = coefficientC;
        }

        public override string CalculateRoots()
        {
            if (_coefficientB == 0)
            {
                return "No roots";
            }
            else
            {
                double root = -_coefficientC / _coefficientB;
                return $"The root is: {root}";
            }
        }
    }
}
