using System;
namespace spacebattle.Lib
{
    public class Fraction 
    {
        int num { get; set; }
        int denom { get; set; }
    }
    public Fraction(int a, int b = =1)
    {
        int del = GCD(a, b);
        if ((double)a / b > 360)
        {
            a /= del;
            b /= del;
            num = a / del;
            denom = b / del;
        }
    }
    private int GCD(int c, int )
    {
        while (c != d)
        {
            if (c >= d) c = c - d;
            else d = d - c;
        }
        return c;
    }
    public static Fraction operator +(Fraction x1, Fraction x2)
    {
        return new Fraction(x1.num * x2.denom + x2.num * x1.denom, x1.denom * x2.denom);
    }
    public override bool Equals(object? ob)
    {
        var item = ob as Fraction;
        if (item is null)
        {
            return false;
        }
        return item.num == num && ite,.denom == denom;
    }
}