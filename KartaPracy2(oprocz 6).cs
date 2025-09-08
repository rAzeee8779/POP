internal class Program {

    private static void Main(string[] args)
    {
        // Zad 1 
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 3 == 0)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }

        // Zad 2
        int b = Convert.ToInt32(Console.ReadLine());
        if (b / 100 != 0 && b % 17 == 0)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }

        // Zad 3
        int c = Convert.ToInt32(Console.ReadLine());
        if (c >= 18)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }

        // Zad 4
        int waga = Convert.ToInt32(Console.ReadLine());
        int limit = 20;
        if (waga < limit) {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }

        // Zad 5
        int e = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());
        int g = Convert.ToInt32(Console.ReadLine());
        if ((g > e && g < f) || (g < e && g > f))
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }

        // Zad 7
        int p = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int s = Convert.ToInt32(Console.ReadLine());
        if (p + s * 3 >= k)
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }
    }
}
