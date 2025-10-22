namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BetterString bs1 = new BetterString("CHARIZARD");
            BetterString bs2 = new BetterString("CHAMELEON");

            Console.WriteLine(bs1 < bs2);
            Console.WriteLine(bs2 < bs1);

            bs1 = bs1 + 3;
            Console.WriteLine(bs1);

            bs2 = bs2 + 1337;
            Console.WriteLine(bs2);

            for (var i = 0; i < 5; i++) bs2--;

            bs2 += 4;
            Console.WriteLine(bs2);

            bs1 *= '\\';
            Console.WriteLine(bs1);

            Console.WriteLine(bs1.Data.IsThere('S'));
            Console.WriteLine(bs1.Data.IsThere('\\'));

            Console.WriteLine(bs2.Data.IsThere('A'));

            bs2.Data += ",./'' фцфцв.,./,/.,][];'.!@#!%";
            bs2.Data = bs2.Data.DeletePunctuationMarks();

            Console.WriteLine(bs2);
        }
    }
}
