namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish f = new Fish("Shark", 4);
            Mammals m = new Mammals("Bear", 20);
            Birds b = new Birds("Parrot", 2);

            Console.WriteLine(f.Descrition());
            Console.WriteLine(m.Descrition());
            Console.WriteLine(b.Descrition());

            f.Name = "okynb";
            m.Name = "Wolf";
            b.Name = "Crow";

            Console.WriteLine(f.Descrition());
            Console.WriteLine(m.Descrition());
            Console.WriteLine(b.Descrition());
        }

        public static void BetterString()
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
            Console.WriteLine(bs2);
            bs2.Data = bs2.Data.DeletePunctuationMarks();

            Console.WriteLine(bs2);
        }
    }
}
