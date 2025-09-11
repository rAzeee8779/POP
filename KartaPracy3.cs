// zad 1
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if ((a + b) % 2 == 0)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

//zad 2
int a = int.Parse(Console.ReadLine());
int g = int.Parse(Console.ReadLine());
if ((a + g) / 2 > Math.Sqrt(a * g))
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

//zad 3
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if(k == l && k == m && l == m)
    {
    Console.WriteLine("NIE");
    }
else if (k == l && k != m)
{
    Console.WriteLine("TAK "+k);
}
else if (k == m  && k != l)
{
    Console.WriteLine("TAK "+k);
}
else if (l == m && l != k)
{
    Console.WriteLine("TAK "+l);
}
