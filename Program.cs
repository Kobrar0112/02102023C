using static System.Console;

namespace ThreeInOne
{
    class Program
    {
        static void Main()
        {
            string txt = " ";
            do
            {
                float a, c, result;
                int s = 3;
                Console.WriteLine(" ");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Игра \"Угадай число\"");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход");
                Console.WriteLine(" ");
                txt = Convert.ToString(Console.ReadLine());
                if (txt == "1")
                {
                    Random rand = new Random();
                    int scr = rand.Next(1, 100);
                    Console.WriteLine("Угадай число от 1 до 100");

                    while (scr != rand.Next())
                    {
                        a = Convert.ToSingle(Console.ReadLine());
                        if (scr == a)
                        {
                            Console.WriteLine("Вы угадали, это число " + scr);
                            break;
                        }
                        else if (a > scr)
                            Console.WriteLine("Число должно быть меньше");
                        else if (a < scr)
                            Console.WriteLine("Число должно быть больше");


                    }

                }


                else if (txt == "2")
                {

                    var table = new int[11, 11];
                    for (int i = 1; i < 11; ++i)
                    {
                        for (int j = 1; j < 11; ++j)
                        {
                            table[i, j] = i * j;
                            Console.Write("{0, 4}", table[i, j]);
                        }
                        Console.WriteLine();
                    }
                    
                }


                else if (txt == "3")
                {
                    Console.Write("Введи число ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i * i <= n || i / 1 <= n; i++)
                    {
                        if (n % i == 0)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                }
                


            } while (txt != "4");
            Console.WriteLine(" ");
            Console.WriteLine("До свидания");


        }
        

    }
}