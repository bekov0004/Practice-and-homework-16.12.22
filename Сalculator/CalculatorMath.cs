using System.Text.RegularExpressions;
public class CalculatorMath
{
public const double PI = 3.14;
public const double E = 2.71;
public double Abs(double value)
{
    if(value<0)
    {
        return value*-1;
    }
    else
    {
        return value;
    }
}
public float Abs(float value)
{
    if(value<0)
    {
        return value*-1;
    }
    else
    {
        return value;
    }
}
public short Abs(short value)
{
       if(value<0)
    {
        return (short)(value*-1);
    }
    else
    {
        return (short)value;
    }
}
public int Abs(int value)
{
        if(value<0)
    {
        return value*-1;
    }
    else
    {
        return value;
    }
}
public double Pow(double x, double y)
{
    double cnt =1;
    for (int i = 0; i < y; i++)
    {
        cnt=cnt*x;
    }
    return cnt;
}
public int Sqrt(int d)
{
    int a=0;
    for (int i = 0; i < d; i++)
    {
        if (i*i==d)
        {
            a = i;
        }
    }
    return a;
}
public int Max(int val1, int val2)
{
    if (val1>val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }
}
public int Min(int val1, int val2)
{
    if (val1<val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }
}
 

}