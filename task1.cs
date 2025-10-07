int f1 = 0;
int f2 = 1;
for (int i = 0; i < 100; i++)
{
    int f3 = f1 + f2;
    Console.WriteLine(f3);
    f1 = f2;
    f2 = f3;
}