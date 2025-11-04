namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Ani()
        {
            Owl o = new Owl();
            Console.WriteLine(o);
            Console.WriteLine(o.Descrition());

            Console.WriteLine();

            Shark s = new Shark();
            Console.WriteLine(s);
            Console.WriteLine(s.Descrition());

            Console.WriteLine();

            Tiger t = new Tiger();
            Console.WriteLine(t);
            Console.WriteLine(t.Descrition());

            Console.WriteLine();

            Parrot p = new Parrot();
            Console.WriteLine(p);
            Console.WriteLine(p.Descrition());

            Console.WriteLine();

            Lion l = new Lion();
            Console.WriteLine(l);
            Console.WriteLine(l.Descrition());

            Console.WriteLine();

            Crocodile c = new Crocodile();
            Console.WriteLine(c);
            Console.WriteLine(c.Descrition());
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
