int x = 144;
int y = 5;
int max = 0;
for(int i=0;i<=x;i++)
{
    if (i % y == 0)
    {
        max = i;
    }
}
Console.WriteLine(max);
if (y>x)
    Console.WriteLine("-1");