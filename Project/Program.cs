using System;
namespace WorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строчек");
            int numberLine = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            string FullName = Firstname + lastName;
            Console.WriteLine();
            int PartOne = numberLine;
            char[] littersName = null;
            char[] litterslastName = null;

            for (int i = 0; i < Firstname.Length; i++)
            {
                littersName = Firstname.ToCharArray();
            }
            for (int i = 0; i < lastName.Length; i++)
            {
                litterslastName = lastName.ToCharArray();
            }
            while (Firstname.Length < numberLine)
            {
                Array.Reverse(littersName);
                foreach (var mass in littersName)
                {
                    Firstname += mass;
                }
            }
            while (lastName.Length < numberLine)
            {
                Array.Reverse(littersName);
                foreach (var mass in litterslastName)
                {
                    lastName += mass;
                }
            }
            for (int i = 1; i <= PartOne; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(changeLastName(numberLine - i, lastName));
                }
                else
                {
                    Console.WriteLine(changeName(numberLine - i, Firstname));
                }
            }
            for (int i = PartOne; i-- != 1;)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(changeLastName(numberLine - i, lastName));
                }
                else
                {
                    Console.WriteLine(changeName(numberLine - i, Firstname));
                }
            }
        }

        private static void Calculate(int n, string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i].Length);
                if (lines[i].Length % 2 == 0)
                {

                }
            }
        }
        private static string changeName(int n, string firstName)
        {
            char[] litter = firstName.ToCharArray();
            string s = "";
            for (int i = 0; i <= litter.Length; i++)
            {
                s += litter[i];
                if (i == (n / 2))
                {
                    return s;
                }
            }
            return "";
        }
        private static string changeLastName(float n, string lastName)
        {
            char[] litter = lastName.ToCharArray();
            Array.Reverse(litter);
            string s = "";
            double v = Math.Ceiling((n - 1) / 2);
            for (int i = 0; i <= litter.Length; i++)
            {
                s += litter[i];
                if (i == v)
                {
                    return s;
                }
            }
            return "";
        }
    }

}
