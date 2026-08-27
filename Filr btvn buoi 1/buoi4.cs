using System;
using System.Collections.Generic;
using System.Text;

namespace Filr_btvn_buoi_1
{
    internal class buoi4
    {
        static void Bai_4_1()
        {
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nPhương trình của bạn: {a}x^2 + {b}x + {c} = 0");

            
            if (a == 0)
            {
              
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("-> Phương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("-> Phương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("-> Phương trình suy biến thành phương trình bậc nhất.");
                    Console.WriteLine($"-> Phương trình có nghiệm duy nhất: x = {x}");
                }
            }
            else
            {
                
                double delta = (b * b) - (4 * a * c);
                Console.WriteLine($"-> Delta = {delta}");

                
                if (delta < 0)
                {
                    Console.WriteLine("-> Phương trình vô nghiệm (trên tập số thực).");
                }
                else if (delta == 0)
                {
                    double xk = -b / (2 * a);
                    Console.WriteLine($"-> Phương trình có nghiệm kép: x1 = x2 = {xk}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("-> Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"   x1 = {x1}");
                    Console.WriteLine($"   x2 = {x2}");
                }
            }
        }

        static void Bai_4_2_1()
        {
            int songuyen = 0;
            while (true)
            {
                Console.Write("Nhập 1 số nguyên: ");
                string songuyenhap = Console.ReadLine();


                if (int.TryParse(songuyenhap, out songuyen))
                {
                    break;
                }
                Console.WriteLine("Nhập sai định dạng, vui lòng nhập lại!");
            }
            if (songuyen % 2 == 0)
            {
                Console.WriteLine($"Số{songuyen} là số chẵn");
            }
                else
            {
                Console.WriteLine($"Số{songuyen}là số lẻ");
            }

            
        }

        static void Bai_4_2_2()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            while (true)
            {
                Console.Write("Nhập số thứ nhất (a): ");
                string anhap = Console.ReadLine();
                if (double.TryParse(anhap, out a) )
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            while (true)
            {
                Console.Write("Nhập số thứ hai (b): ");
                string bnhap = Console.ReadLine();
                if (double.TryParse(bnhap, out b) )
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            while (true)
            {
                Console.Write("Nhập số thứ ba (c): ");
                string cnhap = Console.ReadLine();
                if (double.TryParse(cnhap, out c) )
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            double max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine($" Số lớn nhất trong ba số ({a}, {b}, {c}) là: {max}");
        }

        static void Bai_4_2_3()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            while (true)
            {
                Console.Write("Nhập cạnh thứ nhất (a): ");
                string anhap= Console.ReadLine();
                if (double.TryParse(anhap, out a) && a > 0)
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            while (true)
            {
                Console.Write("Nhập cạnh thứ hai (b): ");
                string bnhap = Console.ReadLine();
                if (double.TryParse(bnhap, out b) && b > 0)
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            while (true)
            {
                Console.Write("Nhập cạnh thứ ba (c): ");
                string cnhap = Console.ReadLine();
                if (double.TryParse(cnhap, out c) && c > 0)
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        Console.WriteLine("Đây là tam giác đều ");
                    }
                    else if (a == b || b == c || a == c)
                    {
                        Console.WriteLine(" Đây là tam giác cân ");
                    }
                    else
                    {
                        Console.WriteLine(" Đây là tam giác thường");
                    }
                }
                else
                {
                    Console.WriteLine("Không có tam giác");
                }
                
            
        }

        static void Bai_4_2_4()
        {
            double x = 0;
            double y = 0;

            while (true)
            {
                Console.Write("Nhập tọa độ x : ");
                string xnhap = Console.ReadLine();
                if (double.TryParse(xnhap, out x))
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }

            while (true)
            {
                Console.Write("Nhập tọa độ y : ");
                string ynhap = Console.ReadLine();
                if (double.TryParse(ynhap, out y))
                {
                    break;
                }
                Console.WriteLine("Số không hợp lệ");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên 1st Quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên 2st Quadrantt");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên 3st Quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên 4st Quadrant");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên gốc tọa độ ");
            }
            else if (x == 0)
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên trục y");
            }
            else
            {
                Console.WriteLine($"Tọa độ ({x};{y}) nằm trên trục x");
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Bai_4_1();
            Bai_4_2_1();
             Bai_4_2_2();
            Bai_4_2_3();
            Bai_4_2_4();

        }
    }
}
