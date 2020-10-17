using System;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1_e();
            //Ex2_c();
            string str = "Fmdulasdwa";
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Function(arr, str);
            Checked();
            Unchecked();
            static void Checked()
            {
                checked
                {
                    int a = 2147483647;
                    Console.WriteLine(a);
                }
            }
            static void Unchecked()
            {
                unchecked
                {
                    int a = 2147483647;
                    Console.WriteLine(a);
                }
            }
           

            static (int maxElement, int minimalElement, int elementsSum, char firstLetter) Function(int[] array, string str)
            {

                var result = (maxElement: 0, minimalElement: 0, elementsSum: 0, firstLetter: ' ');

                

                result.minimalElement = array[0];
                result.maxElement = array[0];

                for (int i = 0; i < array.Length; i++)
                {
                   
                    if (result.minimalElement > array[i])
                    {
                        result.minimalElement = array[i];
                    }
                    if (result.maxElement < array[i])
                    {
                        result.maxElement = array[i];
                    }
                }

                
                //int elementsSum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    result.elementsSum += array[i];
                }

                //  Определение первого символа строки

                result.firstLetter = str[0];

                return result;
            }
        }
        public static void Ex1_a()
        {
            bool booolean = true;
            byte bt = 2;
            sbyte sbt = 4;
            char letter = 'a';
            decimal ochenmnogo = 5555;
            double dbl = 5.2;
            float flt = 5.4f;
            int chislo = -56;
            uint unt = 5;
            long lng = -5000000000000000000;
            ulong ulng = 5446464655555555555;
            short shrt = -45;
            ushort ushrt = 34;

            Console.WriteLine($"{booolean}, {bt}, {sbt}, {letter}, {ochenmnogo}, " +
                $"{dbl},{flt},{chislo},{unt}, {lng}, {ulng}, {shrt}, {ushrt}");            
        }
        public static void Ex1_b()
        {
            // Явные преобразования
            
            double a = 777.9;
            int b = (int)a;

            Console.WriteLine($"double ({a}) to int: {b}");

            
            char c = '\u007a';
            char d = Convert.ToChar(c);

            Console.WriteLine($"char ({c}) to string: {d}");

            
            string e = "Test";
            Object obj = e;
            object f = (object)obj;

            Console.WriteLine($"string ({e}) to object: {obj}");

            
            decimal g = 722.5878e10m;
            float h = (float)g;

            Console.WriteLine($"decimal ({g}) to float: {h}");

            
            int i = 9999;
            sbyte j = (sbyte)i;

            Console.WriteLine($"int ({i}) to sbyte: {j}");

            Console.WriteLine();

            // Неявные преобразования
            
            int k = 9999999;
            long l = k;

            Console.WriteLine($"int ({k}) to long: {l}");

            
            sbyte m = 127;
            double n = m;

            Console.WriteLine($"sbyte ({m}) to double: {n}");

            
            uint o = 4294967295;
            decimal p = o;

            Console.WriteLine($"uint ({o}) to decimal: {p}");

            
            long q = 982939475893769836;
            float r = q;

            Console.WriteLine($"long ({q}) to float: {r}");

            
            float s = 2.3334e-2f;

            Console.WriteLine($"Convert float {s} to double: {Convert.ToDouble(s)}"); ;
        }

        public static void Ex1_c()
        {
            int Int = 124;
            object obj = Int;
            int nInt = (int)obj;
        }
        
        public static void Ex1_d()
        {
            var a = 67;
            int b = 7;
            string str = "asd";

            Console.WriteLine($"var a + int b: {a+b} ; var a + string str : {a+str}");
        }

        public static void Ex1_e()
        {
            Nullable<int> Int1 = null;
            Console.WriteLine(Int1.GetValueOrDefault());

            int? nulInt = null;
            int a = nulInt ?? 0;
            Console.WriteLine(a);

            int? b = null;
            int c = 7;
            Console.WriteLine(Nullable.Compare<int>(a, c));
        }
        public static void Ex1_f()
        {
            var Var = 25.445;
            string VarString = "test";
           // Var = VarString;
            //Не возможно преобразование из string в double
            Console.WriteLine(Var);
        }

        public static void Ex2_a()
        {
            string str1 = "asf";
            string str2 = "dsadw";

            if (str1.CompareTo(str2) > 0)
                Console.WriteLine("str1 >str2");
            else
                Console.WriteLine("str1<str2");
        }
        
        public static void Ex2_b()
        {
            string str1 = "dsadw";
            string str2 = "AAAAA AAAAAAA";
            string str3 = "LoKjniw-asdwKK";

            string result = String.Concat(str1, str2, str3);
            Console.WriteLine("Concatenation :" + result);

            result = str3.Substring(2);
            Console.WriteLine("Substring :" + result);

            string[] splits = str2.Split(new char[] { ' ' });
            Console.WriteLine("Words:");

            foreach(string word in splits)
            {
                Console.WriteLine(word);
            }

            result = str1.Insert(2, str2);
            Console.WriteLine("Insert:" + result);

            result = str1.Remove(3);
            Console.WriteLine("Remove: " + result);
        }

        public static void Ex2_c()
        {
            string str = null;
            Console.WriteLine(String.IsNullOrEmpty(str));

            string str1 = " ";
            Console.WriteLine(String.IsNullOrEmpty(str1));
        }

        public static void Ex2_d()
        {
            StringBuilder str = new StringBuilder("String from string Builder");
            Console.WriteLine(str);

            str.Remove(7, 4);
            Console.WriteLine("Deleted 7, 4" + str);

            str.Insert(0, "1");
            str.Insert(str.Length, "2");
            Console.WriteLine(str);
        }

        public static void Ex3_a()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int counter = 0;
            foreach (int a in array)
            {
                if (counter % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(a);
                counter++;
            }
        }

        public static void Ex3_b()
        {
            
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };

            
            foreach (int a in array)
            {
                Console.Write(a+" ");
            }
            
            Console.WriteLine($"\nРазмер массива: {array.Length}");

            Console.WriteLine("Введите позицию которуюхотите изменить");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число на которое хотите заменить");
            int numb = int.Parse(Console.ReadLine());
            array[pos] = numb;
            Console.WriteLine("Итоговы массив:");

            foreach(int b in array)
            {
                Console.Write(b + " ");
            }            

        }

        public static void Ex3_c()
        {
            double[][] array = new double[3][];
            array[0] = new double[2];
            array[1] = new double[3];
            array[2] = new double[4];

            try
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Введите данные {i + 1}-го массива: ");
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write($"{j} значение из {array[i].Length}: ");
                        array[i][j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                Console.WriteLine();

                
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Нажмите, чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Ex3_d()
        {
            //  Инициаизация неявно-типизированных переменных для хранения массива и строки
            var arrayVar = new int[] { 1, 2, 3, 4, 5 };
            var strokeVar = "Test";

            Console.WriteLine("Var array");
            foreach (var a in arrayVar)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine($"\nVar stroke: {strokeVar}");
        }
        public static void Ex4_a()
        {
            (int, string, char, string, ulong) tuple = (12, "Test", 'S', "HelloWorld", 1123321);

            //Вывод кортежа полностью
            Console.WriteLine(tuple);

            //  Вывод кортежа выборочно
            Console.WriteLine($"{tuple.Item1} {tuple.Item4} {tuple.Item3}");

            int item1 = tuple.Item1;
            string item2 = tuple.Item2;

            var (buff, stringVar1, charVar, stringVar2, ulongVar) = tuple;
            Console.WriteLine(buff);

            //  Сравнение двух кортежей

            var firstTuple = (7, 9);
            var secondTuple = (9, 8);

            if (firstTuple == secondTuple)
            {
                Console.WriteLine("firstTuple = secondTuple");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }


        }
    }
}
