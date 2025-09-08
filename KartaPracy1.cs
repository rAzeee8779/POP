internal class Program {

    private static void Main(string[] args) {
        // Zad 1
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int a2 = a * a;
        int b2 = b * b;
        Console.WriteLine(a2 + b2);

        // Zad 2
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((c+d)*(c+d));

        // Zad 3
        int e = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((Math.Pow(e - f, 3))); 

        // Zad 4
        int g = Convert.ToInt32(Console.ReadLine());    
        int h = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(g*h*j);

        // Zad 5
        int o = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(2 * (o + p)/5);
        Console.WriteLine((o+p) * 0.4);

        // Zad 6
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(r/1.23);

        // Zad 7
        int y = Convert.ToInt32(Console.ReadLine());
        int t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(y%t);
    }   
}
