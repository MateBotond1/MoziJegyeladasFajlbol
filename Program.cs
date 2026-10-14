using MoziJegyeladasFajlbol;
List<Film> lista = new List<Film>();
Console.WriteLine("Adatok beolvasása a filmek.txt fájlból...");
foreach (string beolvasott in File.ReadAllLines("filmek.txt").Skip(1))
{
    string[] adatok =beolvasott.Split(";");
    Film aktualis = new Film();
    aktualis.Cim=adatok[0];
    aktualis.EladottJegyek = int.Parse(adatok[1]);
    aktualis.JegyAr = int.Parse(adatok[2]);
    lista.Add(aktualis);
}
int eladottjegyek = 0;
int osszbevetel = 0;

Console.WriteLine("========================================");
Console.WriteLine("Vetített filmek és bevételek:");
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"\t- {lista[i].Cim}: {lista[i].EladottJegyek} db jegy -> Bevétel:{lista[i].EladottJegyek * lista[i].JegyAr} Ft");
    eladottjegyek += lista[i].EladottJegyek;
    osszbevetel += lista[i].EladottJegyek * lista[i].JegyAr;
}
double atlag = eladottjegyek/lista.Count;
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összes eladott jegy: {eladottjegyek} db");
Console.WriteLine($"Összes napi jegybevétel: {osszbevetel} Ft");
Console.WriteLine($"Átlagos eladott jegyszám/film: {atlag:F0} db");
Console.WriteLine("========================================");