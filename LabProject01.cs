using System;

class Sphere
{
    public double X, Y, Z, R;

    public Sphere(double x, double y, double z, double r)
    {
        X = x; Y = y; Z = z; R = r;
    }

    public bool Contains(double x, double y, double z)
    {
        double dx = x - X, dy = y - Y, dz = z - Z;
        return dx * dx + dy * dy + dz * dz <= R * R;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введіть центр кулі (x y z): ");
        var c = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

        Console.Write("Введіть радіус: ");
        double r = double.Parse(Console.ReadLine());

        Sphere s = new Sphere(c[0], c[1], c[2], r);

        Console.Write("Введіть точку (x y z): ");
        var p = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

        Console.WriteLine(s.Contains(p[0], p[1], p[2])
            ? "Точка попадає в кулю"
            : "Точка не попадає в кулю");
    }
}
