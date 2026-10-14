using MoziJegyeladasFajlbol;
List<Film> lista = new List<Film>();
Console.WriteLine("Adatok beolvasása a filmek.txt fájlból...");
foreach (string beolvasott in File.ReadAllLines("filmek.txt").Skip(1))
{
    string[] adatok =beolvasott.Split(";");
    Film aktualis = new Film();
    aktualis.Cim=adatok[0];
    aktualis.EladottJegyek = int.Parse(adatok[1]);
    aktualis.EladottJegyek = int.Parse(adatok[2]);
    lista.Add(aktualis);
}

