using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Prakticheskai_Rabota_8
{
    internal class Program
    {
        public static string names = " ";
        public static long for_exit = 60;
        public static int letters = 0;
        public static int current_letter = 0;
        static void Main()
        {
            Console.WriteLine("Введите своё имя для таблицы рекордов");
            names = Console.ReadLine(); //инфа о пользователях
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                Text();
            }
            else if (key == ConsoleKey.Escape)
            {
                Console.Clear();
            }
        }
        static void Text()
        {
            string text = "Не верить императору Константину глупо. В описываемую эпоху Византия переживала далеко не лучшие времена, и событие такого масштаба, как приобщение к истинной вере северных варваров, бесперечь тревоживших рубежи империи, просто не могло остаться без комментариев. Конечно же, эта невозможность происходит не от того, что философы не обладают достаточными талантами и навыками, а от того, что в неразрешимости и состоит специфика философских вопросов и проблем.";
            Console.WriteLine(text);
            char[] array_char = text.ToCharArray();
            Console.WriteLine("---------------------------------------");
            int i = 0;
            int c = 0;

            new Thread(time).Start();

            Console.SetCursorPosition(0, 0);

            while (for_exit >= 0)
            {
                char key = Console.ReadKey(true).KeyChar;

                try
                {
                    Console.SetCursorPosition(i, c);
                }
                catch (Exception)
                {
                    c++;
                    i = 0;
                    Console.SetCursorPosition(i, c);
                }

                if (key == array_char[current_letter])
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(key);
                    letters++;
                }
                else
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(key);
                    Console.ResetColor();
                }
                current_letter++;
            }
            kotiki kotiata = new kotiki(names, letters, letters / 60);
            deserialisuem.add_kotiki(kotiata);
            show_records();
        }
        static void time()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();
            while (for_exit >= 0)
            {
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, 15);
                for_exit = 60 - stopwatch.ElapsedMilliseconds / 1000;
                Console.ResetColor();
                Console.WriteLine("Время для работы: " + for_exit + " ");
            }

            stopwatch.Stop();
            stopwatch.Reset();
        }

        static void show_records()
        {
            deserialisuem.vuvod()
;
        }
    }
}