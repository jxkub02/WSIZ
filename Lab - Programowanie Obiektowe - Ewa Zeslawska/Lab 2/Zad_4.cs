using System;
using System.Linq;

class Liczba
{
    private int[] cyfry;

    public Liczba(string liczba)
    {
        cyfry = liczba.Select(c => int.Parse(c.ToString())).ToArray();
    }

    public void WypiszLiczbe()
    {
        Console.WriteLine(string.Join("", cyfry));
    }

    public void NadajWartosc(string nowaLiczba)
    {
        cyfry = nowaLiczba.Select(c => int.Parse(c.ToString())).ToArray();
    }

    public void PomnozPrzez(int mnoznik)
    {
        int[] wynik = new int[cyfry.Length + 5]; // zakładam, że wynikowa liczba może być większa
        int carry = 0;

        for (int i = cyfry.Length - 1; i >= 0; i--)
        {
            int produkt = cyfry[i] * mnoznik + carry;
            wynik[i + 1] = produkt % 10;
            carry = produkt / 10;
        }

        if (carry > 0)
        {
            wynik[0] = carry;
        }

        cyfry = wynik.SkipWhile(c => c == 0).ToArray();
    }

    public int Silnia()
    {
        Liczba wynik = new Liczba("1");

        for (int i = 2; i <= int.Parse(string.Join("", cyfry)); i++)
        {
            wynik.PomnozPrzez(i);
        }

        Console.Write("Silnia: ");
        wynik.WypiszLiczbe();

        return int.Parse(string.Join("", wynik.cyfry));
    }
}

class Program
{
    static void Main()
    {
        Liczba liczba = new Liczba("123");
        liczba.WypiszLiczbe();

        liczba.NadajWartosc("456");
        liczba.WypiszLiczbe();

        liczba.PomnozPrzez(2);
        liczba.WypiszLiczbe();

        int silnia = liczba.Silnia();
        Console.WriteLine($"Silnia: {silnia}");
    }
}
