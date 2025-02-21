using System;

public class PontHat
{
    public int Pontszam { get; private set; }
    public int Osztalyzat { get; private set; }

    // Konstruktor, alapértelmezett pontszám 0
    public PontHat(int pontszam = 0)
    {
        SetPontszam(pontszam);
    }

    // Pontszám beállítása, érvénytelen pontszám esetén hibát dob
    public void SetPontszam(int pontszam)
    {
        if (pontszam < 0 || pontszam > 100)
        {
            throw new ArgumentOutOfRangeException("Hibás pontszám! A pontszámnak 0 és 100 között kell lennie.");
        }

        Pontszam = pontszam;
        Osztalyzat = MegallapitasOsztalyzat();
    }

    // Osztályzat meghatározása
    private int MegallapitasOsztalyzat()
    {
        if (Pontszam >= 90)
        {
            return 5;
        }
        else if (Pontszam >= 80)
        {
            return 4;
        }
        else if (Pontszam >= 65)
        {
            return 3;
        }
        else if (Pontszam >= 50)
        {
            return 2;
        }
        else
        {
            return 1;  // Az alatti pontszámokhoz 1-es osztályzat
        }
    }

    // Eredmény lekérése
    public string Eredmeny()
    {
        return $"Pontszám: {Pontszam}, Osztályzat: {Osztalyzat}";
    }
}