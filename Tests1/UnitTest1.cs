using ProgramForTeamCity;

namespace Tests1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var (x1, x2) = CubicSolver.Solve(1, 0, -4);
            var (lesser, bigger) = (Math.Min(x1, x2), Math.Max(x1, x2));
            Assert.That(lesser, Is.InRange(-2 - CubicSolver.EPS, -2 + CubicSolver.EPS));
            Assert.That(bigger, Is.InRange(2 - CubicSolver.EPS, 2 + CubicSolver.EPS));

        }
        [Test]
        public void Test2()
        {
            var (x1, x2) = CubicSolver.Solve(1, 0, 4);
            Assert.That(x1, Is.NaN);
            Assert.That(x2, Is.NaN);

        }
        [Test]
        public void Test3()
        {
            var (x1, x2) = CubicSolver.Solve(0, 1, 2);
            Assert.That(x1, Is.InRange(-2 - CubicSolver.EPS, -2 + CubicSolver.EPS));
            Assert.That(x2, Is.NaN);
        }
    }
}