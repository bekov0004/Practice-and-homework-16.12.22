CalculatorMath Calcul = new CalculatorMath();
int n,k;
n =  Convert.ToInt32(Console.ReadLine());
k =  Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Max = {Calcul.Sqrt(n)}");
System.Console.WriteLine($"Min = {Calcul.Min(n,k)}");
