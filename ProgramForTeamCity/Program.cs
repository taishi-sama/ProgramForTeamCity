namespace ProgramForTeamCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cubic equations solver in format of a*x^2 + b*x + c = 0 regardless of x");
            Console.WriteLine("Write value of a!");
            var s1 = Console.ReadLine();
            var a = double.Parse(s1, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Write value of b!");
            var s2 = Console.ReadLine();
            var b = double.Parse(s2, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Write value of c!");
            var s3 = Console.ReadLine();
            var c = double.Parse(s3, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine($"Has roots: {CubicSolver.IsSolvable(a, b, c)}");
            var (root1, root2) = CubicSolver.Solve(a, b, c);
            Console.WriteLine($"Root 1: {root1}, root 2: {root2}");

        }
    }
}
