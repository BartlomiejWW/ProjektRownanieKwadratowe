using System;

namespace QuadraticEquationSolver
{
    public static class Solver
    {
        public static (double root1, double root2) Solve(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Współczynnik 'a' nie może być równy 0.");
            }

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                throw new InvalidOperationException("Brak pierwiastków rzeczywistych.");
            }

            double sqrtDelta = Math.Sqrt(delta);
            double root1 = (-b + sqrtDelta) / (2 * a);
            double root2 = (-b - sqrtDelta) / (2 * a);

            return (root1, root2);
        }
    }
}