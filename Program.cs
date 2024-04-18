namespace Labirintus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LabSim ko = new LabSim("Lab1.txt");
            Console.WriteLine($"5. feladat: Labirintus adatai");
            Console.WriteLine($"\t Sorok száma: {ko.SorokSzama}");
            Console.WriteLine($"\t Oszlopok száma: {ko.OszlopokSzama}");
            Console.WriteLine($"\t Kijárat Indexe: sor:{ko.KijaratSorIndex} oszlop:{ko.KijaratOszlopIndex}");
            Console.WriteLine($"6. feladat: A labirintus");
            Console.WriteLine("XXXXXXXXXXXX\r\n           X\r\nX      X   X\r\nX      X   X\r\nX  XX  X   X\r\nX        XXX\r\nX  X       X\r\nX  X    X XX\r\nX  X  XXXX X\r\nX          X\r\nX  XX       \r\nXXXXXXXXXXXX\r\n");
        }
    }
}