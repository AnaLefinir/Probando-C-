using System;
using System.Collections.Generic;
public class Band
{
    public string Name;
    public int Musicians;
    public List<Musicos> musicos = new List<Musicos>();

    public void AddMusicos(int x)
    {
        string NameMusico;
        string PosicionMusico;

        Console.WriteLine("Nombre del Musico n°" + (x + 1) + "?");
        NameMusico = Console.ReadLine();
        Console.WriteLine("Que posicion ocupa " + NameMusico);
        PosicionMusico = Console.ReadLine();

        Musicos musico = new Musicos { Name = NameMusico, Position = PosicionMusico };
        musicos.Add(musico);
    }

    public void Announce()
    {
        Console.WriteLine("The " + Name + "'s band have " + Musicians + " musicians.");
    }
}