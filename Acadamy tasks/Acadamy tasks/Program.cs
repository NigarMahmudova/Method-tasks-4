using System;
using System.Linq;

namespace Acadamy_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 34;
            AddTen(ref number);
            Console.WriteLine(number);

            int point = 20;
            CorrectPoint(ref point);
            Console.WriteLine(point);

            int[] numbers = { 4, 3, 2, 6, 7, 8, 9, };
            MakeEven(ref numbers);
            Console.WriteLine("Cut ededler...");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Hazir metodlar

            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsLetterOrDigit('@'));
            Console.WriteLine(char.IsUpper('h'));
            Console.WriteLine("Ad daxil edin...");
            string name = Console.ReadLine();

            if (!char.IsUpper(name[0]))
            {
                Console.WriteLine("Ad boyuk herfle baslamalidir...");
            }
            string name1 = "";
            do
            {
                Console.WriteLine("Ad daxil edin...");
                name1 = Console.ReadLine();

            } while (!char.IsUpper(name1[0])) ;

            Console.WriteLine(char.IsUpper('3'));
            Console.WriteLine(char.IsLower('3'));
            Console.WriteLine(char.ToLower('H'));

            string str = "Nigar";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Contains('N'));

            str = "Hello World!";
            Console.WriteLine(str.Substring(0,5));
            Console.WriteLine(str.IndexOf('l'));
            Console.WriteLine(str.Substring(0, str.IndexOf(' ')));
            Console.WriteLine(str.Substring(str.IndexOf(' ')+1));
            Console.WriteLine(str.Replace("Hello", "Goodbye"));
            Console.WriteLine(str.Replace('W', 'w'));

            str = "    Hello World!";
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.StartsWith("Hel"));

            int[] num = { 45, 32, 35 };
            int index = Array.IndexOf(num, 32);
            Console.WriteLine(index);
            Array.Sort(num);
            Array.Reverse(num);
            Array.Clear(num, 0, 2);
            Console.WriteLine(num.Rank);
            Console.WriteLine(num.GetValue(2));
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            string sentences = "Hello P231";
            string[] word = sentences.Split(' ');
            string newSentences = string.Join(" + ", word);
            Console.WriteLine(newSentences);
           
        }
        //Verilmis ededi 10 vahid artiran metod
        static void AddTen (ref int num)
        {
            num += 10;
        }

        //Gonderilen deyer menfidirse 0, 100-den coxdursa 100 eden metod. 
        //0-100 araligindadirsa oldugu kimi qalsin
        static void CorrectPoint (ref int point) 
        {
            if (point<0)
            {
                point = 0;
            }
            else if (point>100)
            {
                point = 100;
            }
        }

        //verilmis ededler siyahisini icinde yalniz cut deyerler qalan array-e ceviren metod
        static void MakeEven( ref int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            int j = 0;
            int[] newArr = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 ==0)
                {
                    newArr[j] = numbers[i];
                    j++;
                }
                
            }
            numbers = newArr;
        }
    }
}
