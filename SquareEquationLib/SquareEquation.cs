namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double D;
        double[] ans;
        double eps = Math.Pow(10,-9);
        if (Math.Abs(a) < eps) throw new System.ArgumentException();
        if (Double.IsNaN(Math.Abs(a)) || Double.IsInfinity(Math.Abs(a))) throw new System.ArgumentException();
        if (Double.IsNaN(Math.Abs(b)) || Double.IsInfinity(Math.Abs(b))) throw new System.ArgumentException();
        if (Double.IsNaN(Math.Abs(c)) || Double.IsInfinity(Math.Abs(c))) throw new System.ArgumentException();
        D = b*b-4*a*c;
        if (D <= -eps &&  !(Math.Abs(D) < eps))
        {
            return Array.Empty<double>();
        }
        else if (D < eps)
        {
            D = 0;
            ans = new double[1];
            double x = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
            ans[0] = x;
            return ans;
        }
        else
        {
            ans = new double[2];
            double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
            double x2 = c/x1;
            ans [0] = x1;
            ans [1] = x2;
            return ans;
        }
    }
}
