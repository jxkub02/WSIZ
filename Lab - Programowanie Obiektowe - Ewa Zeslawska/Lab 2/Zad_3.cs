using System;

class Data
{
    private DateTime currentDate;

    public Data()
    {
        currentDate = DateTime.Now;
    }

    public void PrzesunTydzienWPrzod()
    {
        currentDate = currentDate.AddDays(7);
    }

    public void PrzesunTydzienWTyl()
    {
        currentDate = currentDate.AddDays(-7);
    }

    public void WypiszBiezacaDate()
    {
        Console.WriteLine($"Bieżąca data: {currentDate:d}");
    }
}

class Program
{
    static void Main()
    {
        Data data = new Data();
        data.WypiszBiezacaDate();

        data.PrzesunTydzienWPrzod();
        data.WypiszBiezacaDate();

        data.PrzesunTydzienWTyl();
        data.WypiszBiezacaDate();
    }
}
