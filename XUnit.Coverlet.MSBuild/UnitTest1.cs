using Xunit;
using System;
using SquareEquationLib;

namespace SquareEquation.Tests;

public class SquareEquationLib_isUnite
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(double.NaN, 1, 1)]
    [InlineData(1, double.NaN, 1)]
    [InlineData(1, 1, double.NaN)]
    [InlineData(double.NegativeInfinity, 1, 1)]
    [InlineData(1, double.NegativeInfinity, 1)]
    [InlineData(1, 1, double.NegativeInfinity)]
    [InlineData(double.PositiveInfinity, 1, 1)]
    [InlineData(1, double.PositiveInfinity, 1)]
    [InlineData(1, 1, double.PositiveInfinity)]
    public void catchingExceptions(double a, double b, double c)
    {
        try
        {
            SquareEquationLib.SquareEquation.Solve(a, b, c);
        }
        catch (Exception exception)
        {
            Assert.Equal(exception.GetType(), new ArgumentException().GetType());
        }
    }

    [Theory]
    [InlineData(1, -5, 6, new double[]{3, 2})]
    [InlineData(1, -4, -5, new double[]{5, -1})]
    public void TestingTwoRoots(double a, double b, double c, double[] roots)
    {
        double[] actual = SquareEquationLib.SquareEquation.Solve(a, b, c);

        Assert.Equal(roots, actual);
    }

    [Theory]
    [InlineData(1, -6, 9, new double[]{3})]
    [InlineData(1, -8, 16, new double[]{4})]
    public void TestingOneRoot(double a, double b, double c, double[] roots)
    {
        double[] actual = SquareEquationLib.SquareEquation.Solve(a, b, c);

        Assert.Equal(roots, actual);
    }

    [Theory]
    [InlineData(3, -6, 9)]
    [InlineData(2, 5, 7)]
    public void TestingNoRoot(double a, double b, double c)
    {
        Assert.True(SquareEquationLib.SquareEquation.Solve(a, b, c).Length == 0);
    }

}