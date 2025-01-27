using System;
using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationSolver.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(1, -3, 2, 2, 1)]
        public void Solve_TwoRealRoots_ReturnsExpected(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            var result = Solver.Solve(a, b, c);

            Assert.Equal(expectedRoot1, result.root1, precision: 5);
            Assert.Equal(expectedRoot2, result.root2, precision: 5);
        }

        [Theory]
        [InlineData(1, -2, 1, 1)]
        public void Solve_OneRealRoot_ReturnsExpected(double a, double b, double c, double expectedRoot)
        {
            var result = Solver.Solve(a, b, c);

            Assert.Equal(expectedRoot, result.root1, precision: 5);
            Assert.Equal(expectedRoot, result.root2, precision: 5);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public void Solve_NegativeDelta_ThrowsInvalidOperationException(double a, double b, double c)
        {
            Assert.Throws<InvalidOperationException>(() => Solver.Solve(a, b, c));
        }

        [Theory]
        [InlineData(0, 2, 3)]
        public void Solve_InvalidA_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Solver.Solve(a, b, c));
        }
    }
}