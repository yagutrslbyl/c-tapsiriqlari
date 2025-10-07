Console.WriteLine("eded daxil et");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (n>0)

{
  s = s + 1;
  n = n / 10;

}

Console.WriteLine("en boyuk mertebe: " + Math.Pow(10, s-1));