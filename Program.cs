using Dolgozat1126;
List<Varos> varosok = new();
StreamReader sr = new(@"../../../src/varosok.csv");

_ = sr.ReadLine();

while (!sr.EndOfStream)
{
   varosok.Add(new Varos(sr.ReadLine()));
}

Console.WriteLine($"{varosok.Count} város van a listában.");

Console.WriteLine("1. feladat");
Console.WriteLine($"A kínai városokban {varosok.Where(k => k.Orszag == "Kína").Sum(v => v.Lakossag):.00} millió fő él");

Console.WriteLine("\n2. feladat");
Console.WriteLine($"Az indiai városokban átlagosan {varosok.Where(v => v.Orszag == "India").Average(k => k.Lakossag):.00} millió fő él");

Console.WriteLine("\n4. feladat");
Console.WriteLine($"{varosok.MaxBy(v => v.Lakossag).Nev} a legnépesebb város.");

Console.WriteLine("\n4. feladat");
varosok.Where(v => v.Lakossag > 20).OrderByDescending(v => v.Lakossag).ToList().ForEach(Console.WriteLine);

Console.WriteLine("\n5. feladat");
var f5 = varosok.GroupBy(v => v.Orszag).Count(g => g.Count() > 1);
Console.WriteLine($"{f5} olyan ország van ami többször is szerepel");

Console.WriteLine("\n6. feladat");
var f6 = varosok.GroupBy(v => v.Nev[0]).MaxBy(g => g.Count());
Console.WriteLine($"'{f6.Key}' betűvel kezdődik a legtöbb város");