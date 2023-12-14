using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramForTeamCity
{
    public static class CubicSolver
    {
        public const double EPS = 1e-7;
        public static bool IsSolvable(double a, double b, double c)
        {
            if (Math.Abs(a) < EPS) 
            { 
                if (Math.Abs(b) < EPS) 
                {
                    return false; 
                } 
                else 
                { 
                    return true; 
                } 
            }
            else
            {
                if ( b * b - 4 * c * a > -EPS ) {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static (double, double) Solve(double a, double b, double c)
        {
            if (Math.Abs(a) < EPS)
            {
                if (Math.Abs(b) < EPS)
                {
                    return (double.NaN, double.NaN);
                }
                else
                {
                    return (c / -b, double.NaN);
                }
            }
            else
            {
                var discriminant = b * b - 4 * c * a;
                if (discriminant < -EPS)
                {
                    return (double.NaN, double.NaN);
                }
                else
                {
                    var sqrt = Math.Sqrt(Math.Max(discriminant, 0));
                    if (discriminant < EPS)
                    {
                        var root = -b / (2 * a);
                        return (root, root);
                    }
                    return ((-b + sqrt) / (2 * a), (-b - sqrt) / (2 * a));
                }
            }
        }
    }
}
