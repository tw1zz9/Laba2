namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BetterString();

            Console.WriteLine();

            AnimalS();
        }

        public static void AnimalS()
        {
            List<Animals> list = new List<Animals>();
            list.Add(new Mammals("m1", 2));
            list.Add(new Birds("b2", 3));
            list.Add(new Fish("f3", 2));
            list.Add(new Shark("s4", 3, 106.2, 2.3));
            list.Add(new Tiger("t5", 5));
            list.Add(new Parrot("p6", 2));
            list.Add(new Owl("o7", 2));
            list.Add(new Lion("l8", 10));
            list.Add(new Crocodile("CR9", 8));

            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Sound());
                Console.WriteLine("Hash Code of the entity: " + item.GetHashCode());
                Console.WriteLine();
            }

            Console.WriteLine("\tПроверка работы функций Equal и GetHashCode:\n");
            bool ifSomeAreEqual = false;
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i + 1; j < list.Count(); j++)
                {
                    if (list[i].Equals(list[j]) || list[i].GetHashCode() == list[j].GetHashCode())
                    {
                        ifSomeAreEqual = true;
                        break;
                    }
                }

                if (ifSomeAreEqual) break;
            }

            Console.WriteLine("Хотя бы одна пара элементов в списке одинакова?\nОтвет: " + ifSomeAreEqual);
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
