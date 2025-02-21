using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestFixture]
public class TestPontHat
{
    [Test]
    public void TestJoPontszamok()
    {
        // Teszteljük a helyes pontszámokat és osztályzatokat
        PontHat pont = new PontHat(95);
        Assert.AreEqual("Pontszám: 95, Osztályzat: 5", pont.Eredmeny());

        pont.SetPontszam(85);
        Assert.AreEqual("Pontszám: 85, Osztályzat: 4", pont.Eredmeny());

        pont.SetPontszam(75);
        Assert.AreEqual("Pontszám: 75, Osztályzat: 3", pont.Eredmeny());

        pont.SetPontszam(55);
        Assert.AreEqual("Pontszám: 55, Osztályzat: 2", pont.Eredmeny());

        pont.SetPontszam(50);
        Assert.AreEqual("Pontszám: 50, Osztályzat: 2", pont.Eredmeny());
    }

    [Test]
    public void TestHatarErtekPontszamok()
    {
        // Teszteljük a határértékeket
        PontHat pont = new PontHat(90);
        Assert.AreEqual("Pontszám: 90, Osztályzat: 5", pont.Eredmeny());

        pont.SetPontszam(80);
        Assert.AreEqual("Pontszám: 80, Osztályzat: 4", pont.Eredmeny());

        pont.SetPontszam(65);
        Assert.AreEqual("Pontszám: 65, Osztályzat: 3", pont.Eredmeny());

        pont.SetPontszam(50);
        Assert.AreEqual("Pontszám: 50, Osztályzat: 2", pont.Eredmeny());
    }

    [Test]
    public void TestHibasPontszamok()
    {
        // Teszteljük a hibás pontszámokat
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new PontHat(-1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new PontHat(101));

        PontHat pont = new PontHat(90);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => pont.SetPontszam(-5));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => pont.SetPontszam(105));
    }
}