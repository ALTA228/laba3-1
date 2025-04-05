class RivTricutnic
{
    static void Main(string[] args)
    {
        Console.Write("Введіть сторону трикутника = ");
        double storona = double.Parse(Console.ReadLine());
        Console.Write("Введіть основу трикутника = ");
        double osnova = double.Parse(Console.ReadLine());
        Console.WriteLine(Per(storona, osnova));
        Console.WriteLine(Ser(storona, osnova));
    }

    static double Per(double storona, double osnova)
    {
        if (storona <= 0 || osnova <= 0)
        {
            Console.WriteLine("Неможливо обчислити перимитр, cторона і основа трикутника повинні бути більшими за нуль.");
            return 0;
        }
        else
        {
            double P = 2 * storona + osnova;
            Console.Write("P = ");
            return P;
        }
    }
    static double Ser(double storona, double osnova)
    {
        if (storona <= 0 || osnova <= 0)
        {
            Console.WriteLine("Неможливо обчислити площю, сторона і основа трикутника повинні бути більшими за нуль.");
            return 0;
        }
        else
        { 
            double S = (osnova * Math.Sqrt(storona * storona - (osnova * osnova) / 4)) / 2;
            Console.Write("S = ");
            return S;
        }
    }
}
