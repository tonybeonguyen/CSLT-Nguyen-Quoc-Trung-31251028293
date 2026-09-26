using System.Linq;
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
            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());

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


            Console.Write("Nhập số chữ số đầu tiên:");
                int n = int.Parse(Console.ReadLine());

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
            Console.Write("Nhập câu bất kì: ");
            string input = Console.ReadLine();
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

            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());


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
            Console.Write("Nhập các số nguyên (cách nhau bằng khoảng trắng hoặc dấu phẩy): ");
            string input = Console.ReadLine();
            int[] arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
              


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
            Console.Write("Nhập chuỗi: ");
            string chuoi = Console.ReadLine();
            

            Console.WriteLine($"Input: {chuoi} -> Output: {KiemTraDoiXung(chuoi)}");
           
        
        }
        static void bai_12()
        {
            static double CelsiusToFahrenheit(double c)
            {
                return (c * 9.0 / 5.0) + 32;
            }
            Console.Write("Nhập số độ C: ");

            double c = double.Parse(Console .ReadLine());
            Console.WriteLine($"Input: {c} -> Output: {CelsiusToFahrenheit(c)}");
        }
        static void bai_13()
        {
            static int TimMin(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            }

            Console.Write("Nhập các số nguyên (cách nhau bằng khoảng trắng hoặc dấu phẩy): ");
            string input = Console.ReadLine();

     
            int[] arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();


            Console.WriteLine($"Input: [{string.Join(", ", arr)}] -> Output: {TimMin(arr)}");

        }
        static void bai_14()
        {
            static int TongCacChuSo(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;       
                }
                return sum;
            }
            Console.Write("Nhập số nguyên n: ");

            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input: {n} -> Output:{TongCacChuSo(n)}");


        }

        static void bai_15()
        {
            static void SapXepMang(int[] arr)
            {
               
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            Console.Write("Nhập các số nguyên (cách nhau bằng khoảng trắng hoặc dấu phẩy): ");
            string input = Console.ReadLine();

            int[] arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();



            if (arr.Length > 0)
            {
                Console.WriteLine($"Input: [{string.Join(", ", arr)}]");

                
                SapXepMang(arr);

                
                Console.WriteLine($"Output: {string.Join(" ", arr)}");
            }
        }
            
            
            
        static void bai_16()
        {
            static string XoaTrungLap(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return s;
                }
                return new string(s.Distinct().ToArray());
            }
            Console.Write("Nhập chuỗi cần xử lý: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Input: {input} -> Output: {XoaTrungLap(input)}");
        }
        static void bai_17()
        {
            static int UCLN(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b; 
                    a = temp;  
                }
                return Math.Abs(a); 
            }
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input: a = {a}, b = {b} -> Output: {UCLN(a,b)}");
        }
        static void bai_18()
        {
            static string DecimalToBinary(int n)
            {
                if (n == 0) return "0";

                string nhiphan = "";
                while (n > 0)
                {
                    nhiphan = (n % 2) + nhiphan; 
                    n /= 2;                    
                }
                return nhiphan;
            }
            Console.Write("Nhập số thập phân n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input: {n} -> Output: {DecimalToBinary(n)}");
        }
        static void bai_19()
        {
            static bool KiemTraNamNhuan(int year)
            {
                
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    return true;
                }
                return false;
            }
            Console.Write("Nhập năm cần kiểm tra: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input: {year} -> Output: {KiemTraNamNhuan(year)}");
        }
        static void bai_20()
        {
            static int DemSoTu(string sentence)
            {
                if (string.IsNullOrWhiteSpace(sentence))
                {
                    return 0;
                }
                string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }
            Console.Write("Nhập vào một câu bất kỳ: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Input: {input} -> Output: {DemSoTu(input)}");

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
            //bai_13();
            //bai_14();
            //bai_15();
            bai_16();
            // bai_17();
            //bai_18() ;
            //bai_19();
            //bai_20();
        }
    }
}
