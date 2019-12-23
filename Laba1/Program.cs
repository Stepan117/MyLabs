using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Овчинников Степан ИУ5-31Б";
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
            string A, B, C;
            if (args == null)
            {
                Console.WriteLine("Введите первый коэффициент: ");
                A = Console.ReadLine();
                while (Double.TryParse(A, out a) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    A = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Введите второй коэффициент: ");
                B = Console.ReadLine();
                while (Double.TryParse(B, out b) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    B = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Введите третий коэффициент: ");
                C = Console.ReadLine();
                while (Double.TryParse(C, out c) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    C = Console.ReadLine();
                }
            }
            else
            {
                if ((args.Length >= 1))
                {
                    A = args[0];
                }
                else
                {
                    Console.WriteLine("Введите первый коэффициент: ");
                    A = Console.ReadLine();
                }
                while (!Double.TryParse(A, out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    A = Console.ReadLine();

                }
                if ((args.Length >= 2))
                {
                    B = args[1];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Введите второй коэффициент: ");
                    B = Console.ReadLine();
                }
                while (!Double.TryParse(B, out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    B = Console.ReadLine();
                }
                if ((args.Length >= 3))
                {
                    C = args[2];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Введите третий коэффициент: ");
                    C = Console.ReadLine();
                }
                while (!Double.TryParse(C, out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не число");
                    Console.Write("Введите коэффициент заново: ");
                    C = Console.ReadLine();
                }
            }
            if ((a == 0) && (b == 0) && (c == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корень в биквадратном уравнении - любое число");
            }
            else
            {
                if ((a == 0) && (b == 0) && (c != 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней в биквадратном уравнении нет");
                }
                else
                {
                    if (a != 0)
                    {
                        double dscr = b * b - 4 * a * c;
                        if (dscr >= 0)
                        {
                            x1 = (-b + Math.Sqrt(dscr)) / (2 * a);
                            x2 = (-b - Math.Sqrt(dscr)) / (2 * a);
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (x1 == x2)
                            {
                                double xx1 = Math.Sqrt(x1);
                                double xx2 = -Math.Sqrt(x1);
                                Console.WriteLine("Первый корень= " + xx1);
                                Console.WriteLine("Второй корень= " + xx2);
                            }
                            if ((x1 > 0) && (x2 > 0))
                            {
                                double xx1 = Math.Sqrt(x1);
                                double xx2 = -Math.Sqrt(x1);
                                double xx3 = Math.Sqrt(x2);
                                double xx4 = -Math.Sqrt(x2);
                                Console.WriteLine("Корень 1= " + xx1);
                                Console.WriteLine("Корень 2= " + xx2);
                                Console.WriteLine("Корень 3= " + xx3);
                                Console.WriteLine("Корень 4= " + xx4);
                            }
                            if ((x1 > 0) && (x2 < 0))
                            {
                                double xx1 = Math.Sqrt(x1);
                                double xx2 = -Math.Sqrt(x1);
                                Console.WriteLine("Корень 1= " + xx1);
                                Console.WriteLine("Корень 2= " + xx2);
                            }
                            if ((x1 < 0) && (x2 < 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет");
                            }
                            if ((x1 == 0) && (x2 < 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Корень- ноль");
                            }

                            if ((x1 > 0) && (x2 == 0))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                double xx1 = Math.Sqrt(x1);
                                double xx2 = -Math.Sqrt(x1);

                                Console.WriteLine("Корень 1= " + xx1);
                                Console.WriteLine("Корень 2= " + xx2);
                                Console.WriteLine("Корень 3= 0");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Корней в биквадратном уравнении нет");
                        }
                    }
                    else
                    {
                        if (c == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корень- ноль");
                        }
                        else
                        {
                            if (c > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Корней нет");
                            }
                            else
                            {
                                double dscr = -4 * b * c;
                                double xx1 = (Math.Sqrt(dscr)) / (2 * b);
                                double xx2 = (-Math.Sqrt(dscr)) / (2 * b);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Первый корень= " + xx1);
                                Console.WriteLine("Второй корень= " + xx2);
                            }
                        }
                    }
                }
            }
            string s = Console.ReadLine();
        }
    }
}
