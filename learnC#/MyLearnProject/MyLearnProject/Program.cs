using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyLearnProject
{
    class Calc
    {
        public int Multiplicator(int a, int b)
        {
            composition = a * b;
            return composition;
        }

        public int Divivsion(int a, int b)
        {
            priv = a / b;
            return priv;
        }

        public int Addition(int a, int b)
        {
            sum = a + b;
            return sum;
        }

        public int Subtraction(int a, int b)
        {
            dif = a - b;
            return dif;
        }

        public int Task(string str)
        {
            
            char Element = 'a';
            int intStr = str.Length;
            List<char> array = new List<char>();

            for (int i = 0; i < intStr; i++)
            {
                Element = str.ElementAt(i);
                array.Add(Element);
            }

            for (int g = 0; g <= array.Count; g++)
            {
                //char a = array.ElementAt(g);
                //if 
                int count = array.IndexOf('*');
                // стек по массиву елементов.
            }

            return disidion;
        }

        private
           int composition = 0;
           int priv = 0;
           int sum = 0;
           int dif = 0;
           int disidion = 0;
    }

    class Program
    {
        static Calc cal = new Calc();
        public static int fibonacci(int i)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            while (c < i - 2)
            {
                int sum = a + b;
                a = b;
                b = sum;
                c++;
            }
            return b;
        }

        static bool isEnd(char c)
        {
            return c == ' ' || c == '+' || c == '-' || c == '*' || c == '/' || c == '\n' || c == '\r';
        }


        static void Main(string[] args)
        {
            Console.WriteLine(cal.Task("4*4"));
            char c = Console.ReadKey().KeyChar;
            StringBuilder number = new StringBuilder();
            while (!isEnd(c))
            {
                number.Append(c);
                c = Console.ReadKey().KeyChar;
            }
            int a = int.Parse(number.ToString());
            char operation = c;

            c = Console.ReadKey().KeyChar;
            number = new StringBuilder();
            while (!isEnd(c))
            {
                number.Append(c);
                c = Console.ReadKey().KeyChar;
            }
            int b = int.Parse(number.ToString());
            Console.WriteLine();

            switch (operation)
            {
                case '+':
                    {
                        Console.WriteLine(cal.Addition(a, b));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(cal.Subtraction(a, b));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(cal.Multiplicator(a, b));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(cal.Divivsion(a, b));
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}