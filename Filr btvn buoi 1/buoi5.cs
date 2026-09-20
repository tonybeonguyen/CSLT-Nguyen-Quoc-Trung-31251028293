using System;
using System.Collections.Generic;
using System.Text;

namespace Filr_btvn_buoi_1
{
    internal class buoi5
    {
        static void bai_1()
        {
            static int sum(int a, int b)
            {
                return a + b;
            }
            int x = 2;
            int y = 8;
            int ketQua = sum(x, y);
            Console.WriteLine($"Tổng của {x} và {y} là: {ketQua}");
        }
        static void bai_2()
        {
            static bool KiemTraChan(int n)
            {
                return n % 2 == 0;
            }
            int x = 4;
            int y = 5;
            Console.WriteLine($"Số {x} có phải số chẵn không? {KiemTraChan(x)}");
            Console.WriteLine($"Số {y} có phải số chẵn không? {KiemTraChan(y)}");
        }
        static void bai_3()
        {
            static int Timmax(int a, int b, int c)
            {
                return Math.Max(Math.Max(a, b), c);
            }
            int x = 4;
            int y = 8;
            int z = 6;
            Console.WriteLine($"Số lớn nhất trong ba số {x}, {y}, {z} là {Timmax(x, y, z)}");


        }
        static void bai_4()
        {
            static long TinhGiaiThua(int n)
            {
                long ketQua = 1;
                for (int i = 1; i <= n; i++)
                {
                    ketQua *= i;
                }

                return ketQua;
            }
            int n = 3;
            Console.WriteLine($"Giai thừa của {n}  là: {TinhGiaiThua(n)}");
        }
        static void bai_5()
        {
            static string DaoNguocChuoi(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            string chuoiBanDau = "Tôi yêu UEH";
            Console.WriteLine($"Chuỗi ban đầu: {chuoiBanDau}");
            Console.WriteLine($"Chuỗi sau khi đảo ngược: {DaoNguocChuoi(chuoiBanDau)}");
        }
        static void bai_6()
        {
            static bool KiemTraNguyenTo(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                for (int i = 2; i<n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;

            }
            int x = 7;
            int y = 10;
            Console.WriteLine($"Input: {x} -> Output: {KiemTraNguyenTo(x)}");
            Console.WriteLine($"Input: {y} -> Output: {KiemTraNguyenTo(y)}");
        }
        static void bai_7()
        {
            static void InFibonacci(int n)
            {
                if (n <= 0) return;

                int a = 0, b = 1;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(a + " ");

                    int next = a + b;

                    a = b;
                    b = next;
                }

               
            }

          
           
                int n = 6;

                Console.Write($"Input: {n} -> Output: ");
                InFibonacci(n);
            
        }
        static void bai_8()
        {
            static int DemNguyenAm(string s)
            {
                int dem = 0;
                    string chuoiThuong = s.ToLower();
                foreach (char c in chuoiThuong)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        dem++;
                    }
                }

                return dem;
            }
            string input = "Tôi yêu UEH";
            Console.WriteLine($"Input: \"{input}\" -> Output: {DemNguyenAm(input)}");
        }
        static void bai_9()
        {
            static double TinhLuyThua(double x, int y)
            {
                if (y == 0)
                {
                    return 1;
                }

                double ketQua = 1;

                int soMu = y > 0 ? y : -y;

                for (int i = 0; i < soMu; i++)
                {
                    ketQua *= x;
                }

                if (y < 0)
                {
                    return 1 / ketQua;
                }

                return ketQua;
            }

           
                double x = 2;
                int y = 3;

                Console.WriteLine($"Input: x = {x}, y = {y} -> Output: {TinhLuyThua(x, y)}");
            
        }
        static void bai_10()
        {
            static double TinhTrungBinh(int[] arr)
            {
                if (arr == null || arr.Length == 0)
                {
                    return 0;
                }

                double tong = 0;

                foreach (int so in arr)
                {
                    tong += so;
                }

                return tong / arr.Length;
            }

          
                int[] arr = { 4, 5, 6, 7 };

                Console.WriteLine($"Input: [{string.Join(", ", arr)}] -> Output: {TinhTrungBinh(arr)}");
            }
        static void bai_11()
        {
            static bool KiemTraDoiXung(string s)
            {
                int left = 0;
                int right = s.Length - 1;
                while (left < right)
                {
                    if (s[left] != s[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;
            }
            string chuoi1 = "radar";
            string chuoi2 = "hello";

            Console.WriteLine($"Input: {chuoi1} -> Output: {KiemTraDoiXung(chuoi1)}");
            Console.WriteLine($"Input: {chuoi2} -> Output: {KiemTraDoiXung(chuoi2)}");
        
        }
        static void bai_12()
        {
            static double CelsiusToFahrenheit(double c)
            {
                return (c * 9.0 / 5.0) + 32;
            }
            double c = 25;
            Console.WriteLine($"Input: {c} -> Output: {CelsiusToFahrenheit(c)}");
        }
        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // bai_1();
            //bai_2();
            //bai_3();
            //bai_4();
            //bai_5();
            //bai_6();
            // bai_7();
            //bai_8();
            //bai_9();
            // bai_10();
            //bai_11();
            //bai_12();
        }
    }
}
