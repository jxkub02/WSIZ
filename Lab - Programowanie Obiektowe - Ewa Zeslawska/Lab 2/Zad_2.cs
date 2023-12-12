using System;

class Sumator
{
    private int[] Liczby;

    public Sumator(int[] numbers)
    {
        Liczby = numbers;
    }

    public int Suma()
    {
        return Liczby.Sum();
    }

    public int SumaPodziel2()
    {
        return Liczby.Where(x => x % 2 == 0).Sum();
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }

    public void WypiszWszystkieElementy()
    {
        Console.WriteLine(string.Join(", ", Liczby));
    }

    public void WypiszElementyPrzedzial(int lowIndex, int highIndex)
    {
        for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
        {
            Console.Write(Liczby[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Sumator sumator = new Sumator(numbers);

        Console.WriteLine($"Suma: {sumator.Suma()}");
        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");
        Console.WriteLine($"Liczba elementów: {sumator.IleElementow()}");
        Console.Write("Wszystkie elementy: ");
        sumator.WypiszWszystkieElementy();
        Console.Write("Elementy w przedziale [1, 3]: ");
        sumator.WypiszElementyPrzedzial(1, 3);
    }
}
