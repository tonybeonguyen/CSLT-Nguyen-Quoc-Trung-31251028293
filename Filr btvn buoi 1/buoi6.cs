using System;
using System.Collections.Generic;
using System.Text;

namespace Filr_btvn_buoi_1
{
    internal class buoi6
    {
        static void bai_1()
        {
            static int[] RandomNumber(int size, int minValue, int maxValue)
            {
                Random rand = new Random();
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rand.Next(minValue, maxValue + 1);
                }
                return arr;
            }
            int[] array = RandomNumber(5, 1, 30);
            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", array));
            static double gttb(int[] arr)
            {
                if (arr == null || arr.Length == 0) return 0;
                return arr.Average();
            }
            
            Console.WriteLine($"1. Giá trị trung bình của mảng: {gttb(array)}");
            static bool gtdb(int[] arr, int value)
            {
                return Array.Exists(arr, element => element == value);
            }
            int testVal = array[0]; 
            bool contains = gtdb(array, testVal);
            Console.WriteLine($"2. Mảng có chứa giá trị {testVal} không? {contains}");
            static int FindIndexOf(int[] arr, int value)
            {
                return Array.IndexOf(arr, value);
            }
            int index = FindIndexOf(array, testVal);
            Console.WriteLine($"3. Chỉ số (index) đầu tiên của giá trị {testVal} là: {index}");
            static int[] RemoveElement(int[] arr, int value)
            {
                int index = Array.IndexOf(arr, value);
                if (index < 0) return arr; // Không tìm thấy thì trả về nguyên bản

                int[] newArr = new int[arr.Length - 1];
                Array.Copy(arr, 0, newArr, 0, index);
                Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);
                return newArr;
            }
            int[] afterRemove = RemoveElement(array, testVal);
            Console.WriteLine($"4. Mảng sau khi xóa phần tử {testVal}: " + string.Join(", ", afterRemove));
            static void minmax(int[] arr, out int min, out int max)
            {
                min = arr.Min();
                max = arr.Max();
            }
            minmax(array, out int min, out int max);
            Console.WriteLine($"5. Giá trị lớn nhất: {max} | Giá trị nhỏ nhất: {min}");
            static int[] Reversearray(int[] arr)
            {
                int[] newArr = (int[])arr.Clone();
                Array.Reverse(newArr);
                return newArr;
            }
            int[] reversed = Reversearray(array);
            Console.WriteLine($"6. Mảng sau khi đảo ngược: " + string.Join(", ", reversed));
            static int[] Duplicates(int[] arr)
            {
                return arr.GroupBy(x => x)
                          .Where(g => g.Count() > 1)
                          .Select(g => g.Key)
                          .ToArray();
            }
            int[] duplicates = Duplicates(array);
            string dupStr = duplicates.Length > 0 ? string.Join(", ", duplicates) : "Không có";
            Console.WriteLine($"7. Các giá trị trùng lặp trong mảng: {dupStr}");
            static int[] Removeduplicates(int[] arr)
            {
                return arr.Distinct().ToArray();
            }
            int[] uniqueArray = Removeduplicates(array);
            Console.WriteLine($"8. Mảng sau khi loại bỏ các phần tử trùng lặp: " + string.Join(", ", uniqueArray));
        }
        static void bai_2()
        {
            Console.WriteLine(" 1. sắp xếp mảng 10 số nguyên (");
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Giá trị không hợp lệ. Vui lòng nhập lại số nguyên: ");
                }
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Hoán đổi vị trí
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(" 2. Tìm từ trong câu ");

            Console.Write("Nhập vào một câu văn: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập từ cần tìm: ");
            string tucantim = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int tim = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(tucantim, StringComparison.OrdinalIgnoreCase))
                {
                    tim = i;
                    break; 
                }
            
        }
            if (tim != -1)
            {
                Console.WriteLine($"\nKết quả: Đã tìm thấy từ '{tucantim}' trong câu tại vị trí từ thứ {tim + 1}.");
            }
            else
            {
                Console.WriteLine($"\nKết quả: Không tìm thấy từ '{tucantim}' trong câu.");
            }
        }
        static void bai_3()
        {
            static int[,] matranbk(int rows, int cols, int min, int max)
            {
                Random rand = new Random();
                int[,] mat = new int[rows, cols];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        mat[r, c] = rand.Next(min, max + 1);
                    }
                }
                return mat;
            }
            Console.Write("Nhập số hàng (N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột (M): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matran = matranbk(n, m, 1, 99);
            static void Inmatran(int[,] mat)
            {
                int rows = mat.GetLength(0);
                int cols = mat.GetLength(1);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write($"{mat[r, c],4} "); 
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($" Ma trận ngẫu nhiên kích thước {n}x{m} ");
            Inmatran(matran);
            static void incotvadong(int[,] mat, int i)
            {
                int dong = mat.GetLength(0);
                int cot = mat.GetLength(1);

                if (i >= 0 && i < dong)
                {
                    Console.Write($"Hàng thứ {i}: ");
                    for (int c = 0; c < cot; c++)
                    {
                        Console.Write($"{mat[i, c]} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Chỉ số hàng {i} vượt quá giới hạn ma trận (0 - {dong - 1}).");
                }

                if (i >= 0 && i < cot)
                {
                    Console.Write($"Cột thứ {i}: ");
                    for (int r = 0; r < dong; r++)
                    {
                        Console.Write($"{mat[r, i]} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Chỉ số cột {i} vượt quá giới hạn ma trận (0 - {cot - 1}).");
                }
            }
            Console.Write($"Nhập chỉ số i cần kiểm tra (từ 0 đến {Math.Max(n, m) - 1}): ");
            int i = int.Parse(Console.ReadLine());
            incotvadong(matran, i);
            static int FindMaxMatrix(int[,] mat)
            {
                int max = mat[0, 0];
                int dong = mat.GetLength(0);
                int cot = mat.GetLength(1);
                for (int r = 0; r < dong; r++)
                {
                    for (int c = 0; c < cot; c++)
                    {
                        if (mat[r, c] > max)
                        {
                            max = mat[r, c];
                        }
                    }
                }
                return max;
            }
            int maxVal = FindMaxMatrix(matran);
            Console.WriteLine($"Giá trị lớn nhất trong toàn bộ ma trận: {maxVal}");
            static void FindMinRowCol(int[,] mat, int i)
            {
                int dong = mat.GetLength(0);
                int cot = mat.GetLength(1);

                if (i >= 0 && i < dong)
                {
                    int minRow = mat[i, 0];
                    for (int c = 1; c < cot; c++)
                    {
                        if (mat[i, c] < minRow) minRow = mat[i, c];
                    }
                    Console.WriteLine($"Giá trị nhỏ nhất của hàng {i}: {minRow}");
                }

                if (i >= 0 && i < cot)
                {
                    int minCol = mat[0, i];
                    for (int r = 1; r < dong; r++)
                    {
                        if (mat[r, i] < minCol) minCol = mat[r, i];
                    }
                    Console.WriteLine($" Giá trị nhỏ nhất của cột {i}: {minCol}");
                }
            }
            Console.WriteLine("Giá trị nhỏ nhất của hàng/cột thứ i ");
            FindMinRowCol(matran, i);
            static int[,] matrancv(int[,] mat)
            {
                int dong = mat.GetLength(0);
                int cot = mat.GetLength(1);
                int[,] cv = new int[cot, dong];
                for (int r = 0; r < dong; r++)
                {
                    for (int c = 0; c < cot; c++)
                    {
                        cv[c, r] = mat[r, c];
                    }
                }
                return cv;
            }
            int[,] cv = matrancv(matran);
            Console.WriteLine("Ma trận sau khi chuyển vị ");
            Inmatran(cv);
            static void induongcheo(int[,] mat)
            {
                int n = mat.GetLength(0);

                Console.Write("Đường chéo chính: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{mat[i, i]} ");
                }
                Console.WriteLine();

                Console.Write("Đường chéo phụ: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{mat[i, n - 1 - i]} ");
                }
                Console.WriteLine();
            }
            if (n == m)
            {
                Console.WriteLine(" Các giá trị trên đường chéo chính và phụ ");
                induongcheo(matran);
            }
            else
            {
                Console.WriteLine("Đây không phải là ma trận vuông nên không có đường chéo chính/phụ");
            }

           
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            bai_1();
            bai_2();
            bai_3();
            
        }

    }
}
