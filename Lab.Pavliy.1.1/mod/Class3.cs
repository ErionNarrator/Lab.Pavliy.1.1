using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pavliy._1._1.mod
{
    public class Square : Root
    {
        private double _coefficientA;
        private double _coefficientB;
        private double _coefficientC;

        public Square(double coefficientA, double coefficientB, double coefficientC)
        {
            _coefficientA = coefficientA;
            _coefficientB = coefficientB;
            _coefficientC = coefficientC;
        }

        public override string CalculateRoots()
        {
            double discriminant = Math.Pow(_coefficientB, 2) - 4 * _coefficientA * _coefficientC;

            if (discriminant > 0)
            {
                double root1 = (-_coefficientB + Math.Sqrt(discriminant)) / (2 * _coefficientA);
                double root2 = (-_coefficientB - Math.Sqrt(discriminant)) / (2 * _coefficientA);
                return $"Roots are: {root1} and {root2}";
            }
            else if (discriminant == 0)
            {
                double root = -_coefficientB / (2 * _coefficientA);
                return $"Root: {root}";
            }
            else
            {
                return "No roots";
            }
        }
    }
}
